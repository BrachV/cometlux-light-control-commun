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

namespace CometLux_Solution_ESP32
{
    public partial class Form_etape : Form
    {
        public Form_etape()
        {
            InitializeComponent();
        }

        // definition des variables
        ColorDialog dialogue_couleur = new ColorDialog();
        int id = 0, delai = 0, luminosite = 255;
        bool etat = true;
        Color couleur = Color.White;
        string cible = "", code_hexa = "";
        string[,] liste_lampes;
        int lampe_choisie;

        //getters et setters
        public void set_id(int i) { id = i; label_num.Text = i.ToString(); }
        public void set_cible(int l) { lampe_choisie = l; combo_lampe.SelectedIndex = l; }
        public void set_etat(bool e) { etat = e; if (e == true) combo_etat.SelectedIndex = 0; else combo_etat.SelectedIndex = 1; }
        public void set_luminosite(int l) { luminosite = l; trackbar_lum.Value = l; }
        public void set_couleur(Color c)
        {
            couleur = c;
            color_picker.BackColor = c;
            code_hexa = color_picker.BackColor.R.ToString("X2") + color_picker.BackColor.G.ToString("X2") + color_picker.BackColor.B.ToString("X2");
            color_hexa.Text = "#" + code_hexa;
        }

        public void set_couleur_hexa(string c)
        {
            if(c == null || c == "" || c.Length != 6)
            {
                return; // vérificatio, si aucun code n'est stocké, alors aucune action n'est faites
            } else
            {
                code_hexa = c;
                color_hexa.Text = "#" + code_hexa;
                // conversion de code Hexadecimal a code RGB
                int r, g, b;
                r = int.Parse(c.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                g = int.Parse(c.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                b = int.Parse(c.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                color_picker.BackColor = Color.FromArgb(r, g, b);
            }
        }
        public void set_delai(int d) { delai = d; textBox_delais.Text = d.ToString(); }
        public void set_coord(int c) { this.Top = c; }
        public void set_liste_lampes(string[,] ll) 
        { 
            liste_lampes = ll;
            for(int i = 0; i < ll.GetLength(0); i++)
            {
                combo_lampe.Items.Add(liste_lampes[i,1]);
            }
            
        }
        public int get_id() { return id; }
        public string get_cible() { return cible; }
        public bool get_etat() { return etat; }
        public int get_etat_int() { if (etat == true) return 1; else return 0; }
        public int get_luminosite() { return luminosite; }
        public Color get_couleur() { return couleur; }
        public string get_hex() { return code_hexa; }
        public int get_delai() { return delai; }
        public int get_coord() { return this.Top; }

        public string[,] get_liste_lampes() { return liste_lampes; }
        public int get_lampe_choisie() { return lampe_choisie; }

        // méthodes

        private void Form_etape_Load(object sender, EventArgs e)
        {
            if (id % 2 != 0)
            {
                this.BackColor = Color.LightGray;
                trackbar_lum.BackColor = Color.LightGray;
            }
        }

        private void textBox_delais_TextChanged(object sender, EventArgs e)
        {
            char[] Texte = textBox_delais.Text.ToCharArray();
            foreach (char c in Texte)
            {
                try
                {

                    if (!(Char.IsNumber(c))) // verifie sur l'utilisateur entre un nombre
                    {
                        textBox_delais.Text = textBox_delais.Text.Remove(textBox_delais.Text.IndexOf(c)); // si non, le supprime
                    }
                    else
                    {
                        delai = Convert.ToInt16(textBox_delais.Text); // si oui, enregistre la valeur
                    }
                }catch
                {
                    textBox_delais.Text = "0"; // en cas d'erreur, réinitialise la textbox
                }
                
            }
        }

        private void combo_etat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_etat.SelectedIndex == 0) etat = true; else etat = false;
        }

        private void trackbar_lum_Scroll(object sender, EventArgs e)
        {
            luminosite = trackbar_lum.Value;
        }

        private void color_picker_Click(object sender, EventArgs e)
            {
                dialogue_couleur.ShowDialog();
                color_picker.BackColor = dialogue_couleur.Color; // definis la couleur selon celle choisis par l'utilisateur
                code_hexa = dialogue_couleur.Color.R.ToString("X2") + dialogue_couleur.Color.G.ToString("X2") + dialogue_couleur.Color.B.ToString("X2");
                color_hexa.Text = "#" + code_hexa;

            }

            private void combo_lampe_SelectedIndexChanged(object sender, EventArgs e)
            {
                lampe_choisie = combo_lampe.SelectedIndex;
                if (liste_lampes[lampe_choisie,2].ToLower() != "hue")
                {
                    color_hexa.Enabled = false;
                    color_picker.Enabled = false;
                } else
                {
                    color_hexa.Enabled = true;
                    color_picker.Enabled = true;
                }
                trackbar_lum.Enabled = true;
                color_hexa.Text = "#FFFFFF";
                code_hexa = "FFFFFF";
                color_picker.BackColor = Color.White;
                trackbar_lum.Value = 255;
                textBox_delais.Enabled = true;
                combo_etat.Enabled = true;
            }
        }
    }

