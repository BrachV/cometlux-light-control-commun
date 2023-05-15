using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Asn1.Ocsp;

namespace CometLux_Solution_ESP32
{
    public class C_Scenario
    {
        // définitions des variables
        string nom = "", description = "";
        Form_etape[] etapes = new Form_etape[0];
        int nombre_etapes = 1;
        string[,] listes_lampes = new string[1,4]; // 0 = id, 1 = nom, 2 = type, 3 = id HUE
        C_SQL bdd = new C_SQL("192.168.0.20","Admin","cocorico%*","cometlux", "3306");
        bool modification = false;


        // constructeurs
        public C_Scenario()
        {
            nom = "";
            description = "";
            etapes = new Form_etape[0];
        }
        public C_Scenario(string n, string d, Form_etape[] e)
        {
            nom = n;
            description = d;
            etapes = e;
        }

        //setters et getters
        public void set_etapes(Form_etape[] e) { etapes = e; }
        public void set_une_etape(int i, Form_etape e) { etapes.SetValue(e, i); }
        public void set_nom(string n) { nom = n; }
        public void set_description(string d) { description = d; }
        public void set_nombre_etapes(int nb) { nombre_etapes = nb; }

        public void set_une_etape(int num, int l_choisis, int etat, int lum, string couleur, int delai)
        {
            etapes[num].set_cible(l_choisis);
            if (etat == 1) etapes[num].set_etat(true); else etapes[num].set_etat(false);
            etapes[num].set_luminosite(lum);
            etapes[num].set_couleur_hexa(couleur);
            etapes[num].set_delai(delai);
        }

        public Form_etape[] get_etapes() { return etapes; }
        public Form_etape get_une_etape(int i) { return etapes[i]; }
        public string get_nom() { return nom; }
        public string getDescription() { return description; }
        public int get_nombre_etapes() { return nombre_etapes; }
        public string[,] get_liste_lampes() { return listes_lampes; }

        // méthodes
        public void ajouter_etape()
        {
            nombre_etapes++; // augmente le nombre d'étape
            Form_etape[] etape_temp = new Form_etape[etapes.Length + 1]; // augmente la taille de notre liste
            int i;
            for (i = 0; i < etape_temp.Length-1; i++)
            {
                etape_temp[i] = etapes[i]; // importe les étapes de l'ancienne liste à la nouvelle
            }
            etapes = etape_temp; // enregistre notre nouvelle liste
        }

        public void supprimer_etape()
        {
            nombre_etapes = nombre_etapes - 1;
            Form_etape[] etape_temp = new Form_etape[etapes.Length - 1]; // augmente la taille de notre liste
            int i;
            for (i = 0; i < etape_temp.Length; i++)
            {
                etape_temp[i] = etapes[i]; // importe les étapes de l'ancienne liste à la nouvelle
            }
            etapes = etape_temp; // enregistre notre nouvelle liste
        }


        public bool sauvegarder_scenario()
        {
            try
            {
            if (modification == false)
            {
                // sauvegarde du scénario
                string requete = "INSERT INTO scenario (nom, description, etat) VALUES(\'" + nom + "\',\'" + description + "\',\'0\')";
                bdd.exec_commande(requete);
                string requete2 = "SELECT id FROM scenario WHERE nom = \"" + nom + "\" AND description = \"" + description + "\"";
                string id_scenar = bdd.exec_commande(requete2, true); // permet de récuperer l'index du scénario actuel;
                for (int i = 0; i < etapes.Length; i++)
                {
                    requete = "INSERT INTO `etapes`(`num_etape`, `id_scenarios`, `lampe_id`, `luminosite`, `couleur`, `allume`, `delais`) VALUES ('" + (i + 1).ToString() + "','" + id_scenar + "','" + listes_lampes[etapes[i].get_lampe_choisie(), 0] + "','" + etapes[i].get_luminosite() + "','" + etapes[i].get_hex() + "','" + etapes[i].get_etat_int() + "','" + etapes[i].get_delai() + "')";
                    bdd.exec_commande(requete);
                }
            }
            else
            {
                string requete2 = "SELECT id FROM scenario WHERE nom = \"" + nom + "\" AND description = \"" + description + "\"";
                string id_scenar = bdd.exec_commande(requete2, true); // permet de récuperer l'index du scénario actuel;
                // sauvegarde du scénario en écrasant les anciennes données.
                for (int i = 0; i < etapes.Length; i++)
                {
                    string requete3 = "SELECT * FROM etapes WHERE id_scenarios = " + id_scenar + " AND num_etape = " + (i + 1).ToString();
                    DataTable VerifEtape = bdd.exec_commande(requete3);
                    if (VerifEtape.Rows.Count != 0)
                    { // verifie que l'étape existe déjà
                        requete3 = "UPDATE etapes SET allume = " + etapes[i].get_etat_int() + ", luminosite = " + etapes[i].get_luminosite() + ", lampe_id = '" + listes_lampes[etapes[i].get_lampe_choisie(), 0] + "', couleur = '" + etapes[i].get_hex() + "', delais = " + etapes[i].get_delai() + " WHERE id_scenarios = " + id_scenar + " AND num_etape = " + (i + 1);
                        bdd.exec_commande(requete3);
                    }
                    else // si elle n'existe pas, il faut la créer
                    {
                        requete3 = "INSERT INTO `etapes`(`num_etape`, `id_scenarios`, `lampe_id`, `luminosite`, `couleur`, `allume`, `delais`) VALUES ('" + (i + 1).ToString() + "','" + id_scenar + "','" + listes_lampes[etapes[i].get_lampe_choisie(), 0] + "','" + etapes[i].get_luminosite() + "','" + etapes[i].get_hex() + "','" + etapes[i].get_etat_int() + "','" + etapes[i].get_delai() + "')";
                        bdd.exec_commande(requete3);
                    }
                }
                // supprime toutes les étapes en trop
                string requete = "DELETE FROM etapes WHERE id_scenarios = " + id_scenar + " AND num_etape > " + etapes.Length;
                bdd.exec_commande(requete);
                MessageBox.Show("Sauvegarde terminée", "Opération terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                return true;
            }
            catch
            {
                MessageBox.Show("Sauvegarde Echouée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void importer_scenario(int id)
        {
            modification = true; // indique que je vais devoir modifier un scénario déjà existant
            // récupération du nom et de la description du scénario
            string requete = "SELECT nom, description FROM scenario WHERE id = " + id;
            DataTable dt = bdd.exec_commande(requete);
            DataTableReader dr = dt.CreateDataReader();
            while(dr.Read()) // lecture des données récupérée
            {
                nom = dr.GetString(0); // je definis le nom selon ce que j'ai récupéré dans la base de données
                description = dr.GetString(1); // idem avec la description
            }
            // l'import des étapes se fait dans le Form_Scen-Creation
        }

        public string[,] importer_lampe()
        {
            string requete = "SELECT `id`,`nom`,`type`,`id_hue` FROM `lampe`"; // prépare la requête
            DataTable dt = bdd.exec_commande(requete); // récupère un DataTable grâce a la requête
            listes_lampes = new string[dt.Rows.Count, 4]; // ajuste la taille du tableau
            listes_lampes = bdd.exec_commande_lampe(requete); // récupère un DataReader grâce à la requête
            return listes_lampes;
        }

    }
}
