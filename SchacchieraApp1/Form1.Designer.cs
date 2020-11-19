namespace SchacchieraApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.scacchieraControl1 = new SchacchieraApp1.ScacchieraControl();
            this.SuspendLayout();
            // 
            // scacchieraControl1
            // 
            this.scacchieraControl1.Lato = 46;
            this.scacchieraControl1.Location = new System.Drawing.Point(205, 41);
            this.scacchieraControl1.Name = "scacchieraControl1";
            this.scacchieraControl1.Size = new System.Drawing.Size(370, 369);
            this.scacchieraControl1.TabIndex = 0;
            this.scacchieraControl1.Text = "scacchieraControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scacchieraControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ScacchieraControl scacchieraControl1;
    }
}

