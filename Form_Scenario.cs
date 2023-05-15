using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CometLux_Solution_ESP32
{
    public partial class Form_Scenario : Form
    {
        public Form_Scenario()
        {
            InitializeComponent();
        }

        C_SQL bdd = new C_SQL("192.168.0.20", "Admin", "cocorico%*", "cometlux", "3306");
        private bool protection_refresh = false;
        int[] coord = { 10, 14 };
        int id_nb_scenar = 1;
        int nb_scenar = 0;

        private void Form_Scenario_Load(object sender, EventArgs e)
        {
            MaJ_Liste_Scenar();
        }

        public void MaJ_Liste_Scenar()
        {
            protection_refresh = true; // evite que la fonction se lance en boucle
            panel_liste.Hide();
            panel_liste.Controls.Clear(); // supprimer tout les forms existant
            //réinitialisation des variables
            coord[0] = 10;
            coord[1] = 14;
            id_nb_scenar = 1;
            nb_scenar = 0;
            DataTable dt = bdd.exec_commande("SELECT * FROM scenario");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nb_scenar++;
                ajouter_scenario_liste();
            }
            // récupération du nombre de scénario afin de créer le nombre de form approprié
            panel_liste.Show();
            protection_refresh = false; // remet a zero la vérification
        }

        private void ajouter_scenario_liste()
        {
            // création du form
            Form_Scen_Existant objet_form = new Form_Scen_Existant();
            objet_form.TopLevel = false;
            objet_form.StartPosition = FormStartPosition.Manual;
            objet_form.set_coord(coord[0], coord[1]);
            panel_liste.Controls.Add(objet_form);
            //récupération des infos de la base de données
            DataTable dt = bdd.exec_commande("SELECT id, nom FROM scenario");
            DataTableReader dr = dt.CreateDataReader();
            int pos_lecteur = 1;
            while(dr.Read())
            {
                int id = dr.GetInt32(0);
                if (id == id_nb_scenar || id_nb_scenar == pos_lecteur)
                {
                    objet_form.set_info(dr.GetString(1), dr.GetInt32(0), nb_scenar);
                }
                pos_lecteur++;
            }
            // incrémentation des valeurs de position permettant de repositionner les forms
            objet_form.Show();
            if (coord[0] + 331 > 672)
            {
                coord[0] = 10;
                coord[1] = coord[1] + 150;
            }
            else
            {
                coord[0] = coord[0] + 331;
            }
            id_nb_scenar++;
        }
        private void labelLumiere_Click(object sender, EventArgs e)
        {
            Form_Lumiere lumiere = new Form_Lumiere();
            this.Hide();

            lumiere.Closed += (s, args) => this.Close();

            lumiere.Show();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            Form_Home home = new Form_Home();
            this.Hide();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void button_addScenario_Click(object sender, EventArgs e)
        {
            Form_Scen_Creation Form_Crea = new Form_Scen_Creation();
            this.Hide();
            Form_Crea.Closed += (s, args) => this.Close();
            Form_Crea.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Form_Lumiere lumiere = new Form_Lumiere();
            this.Hide();
            lumiere.Closed += (s, args) => this.Close();
            lumiere.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form_Home home = new Form_Home();
            this.Hide();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void panel_liste_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (protection_refresh == false)
            MaJ_Liste_Scenar();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            MaJ_Liste_Scenar();
        }
    }
}
