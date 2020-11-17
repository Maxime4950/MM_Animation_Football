namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TV = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).BeginInit();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.BackColor = System.Drawing.Color.SkyBlue;
            this.TV.Location = new System.Drawing.Point(70, 38);
            this.TV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(944, 354);
            this.TV.TabIndex = 0;
            this.TV.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(944, 115);
            this.button1.TabIndex = 33;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TV;
        private System.Windows.Forms.Button button1;
    }
}

