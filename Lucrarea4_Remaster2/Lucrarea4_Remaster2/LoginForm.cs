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
    public partial class LoginForm : Form
    {
        List<LoginClass> login = new List<LoginClass>();

        public LoginForm()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login.Add(new LoginClass("", ""));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach(LoginClass l in login)
            {
                if(l.Username.ToString().Equals(txtUser.Text) && l.Password.ToString().Equals(txtParola.Text))
                {
                    btnCancel.Visible = false;
                    btnLogin.Visible = false;
                    txtParola.Enabled = false;
                    txtUser.Enabled = false;
                    progressBar1.Visible = true;

                    timer1.Interval = 1;
                    progressBar1.Value = 0;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;

                    timer1.Tick += Timer1_Tick;
                    timer1.Enabled = true;
                    
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            progressBar1.Value++;
            if (progressBar1.Value < progressBar1.Maximum) timer1.Enabled = true;
            else DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
