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
    public partial class Form_Scen_Existant : Form
    {
        public Form_Scen_Existant()
        {
            InitializeComponent();
        }
        int id_scenario;
        public void set_coord(int l, int h)
        {
            this.Left = l;
            this.Top = h;
        }

        public void set_info(string n, int id, int nb)
        {
            label_Index.Text = nb.ToString();
            id_scenario = id;
            label_Titre.Text = n;
        }

        public void modification()
        {
            C_Scenario Scenario_modif = new C_Scenario();
            Scenario_modif.importer_scenario(id_scenario);
            Form_Scen_Creation Form_Crea = new Form_Scen_Creation();
            Form_Crea.import_scenario(Scenario_modif, id_scenario);
            Form_Crea.ShowDialog();
        }

        public void suppression()
        {
            DialogResult dlg = MessageBox.Show("Êtes vous sûr de vouloir effectuer cette opération ?\nIl est impossible de récuperer tout scénario qui a été supprimé.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                C_SQL bdd = new C_SQL("192.168.0.20", "Admin", "cocorico%*", "cometlux", "3306");
                string requete = "DELETE FROM `etapes` WHERE id_scenarios = " + id_scenario.ToString();
                if (bdd.exec_commande(requete) == null) return; // suppression des étapes
                requete = "DELETE FROM `scenario` WHERE id = " + id_scenario.ToString();
                if (bdd.exec_commande(requete) == null) return; // suppression des étapes
                this.Close(); // fermeture du form
            }
        }
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            modification();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            suppression();
        }
    }
}
