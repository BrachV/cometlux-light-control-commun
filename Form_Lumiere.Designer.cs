namespace CometLux_Solution_ESP32
{
    partial class Form_Lumiere
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lumiere));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelLumiere = new System.Windows.Forms.Label();
            this.labelScenario = new System.Windows.Forms.Label();
            this.buttonHUE = new System.Windows.Forms.Button();
            this.buttonProjecteurX = new System.Windows.Forms.Button();
            this.buttonProjecteurW = new System.Windows.Forms.Button();
            this.imgHUE = new System.Windows.Forms.PictureBox();
            this.imgProjecteurW = new System.Windows.Forms.PictureBox();
            this.imgProjecteurX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProjecteurW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProjecteurX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(502, 42);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(77, 29);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // labelLumiere
            // 
            this.labelLumiere.AutoSize = true;
            this.labelLumiere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLumiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelLumiere.ForeColor = System.Drawing.Color.White;
            this.labelLumiere.Location = new System.Drawing.Point(634, 42);
            this.labelLumiere.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLumiere.Name = "labelLumiere";
            this.labelLumiere.Size = new System.Drawing.Size(108, 29);
            this.labelLumiere.TabIndex = 2;
            this.labelLumiere.Text = "Lumière";
            // 
            // labelScenario
            // 
            this.labelScenario.AutoSize = true;
            this.labelScenario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelScenario.ForeColor = System.Drawing.Color.White;
            this.labelScenario.Location = new System.Drawing.Point(778, 42);
            this.labelScenario.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelScenario.Name = "labelScenario";
            this.labelScenario.Size = new System.Drawing.Size(117, 29);
            this.labelScenario.TabIndex = 3;
            this.labelScenario.Text = "Scénario";
            this.labelScenario.Click += new System.EventHandler(this.labelScenario_Click);
            // 
            // buttonHUE
            // 
            this.buttonHUE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.buttonHUE.FlatAppearance.BorderSize = 3;
            this.buttonHUE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHUE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHUE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHUE.ForeColor = System.Drawing.Color.White;
            this.buttonHUE.Location = new System.Drawing.Point(85, 113);
            this.buttonHUE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHUE.Name = "buttonHUE";
            this.buttonHUE.Size = new System.Drawing.Size(252, 75);
            this.buttonHUE.TabIndex = 4;
            this.buttonHUE.Text = "         HUE";
            this.buttonHUE.UseVisualStyleBackColor = true;
            this.buttonHUE.Click += new System.EventHandler(this.buttonHUE_Click);
            // 
            // buttonProjecteurX
            // 
            this.buttonProjecteurX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.buttonProjecteurX.FlatAppearance.BorderSize = 3;
            this.buttonProjecteurX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonProjecteurX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjecteurX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProjecteurX.ForeColor = System.Drawing.Color.White;
            this.buttonProjecteurX.Location = new System.Drawing.Point(674, 113);
            this.buttonProjecteurX.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProjecteurX.Name = "buttonProjecteurX";
            this.buttonProjecteurX.Size = new System.Drawing.Size(252, 75);
            this.buttonProjecteurX.TabIndex = 5;
            this.buttonProjecteurX.Text = "                 Projecteur                     piloté x        ";
            this.buttonProjecteurX.UseVisualStyleBackColor = true;
            this.buttonProjecteurX.Click += new System.EventHandler(this.buttonProjecteurX_Click);
            // 
            // buttonProjecteurW
            // 
            this.buttonProjecteurW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.buttonProjecteurW.FlatAppearance.BorderSize = 3;
            this.buttonProjecteurW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonProjecteurW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjecteurW.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProjecteurW.ForeColor = System.Drawing.Color.White;
            this.buttonProjecteurW.Location = new System.Drawing.Point(379, 113);
            this.buttonProjecteurW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProjecteurW.Name = "buttonProjecteurW";
            this.buttonProjecteurW.Size = new System.Drawing.Size(252, 75);
            this.buttonProjecteurW.TabIndex = 6;
            this.buttonProjecteurW.Text = "                    Projecteur                      piloté W        ";
            this.buttonProjecteurW.UseVisualStyleBackColor = true;
            this.buttonProjecteurW.Click += new System.EventHandler(this.buttonProjecteurW_Click);
            // 
            // imgHUE
            // 
            this.imgHUE.BackColor = System.Drawing.Color.Transparent;
            this.imgHUE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgHUE.BackgroundImage")));
            this.imgHUE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHUE.Location = new System.Drawing.Point(95, 116);
            this.imgHUE.Margin = new System.Windows.Forms.Padding(2);
            this.imgHUE.Name = "imgHUE";
            this.imgHUE.Size = new System.Drawing.Size(80, 67);
            this.imgHUE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHUE.TabIndex = 8;
            this.imgHUE.TabStop = false;
            // 
            // imgProjecteurW
            // 
            this.imgProjecteurW.BackColor = System.Drawing.Color.Transparent;
            this.imgProjecteurW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgProjecteurW.BackgroundImage")));
            this.imgProjecteurW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgProjecteurW.Location = new System.Drawing.Point(388, 116);
            this.imgProjecteurW.Margin = new System.Windows.Forms.Padding(2);
            this.imgProjecteurW.Name = "imgProjecteurW";
            this.imgProjecteurW.Size = new System.Drawing.Size(80, 67);
            this.imgProjecteurW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProjecteurW.TabIndex = 9;
            this.imgProjecteurW.TabStop = false;
            // 
            // imgProjecteurX
            // 
            this.imgProjecteurX.BackColor = System.Drawing.Color.Transparent;
            this.imgProjecteurX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgProjecteurX.BackgroundImage")));
            this.imgProjecteurX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgProjecteurX.Location = new System.Drawing.Point(685, 116);
            this.imgProjecteurX.Margin = new System.Windows.Forms.Padding(2);
            this.imgProjecteurX.Name = "imgProjecteurX";
            this.imgProjecteurX.Size = new System.Drawing.Size(80, 67);
            this.imgProjecteurX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProjecteurX.TabIndex = 10;
            this.imgProjecteurX.TabStop = false;
            // 
            // Form_Lumiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.imgProjecteurX);
            this.Controls.Add(this.imgProjecteurW);
            this.Controls.Add(this.imgHUE);
            this.Controls.Add(this.buttonProjecteurW);
            this.Controls.Add(this.buttonProjecteurX);
            this.Controls.Add(this.buttonHUE);
            this.Controls.Add(this.labelScenario);
            this.Controls.Add(this.labelLumiere);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Lumiere";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application CometLux";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProjecteurW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProjecteurX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelMenu;
        private Label labelLumiere;
        private Label labelScenario;
        private Button buttonHUE;
        private Button buttonProjecteurX;
        private Button buttonProjecteurW;
        private PictureBox imgHUE;
        private PictureBox imgProjecteurW;
        private PictureBox imgProjecteurX;
    }
}