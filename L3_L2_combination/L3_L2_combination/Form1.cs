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
    public partial class Form1 : Form
    {
        List<JucatorClass> listaJucatori = new List<JucatorClass>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //goleste elementele de potentiale rezultate
            cmbEchipa.Items.Clear();
            treeView1.Nodes.Clear();
            flowLayoutPanel1.Controls.Clear();
            IncarcaEchipe();
        }

        private void btnNewEchipa_Click(object sender, EventArgs e)
        {
            EchipaForm f = new EchipaForm();

            if (f.ShowDialog() == DialogResult.OK)
            {
                cmbEchipa.Items.Clear();
                IncarcaEchipe();
            }
        }

        void IncarcaEchipe()
        {
            LoginForm l = new LoginForm();
            if(l.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }


            cmbEchipa.Items.Clear();
            treeView1.Nodes.Clear();

            foreach (string directoryFile in Directory.EnumerateDirectories(Application.StartupPath))
            {
                DirectoryInfo directoryName = new DirectoryInfo(directoryFile);
                cmbEchipa.Items.Add(directoryName.Name);
                treeView1.Nodes.Add(directoryName.Name, directoryName.Name, 1);
                IncarcaJucatori(directoryName.Name);
            }
        }

        private void btnJucatorNou_Click(object sender, EventArgs e)
        {
            JucatorForm f = new JucatorForm();

            if (f.ShowDialog() == DialogResult.OK && cmbEchipa.Text.Trim().Length > 0)
            {
                string nume = f.Nume;
                string cnp = f.CNP;
                Post post = (Post)Enum.Parse(typeof(Post), f.Post);


                string startPath = Application.StartupPath;

                using (StreamWriter sw = new StreamWriter(startPath + "\\" + cmbEchipa.Text
                    + "\\" + cnp + ".lpf"))
                {
                    sw.WriteLine(nume);
                    sw.WriteLine(post);
                }
                IncarcaJucatori(cmbEchipa.Text);
            }

        }

        private void IncarcaJucatori(string numeEchipa)
        {
            string filePath = Application.StartupPath + "\\" + numeEchipa;
            flowLayoutPanel1.Controls.Clear();

            listaJucatori.Clear();

            TreeNode myNode = treeView1.Nodes[numeEchipa];
            myNode.Nodes.Clear();
            foreach (string fileJucator in Directory.EnumerateFiles(filePath, "*lpf"))
            {


                using (StreamReader sr = new StreamReader(fileJucator))
                {
                    string cnp = Path.GetFileNameWithoutExtension(fileJucator);
                    string nume = sr.ReadLine();
                    Post post = (Post)Enum.Parse(typeof(Post), sr.ReadLine());

                    JucatorClass j = new JucatorClass(nume, cnp, post);
                    Button btn = new Button();
                    btn.Text = j.Nume;
                    btn.Tag = j;
                    btn.Width = 200;

                    if (cmbEchipa.Text.Trim().Length > 0)
                    {
                        flowLayoutPanel1.Controls.Add(btn);
                        btn.Click += Btn_Click;
                    }



                    myNode.Nodes.Add(j.CNP, j.Nume, 2);
                    listaJucatori.Add(j);

                }
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            JucatorClass j = (JucatorClass)btn.Tag;

            txtNume.Enabled = false;
            txtCNP.Enabled = false;
            txtVarsta.Enabled = false;
            dtp.Enabled = false;
            cmbPost.Enabled = false;

            txtNume.Text = j.Nume;
            txtCNP.Text = j.CNP;
            txtVarsta.Text = j.Varsta.ToString();
            dtp.Value = j.DataNasterii;
            cmbPost.Text = j.Post.ToString();
            pgd.SelectedObject = j;
        }

        private void cmbEchipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncarcaJucatori(cmbEchipa.Text);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            JucatorClass j;
            string cnp = e.Node.Name;


            j = GetByIndex(cnp);
            if (j != null)
            {
                pgd.SelectedObject = j;
                txtNume.Text = j.Nume;
                txtCNP.Text = j.CNP;
                txtVarsta.Text = j.Varsta.ToString();
                dtp.Value = j.DataNasterii;
                cmbPost.Text = j.Post.ToString();
            }
        }

        private JucatorClass GetByIndex(string cnp)
        {
            foreach (JucatorClass j in listaJucatori)
            {
                if (j.CNP == cnp) return j;
            }
            return null;
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string numeCautat = txtCautare.Text;

            string pathDirectory = Application.StartupPath;

            foreach (string directory in Directory.EnumerateDirectories(pathDirectory))
            {
                DirectoryInfo directoryName = new DirectoryInfo(directory);

                string pathDirectoryForFile = pathDirectory + "\\" + directoryName.Name;

                foreach (string fileTeam in Directory.EnumerateFiles(pathDirectoryForFile))
                {
                    string cnp = Path.GetFileNameWithoutExtension(fileTeam);
                    using (StreamReader sr = new StreamReader(fileTeam))
                    {
                        string nume = sr.ReadLine();
                        Post post = (Post)Enum.Parse(typeof(Post), sr.ReadLine());

                        if (nume.Contains(numeCautat) || cnp.Contains(numeCautat))
                        {
                            JucatorClass j = new JucatorClass(nume, cnp, post);
                            pgd.SelectedObject = j;
                            txtNume.Text = j.Nume;
                            txtCNP.Text = j.CNP;
                            txtVarsta.Text = j.Varsta.ToString();
                            dtp.Value = j.DataNasterii;
                            cmbPost.Text = j.Post.ToString();
                        }

                    }
                }

            }

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            string cnpDeSters = txtSterge.Text;

            string pathDirectory = Application.StartupPath;

            foreach (string directory in Directory.EnumerateDirectories(pathDirectory))
            {
                DirectoryInfo directoryName = new DirectoryInfo(directory);

                string pathDirectoryForFile = pathDirectory + "\\" + directoryName.Name;
                foreach (string fileTeam in Directory.EnumerateFiles(pathDirectoryForFile))
                {
                    string cnp = Path.GetFileNameWithoutExtension(fileTeam);
                    if (cnp.Equals(cnpDeSters))
                    {
                    }
                }

            }
        }
    
    }
}
enum Post : int
{
    Portar,
    Fundas,
    Mijlocas,
    Atacant
}
