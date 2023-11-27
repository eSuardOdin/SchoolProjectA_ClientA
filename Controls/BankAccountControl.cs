using SchoolProjectA_ClientA.Classes;
using SchoolProjectA_ClientA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProjectA_ClientA.Controls
{
    public partial class BankAccountControl : UserControl
    {
        private BankAccount MyBankAccount { get; set; }
        public BankAccountControl(BankAccount myBa)
        {
            InitializeComponent();
            MyBankAccount = myBa;
            balanceLbl.Text = MyBankAccount.BankAccountBalance.ToString() + "€";
            balanceLbl.ForeColor = MyBankAccount.BankAccountBalance > 0 ? Color.Green : Color.Red;
            accountNameLbl.Text = MyBankAccount.BankAccountLabel;
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            BankAccountForm baForm = new((MainForm)ParentForm, MyBankAccount);
            baForm.Show();
            ParentForm.Hide();
        }
    }
}
