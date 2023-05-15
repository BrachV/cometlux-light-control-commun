using System.Drawing.Drawing2D;

namespace CometLux_Solution_ESP32
{
    public partial class Form_Lumiere : Form
    {
        public string selected = "";
        public Dictionary<string, Button> items = new Dictionary<string, Button>();
        public Form formSelected = new Form();

        public int x = 150;
        public int y = 200;

        public Form_Lumiere()
        {
            InitializeComponent();

            items.Add("hue", buttonHUE);
            items.Add("pro_w", buttonProjecteurW);
            items.Add("pro_x", buttonProjecteurX);
        }

        public void setDefaut(string lampe)
        {
            if (lampe == "hue") buttonHUE_Click(null, null);
            if (lampe == "pro_w") buttonProjecteurW_Click(null, null);
            if (lampe == "pro_x") buttonProjecteurX_Click(null, null);
        }

        private void buttonHUE_Click(object? sender, EventArgs? e)
        {
            if (selected == "hue") return;
            switchColor("hue");
            if (formSelected != null) formSelected.Dispose();

            Form_HUE form_HUE = new Form_HUE();
            form_HUE.TopLevel = false;


            form_HUE.StartPosition = FormStartPosition.Manual;
            form_HUE.Top = y;
            form_HUE.Left = x;
            this.Controls.Add(form_HUE);
            form_HUE.Show();
            formSelected = form_HUE;

        }

        private void buttonProjecteurW_Click(object? sender, EventArgs? e)
        {
            if (selected == "pro_w") return;
            switchColor("pro_w");
            if (formSelected != null) formSelected.Dispose();

            Form_ProjecteurW form_ProjecteurW = new Form_ProjecteurW();
            form_ProjecteurW.TopLevel = false;
            

            form_ProjecteurW.StartPosition = FormStartPosition.Manual;
            form_ProjecteurW.Top = y;
            form_ProjecteurW.Left = x;
            this.Controls.Add(form_ProjecteurW);
            form_ProjecteurW.Show();
            formSelected = form_ProjecteurW;
        }

        private void buttonProjecteurX_Click(object? sender, EventArgs? e)
        {if (selected == "pro_x") return;
            switchColor("pro_x");
            if (formSelected != null) formSelected.Dispose();


            Form_ProjecteurX form_ProjecteurX = new Form_ProjecteurX();
            form_ProjecteurX.TopLevel = false;


            form_ProjecteurX.StartPosition = FormStartPosition.Manual;
            form_ProjecteurX.Top = y;
            form_ProjecteurX.Left = x;
            this.Controls.Add(form_ProjecteurX);
            form_ProjecteurX.Show();
            formSelected = form_ProjecteurX;

        }

        public void switchColor(string source)
        { 
            for (int i = 0; i < items.Count; i++)
            {
                items.ElementAt(i).Value.BackColor = Color.Transparent;
                items.ElementAt(i).Value.ForeColor = ColorTranslator.FromHtml("#FFF");
            }

            items[source].BackColor = ColorTranslator.FromHtml("#FFE66D");
            items[source].ForeColor = ColorTranslator.FromHtml("#000");
            selected = source;

        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            Form_Home home = new Form_Home();
            this.Hide();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void labelScenario_Click(object sender, EventArgs e)
        {
            Form_Scenario scenario = new Form_Scenario();
            scenario.Closed += (s, args) => this.Close();

            scenario.Show();
            this.Hide();
        }
    }
}