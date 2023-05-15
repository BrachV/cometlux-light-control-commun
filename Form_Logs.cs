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
    public partial class Form_Logs : Form
    {
        public Form_Logs()
        {
            InitializeComponent();
        }

        C_SQL bdd = new C_SQL("192.168.0.20", "Admin", "cocorico%*", "cometlux", "3306");

        private void Form_Logs_Load(object sender, EventArgs e)
        {
            MaJ_logs();
        }

        private void MaJ_logs()
        {
            dataGridView_logs.Rows.Clear();
            string requete = "SELECT logs.id, lampe.nom, logs.description, logs.source, logs.timestamp " +
                "FROM logs JOIN lampe ON logs.lampe_id = lampe.id " +
                "ORDER BY logs.id DESC;";
            // récupère les valeurs en associant l'id de la lampe a son nom et en les classant par id de logs décroissant.
            DataTable dt = bdd.exec_commande(requete);
            DataTableReader dr = new DataTableReader(dt);
            while (dr.Read())
            {
                object[] arrayValeurs = new object[dt.Rows.Count];
                dr.GetValues(arrayValeurs);
                dataGridView_logs.Rows.Add(arrayValeurs);
            }
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaJ_logs();
        }
    }
}
