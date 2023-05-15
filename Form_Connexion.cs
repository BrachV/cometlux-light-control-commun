using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CometLux_Solution_ESP32;
using Q42.HueApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PhilipsHue
{
    public partial class Form_Connexion : Form
    {
        public Form_Connexion()
        {
            InitializeComponent();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\config_light.txt") == true)
            {
                import(); // vérifie si l'ip a déjà été enregistrée, si c'est le cas, elle appelle la fonction "import"
            }
        }

        //definition variables
        string ip;
        LocalHueClient hueClient;
        C_Lampes_HUE Controlleur_Lampes;

        public async void trouverCentrale()
        {
            //création de l'outil fait pour chercher la centrale sur le réseau
            HttpBridgeLocator locator = new HttpBridgeLocator();
            Form_Loader chargement = new Form_Loader();
            chargement.Show();
            try
            {
                var bridges = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));


                //Cherche la centrale sur le réseau
                bridges = await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
                bridges = await HueBridgeDiscovery.FastDiscoveryWithNetworkScanFallbackAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
                bridges = await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));

                connecterCentrale(); // appelle la fonction de connexion à la centrale
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Aucune centrale n'a été trouvée\nCode d'erreur :\n"+ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                return;
            }
            chargement.Close();
        }

        public async void connecterCentrale()
        {
            try
            {
                LocalHueClient client = new LocalHueClient(ip); // création d'un client de controle

                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\config_light_authkey.txt"))
                {
                    var appKey = await client.RegisterAsync("HUELightControl", "CentraleCometLux");
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\config_light_authkey.txt", appKey.ToString(), Encoding.UTF8);
                    //créé et sauvegarde la clé d'application dans le cas ou c'est la première fois que l'application se connecte à la centrale
                }
                else
                {
                    StreamReader fichier = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\config_light_authkey.txt");
                    string ligne = "";
                    string appKey = "";
                    while ((ligne = fichier.ReadLine()) != null)
                    {
                        appKey = ligne; // récupère la clé d'authentification dans un fichier
                    }
                    fichier.Close();

                    client.Initialize(appKey); // initialise la connexion avec la clé d'authentification
                }
                MessageBox.Show("Connexion terminée", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hueClient = client;
                Controlleur_Lampes = new C_Lampes_HUE(hueClient, true, Color.White, 255, -1); // créer un objet de la classe
                this.Close();

            } catch
            {
                MessageBox.Show("Connexion échouée", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error); // en cas d'erreur pour éviter le crash
                button1.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e) // bouton de connexion
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\config_light_authkey.txt"))
            {
                MessageBox.Show("Aucune centrale n'est connectée, avant de continuer, veuillez appuyer sur le bouton de la centrale que vous souhaitez connecter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // vérifie si la centrale a déjà été connectée, si ce n'est pas le cas, elle donne des instructions
            }
                MessageBox.Show("Début de la connexion, Appuyez sur \"OK\" pour continuer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
            trouverCentrale(); // lancement de la recherche de la centrale
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Champs de texte "IP"
        {
            ip = text_ip1.Text; // définis l'adresse IP a chaque changement de valeur de la textBox
        }

        private void Form_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // bouton "Valider Adresse IP"
        {
            try
            {
                string nom_fichier = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\config_light.txt";
                File.WriteAllText(nom_fichier, ip, Encoding.UTF8);
                MessageBox.Show("Configuration enregistrée", "Succès de l'opération", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // enregistre l'adresse IP fournie par l'utilisateur dans un fichier texte externe pour pouvoir la réutiliser
            }
            catch
            {
                MessageBox.Show("Sauvegarde échouée", "Echec de l'opération", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void import()
        {
            string nom_fichier = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\config_light.txt";
            StreamReader fichier = new StreamReader(nom_fichier);
            {
                string ligne = "";
                while ((ligne = fichier.ReadLine()) != null)
                {
                    ip = ligne;
                    text_ip1.Text = ip;
                }
                // importe l'adresse IP du fichier texte créer précedamment dans le cas ou ce n'est pas la première fois que cette application est lancée
                fichier.Close();
            }
        }

        public C_Lampes_HUE export()
        {
            return Controlleur_Lampes;
        }
        private LocalHueClient Form_Connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            return hueClient;
        }
    }
}
