namespace CometLux_Solution_ESP32
{
    partial class Form_Ajout_Lampe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajout_Lampe));
            this.label_logs = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.comboBox_lampes = new System.Windows.Forms.ComboBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ID_HUE = new System.Windows.Forms.TextBox();
            this.separateur = new System.Windows.Forms.PictureBox();
            this.bouton_save = new System.Windows.Forms.Button();
            this.button_supp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateur)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logs
            // 
            this.label_logs.AutoSize = true;
            this.label_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_logs.ForeColor = System.Drawing.Color.White;
            this.label_logs.Location = new System.Drawing.Point(341, 53);
            this.label_logs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_logs.Name = "label_logs";
            this.label_logs.Size = new System.Drawing.Size(305, 39);
            this.label_logs.TabIndex = 9;
            this.label_logs.Text = "Liste des Lampes";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(726, 42);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(197, 29);
            this.labelMenu.TabIndex = 8;
            this.labelMenu.Text = "Retour au Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // comboBox_lampes
            // 
            this.comboBox_lampes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_lampes.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox_lampes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_lampes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_lampes.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_lampes.FormattingEnabled = true;
            this.comboBox_lampes.ItemHeight = 23;
            this.comboBox_lampes.Location = new System.Drawing.Point(341, 138);
            this.comboBox_lampes.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_lampes.Name = "comboBox_lampes";
            this.comboBox_lampes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_lampes.Size = new System.Drawing.Size(274, 31);
            this.comboBox_lampes.TabIndex = 10;
            this.comboBox_lampes.Text = "      Sélectionnez une option";
            this.comboBox_lampes.SelectedIndexChanged += new System.EventHandler(this.comboBox_lampes_SelectedIndexChanged);
            // 
            // textBox_nom
            // 
            this.textBox_nom.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_nom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_nom.ForeColor = System.Drawing.Color.White;
            this.textBox_nom.Location = new System.Drawing.Point(226, 234);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(274, 31);
            this.textBox_nom.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adresse IP";
            // 
            // textBox_IP
            // 
            this.textBox_IP.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_IP.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_IP.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_IP.ForeColor = System.Drawing.Color.White;
            this.textBox_IP.Location = new System.Drawing.Point(226, 350);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.ReadOnly = true;
            this.textBox_IP.Size = new System.Drawing.Size(274, 31);
            this.textBox_IP.TabIndex = 13;
            // 
            // comboBox_type
            // 
            this.comboBox_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_type.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_type.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_type.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.ItemHeight = 23;
            this.comboBox_type.Items.AddRange(new object[] {
            "WIFI",
            "XBEE",
            "HUE"});
            this.comboBox_type.Location = new System.Drawing.Point(226, 292);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_type.Size = new System.Drawing.Size(274, 31);
            this.comboBox_type.TabIndex = 15;
            this.comboBox_type.Text = "      Sélectionnez une option";
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adresse MAC";
            // 
            // textBox_MAC
            // 
            this.textBox_MAC.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_MAC.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_MAC.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_MAC.ForeColor = System.Drawing.Color.White;
            this.textBox_MAC.Location = new System.Drawing.Point(226, 408);
            this.textBox_MAC.Name = "textBox_MAC";
            this.textBox_MAC.ReadOnly = true;
            this.textBox_MAC.Size = new System.Drawing.Size(274, 31);
            this.textBox_MAC.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID Hue";
            // 
            // textBox_ID_HUE
            // 
            this.textBox_ID_HUE.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_ID_HUE.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_ID_HUE.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_ID_HUE.ForeColor = System.Drawing.Color.White;
            this.textBox_ID_HUE.Location = new System.Drawing.Point(226, 469);
            this.textBox_ID_HUE.Name = "textBox_ID_HUE";
            this.textBox_ID_HUE.ReadOnly = true;
            this.textBox_ID_HUE.Size = new System.Drawing.Size(274, 31);
            this.textBox_ID_HUE.TabIndex = 19;
            // 
            // separateur
            // 
            this.separateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.separateur.BackColor = System.Drawing.Color.Silver;
            this.separateur.Location = new System.Drawing.Point(573, 209);
            this.separateur.Name = "separateur";
            this.separateur.Size = new System.Drawing.Size(1, 320);
            this.separateur.TabIndex = 21;
            this.separateur.TabStop = false;
            // 
            // bouton_save
            // 
            this.bouton_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bouton_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bouton_save.ForeColor = System.Drawing.SystemColors.Control;
            this.bouton_save.Location = new System.Drawing.Point(649, 292);
            this.bouton_save.Name = "bouton_save";
            this.bouton_save.Size = new System.Drawing.Size(264, 50);
            this.bouton_save.TabIndex = 22;
            this.bouton_save.Text = "Sauvegarder";
            this.bouton_save.UseVisualStyleBackColor = true;
            this.bouton_save.Click += new System.EventHandler(this.bouton_save_Click);
            // 
            // button_supp
            // 
            this.button_supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_supp.ForeColor = System.Drawing.SystemColors.Control;
            this.button_supp.Location = new System.Drawing.Point(649, 362);
            this.button_supp.Name = "button_supp";
            this.button_supp.Size = new System.Drawing.Size(264, 50);
            this.button_supp.TabIndex = 23;
            this.button_supp.Text = "Supprimer";
            this.button_supp.UseVisualStyleBackColor = true;
            this.button_supp.Click += new System.EventHandler(this.button_supp_Click);
            // 
            // Form_Ajout_Lampe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.button_supp);
            this.Controls.Add(this.bouton_save);
            this.Controls.Add(this.separateur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ID_HUE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.comboBox_lampes);
            this.Controls.Add(this.label_logs);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Ajout_Lampe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout et modification des lampes";
            this.Load += new System.EventHandler(this.Form_Ajout_Lampe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_logs;
        private Label labelMenu;
        private PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox comboBox_lampes;
        private TextBox textBox_nom;
        private Label label1;
        private Label label2;
        private TextBox textBox_IP;
        private ComboBox comboBox_type;
        private Label label3;
        private Label label4;
        private TextBox textBox_MAC;
        private Label label5;
        private TextBox textBox_ID_HUE;
        private PictureBox separateur;
        private Button bouton_save;
        private Button button_supp;
    }
}