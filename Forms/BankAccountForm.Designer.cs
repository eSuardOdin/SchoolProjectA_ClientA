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
            mainMenuBtn = new Button();
            addTransactionBtn = new Button();
            transactionsList = new ListView();
            transacLabelCol = new ColumnHeader();
            transacDateCol = new ColumnHeader();
            transacAmountCol = new ColumnHeader();
            transacDetailCol = new ColumnHeader();
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
            // mainMenuBtn
            // 
            mainMenuBtn.Location = new Point(12, 12);
            mainMenuBtn.Name = "mainMenuBtn";
            mainMenuBtn.Size = new Size(75, 23);
            mainMenuBtn.TabIndex = 1;
            mainMenuBtn.Text = "Menu";
            mainMenuBtn.UseVisualStyleBackColor = true;
            mainMenuBtn.Click += mainMenuBtn_Click;
            // 
            // addTransactionBtn
            // 
            addTransactionBtn.Location = new Point(12, 63);
            addTransactionBtn.Name = "addTransactionBtn";
            addTransactionBtn.Size = new Size(89, 46);
            addTransactionBtn.TabIndex = 3;
            addTransactionBtn.Text = "Ajouter une transaction";
            addTransactionBtn.UseVisualStyleBackColor = true;
            // 
            // transactionsList
            // 
            transactionsList.Columns.AddRange(new ColumnHeader[] { transacLabelCol, transacDateCol, transacAmountCol, transacDetailCol });
            transactionsList.Location = new Point(107, 63);
            transactionsList.Name = "transactionsList";
            transactionsList.Size = new Size(650, 335);
            transactionsList.TabIndex = 4;
            transactionsList.UseCompatibleStateImageBehavior = false;
            transactionsList.View = View.Details;
            // 
            // transacLabelCol
            // 
            transacLabelCol.Text = "Transaction";
            transacLabelCol.Width = 100;
            // 
            // transacDateCol
            // 
            transacDateCol.Text = "Date";
            transacDateCol.TextAlign = HorizontalAlignment.Center;
            transacDateCol.Width = 100;
            // 
            // transacAmountCol
            // 
            transacAmountCol.Text = "Montant";
            transacAmountCol.TextAlign = HorizontalAlignment.Center;
            transacAmountCol.Width = 80;
            // 
            // transacDetailCol
            // 
            transacDetailCol.Text = "Détail";
            transacDetailCol.TextAlign = HorizontalAlignment.Center;
            // 
            // BankAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(transactionsList);
            Controls.Add(addTransactionBtn);
            Controls.Add(mainMenuBtn);
            Controls.Add(bankAccountNameLbl);
            MaximizeBox = false;
            Name = "BankAccountForm";
            Text = "Compte en banque";
            FormClosed += BankAccountForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bankAccountNameLbl;
        private Button mainMenuBtn;
        private Button addTransactionBtn;
        private ListView transactionsList;
        private ColumnHeader transacLabelCol;
        private ColumnHeader transacDateCol;
        private ColumnHeader transacAmountCol;
        private ColumnHeader transacDetailCol;
    }
}