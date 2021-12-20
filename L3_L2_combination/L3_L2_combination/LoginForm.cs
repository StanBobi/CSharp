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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Login l = new Login(txtUtilizator.Text, txParola.Text);

            List<Login> listaLogin = new List<Login>();
            listaLogin.Add(new Login("admin", "admin"));

            listaLogin.Add(new Login("", ""));


            foreach (Login p in listaLogin)
            {
                if (l.Username == p.Username && l.Password == p.Password)
                {
                    btnOk.Visible = false;
                    btnCancel.Visible = false;
                    progressBar1.Visible = true;

                    startTimer();
                }
            }

        }

        private void startTimer()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            txtUtilizator.Enabled = false;
            txParola.Enabled = false;
        }
  
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                timer1.Start();
            }
            else
            {
                timer1.Start();
                timer1.Start();
                DialogResult = DialogResult.OK;
            }
            
            

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
