using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Register_Form : Form
    {
        Register_Form registForm;
        public Register_Form()
        {
            InitializeComponent();
            registForm = this;
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            var regist = new Register(ID_TextBox.Text, PW_TextBox.Text, Name_TextBox.Text, Age_TextBox.Text, HP_TextBox.Text);
        }

        private void Register_Cancel_Button_Click(object sender, EventArgs e) => registForm.Close();



    }
}
