namespace background_worker
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
            this.InitBtn = new System.Windows.Forms.Button();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.listValeursNonTriees = new System.Windows.Forms.ListBox();
            this.btnTri = new System.Windows.Forms.Button();
            this.listValeursTriees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // InitBtn
            // 
            this.InitBtn.Location = new System.Drawing.Point(292, 50);
            this.InitBtn.Name = "InitBtn";
            this.InitBtn.Size = new System.Drawing.Size(75, 23);
            this.InitBtn.TabIndex = 0;
            this.InitBtn.Text = "Initialiser";
            this.InitBtn.UseVisualStyleBackColor = true;
            this.InitBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(574, 12);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(100, 20);
            this.txtTaille.TabIndex = 1;
            // 
            // listValeursNonTriees
            // 
            this.listValeursNonTriees.FormattingEnabled = true;
            this.listValeursNonTriees.Location = new System.Drawing.Point(79, 74);
            this.listValeursNonTriees.Name = "listValeursNonTriees";
            this.listValeursNonTriees.Size = new System.Drawing.Size(120, 95);
            this.listValeursNonTriees.TabIndex = 2;
            // 
            // btnTri
            // 
            this.btnTri.Location = new System.Drawing.Point(292, 101);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(75, 23);
            this.btnTri.TabIndex = 3;
            this.btnTri.Text = "Trier";
            this.btnTri.UseVisualStyleBackColor = true;
            this.btnTri.Click += new System.EventHandler(this.btnTri_Click);
            // 
            // listValeursTriees
            // 
            this.listValeursTriees.FormattingEnabled = true;
            this.listValeursTriees.Location = new System.Drawing.Point(458, 74);
            this.listValeursTriees.Name = "listValeursTriees";
            this.listValeursTriees.Size = new System.Drawing.Size(120, 95);
            this.listValeursTriees.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 261);
            this.Controls.Add(this.listValeursTriees);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.listValeursNonTriees);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.InitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InitBtn;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.ListBox listValeursNonTriees;
        private System.Windows.Forms.Button btnTri;
        private System.Windows.Forms.ListBox listValeursTriees;
    }
}

