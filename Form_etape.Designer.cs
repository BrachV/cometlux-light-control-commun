namespace CometLux_Solution_ESP32
{
    partial class Form_etape
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_num = new System.Windows.Forms.Label();
            this.combo_lampe = new System.Windows.Forms.ComboBox();
            this.combo_etat = new System.Windows.Forms.ComboBox();
            this.trackbar_lum = new System.Windows.Forms.TrackBar();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.color_hexa = new System.Windows.Forms.TextBox();
            this.textBox_delais = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_lum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // label_num
            // 
            this.label_num.BackColor = System.Drawing.Color.Transparent;
            this.label_num.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_num.Location = new System.Drawing.Point(59, 1);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(69, 31);
            this.label_num.TabIndex = 3;
            this.label_num.Text = "000";
            this.label_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_lampe
            // 
            this.combo_lampe.FormattingEnabled = true;
            this.combo_lampe.Location = new System.Drawing.Point(132, 5);
            this.combo_lampe.Name = "combo_lampe";
            this.combo_lampe.Size = new System.Drawing.Size(196, 23);
            this.combo_lampe.TabIndex = 4;
            this.combo_lampe.Text = "Veuillez choisir une lampe";
            this.combo_lampe.SelectedIndexChanged += new System.EventHandler(this.combo_lampe_SelectedIndexChanged);
            // 
            // combo_etat
            // 
            this.combo_etat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_etat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_etat.Enabled = false;
            this.combo_etat.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.combo_etat.Location = new System.Drawing.Point(341, 5);
            this.combo_etat.Name = "combo_etat";
            this.combo_etat.Size = new System.Drawing.Size(54, 23);
            this.combo_etat.TabIndex = 5;
            this.combo_etat.Text = "On";
            this.combo_etat.SelectedIndexChanged += new System.EventHandler(this.combo_etat_SelectedIndexChanged);
            // 
            // trackbar_lum
            // 
            this.trackbar_lum.Enabled = false;
            this.trackbar_lum.LargeChange = 25;
            this.trackbar_lum.Location = new System.Drawing.Point(411, -5);
            this.trackbar_lum.Margin = new System.Windows.Forms.Padding(0);
            this.trackbar_lum.Maximum = 255;
            this.trackbar_lum.Name = "trackbar_lum";
            this.trackbar_lum.Size = new System.Drawing.Size(193, 45);
            this.trackbar_lum.TabIndex = 6;
            this.trackbar_lum.TickFrequency = 0;
            this.trackbar_lum.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackbar_lum.Value = 255;
            this.trackbar_lum.Scroll += new System.EventHandler(this.trackbar_lum_Scroll);
            // 
            // color_picker
            // 
            this.color_picker.BackColor = System.Drawing.Color.White;
            this.color_picker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Enabled = false;
            this.color_picker.Location = new System.Drawing.Point(629, 5);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(22, 23);
            this.color_picker.TabIndex = 7;
            this.color_picker.TabStop = false;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            // 
            // color_hexa
            // 
            this.color_hexa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.color_hexa.Enabled = false;
            this.color_hexa.Location = new System.Drawing.Point(657, 5);
            this.color_hexa.Name = "color_hexa";
            this.color_hexa.ReadOnly = true;
            this.color_hexa.Size = new System.Drawing.Size(104, 23);
            this.color_hexa.TabIndex = 8;
            this.color_hexa.Text = "#FFFFFF";
            this.color_hexa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_delais
            // 
            this.textBox_delais.Enabled = false;
            this.textBox_delais.Location = new System.Drawing.Point(789, 5);
            this.textBox_delais.MaxLength = 2;
            this.textBox_delais.Name = "textBox_delais";
            this.textBox_delais.Size = new System.Drawing.Size(134, 23);
            this.textBox_delais.TabIndex = 9;
            this.textBox_delais.Text = "0";
            this.textBox_delais.TextChanged += new System.EventHandler(this.textBox_delais_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(31, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form_etape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 33);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_delais);
            this.Controls.Add(this.color_hexa);
            this.Controls.Add(this.color_picker);
            this.Controls.Add(this.trackbar_lum);
            this.Controls.Add(this.combo_etat);
            this.Controls.Add(this.combo_lampe);
            this.Controls.Add(this.label_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_etape";
            this.Text = "Form_etape";
            this.Load += new System.EventHandler(this.Form_etape_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_lum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_num;
        private ComboBox combo_lampe;
        private ComboBox combo_etat;
        private TrackBar trackbar_lum;
        private PictureBox color_picker;
        private TextBox color_hexa;
        private TextBox textBox_delais;
        private CheckBox checkBox1;
    }
}