using PhilipsHue;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.Original;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CometLux_Solution_ESP32
{
    public partial class Form_HUE : Form
    {
        public Form_HUE()
        {
            InitializeComponent();
            //imageOff.BackgroundImage = new Bitmap(@"D:\Cours\2eme_Annee_BTS\Info\Projet_E62\VSed\CometLux_Solution_C#\src\off.png");
            //imageOn.BackgroundImage = new Bitmap(@"D:\Cours\2eme_Annee_BTS\Info\Projet_E62\VSed\CometLux_Solution_C#\src\on.png");
            // définis les images afin de les garder chargée
        }

        //définition des variables
        C_Lampes_HUE controlleur_lampes;
        Color couleur_lampe;
        ColorDialog dialogue_couleur = new ColorDialog();
        int lampes_choisis = -1;
        int effets = -1;
        string[,] liste_lampes;

        // Fonctions

        public void definition_couleur()
        {
            controlleur_lampes.changement_couleur(couleur_lampe, lampes_choisis); // change la couleur
            import_etat(lampes_choisis); // mets a jour les données affichées
        }

        private void trackBar_lum_Scroll(object sender, EventArgs e)
        {
            float pourcentage = (float)(Math.Floor(((float)(trackBar_lum.Value) / 255) * 100));
            label_lumi_pourcent.Text = ((pourcentage).ToString() + "%"); // convertis la valeur en pourcentage pour l'affichage
        }

        private void button_on_Click(object sender, EventArgs e)
        {
            controlleur_lampes.allumer_lampe(lampes_choisis);
            import_etat(lampes_choisis); // mets a jour les données affichées
            //allume les lampes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlleur_lampes.eteindre_lampe(lampes_choisis);
            import_etat(lampes_choisis); // mets a jour les données affichées
            // éteints les lampes
        }

        private void button_lum_Click(object sender, EventArgs e)
        {
            controlleur_lampes.changement_luminosite(trackBar_lum.Value, lampes_choisis); // change la luminosité
        }

        private void pictureBox_w_Click(object sender, EventArgs e)
        {
            couleur_lampe = pictureBox_w.BackColor; // définis la couleur en blanc
            definition_couleur(); // definis et envoie la couleur

        }

        private void pictureBox_R_Click(object sender, EventArgs e)
        {
            couleur_lampe = pictureBox_R.BackColor; // définis la couleur en rouge
            definition_couleur(); // definis et envoie la couleur
        }

        private void pictureBox_G_Click(object sender, EventArgs e)
        {
            couleur_lampe = pictureBox_G.BackColor; // définis la couleur en vert
            definition_couleur(); // definis et envoie la couleur
        }

        private void pictureBox_B_Click(object sender, EventArgs e)
        {
            couleur_lampe = pictureBox_B.BackColor; // définis la couleur en bleu
            definition_couleur(); // definis et envoie la couleur
        }

        private void button_appliquer_effets_Click(object sender, EventArgs e)
        {
            if(checkBox_multi.Checked == true)
            {
                effets = 1; // définis la valeur d'effet pour activer l'effet multicolore
            } else if(checkBox_cligno.Checked == true)
            {
                effets = 2; // définis la valeur d'effet pour activer le clignotement
            }
            else if(checkBox_cligno.Checked == true && checkBox_multi.Checked == true)
            {
                effets = 0; // pour activer tout les effets
            } else
            {
                effets = -1; // pour tout désactiver
            }
            controlleur_lampes.appliquer_effets(effets, lampes_choisis);
        }

        private void pictureBox_C_Click(object sender, EventArgs e)
        {
            dialogue_couleur.ShowDialog();
            pictureBox_C.BackColor = dialogue_couleur.Color; // definis la couleur selon celle choisis par l'utilisateur
            couleur_lampe = pictureBox_C.BackColor;
            definition_couleur(); // definis et envoie la couleur
        }

        private void Form_HUE_Load(object sender, EventArgs e)
        {
            Form_Connexion connect = new Form_Connexion();
            connect.ShowDialog();
            controlleur_lampes = connect.export();
            liste_lampes = controlleur_lampes.importer_lampe();
            comboBox_lampes.Items.Add("Toutes les lampes");
            for (int i = 0; i < liste_lampes.Length/4; i++)
            {
                comboBox_lampes.Items.Add(liste_lampes[i, 1]);
            }
            // affiche le form de connexion afin de se connecter à la centrale Philips HUE
        }

        private void comboBox_lampes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lampes_choisis = comboBox_lampes.SelectedIndex; // définis les lampes choisies
            controlleur_lampes.import_donnees_lampes(lampes_choisis);
            import_etat(lampes_choisis);

        }

        private void import_etat(int lc)
        {
            switch (lc)
            {
                case 0:
                    label_warning.Visible = true;
                    trackBar_lum.Value = 255;
                    pictureBox_couleur_actuelle.BackColor = Color.White;
                    textBox_etat_actuel.Text = "X";
                    break;
                case 1:
                    label_warning.Visible = false;
                    trackBar_lum.Value = controlleur_lampes.get_luminosite(1);
                    pictureBox_couleur_actuelle.BackColor = controlleur_lampes.get_couleur(1);
                    if (controlleur_lampes.get_etat(1) == true)
                        textBox_etat_actuel.Text = "On";
                    else
                        textBox_etat_actuel.Text = "Off";
                    break;
                case 2:
                    label_warning.Visible = false;
                    trackBar_lum.Value = controlleur_lampes.get_luminosite(2);
                    pictureBox_couleur_actuelle.BackColor = controlleur_lampes.get_couleur(2);
                    if (controlleur_lampes.get_etat(2) == true)
                        textBox_etat_actuel.Text = "On";
                    else
                        textBox_etat_actuel.Text = "Off";
                    break;
            }
            float pourcentage = (float)(Math.Floor(((float)(trackBar_lum.Value) / 255) * 100));
            label_lumi_pourcent.Text = ((pourcentage).ToString() + "%");
        }


        private void checkBox_cligno_Click(object sender, EventArgs e)
        {
            checkBox_multi.Checked = false; // rends les options clignotement et multicolore mutuellement exclusive
        }

        private void checkBox_multi_Click(object sender, EventArgs e)
        {
            checkBox_cligno.Checked = false; // rends les options clignotement et multicolore mutuellement exclusive
        }

        private void label_lumi_pourcent_Click(object sender, EventArgs e)
        {

        }
    }
    
}
