namespace CometLux_Solution_ESP32
{
    partial class Form_Scen_Existant
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
            this.label_Index = new System.Windows.Forms.Label();
            this.label_Titre = new System.Windows.Forms.Label();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Index
            // 
            this.label_Index.AutoSize = true;
            this.label_Index.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Index.Location = new System.Drawing.Point(-8, 4);
            this.label_Index.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Index.Name = "label_Index";
            this.label_Index.Size = new System.Drawing.Size(164, 128);
            this.label_Index.TabIndex = 0;
            this.label_Index.Text = "99";
            // 
            // label_Titre
            // 
            this.label_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Titre.Location = new System.Drawing.Point(11, 4);
            this.label_Titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Titre.Name = "label_Titre";
            this.label_Titre.Size = new System.Drawing.Size(262, 33);
            this.label_Titre.TabIndex = 1;
            this.label_Titre.Text = "\"Titre\"";
            this.label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Modifier
            // 
            this.button_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(133)))), ((int)(((byte)(53)))));
            this.button_Modifier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Modifier.FlatAppearance.BorderSize = 4;
            this.button_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Modifier.Location = new System.Drawing.Point(137, 42);
            this.button_Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(136, 33);
            this.button_Modifier.TabIndex = 2;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = false;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(133)))), ((int)(((byte)(53)))));
            this.button_Supprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Supprimer.FlatAppearance.BorderSize = 4;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Supprimer.Location = new System.Drawing.Point(137, 79);
            this.button_Supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(136, 33);
            this.button_Supprimer.TabIndex = 3;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = false;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // Form_Scen_Existant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.label_Titre);
            this.Controls.Add(this.label_Index);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Scen_Existant";
            this.Text = "Page Scénario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Index;
        private Label label_Titre;
        private Button button_Modifier;
        private Button button_Supprimer;
    }
}