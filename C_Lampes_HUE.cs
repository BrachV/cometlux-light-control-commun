using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhilipsHue;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.Original;

namespace CometLux_Solution_ESP32
{
    public class C_Lampes_HUE
    {
        // ---------------- [définition des variables] ----------------

        private LocalHueClient client; // permet l'envoi des commandes.
        private bool etat = true, etat_temp = true; // allumé ou éteint
        private Color couleur = Color.White, couleur_temp = Color.White; // couleur choisis
        private string hexa = "FFFFFF", hexa_temp = "FFFFFF";
        private int luminosite = 255, lum_temp = 255; // allant de 0 à 255
        private int lampes_cibles; // 0 = toutes les lampes, 
        private string[,] liste_lampes = new string[0,0];
        C_SQL bdd = new C_SQL("192.168.0.20", "Admin", "cocorico%*", "cometlux", "3306");

        // ------------ [fin de définition des variables] -------------

        // --------------------- [constructeur] ----------------------

        public C_Lampes_HUE(LocalHueClient c, bool e, Color cl, int l, int lc)
        {
            client = c;
            etat = e;
            couleur = cl;
            luminosite = l;
            lampes_cibles = lc;
        }

        // ------------------ [getteurs de la classe] -------------------
        public LocalHueClient get_client() { return client; }
        public int get_lampes_cibles() {  return lampes_cibles; }
        public string[,] get_liste_lampes() { return liste_lampes; }

        public bool get_etat(int lc) // pour cette methodes et les suivantes, 
        { //le paramètre "lc" permet de récupérer la  valeur d'une lampe au choix.
            if(lc != 0)
            {
                import_donnees_lampes(lc);
                return etat; // retourne l'etat de la 1ère lampe
            }
            else
                return false; // retourne une valeur par défaut
        }
        public Color get_couleur(int lc)
        {
            if (lc != 0)
            {
                import_donnees_lampes(lc);
                return couleur; // retourne l'etat de la 1ère lampe
            }
            else
                return Color.White; // retourne une valeur par défaut
        }

        public string get_hex(int lc)
        {
            if (lc != 0)
            {
                import_donnees_lampes(lc);
                return hexa; // retourne l'etat de la 1ère lampe
            }
            else
                return "FFFFFF"; // retourne une valeur par défaut
        }
        public int get_luminosite(int lc)
        {
            if (lc != 0)
            {
                import_donnees_lampes(lc);
                return luminosite; // retourne l'etat de la 1ère lampe
            }
            else
                return 255; // retourne une valeur par défaut
        }


        // ------------------ [méthodes de la classe] -------------------

