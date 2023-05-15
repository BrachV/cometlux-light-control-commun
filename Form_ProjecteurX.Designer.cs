namespace CometLux_Solution_ESP32
{
    partial class Form_ProjecteurX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ProjecteurX));
            this.track_puissanceEclairage = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageOff = new System.Windows.Forms.PictureBox();
            this.imageOn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.track_puissanceEclairage)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // track_puissanceEclairage
            // 
            this.track_puissanceEclairage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.track_puissanceEclairage.Location = new System.Drawing.Point(178, 255);
            this.track_puissanceEclairage.Name = "track_puissanceEclairage";
            this.track_puissanceEclairage.Size = new System.Drawing.Size(188, 69);
            this.track_puissanceEclairage.TabIndex = 0;
            this.track_puissanceEclairage.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puissance éclairage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Projecteur piloté X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupInfo
            // 
            this.groupInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupInfo.Controls.Add(this.label4);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupInfo.ForeColor = System.Drawing.Color.Yellow;
            this.groupInfo.Location = new System.Drawing.Point(576, 196);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(438, 289);
            this.groupInfo.TabIndex = 3;
            this.groupInfo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 70);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ce projeteur est concerné \npar 4 scénarios dont 2 actifs. ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Informations";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(79, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 118);
            this.button1.TabIndex = 4;
            this.button1.Text = "Allumer         ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageOff
            // 
            this.imageOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageOff.BackgroundImage")));
            this.imageOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageOff.Location = new System.Drawing.Point(60, 224);
            this.imageOff.Name = "imageOff";
            this.imageOff.Size = new System.Drawing.Size(100, 100);
            this.imageOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOff.TabIndex = 5;
            this.imageOff.TabStop = false;
            this.imageOff.Click += new System.EventHandler(this.imageOff_Click);
            // 
            // imageOn
            // 
            this.imageOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageOn.BackgroundImage")));
            this.imageOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageOn.Location = new System.Drawing.Point(383, 224);
            this.imageOn.Name = "imageOn";
            this.imageOn.Size = new System.Drawing.Size(100, 100);
            this.imageOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOn.TabIndex = 6;
            this.imageOn.TabStop = false;
            this.imageOn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(329, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ProjecteurX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1042, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageOn);
            this.Controls.Add(this.imageOff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_puissanceEclairage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ProjecteurX";
            this.Text = "Form_ProjecteurX";
            ((System.ComponentModel.ISupportInitialize)(this.track_puissanceEclairage)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar track_puissanceEclairage;
        private Label label1;
        private Label label2;
        private GroupBox groupInfo;
        private Button button1;
        private PictureBox imageOff;
        private PictureBox imageOn;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}