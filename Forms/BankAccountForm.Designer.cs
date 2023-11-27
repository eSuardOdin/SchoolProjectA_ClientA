namespace SchoolProjectA_ClientA.Forms
{
    partial class BankAccountForm
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
            bankAccountNameLbl = new Label();
            SuspendLayout();
            // 
            // bankAccountNameLbl
            // 
            bankAccountNameLbl.AutoSize = true;
            bankAccountNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bankAccountNameLbl.Location = new Point(343, 23);
            bankAccountNameLbl.Name = "bankAccountNameLbl";
            bankAccountNameLbl.Size = new Size(40, 15);
            bankAccountNameLbl.TabIndex = 0;
            bankAccountNameLbl.Text = "label1";
            // 
            // BankAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bankAccountNameLbl);
            MaximizeBox = false;
            Name = "BankAccountForm";
            Text = "Compte en banque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bankAccountNameLbl;
    }
}