        public bool envoi_commande(LightCommand cmd, int lc)
        {
            string requete;
            int etat_int;
            if (etat == false) etat_int = 0; else etat_int = 1;
            switch (lc)
               {
                case 0:
                    client.SendCommandAsync(cmd); // envoie la commande a toute les lampes
                    for(int i = 0; i < liste_lampes.Length; i++)
                    {
                        comparer_valeurs(i); // met a jour les valeurs pour entrer les bonnes valeurs dans la bdd
                        requete = "UPDATE `lampe` SET `couleur` = '" + hexa + "', `luminosite` = '" + luminosite + "', `etat` = '" + etat_int + "' WHERE id = " + liste_lampes[i, 0];
                        bdd.exec_commande(requete);
                    }
                    break;
                default:
                    client.SendCommandAsync(cmd, new List<string> { liste_lampes[lc-1, 2] }); // envoie la commande à la lampe choisie
                    comparer_valeurs(lc-1);
                    requete = "UPDATE `lampe` SET `couleur` = '" + hexa + "', `luminosite` = '" + luminosite + "', `etat` = '" + etat_int + "' WHERE id = " + liste_lampes[lc-1, 0];
                    bdd.exec_commande(requete);
                    break;
                case -1:
                    MessageBox.Show("Veuillez choisir au moins une lampe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // affiche un message d'erreur
                    return false;
            }
            return true;
        }

        public void import_donnees_lampes(int lc)
        {
            string requete = "SELECT `couleur`, `luminosite`, `etat` FROM `lampe` WHERE `type` = \"HUE\" AND `id` = "+ lc; // prépare la requête
            DataTable dt = bdd.exec_commande(requete);
            DataTableReader dr = dt.CreateDataReader();

            dr.Read(); // lecture de la ligne récupérée
            hexa = dr.GetString(0);
            // conversion de code Hexadecimal a code RGB
            int r, g, b;
            r = int.Parse(hexa.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            g = int.Parse(hexa.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            b = int.Parse(hexa.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            couleur = Color.FromArgb(r, g, b);
            luminosite = dr.GetInt32(1);
            if (dr.GetInt32(2) == 1)
                etat = true;
            else
                etat = false;

        }

        public void changement_couleur(Color cl, int lc)
        {
            var cmd = new LightCommand();
            cmd.On = true; // active la commande
            cmd.SetColor(new RGBColor(cl.R, cl.G, cl.B)); // convertis la couleur
            couleur_temp = cl;
            hexa_temp = cl.R.ToString("X2") + cl.G.ToString("X2") + cl.B.ToString("X2");
            if(envoi_commande(cmd, lc) == true); // envoie la commande & verifie que cela fonctionne pour l'inscrire dans les logs
            {
                if(lc != 0)
                {
                    string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[lc - 1, 0] + "','Couleur modifiée, nouvelle valeur : #" + hexa_temp + "', 'Application PC')";
                    bdd.exec_commande(requete);
                } else
                {
                    for(int i = 0; i < liste_lampes.Length; i++)
                    {
                        string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[i, 0] + "','Couleur modifiée, nouvelle valeur : #" + hexa_temp + "', 'Application PC')";
                        bdd.exec_commande(requete);
                    }
                }
            }
        }

        public void allumer_lampe(int lc)
        {
            var cmd = new LightCommand();
            cmd.On = true;
            cmd.TurnOn(); // allume la lampe
            etat_temp = true;
            
            if (envoi_commande(cmd, lc) == true) ; // envoie la commande & verifie que cela fonctionne pour l'inscrire dans les logs
            {
                if (lc != 0)
                {
                    string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[lc - 1, 0] + "','La lampe est à présent allumée', 'Application PC')";
                    bdd.exec_commande(requete);
                }
                else
                {
                    for(int i = 0; i < liste_lampes.Length; i++)
                    {
                        string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[i, 0] + "','La lampe est à présent allumée', 'Application PC')";
                        bdd.exec_commande(requete);
                    }
                }
            }
        }
        public void eteindre_lampe(int lc)
        {
            var cmd = new LightCommand();
            cmd.On = true;
            cmd.TurnOff(); // éteint la lampe
            etat_temp = false;
            if (envoi_commande(cmd, lc) == true) ; // envoie la commande & verifie que cela fonctionne pour l'inscrire dans les logs
            {
                if (lc != 0)
                {
                    string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[lc - 1, 0] + "','La lampe est a présent éteinte', 'Application PC')";
                    bdd.exec_commande(requete);
                }
                else
                {
                    for( int i = 0; i < liste_lampes.Length; i++)
                    {
                        string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[i, 0] + "','La lampe est a présent éteinte', 'Application PC')";
                        bdd.exec_commande(requete);
                    }
                }
            }
        }

        public void changement_luminosite(int l, int lc)
        {
            var cmd = new LightCommand();
            cmd.On = true;
            cmd.Brightness = (byte)l; // convertis la variable du type int au type byte avant d'envoyer
            lum_temp = l;
            if (envoi_commande(cmd, lc) == true) ; // envoie la commande & verifie que cela fonctionne pour l'inscrire dans les logs
            {
                if (lc != 0)
                {
                    float lum_pourcent = (float)Math.Floor(((float)lum_temp / 255) * 100); // convertis la valeur en pourcentage
                    string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[lc - 1, 0] + "','Luminosité modifiée, nouvelle valeur : " + lum_pourcent + "%', 'Application PC Gestionnaire')";
                    bdd.exec_commande(requete);
                }
                else // dans le cas ou toutes les lampes sont selectionnées.
                {
                    float lum_pourcent = (float)Math.Floor(((float)lum_temp / 255) * 100); // convertis la valeur en pourcentage
                    for(int i = 0; i < liste_lampes.Length; i++)
                    {
                        string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[i, 0] + "','Luminosité modifiée, nouvelle valeur : " + lum_pourcent + "%', 'Application PC Gestionnaire')";
                        bdd.exec_commande(requete); // première requête pour toutes les lampes
                    }
                }
            }
        }

        public void appliquer_effets(int e, int lc)
        {
            var command = new LightCommand();
            string effect_actifs = "";
            command.On = true;
            switch (e)
            {
                case 1:
                    command.SetColor(new RGBColor(255, 0, 0)); // met une couleur de départ pour la boucle de couleur
                    command.Effect = Effect.ColorLoop; // active l'effet multicolor
                    command.Alert = Alert.None; // desactive l'effet clignotement
                    effect_actifs = "Multicolor";
                    break;
                case 2:
                    command.Alert = Alert.Multiple; // active l'effet clignotement
                    command.Effect = Effect.None; // desactive l'effect mutlicolore
                    effect_actifs = "Clignotement";
                    break;
                case 0:
                    command.SetColor(new RGBColor(255, 0, 0)); // met une couleur de départ pour la boucle de couleur
                    command.Effect = Effect.ColorLoop; // active l'effet multicolor
                    command.Alert = Alert.Multiple; // active l'effet clignotement
                    effect_actifs = "Multicolor & Clignotement";
                    break;
                default:
                    command.Effect = Effect.None;
                    command.Alert = Alert.None;
                    effect_actifs = "Aucun";
                    // desactive tout les effets
                    break;
            }
            if (envoi_commande(command, lc) == true) ; // envoie la commande & verifie que cela fonctionne pour l'inscrire dans les logs
            {
                if (lc != 0)
                {
                    string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[lc - 1, 0] + "','Effets modifiés, effets actifs : " + effect_actifs + "', 'Application PC Gestionnaire')";
                    bdd.exec_commande(requete);
                }
                else // dans le cas ou toutes les lampes sont selectionnées.
                {
                    for(int i = 0; i < liste_lampes.Length; i++)
                    {
                        string requete = "INSERT INTO `logs` (`lampe_id`, `description`, `source`) VALUES ('" + liste_lampes[i, 0] + "','Effets modifiés, effets actifs : " + effect_actifs + "', 'Application PC Gestionnaire')";
                        bdd.exec_commande(requete); // première requête pour les lapes
                    }
                }
            }
        }

        public string[,] importer_lampe()
        {
            string requete = "SELECT `id`, `nom`, `id_hue`, `type` FROM `lampe` WHERE `type` = \"HUE\";"; // prépare la requête
            DataTable dt = bdd.exec_commande(requete); // récupère un DataTable grâce a la requête
            liste_lampes = new string[dt.Rows.Count, 4]; // ajuste la taille du tableau
            liste_lampes = bdd.exec_commande_lampe(requete); // récupère un DataReader grâce à la requête
            return liste_lampes;
        }

        public void comparer_valeurs(int lc)
        {
            import_donnees_lampes(lc);
            // si les valeurs diffère, alors la valeur normal prends la valeur temporaire.
            if (etat != etat_temp) etat = etat_temp;
            if (couleur != couleur_temp) couleur = couleur_temp;
            if (hexa != hexa_temp) hexa = hexa_temp;
            if (luminosite != lum_temp) luminosite = lum_temp;
        }
    }
}
