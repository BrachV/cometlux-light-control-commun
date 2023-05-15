using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CometLux_Solution_ESP32
{
    public partial class Form_Ajout_Lampe : Form
    {
        public Form_Ajout_Lampe()
        {
            InitializeComponent();
        }

        private void Form_Ajout_Lampe_Load(object sender, EventArgs e)
        {
            importer_lampe();
        }

        C_SQL bdd = new C_SQL("192.168.0.20", "Admin", "cocorico%*", "cometlux", "3306");
        string[,] liste_lampes = new string[0, 0];

        public void importer_lampe()
        {
            liste_lampes = new string[0, 0]; // réinitialise la liste des lampes
            comboBox_lampes.Items.Clear(); // vide la combobox afin d'éviter les doublons.
            comboBox_lampes.Items.Add("Nouvelle Lampe"); // ajoute le choix de création d'une lampe
            int i = 0; // création d'un index
            string requete = "SELECT `id`, `nom`,`type` ,`id_hue`,`adresse_ip`, `adresse_mac` FROM `lampe` WHERE 1;"; // prépare la requête
            DataTable dt = bdd.exec_commande(requete); // récupère un DataTable grâce a la requête
            liste_lampes = new string[dt.Rows.Count, 6]; // ajuste la taille du tableau
            DataTableReader dr = dt.CreateDataReader();
            while (dr.Read()) // lecture des données récupérée
            {
                for(int i2 = 0; i2 < 6; i2++)
                {
                    if(i2 != 0 && i2 != 3) // les ID 0 et 3 correspondent à l'id et l'id HUE, des nombres entiers, je ne peux pas utiliser GetString pour eux.
                        liste_lampes[i, i2] = dr.GetString(i2); // récupère et stocke les données sous forme de string
                    else
                        liste_lampes[i, i2] = dr.GetInt32(i2).ToString(); // récupère, convertis et stocke les données sous forme de string
                }
                comboBox_lampes.Items.Add(liste_lampes[i, 1]); // ajoute la lampe à la combobox
                i++;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // désactive tout les champs
            textBox_IP.ReadOnly = true;
            textBox_MAC.ReadOnly = true;
            textBox_ID_HUE.ReadOnly = true;

            textBox_IP.Cursor = Cursors.No;
            textBox_MAC.Cursor = Cursors.No;
            textBox_ID_HUE.Cursor = Cursors.No;

            if (comboBox_type.SelectedIndex == 2) // si la lampe est une Philips HUE, active le champs ID HUE
            {
                textBox_ID_HUE.ReadOnly = false;
                textBox_ID_HUE.Cursor = Cursors.Default;
            }
            else if (comboBox_type.SelectedIndex == 1) // si la lampe est une Xbee, active le champs adresse MAC
            {
                textBox_MAC.ReadOnly = false;
                textBox_MAC.Cursor = Cursors.Default;
            }

            // remet a zero les champs pour éviter les problèmes
            textBox_MAC.Text = "";
            textBox_ID_HUE.Text = "";
            textBox_IP.Text = "";

        }

        private void bouton_save_Click(object sender, EventArgs e)
        {
            if ((textBox_nom.Text == "" || textBox_nom.Text == null) && (comboBox_type.SelectedIndex == -1))
            {
                MessageBox.Show("Veuillez renseigner un nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // insertion de valeur par défaut si aucune n'est entrée
                if (textBox_ID_HUE.Text == "" || textBox_ID_HUE.Text == null)
                    textBox_ID_HUE.Text = "0";
                if (textBox_IP.Text == "" || textBox_IP.Text == null)
                    textBox_IP.Text = "0";
                if (textBox_MAC.Text == "" || textBox_MAC.Text == null)
                    textBox_MAC.Text = "0";

                if (comboBox_lampes.SelectedIndex == 0) // ajout d'une nouvelle lampe
                {
                    string requete = "INSERT INTO lampe (`nom`, `type`, `id_hue`, `adresse_ip`, `adresse_mac`) " +
                        "VALUES ('" + textBox_nom.Text + "','" + comboBox_type.SelectedItem.ToString() + "','" + textBox_ID_HUE.Text + "','" + textBox_IP.Text + "','" + textBox_MAC.Text + "')";
                    bdd.exec_commande(requete);
                    MessageBox.Show("Sauvegarde terminée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                { // met a jour la lampe existante correspondante
                    string requete = "UPDATE `lampe` SET `nom` = '" + textBox_nom.Text + "', `type` = '" + comboBox_type.SelectedItem.ToString() +
                        "', `id_hue` = '" + textBox_ID_HUE.Text + "', `adresse_ip` = '" + textBox_IP.Text + "', `adresse_mac` = '" + textBox_MAC.Text + "' WHERE id = " +
                        liste_lampes[comboBox_lampes.SelectedIndex-1, 0];
                    bdd.exec_commande(requete);
                    MessageBox.Show("Sauvegarde terminée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            importer_lampe(); // met a jour la liste des lampes
            comboBox_lampes.SelectedIndex = 0; // sélectionne le premier index
        }

        private void comboBox_lampes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_lampes.SelectedIndex != 0 )
            { // importe les valeurs selon le type et la lampe
                if(liste_lampes[comboBox_lampes.SelectedIndex - 1, 2] == "WIFI") 
                {
                    comboBox_type.SelectedIndex = 0;
                    textBox_nom.Text = liste_lampes[comboBox_lampes.SelectedIndex - 1, 1];
                    textBox_ID_HUE.Text = "";
                    textBox_IP.Text = "";
                    textBox_MAC.Text = "";
                }
                else if (liste_lampes[comboBox_lampes.SelectedIndex - 1, 2] == "XBEE")
                {
                    comboBox_type.SelectedIndex = 1;
                    textBox_nom.Text = liste_lampes[comboBox_lampes.SelectedIndex - 1, 1];
                    textBox_ID_HUE.Text = "";
                    textBox_IP.Text = "";
                    textBox_MAC.Text = liste_lampes[comboBox_lampes.SelectedIndex - 1, 5];
                }
                else if (liste_lampes[comboBox_lampes.SelectedIndex - 1, 2] == "HUE")
                {
                    comboBox_type.SelectedIndex = 2;
                    textBox_nom.Text = liste_lampes[comboBox_lampes.SelectedIndex - 1, 1];
                    textBox_ID_HUE.Text = liste_lampes[comboBox_lampes.SelectedIndex - 1, 3];
                    textBox_IP.Text = "";
                    textBox_MAC.Text = "";
                }
            } else
            {
                textBox_MAC.Text = "";
                textBox_ID_HUE.Text = "";
                textBox_IP.Text = "";
                textBox_nom.Text = "";
                comboBox_type.Text = "      Sélectionnez une option";
            }
        }

        private void button_supp_Click(object sender, EventArgs e)
        {
            try
            { 
                if (comboBox_lampes.SelectedIndex == 0 || comboBox_lampes.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez choisir une lampe valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    DialogResult dlg = MessageBox.Show("Attention, cette action est irréversible, voulez-vous vraiment supprimer cette lampe ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        string requete = "DELETE FROM `lampe` WHERE id = " + liste_lampes[comboBox_lampes.SelectedIndex - 1, 0];
                        bdd.exec_commande(requete);
                        MessageBox.Show("Suppression terminée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        importer_lampe(); // met a jour la liste des lampes
                        comboBox_lampes.SelectedIndex = 0; // sélectionne le premier index
                    }
                }
            } catch {
                MessageBox.Show("Veuillez choisir une lampe valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
    }
}
