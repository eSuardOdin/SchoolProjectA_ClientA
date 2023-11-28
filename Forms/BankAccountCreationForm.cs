using SchoolProjectA_ClientA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolProjectA_ClientA.Forms
{
    public partial class BankAccountCreationForm : Form
    {
        private MainForm MyMainForm { get; set; }
        private int MyMoniId { get; set; }
        public BankAccountCreationForm(MainForm myMainForm, int myMoniId)
        {
            InitializeComponent();
            MyMoniId = myMoniId;
            MyMainForm = myMainForm;
            MyMainForm.Enabled = false;
        }



        private void BankAccountCreationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyMainForm.Enabled = true;
            Dispose();
        }

        private async void createAccountBtn_Click(object sender, EventArgs e)
        {
            accountLabelTBox.BackColor = Color.White;
            string error = "";
            // Check du label
            Regex regex = new(@"^[a-zA-Z0-9\s]+$");

            // Check caractères
            if (!regex.IsMatch(accountLabelTBox.Text))
            {
                error += "Le libellé du compte ne peut contenir que des caractères alphanumériques\n";
                accountLabelTBox.BackColor = Color.Red;
            }
            else if(accountLabelTBox.Text.Trim() == "")
            {
                error += "Le libellé du compte ne peut être vide\n";
                accountLabelTBox.BackColor = Color.Red;
            }
            // Round du solde
            decimal rounded = Math.Round(accountBalanceTBox.Value,2);
            //MessageBox.Show(accountBalanceTBox.Value.ToString() + " de type : " + accountBalanceTBox.Value.GetType() +"\nArrondi : " + rounded.ToString());

            if(error == "")
            {
                // Création de l'account
                BankAccount account = new BankAccount();
                account.BankAccountLabel = accountLabelTBox.Text;
                account.BankAccountBalance = rounded;
                account.MoniId = MyMoniId;

                // POST
                BankAccount res = await Queries.PostAccount(account);
                if(res != null)
                {
                    MessageBox.Show($"Le compte {res.BankAccountLabel} a été créé avec succès", "Création effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyMainForm.PopulateForm();
                    MyMainForm.Enabled = true;
                    Dispose();
                }
                else
                {
                    MessageBox.Show($"Le compte {account.BankAccountLabel} n'a pas pu être créé", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(error, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
