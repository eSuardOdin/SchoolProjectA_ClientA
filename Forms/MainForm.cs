using SchoolProjectA_ClientA.Classes;
using SchoolProjectA_ClientA.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProjectA_ClientA.Forms
{
    /// <summary>
    /// Classe gérant le formulaire principal.
    /// À noter que la classe ne contient pas de List BankAccount, je préfère envoyer des requètes que de garder
    /// en mémoire un nombre d'info potentiellement trop élevé.
    /// </summary>
    public partial class MainForm : Form
    {
        private Moni MyMoni { get; set; }
        private ConnexionForm MyConnexionForm { get; set; }
        public MainForm(Moni myMoni, ConnexionForm myConnexionForm)
        {
            InitializeComponent();
            MyMoni = myMoni;
            MyConnexionForm = myConnexionForm;
            this.Text = $"MoniWatch - {MyMoni.MoniLogin}";
            loginLbl.Text = $"Utilisateur : {MyMoni.LastName} {MyMoni.FirstName}";
            PopulateForm();
        }


        /// <summary>
        /// Ajout des controls de compte en banque
        /// </summary>
        private async void PopulateForm()
        {
            List<BankAccount> accounts = await Queries.GetMoniAccounts(MyMoni.MoniId);
            if (accounts != null)
            {
                foreach (BankAccount account in accounts)
                {
                    BankAccountControl ctrl = new(account);
                    ctrl.Tag = account;
                    ctrl.BackColor = SystemColors.ControlLightLight;
                    bankAccountContainer.Controls.Add(ctrl);
                }
            }
        }


        /// <summary>
        /// Disconnect user and go back to connexion form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (MyConnexionForm != null && !MyConnexionForm.Visible)
            {
                MyConnexionForm.Show();
            }
            this.Dispose();
        }


        /// <summary>
        /// Quit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnexionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyConnexionForm != null) MyConnexionForm.Dispose();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            BankAccountCreationForm creationForm = new(this, MyMoni.MoniId);
            creationForm.Show();
        }
    }
}
