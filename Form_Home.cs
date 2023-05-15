using System.Drawing.Drawing2D;

namespace CometLux_Solution_ESP32
{
    public partial class Form_Home : Form
    {
        public string selected = "";
        public Dictionary<string, Button> items = new Dictionary<string, Button>();
        public Form formSelected = new Form();

        public Form_Home()
        {
            InitializeComponent();

        }

        private void button_voirHUE_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Lumiere lumiere = new Form_Lumiere();
                this.Hide();

                lumiere.Closed += (s, args) => this.Close();
                lumiere.Show();
                lumiere.setDefaut("hue");

            } catch
            {
                MessageBox.Show("Echec de l'opération.\nVérifiez votre connexion internet et l'état de votre serveur.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labelLumiere_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Lumiere lumiere = new Form_Lumiere();
                this.Hide();

                lumiere.Closed += (s, args) => this.Close();

                lumiere.Show();
            }
            catch
            {
                MessageBox.Show("Echec de l'opération.\nVérifiez votre connexion internet et l'état de votre serveur.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_voirW_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Lumiere lumiere = new Form_Lumiere();
                lumiere.Closed += (s, args) => this.Close();

                lumiere.Show();
                this.Hide();

                lumiere.setDefaut("pro_w");
            }
            catch
            {
                MessageBox.Show("Echec de l'opération.\nVérifiez votre connexion internet et l'état de votre serveur.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_voirX_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Lumiere lumiere = new Form_Lumiere();
                lumiere.Closed += (s, args) => this.Close();

                lumiere.Show();
                this.Hide();

                lumiere.setDefaut("pro_x");
            }
            catch
            {
                MessageBox.Show("Echec de l'opération.\nVérifiez votre connexion internet et l'état de votre serveur.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labelScenario_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Scenario scenario = new Form_Scenario();
                scenario.Closed += (s, args) => this.Close();

                scenario.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Echec de l'opération.\nVérifiez votre connexion internet et l'état de votre serveur.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Logs log = new Form_Logs();

                log.Closed += (s, args) => this.Show(); //affiche le form home quand le form log est fermé

                log.Show();
                this.Hide();
            } catch
            {
                MessageBox.Show("Echec de l'opération.\nVérifiez votre connexion internet et l'état de votre serveur.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_liste_lampes_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Ajout_Lampe liste_lampes = new Form_Ajout_Lampe();

                liste_lampes.Closed += (s, args) => this.Show(); //affiche le form home quand le form log est fermé
                liste_lampes.Show();
                this.Hide();
            } catch
            {
                MessageBox.Show("Echec de l'opération.\nVérifiez votre connexion internet et l'état de votre serveur.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}