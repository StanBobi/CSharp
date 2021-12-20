using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L3_L2_combination
{
    public partial class JucatorForm : Form
    {
        public JucatorForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNume.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNume, "Nume invalid !");
                return;
            }
            else if (txtCNP.Text.Trim().Length != 13)
            {
                errorProvider1.SetError(txtCNP, "Lungimea trebuie sa fie 13 !");
                return;
            }
                DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public String Nume { get { return txtNume.Text; } }
        public String CNP { get { return txtCNP.Text; } }
        public String Post { get { return cmbPost.Text; } }

        private void JucatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
