namespace CometLux_Solution_ESP32
{
    partial class Form_HUE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HUE));
            this.imageOff = new System.Windows.Forms.PictureBox();
            this.imageOn = new System.Windows.Forms.PictureBox();
            this.button_on = new System.Windows.Forms.Button();
            this.comboBox_lampes = new System.Windows.Forms.ComboBox();
            this.trackBar_lum = new System.Windows.Forms.TrackBar();
            this.label_etat = new System.Windows.Forms.Label();
            this.label_lum = new System.Windows.Forms.Label();
            this.separateur = new System.Windows.Forms.PictureBox();
            this.label_couleur = new System.Windows.Forms.Label();
            this.label_lumi_pourcent = new System.Windows.Forms.Label();
            this.button_lum = new System.Windows.Forms.Button();
            this.pictureBox_w = new System.Windows.Forms.PictureBox();
            this.pictureBox_R = new System.Windows.Forms.PictureBox();
            this.pictureBox_G = new System.Windows.Forms.PictureBox();
            this.pictureBox_B = new System.Windows.Forms.PictureBox();
            this.pictureBox_C = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_multi = new System.Windows.Forms.CheckBox();
            this.checkBox_cligno = new System.Windows.Forms.CheckBox();
            this.button_appliquer_effets = new System.Windows.Forms.Button();
            this.textBox_etat_actuel = new System.Windows.Forms.TextBox();
            this.label_warning = new System.Windows.Forms.Label();
            this.label_couleur_actuelle = new System.Windows.Forms.Label();
            this.pictureBox_couleur_actuelle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_lum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_couleur_actuelle)).BeginInit();
            this.SuspendLayout();
            // 
            // imageOff
            // 
            this.imageOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageOff.BackgroundImage")));
            this.imageOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageOff.Location = new System.Drawing.Point(77, 428);
            this.imageOff.Name = "imageOff";
            this.imageOff.Size = new System.Drawing.Size(74, 80);
            this.imageOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOff.TabIndex = 5;
            this.imageOff.TabStop = false;
            // 
            // imageOn
            // 
            this.imageOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageOn.BackgroundImage")));
            this.imageOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageOn.Location = new System.Drawing.Point(337, 423);
            this.imageOn.Name = "imageOn";
            this.imageOn.Size = new System.Drawing.Size(74, 85);
            this.imageOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOn.TabIndex = 6;
            this.imageOn.TabStop = false;
            // 
            // button_on
            // 
            this.button_on.AutoEllipsis = true;
            this.button_on.BackColor = System.Drawing.Color.Gray;
            this.button_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_on.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_on.FlatAppearance.BorderSize = 2;
            this.button_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button_on.ForeColor = System.Drawing.Color.Black;
            this.button_on.Image = ((System.Drawing.Image)(resources.GetObject("button_on.Image")));
            this.button_on.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_on.Location = new System.Drawing.Point(77, 213);
            this.button_on.Name = "button_on";
            this.button_on.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_on.Size = new System.Drawing.Size(157, 100);
            this.button_on.TabIndex = 4;
            this.button_on.Text = "On";
            this.button_on.UseVisualStyleBackColor = false;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // comboBox_lampes
            // 
            this.comboBox_lampes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_lampes.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox_lampes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_lampes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_lampes.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_lampes.FormattingEnabled = true;
            this.comboBox_lampes.ItemHeight = 36;
            this.comboBox_lampes.Location = new System.Drawing.Point(323, 53);
            this.comboBox_lampes.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_lampes.Name = "comboBox_lampes";
            this.comboBox_lampes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_lampes.Size = new System.Drawing.Size(390, 44);
            this.comboBox_lampes.TabIndex = 8;
            this.comboBox_lampes.Text = "      Sélectionnez une lumière";
            this.comboBox_lampes.SelectedIndexChanged += new System.EventHandler(this.comboBox_lampes_SelectedIndexChanged);
            // 
            // trackBar_lum
            // 
            this.trackBar_lum.LargeChange = 10;
            this.trackBar_lum.Location = new System.Drawing.Point(143, 428);
            this.trackBar_lum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_lum.Maximum = 255;
            this.trackBar_lum.Name = "trackBar_lum";
            this.trackBar_lum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_lum.Size = new System.Drawing.Size(203, 69);
            this.trackBar_lum.TabIndex = 9;
            this.trackBar_lum.TickFrequency = 0;
            this.trackBar_lum.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_lum.Value = 255;
            this.trackBar_lum.Scroll += new System.EventHandler(this.trackBar_lum_Scroll);
            // 
            // label_etat
            // 
            this.label_etat.AutoSize = true;
            this.label_etat.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_etat.ForeColor = System.Drawing.Color.White;
            this.label_etat.Location = new System.Drawing.Point(77, 148);
            this.label_etat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_etat.Name = "label_etat";
            this.label_etat.Size = new System.Drawing.Size(91, 47);
            this.label_etat.TabIndex = 10;
            this.label_etat.Text = "Etat";
            // 
            // label_lum
            // 
            this.label_lum.AutoSize = true;
            this.label_lum.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_lum.ForeColor = System.Drawing.Color.White;
            this.label_lum.Location = new System.Drawing.Point(77, 362);
            this.label_lum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lum.Name = "label_lum";
            this.label_lum.Size = new System.Drawing.Size(226, 47);
            this.label_lum.TabIndex = 11;
            this.label_lum.Text = "Luminosité";
            // 
            // separateur
            // 
            this.separateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.separateur.BackColor = System.Drawing.Color.Silver;
            this.separateur.Location = new System.Drawing.Point(526, 148);
            this.separateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separateur.Name = "separateur";
            this.separateur.Size = new System.Drawing.Size(1, 388);
            this.separateur.TabIndex = 12;
            this.separateur.TabStop = false;
            // 
            // label_couleur
            // 
            this.label_couleur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_couleur.AutoSize = true;
            this.label_couleur.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_couleur.ForeColor = System.Drawing.Color.White;
            this.label_couleur.Location = new System.Drawing.Point(609, 148);
            this.label_couleur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_couleur.Name = "label_couleur";
            this.label_couleur.Size = new System.Drawing.Size(382, 47);
            this.label_couleur.TabIndex = 13;
            this.label_couleur.Text = "Palette de Couleur";
            // 
            // label_lumi_pourcent
            // 
            this.label_lumi_pourcent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_lumi_pourcent.ForeColor = System.Drawing.Color.White;
            this.label_lumi_pourcent.Location = new System.Drawing.Point(211, 473);
            this.label_lumi_pourcent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lumi_pourcent.Name = "label_lumi_pourcent";
            this.label_lumi_pourcent.Size = new System.Drawing.Size(74, 35);
            this.label_lumi_pourcent.TabIndex = 14;
            this.label_lumi_pourcent.Text = "100%";
            this.label_lumi_pourcent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_lumi_pourcent.Click += new System.EventHandler(this.label_lumi_pourcent_Click);
            // 
            // button_lum
            // 
            this.button_lum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.button_lum.FlatAppearance.BorderSize = 0;
            this.button_lum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_lum.ForeColor = System.Drawing.Color.White;
            this.button_lum.Location = new System.Drawing.Point(304, 377);
            this.button_lum.Margin = new System.Windows.Forms.Padding(0);
            this.button_lum.Name = "button_lum";
            this.button_lum.Size = new System.Drawing.Size(107, 38);
            this.button_lum.TabIndex = 15;
            this.button_lum.Text = "Appliquer";
            this.button_lum.UseVisualStyleBackColor = false;
            this.button_lum.Click += new System.EventHandler(this.button_lum_Click);
            // 
            // pictureBox_w
            // 
            this.pictureBox_w.BackColor = System.Drawing.Color.White;
            this.pictureBox_w.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_w.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_w.Location = new System.Drawing.Point(829, 263);
            this.pictureBox_w.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_w.Name = "pictureBox_w";
            this.pictureBox_w.Size = new System.Drawing.Size(27, 31);
            this.pictureBox_w.TabIndex = 16;
            this.pictureBox_w.TabStop = false;
            this.pictureBox_w.Click += new System.EventHandler(this.pictureBox_w_Click);
            // 
            // pictureBox_R
            // 
            this.pictureBox_R.BackColor = System.Drawing.Color.Red;
            this.pictureBox_R.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_R.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_R.Location = new System.Drawing.Point(829, 230);
            this.pictureBox_R.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_R.Name = "pictureBox_R";
            this.pictureBox_R.Size = new System.Drawing.Size(27, 31);
            this.pictureBox_R.TabIndex = 17;
            this.pictureBox_R.TabStop = false;
            this.pictureBox_R.Click += new System.EventHandler(this.pictureBox_R_Click);
            // 
            // pictureBox_G
            // 
            this.pictureBox_G.BackColor = System.Drawing.Color.Green;
            this.pictureBox_G.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_G.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_G.Location = new System.Drawing.Point(857, 263);
            this.pictureBox_G.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_G.Name = "pictureBox_G";
            this.pictureBox_G.Size = new System.Drawing.Size(27, 31);
            this.pictureBox_G.TabIndex = 18;
            this.pictureBox_G.TabStop = false;
            this.pictureBox_G.Click += new System.EventHandler(this.pictureBox_G_Click);
            // 
            // pictureBox_B
            // 
            this.pictureBox_B.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_B.Location = new System.Drawing.Point(857, 230);
            this.pictureBox_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_B.Name = "pictureBox_B";
            this.pictureBox_B.Size = new System.Drawing.Size(27, 31);
            this.pictureBox_B.TabIndex = 19;
            this.pictureBox_B.TabStop = false;
            this.pictureBox_B.Click += new System.EventHandler(this.pictureBox_B_Click);
            // 
            // pictureBox_C
            // 
            this.pictureBox_C.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_C.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_C.BackgroundImage")));
            this.pictureBox_C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_C.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_C.Location = new System.Drawing.Point(899, 230);
            this.pictureBox_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_C.Name = "pictureBox_C";
            this.pictureBox_C.Size = new System.Drawing.Size(55, 64);
            this.pictureBox_C.TabIndex = 20;
            this.pictureBox_C.TabStop = false;
            this.pictureBox_C.Click += new System.EventHandler(this.pictureBox_C_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(254, 213);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(157, 100);
            this.button1.TabIndex = 21;
            this.button1.Text = "Off";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(723, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 47);
            this.label1.TabIndex = 22;
            this.label1.Text = "Effets";
            // 
            // checkBox_multi
            // 
            this.checkBox_multi.AutoSize = true;
            this.checkBox_multi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_multi.ForeColor = System.Drawing.Color.White;
            this.checkBox_multi.Location = new System.Drawing.Point(580, 423);
            this.checkBox_multi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_multi.Name = "checkBox_multi";
            this.checkBox_multi.Size = new System.Drawing.Size(173, 36);
            this.checkBox_multi.TabIndex = 23;
            this.checkBox_multi.Text = "Multicolore";
            this.checkBox_multi.UseVisualStyleBackColor = true;
            this.checkBox_multi.Click += new System.EventHandler(this.checkBox_multi_Click);
            // 
            // checkBox_cligno
            // 
            this.checkBox_cligno.AutoSize = true;
            this.checkBox_cligno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_cligno.ForeColor = System.Drawing.Color.White;
            this.checkBox_cligno.Location = new System.Drawing.Point(803, 423);
            this.checkBox_cligno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_cligno.Name = "checkBox_cligno";
            this.checkBox_cligno.Size = new System.Drawing.Size(195, 36);
            this.checkBox_cligno.TabIndex = 24;
            this.checkBox_cligno.Text = "Clignotement";
            this.checkBox_cligno.UseVisualStyleBackColor = true;
            this.checkBox_cligno.Click += new System.EventHandler(this.checkBox_cligno_Click);
            // 
            // button_appliquer_effets
            // 
            this.button_appliquer_effets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.button_appliquer_effets.FlatAppearance.BorderSize = 0;
            this.button_appliquer_effets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_appliquer_effets.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_appliquer_effets.ForeColor = System.Drawing.Color.White;
            this.button_appliquer_effets.Location = new System.Drawing.Point(723, 473);
            this.button_appliquer_effets.Margin = new System.Windows.Forms.Padding(0);
            this.button_appliquer_effets.Name = "button_appliquer_effets";
            this.button_appliquer_effets.Size = new System.Drawing.Size(127, 63);
            this.button_appliquer_effets.TabIndex = 25;
            this.button_appliquer_effets.Text = "Appliquer";
            this.button_appliquer_effets.UseVisualStyleBackColor = false;
            this.button_appliquer_effets.Click += new System.EventHandler(this.button_appliquer_effets_Click);
            // 
            // textBox_etat_actuel
            // 
            this.textBox_etat_actuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.textBox_etat_actuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_etat_actuel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_etat_actuel.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox_etat_actuel.Location = new System.Drawing.Point(174, 152);
            this.textBox_etat_actuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_etat_actuel.MaxLength = 3;
            this.textBox_etat_actuel.Name = "textBox_etat_actuel";
            this.textBox_etat_actuel.ReadOnly = true;
            this.textBox_etat_actuel.Size = new System.Drawing.Size(59, 42);
            this.textBox_etat_actuel.TabIndex = 26;
            this.textBox_etat_actuel.Text = "X";
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.ForeColor = System.Drawing.Color.Salmon;
            this.label_warning.Location = new System.Drawing.Point(187, 22);
            this.label_warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(714, 25);
            this.label_warning.TabIndex = 27;
            this.label_warning.Text = "/!\\ La sélection globale des lampes n\'est pas compatible avec la visualisation de" +
    "s états /!\\";
            this.label_warning.Visible = false;
            // 
            // label_couleur_actuelle
            // 
            this.label_couleur_actuelle.AutoSize = true;
            this.label_couleur_actuelle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_couleur_actuelle.ForeColor = System.Drawing.Color.Snow;
            this.label_couleur_actuelle.Location = new System.Drawing.Point(570, 205);
            this.label_couleur_actuelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_couleur_actuelle.Name = "label_couleur_actuelle";
            this.label_couleur_actuelle.Size = new System.Drawing.Size(229, 28);
            this.label_couleur_actuelle.TabIndex = 28;
            this.label_couleur_actuelle.Text = "Couleur actuelle :";
            // 
            // pictureBox_couleur_actuelle
            // 
            this.pictureBox_couleur_actuelle.BackColor = System.Drawing.Color.White;
            this.pictureBox_couleur_actuelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_couleur_actuelle.Location = new System.Drawing.Point(646, 245);
            this.pictureBox_couleur_actuelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_couleur_actuelle.Name = "pictureBox_couleur_actuelle";
            this.pictureBox_couleur_actuelle.Size = new System.Drawing.Size(55, 47);
            this.pictureBox_couleur_actuelle.TabIndex = 29;
            this.pictureBox_couleur_actuelle.TabStop = false;
            // 
            // Form_HUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1041, 587);
            this.Controls.Add(this.pictureBox_couleur_actuelle);
            this.Controls.Add(this.label_couleur_actuelle);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.textBox_etat_actuel);
            this.Controls.Add(this.button_appliquer_effets);
            this.Controls.Add(this.checkBox_cligno);
            this.Controls.Add(this.checkBox_multi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_C);
            this.Controls.Add(this.pictureBox_B);
            this.Controls.Add(this.pictureBox_G);
            this.Controls.Add(this.pictureBox_R);
            this.Controls.Add(this.pictureBox_w);
            this.Controls.Add(this.button_lum);
            this.Controls.Add(this.label_lumi_pourcent);
            this.Controls.Add(this.label_couleur);
            this.Controls.Add(this.separateur);
            this.Controls.Add(this.label_lum);
            this.Controls.Add(this.label_etat);
            this.Controls.Add(this.trackBar_lum);
            this.Controls.Add(this.comboBox_lampes);
            this.Controls.Add(this.imageOn);
            this.Controls.Add(this.imageOff);
            this.Controls.Add(this.button_on);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_HUE";
            this.Text = "Form_HUE";
            this.Load += new System.EventHandler(this.Form_HUE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_lum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_couleur_actuelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox imageOff;
        private PictureBox imageOn;
        private Button button_on;
        private ComboBox comboBox_lampes;
        private TrackBar trackBar_lum;
        private Label label_etat;
        private Label label_lum;
        private PictureBox separateur;
        private Label label_couleur;
        private Label label_lumi_pourcent;
        private Button button_lum;
        private PictureBox pictureBox_w;
        private PictureBox pictureBox_R;
        private PictureBox pictureBox_G;
        private PictureBox pictureBox_B;
        private PictureBox pictureBox_C;
        private Button button1;
        private Label label1;
        private CheckBox checkBox_multi;
        private CheckBox checkBox_cligno;
        private Button button_appliquer_effets;
        private TextBox textBox_etat_actuel;
        private Label label_warning;
        private Label label_couleur_actuelle;
        private PictureBox pictureBox_couleur_actuelle;
    }
}