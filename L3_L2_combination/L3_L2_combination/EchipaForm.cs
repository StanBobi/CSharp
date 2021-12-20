using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L3_L2_combination
{
    public partial class EchipaForm : Form
    {
        public EchipaForm()
        {
            InitializeComponent();
        }

        private void EchipaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath;

            if (txtNumeEchipa.Text.Trim().Length > 0)
            {
                Directory.CreateDirectory(filepath + "\\" + txtNumeEchipa.Text);
            }
            else
            {
                errorProvider1.SetError(txtNumeEchipa, "Text invalid ! ");
                return; 
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}


