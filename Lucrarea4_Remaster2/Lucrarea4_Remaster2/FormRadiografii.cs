using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea4_Remaster2
{
    public partial class FormRadiografii : Form
    {
        public FormRadiografii()
        {
            InitializeComponent();
        }
        public FormRadiografii(string CNP)
        {
            InitializeComponent();
            txtCNP.Text = CNP;
        }

        private void FormRadiografii_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void btnSalveazaImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = Form1.imgPath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string imgPath = GetFileName(dlg.FileName);
                txtImagine.Text = imgPath;
            }


        }

        private string GetFileName(string fileName)
        {
            string[] splitChars = {"\\"};
            string[] result = fileName.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            return result[result.GetLength(0) - 1];
        }

        public string CNP { get { return txtCNP.Text; } }

        public DateTime Data { get { return dateTimePicker1.Value; } }

        public string Imagine { get { return txtImagine.Text; } }
        public string Diagnostic { get { return txtDiagnostic.Text; } }
        public string Comentarii { get { return txtComentarii.Text; } }


    }
}
