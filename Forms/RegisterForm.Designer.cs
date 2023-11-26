namespace SchoolProjectA_ClientA.Forms
{
    partial class RegisterForm
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
            loginTBox = new TextBox();
            pwd1TBox = new TextBox();
            pwd2TBox = new TextBox();
            lnameTBox = new TextBox();
            fnameTBox = new TextBox();
            validateBtn = new Button();
            label1 = new Label();
            errorLbl = new Label();
            SuspendLayout();
            // 
            // loginTBox
            // 
            loginTBox.Location = new Point(63, 61);
            loginTBox.MaxLength = 32;
            loginTBox.Name = "loginTBox";
            loginTBox.PlaceholderText = "Login";
            loginTBox.Size = new Size(193, 23);
            loginTBox.TabIndex = 0;
            // 
            // pwd1TBox
            // 
            pwd1TBox.Location = new Point(63, 117);
            pwd1TBox.MaxLength = 64;
            pwd1TBox.Name = "pwd1TBox";
            pwd1TBox.PlaceholderText = "Mot de passe";
            pwd1TBox.Size = new Size(193, 23);
            pwd1TBox.TabIndex = 1;
            pwd1TBox.UseSystemPasswordChar = true;
            // 
            // pwd2TBox
            // 
            pwd2TBox.Location = new Point(63, 171);
            pwd2TBox.MaxLength = 64;
            pwd2TBox.Name = "pwd2TBox";
            pwd2TBox.PlaceholderText = "Confirmation du mot de passe";
            pwd2TBox.Size = new Size(193, 23);
            pwd2TBox.TabIndex = 2;
            pwd2TBox.UseSystemPasswordChar = true;
            // 
            // lnameTBox
            // 
            lnameTBox.Location = new Point(63, 224);
            lnameTBox.MaxLength = 32;
            lnameTBox.Name = "lnameTBox";
            lnameTBox.PlaceholderText = "Nom";
            lnameTBox.Size = new Size(193, 23);
            lnameTBox.TabIndex = 3;
            // 
            // fnameTBox
            // 
            fnameTBox.Location = new Point(63, 274);
            fnameTBox.MaxLength = 32;
            fnameTBox.Name = "fnameTBox";
            fnameTBox.PlaceholderText = "Prénom";
            fnameTBox.Size = new Size(193, 23);
            fnameTBox.TabIndex = 4;
            // 
            // validateBtn
            // 
            validateBtn.Location = new Point(123, 339);
            validateBtn.Name = "validateBtn";
            validateBtn.Size = new Size(75, 23);
            validateBtn.TabIndex = 5;
            validateBtn.Text = "Créer";
            validateBtn.UseVisualStyleBackColor = true;
            validateBtn.Click += validateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 21);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 6;
            label1.Text = "Formulaire d'inscription";
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.ForeColor = Color.FromArgb(192, 0, 0);
            errorLbl.Location = new Point(68, 91);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(48, 15);
            errorLbl.TabIndex = 7;
            errorLbl.Text = "errorLbl";
            errorLbl.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 390);
            Controls.Add(errorLbl);
            Controls.Add(label1);
            Controls.Add(validateBtn);
            Controls.Add(fnameTBox);
            Controls.Add(lnameTBox);
            Controls.Add(pwd2TBox);
            Controls.Add(pwd1TBox);
            Controls.Add(loginTBox);
            MaximizeBox = false;
            Name = "RegisterForm";
            Text = "Création du Moni";
            FormClosed += RegisterForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTBox;
        private TextBox pwd1TBox;
        private TextBox pwd2TBox;
        private TextBox lnameTBox;
        private TextBox fnameTBox;
        private Button validateBtn;
        private Label label1;
        private Label errorLbl;
    }
}