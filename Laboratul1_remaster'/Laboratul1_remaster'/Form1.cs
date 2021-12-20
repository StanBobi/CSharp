using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratul1_remaster_
{
    
    public partial class Form1 : Form
    {
        private  List<Student> listaStudenti = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;

            try
            {
                byte varsta = Convert.ToByte(numeric.Value);

                //get note from form 
                byte[] note = new byte[5];
                note[0] = Convert.ToByte(cmbNota1.Text);
                note[1] = Convert.ToByte(cmbNota2.Text);
                note[2] = Convert.ToByte(cmbNota3.Text);
                note[3] = Convert.ToByte(cmbNota4.Text);
                note[4] = Convert.ToByte(cmbNota5.Text);

                byte an = Convert.ToByte(cmbAn.Text);
                Student s = new Student(nume, varsta, an, note);
                
                listaStudenti.Add(s);
                afisareLista();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void afisareLista()
        {
            lstBox1.Items.Clear();
            foreach(Student s in listaStudenti)
            {
                lstBox1.Items.Add(s.AfisareStudent());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numeric.Maximum = 120;
            numeric.Minimum = 0;
            lstBox1.Items.Clear(); //golim lista de potentiale elemente
}

        private void btnOrdonareNume_Click(object sender, EventArgs e)
        {
            ComparaNume comp = new ComparaNume();
            listaStudenti.Sort(comp);
            afisareLista();
        }

        private void btnOrdonareMedie_Click(object sender, EventArgs e)
        {
            ComparaMedie comp = new ComparaMedie();
            listaStudenti.Sort(comp);
            afisareLista();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            try
            {
                byte an = Convert.ToByte(cmbAnCautat.Text);

                //goleste lista
                lstBox1.Items.Clear();

                foreach (Student s in listaStudenti)
                {
                    if (s.AnStudiu == an) lstBox1.Items.Add(s.AfisareStudent());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string numeCautat = txtCauta.Text;

            lstBox1.Items.Clear();
            
            foreach(Student s in listaStudenti)
            {
                if(s.NumeStudent.Equals(numeCautat))
                {
                    lstBox1.Items.Add(s.AfisareStudent());
                }
            }

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            for(int x = lstBox1.SelectedIndices.Count-1; x>=0; x--)
            {
                int idx = lstBox1.SelectedIndices[x];
                listaStudenti.RemoveAt(idx);
                afisareLista();
            }
        }
    }
}
