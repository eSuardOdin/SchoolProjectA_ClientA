namespace SchoolProjectA_ClientA.Forms
{
    partial class BankAccountCreationForm
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
            accountLabelTBox = new TextBox();
            accountBalanceTBox = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            createAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)accountBalanceTBox).BeginInit();
            SuspendLayout();
            // 
            // accountLabelTBox
            // 
            accountLabelTBox.Location = new Point(121, 30);
            accountLabelTBox.MaxLength = 128;
            accountLabelTBox.Name = "accountLabelTBox";
            accountLabelTBox.Size = new Size(240, 23);
            accountLabelTBox.TabIndex = 0;
            // 
            // accountBalanceTBox
            // 
            accountBalanceTBox.DecimalPlaces = 2;
            accountBalanceTBox.Location = new Point(121, 85);
            accountBalanceTBox.Name = "accountBalanceTBox";
            accountBalanceTBox.Size = new Size(120, 23);
            accountBalanceTBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Nom du compte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Montant initial";
            // 
            // createAccountBtn
            // 
            createAccountBtn.Location = new Point(286, 87);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(75, 23);
            createAccountBtn.TabIndex = 4;
            createAccountBtn.Text = "Créer";
            createAccountBtn.UseVisualStyleBackColor = true;
            // 
            // BankAccountCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 129);
            Controls.Add(createAccountBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(accountBalanceTBox);
            Controls.Add(accountLabelTBox);
            MaximizeBox = false;
            Name = "BankAccountCreationForm";
            Text = "Création d'un compte";
            FormClosed += BankAccountCreationForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)accountBalanceTBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox accountLabelTBox;
        private NumericUpDown accountBalanceTBox;
        private Label label1;
        private Label label2;
        private Button createAccountBtn;
    }
}