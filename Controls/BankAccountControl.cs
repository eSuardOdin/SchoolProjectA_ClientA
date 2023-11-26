using SchoolProjectA_ClientA.Classes;
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
    }
}
