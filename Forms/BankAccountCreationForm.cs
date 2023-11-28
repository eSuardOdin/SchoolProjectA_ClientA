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
    public partial class BankAccountCreationForm : Form
    {
        private MainForm MyMainForm {  get; set; }
        public BankAccountCreationForm(MainForm myMainForm)
        {
            InitializeComponent();
            MyMainForm = myMainForm;
            MyMainForm.Enabled = false;
        }



        private void BankAccountCreationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyMainForm.Enabled = true;
            Dispose();
        }
    }
}
