using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Form_Scen_Creation : Form
    {
        public Form_Scen_Creation()
        {
            InitializeComponent();
            tableau_etapes.VerticalScroll.Visible = true;
        }

        C_Scenario scenario = new C_Scenario();
        string[,] liste_lampes;

        private void button_commencer_Click(object sender, EventArgs e)
        {
            if (text_box_nom.Text == "" || text_box_nom.Text == null || textBox_desc.Text == "" || textBox_desc.Text == null)
                MessageBox.Show("Veuillez renseigner le nom et la description de votre scénario", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            panel_menu_ajout.Hide();
            panel_planification.Show();
            scenario = new C_Scenario(text_box_nom.Text, textBox_desc.Text, new Form_etape[0]);
            liste_lampes = scenario.importer_lampe();
            ajouter_etape();
        }

        public void import_scenario(C_Scenario scenar_import, int id)
        {
            scenario = scenar_import;
            panel_menu_ajout.Hide();
            panel_planification.Show();
            liste_lampes = scenario.importer_lampe();

            // définition des variables nécessaire pour l'import
            C_SQL bdd = new C_SQL("192.168.0.20", "Admin", "cocorico%*", "cometlux", "3306");
            int num_etape_actuelle = 0;

            //envoie de la requête
            string requete = "SELECT * FROM etapes WHERE id_scenarios =" + id;
            DataTable dt = bdd.exec_commande(requete);
            DataTableReader dr = dt.CreateDataReader();
            // parcours des informations afin de pouvoir les traiter
            while (dr.Read())
            {
                ajouter_etape();
                scenario.set_une_etape(num_etape_actuelle, dr.GetInt32(6)-1, dr.GetInt32(4), dr.GetInt32(5), dr.GetString(7), dr.GetInt32(8)) ;
                num_etape_actuelle++;
            }

        }

        private void ajouter_etape()
        {
            scenario.ajouter_etape();
            int nb_etapes = scenario.get_etapes().Length - 1;
            Form_etape nouvelle_etape = new Form_etape();
            int coord_precedent = 0;
            nouvelle_etape.TopLevel = false;
            tableau_etapes.Controls.Add(nouvelle_etape);
            nouvelle_etape.StartPosition = FormStartPosition.Manual;
            nouvelle_etape.set_liste_lampes(scenario.get_liste_lampes());
            if (nb_etapes == 0)
            {
                nouvelle_etape.Top = 0;
            } else
            {
                 coord_precedent = scenario.get_une_etape(nb_etapes - 1).get_coord();
                 nouvelle_etape.Top = coord_precedent + 35;
            }
            
            nouvelle_etape.set_coord(nouvelle_etape.Top);
            nouvelle_etape.Left = 2;
            nouvelle_etape.set_id(nb_etapes+1);
            scenario.set_une_etape(nb_etapes, nouvelle_etape);
            nouvelle_etape.Show();
            label_nb_etapes.Text = "Nombre d'étape(s) : "+(nb_etapes+1).ToString();
        }

        private void button_ajout_Click(object sender, EventArgs e)
        {
            ajouter_etape();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            if(scenario.sauvegarder_scenario() == true)
                this.Close();
        }

        private void label_nb_etapes_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form_Home home = new Form_Home();
            this.Hide();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form_Lumiere lumiere = new Form_Lumiere();
            this.Hide();

            lumiere.Closed += (s, args) => this.Close();

            lumiere.Show();
        }

        private void text_box_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_sup_Click(object sender, EventArgs e)
        {
            if(scenario.get_etapes().Length <= 1)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer la première étape", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                scenario.get_etapes()[scenario.get_etapes().Length - 1].Close();
                
                scenario.supprimer_etape();
                label_nb_etapes.Text = "Nombre d'étape(s) : " + (scenario.get_etapes().Length).ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        { //bouton scenario
            Form_Scenario scenar = new Form_Scenario();
            this.Hide();
            scenar.Closed += (s, args) => this.Close();
            scenar.Show();
        }
    }

}
