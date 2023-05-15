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
    public partial class Form_ProjecteurX : Form
    {
        public Form_ProjecteurX()
        {
            InitializeComponent();
            imageOff.BackgroundImage = new Bitmap(@"C:\Developpement\Cometlux\CometLux_Solution_ESP32\src\off.png");
            imageOn.BackgroundImage = new Bitmap(@"C:\Developpement\Cometlux\CometLux_Solution_ESP32\src\on.png");
        }

        private void imageOff_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
