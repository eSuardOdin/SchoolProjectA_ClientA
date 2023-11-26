namespace SchoolProjectA_ClientA.Controls
{
    partial class BankAccountControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            accountNameLbl = new Label();
            manageBtn = new Button();
            label1 = new Label();
            balanceLbl = new Label();
            SuspendLayout();
            // 
            // accountNameLbl
            // 
            accountNameLbl.AutoSize = true;
            accountNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            accountNameLbl.Location = new Point(196, 12);
            accountNameLbl.Name = "accountNameLbl";
            accountNameLbl.Size = new Size(40, 15);
            accountNameLbl.TabIndex = 0;
            accountNameLbl.Text = "label1";
            // 
            // manageBtn
            // 
            manageBtn.Location = new Point(321, 54);
            manageBtn.Name = "manageBtn";
            manageBtn.Size = new Size(75, 23);
            manageBtn.TabIndex = 1;
            manageBtn.Text = "Voir";
            manageBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 54);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Solde : ";
            // 
            // balanceLbl
            // 
            balanceLbl.AutoSize = true;
            balanceLbl.Location = new Point(64, 54);
            balanceLbl.Name = "balanceLbl";
            balanceLbl.Size = new Size(38, 15);
            balanceLbl.TabIndex = 3;
            balanceLbl.Text = "label2";
            // 
            // BankAccountControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(balanceLbl);
            Controls.Add(label1);
            Controls.Add(manageBtn);
            Controls.Add(accountNameLbl);
            Name = "BankAccountControl";
            Size = new Size(424, 98);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label accountNameLbl;
        private Button manageBtn;
        private Label label1;
        private Label balanceLbl;
    }
}
