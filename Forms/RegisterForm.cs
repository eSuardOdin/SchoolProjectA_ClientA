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
using SchoolProjectA_ClientA.Classes;

namespace SchoolProjectA_ClientA.Forms
{
    public partial class RegisterForm : Form
    {
        private ConnexionForm MyConnexionForm { get; set; }
        public RegisterForm(ConnexionForm myConnexionForm)
        {
            InitializeComponent();
            MyConnexionForm = myConnexionForm;
            ActiveControl = null;
        }


        private async Task<string> CheckInput()
        {
            validateBtn.Enabled = false;
            // Reset des couleurs
            loginTBox.BackColor = Color.White;
            pwd1TBox.BackColor = Color.White;
            pwd2TBox.BackColor = Color.White;
            lnameTBox.BackColor = Color.White;
            fnameTBox.BackColor = Color.White;
            errorLbl.Visible = false;

            string error = "";
            Regex regex = new("^[a-zA-Z0-9]+$");

            // Check caractères
            if (!regex.IsMatch(loginTBox.Text))
            {
                error += "Les pseudos ne peuvent contenir que des caractères alphanumériques\n";
                loginTBox.BackColor = Color.Red;
            }
            if (!regex.IsMatch(fnameTBox.Text))
            {
                error += "Le prénom ne peut contenir que des caractères alphanumériques\n";
                fnameTBox.BackColor = Color.Red;
            }
            if (!regex.IsMatch(lnameTBox.Text))
            {
                error += "Le nom ne peut contenir que des caractères alphanumériques\n";
                lnameTBox.BackColor = Color.Red;
            }

            // Check vide
            if (loginTBox.Text == "")
            {
                error += "Champ login vide\n";
                loginTBox.BackColor = Color.Red;
            }
            else
            {
                Moni? moni = await Queries.GetMoni(loginTBox.Text);
                if (moni != null)
                {
                    error += "Erreur login\n";
                    errorLbl.Text = "Ce login existe déjà\n";
                    errorLbl.Visible = true;
                    loginTBox.BackColor = Color.Red;
                }
            }
            if (pwd1TBox.Text == "")
            {
                error += "Champ password vide\n";
                pwd1TBox.BackColor = Color.Red;
            }
            if (pwd2TBox.Text == "")
            {
                error += "Champ validation password vide\n";
                pwd2TBox.BackColor = Color.Red;
            }
            if (lnameTBox.Text == "")
            {
                error += "Champ nom vide\n";
                lnameTBox.BackColor = Color.Red;
            }
            if (fnameTBox.Text == "")
            {
                error += "Champ prénom vide\n";
                fnameTBox.BackColor = Color.Red;
            }

            if (pwd1TBox.Text.Length < 8 && pwd1TBox.Text.Length != 0)
            {
                error += "Le mot de passe doit contenir au moins 8 caractères\n";
                pwd1TBox.BackColor = Color.Red;
            }
            else if (pwd1TBox.Text != pwd2TBox.Text)
            {
                error += "Les mots de passe ne correspondent pas\n";
                pwd1TBox.BackColor = Color.Red;
                pwd2TBox.BackColor = Color.Red;
            }

            if (error != "") validateBtn.Enabled = true;
            return error;
        }



        private async void validateBtn_Click(object sender, EventArgs e)
        {
            string err = await CheckInput();
            if (err != "")
            {
                MessageBox.Show(err, "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Moni? targetMoni = null;
                Moni moni = new() { MoniLogin = loginTBox.Text, MoniPwd = pwd1TBox.Text, FirstName = fnameTBox.Text, LastName = lnameTBox.Text };
                targetMoni = await Queries.PostMoni(moni);

                if (targetMoni != null)
                {
                    MessageBox.Show("Merci d'avoir créé votre Moni");
                    MainForm main = new(targetMoni, MyConnexionForm);
                    main.Show();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Le moni n'a pas pu être créé, merci de vérifier votre connexion à l'API MoniWatch.", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyConnexionForm != null && !MyConnexionForm.Visible)
            {
                MyConnexionForm.Show();
                Dispose();
            }
        }
    }
}
