using SchoolProjectA_ClientA.Classes;
using SchoolProjectA_ClientA.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace SchoolProjectA_ClientA
{
    public partial class ConnexionForm : Form
    {
        private Moni? MyMoni { get; set; }
        public ConnexionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérification des champs d'input
        /// </summary>
        /// <returns>Une chaîne d'erreurs ou une chaine vide si ok</returns>
        private string CheckInput()
        {
            string error = "";
            if (loginTBox.Text.Trim() == "") error += "Le champ de login est vide\n";
            if (pwdTBox.Text.Trim() == "") error += "Le champ de password est vide\n";
            return error;
        }


        /// <summary>
        /// Clic on connect button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void connectBtn_Click(object sender, EventArgs e)
        {
            connectBtn.Enabled = false;
            string error = CheckInput();
            // Si mauvaise saisie
            if (error != "")
            {
                MessageBox.Show(error, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectBtn.Enabled = true;
                return;
            }
            // On récupère le Moni correspondant au pseudo (mauvaise pratique car je n'ai pas prévu de tri par pseudo dans l'api)
            MyMoni = await Queries.GetMoni(loginTBox.Text);
            if (MyMoni == null)
            {
                MessageBox.Show("L'identifiant et le mot de passe saisis ne correspondent pas", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // On check le pwd
            else
            {
                MyMoni = await Queries.CheckMoni(MyMoni, pwdTBox.Text);
                if (MyMoni == null)
                {
                    MessageBox.Show("L'identifiant et le mot de passe saisis ne correspondent pas", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Connexion réussie
                else
                {
                    MainForm main = new(MyMoni, this);
                    main.StartPosition = FormStartPosition.Manual;
                    main.Location = this.PointToScreen(Point.Empty);

                    // Reset du moni et des champs d'input
                    MyMoni = null;
                    pwdTBox.Text = "";
                    loginTBox.Text = "";
                    main.Show();
                    this.Hide();
                }
            }
            connectBtn.Enabled = true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new(this);
            reg.Show();
            Hide();
        }
    }
}