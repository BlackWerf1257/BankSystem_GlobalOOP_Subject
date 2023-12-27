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
    public partial class Wiring_Form : Form
    {
        public Wiring_Form(string ID)
        {
            InitializeComponent();
            MessageBox.Show(ID);
        }
    }
}
