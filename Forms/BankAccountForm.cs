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

namespace SchoolProjectA_ClientA.Forms
{
    public partial class BankAccountForm : Form
    {
        private MainForm MyMainForm { get; set; }
        private BankAccount MyBankAccount { get; set; }
        public BankAccountForm(MainForm myMainForm, BankAccount myBankAccount)
        {
            InitializeComponent();
            MyMainForm = myMainForm;
            MyBankAccount = myBankAccount;
            bankAccountNameLbl.Text = MyBankAccount.BankAccountLabel;
            // Headers liste
            /*
            transactionsList.Columns.Add("Transaction", 100);
            transactionsList.Columns.Add("Date", 150);
            transactionsList.Columns.Add("Montant", 100);
            transactionsList.Columns.Add("Detail", 100);
            */

        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            if (MyMainForm != null && !MyMainForm.Visible)
            {
                MyMainForm.Show();
                Dispose();
            }
        }

        private void BankAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyMainForm != null) MyMainForm.Dispose();
        }
    }
}
