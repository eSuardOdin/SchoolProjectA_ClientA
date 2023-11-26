namespace SchoolProjectA_ClientA.Forms
{
    partial class MainForm
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
            loginLbl = new Label();
            disconnectBtn = new Button();
            bankAccountContainer = new FlowLayoutPanel();
            createAccountBtn = new Button();
            SuspendLayout();
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.Location = new Point(35, 28);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(38, 15);
            loginLbl.TabIndex = 0;
            loginLbl.Text = "label1";
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(713, 24);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(75, 23);
            disconnectBtn.TabIndex = 1;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // bankAccountContainer
            // 
            bankAccountContainer.AutoScroll = true;
            bankAccountContainer.BackColor = SystemColors.ControlLight;
            bankAccountContainer.BorderStyle = BorderStyle.Fixed3D;
            bankAccountContainer.FlowDirection = FlowDirection.TopDown;
            bankAccountContainer.Location = new Point(165, 81);
            bankAccountContainer.Name = "bankAccountContainer";
            bankAccountContainer.Padding = new Padding(2);
            bankAccountContainer.Size = new Size(460, 340);
            bankAccountContainer.TabIndex = 2;
            bankAccountContainer.WrapContents = false;
            // 
            // createAccountBtn
            // 
            createAccountBtn.Location = new Point(12, 81);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(111, 40);
            createAccountBtn.TabIndex = 3;
            createAccountBtn.Text = "Créer un compte en banque";
            createAccountBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createAccountBtn);
            Controls.Add(bankAccountContainer);
            Controls.Add(disconnectBtn);
            Controls.Add(loginLbl);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += ConnexionForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLbl;
        private Button disconnectBtn;
        private FlowLayoutPanel bankAccountContainer;
        private Button createAccountBtn;
    }
}