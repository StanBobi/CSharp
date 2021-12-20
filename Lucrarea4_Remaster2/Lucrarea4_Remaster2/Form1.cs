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
    public partial class Form1 : Form
    {
        public static string imgPath = @"C:\Users\bogda\source\repos\Lucrarea4_Remaster2\Lucrarea4_Remaster2\_IMG";
        public Form1()
        {
            InitializeComponent();
        }

        private void pacientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
           // if (f.ShowDialog() != DialogResult.OK) this.Close();

            // TODO: This line of code loads data into the 'pacient2DataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.pacient2DataSet.Radiografii);
            // TODO: This line of code loads data into the 'pacient2DataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.pacient2DataSet.Pacienti);

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pacient2DataSet);
        }

        private void btnAdaugaRadiografie_Click(object sender, EventArgs e)
        {
            string CNPCurent = ((DataRowView)pacientiBindingSource.Current)["CNP"].ToString(); 

            FormRadiografii f = new FormRadiografii(CNPCurent);

            if(f.ShowDialog() == DialogResult.OK)
            {
                radiografiiTableAdapter.Insert(f.CNP, f.Imagine, f.Data, f.Diagnostic, f.Comentarii);
                tableAdapterManager.UpdateAll(pacient2DataSet);
                radiografiiTableAdapter.Fill(pacient2DataSet.Radiografii);
                showImages();
            }

        }

        private void showImages()
        {
            flw.Controls.Clear();
            flw.AutoScroll = true;
            pictureBox1.Image = null;
            txtComentarii.Visible = false;

            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                PictureBox myPicture = new PictureBox();
                myPicture.SizeMode = PictureBoxSizeMode.Zoom;
                myPicture.SetBounds(0, 0, 150, 150);
                myPicture.Image = Bitmap.FromFile(imgPath + "\\" + drv["Imagine"]);
                myPicture.BackColor = Color.Transparent;
                myPicture.Tag = drv["Imagine"];
                
                flw.Controls.Add(myPicture);
                myPicture.Click += MyPicture_Click;
            }
        }

        private void MyPicture_Click(object sender, EventArgs e)
        {
            PictureBox myPicture = (PictureBox)sender;
            PictureBox myPictureforBox = new PictureBox();
            myPictureforBox.Image = myPicture.Image;
            myPictureforBox.SetBounds(0, 0, 216, 198);

            foreach(DataRowView drv in radiografiiBindingSource.List)
            {
                if(myPicture.Tag.Equals(drv["Imagine"]))
                {
                    pictureBox1.Image = myPictureforBox.Image;
                    txtComentarii.Visible = true;
                    txtComentarii.Text = "Diagnostic: " + drv["Diagnostic"]
                        + " Comentarii:" + drv["Comentarii"];
                }
            }

            
        }

        private void pacientiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showImages();
        }

        private void txtNumeCautat_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeCautat.Text.Trim().Length > 0)
            {
                string numeCautat = txtNumeCautat.Text;
                numeCautat = "nume LIKE '" + numeCautat + "%'";

                pacientiBindingSource.Filter = numeCautat;
            }
            else pacientiBindingSource.RemoveFilter();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            string numeSters = txtSterge.Text;

            foreach(DataRowView drv in pacientiBindingSource.List)
            {
                
                if(drv["nume"].ToString().Equals(numeSters))
                {
                    foreach(DataRowView drv2 in radiografiiBindingSource.List)
                    {
                       // radiografiiTableAdapter.Dispose();
                        
                        radiografiiTableAdapter.Delete((int)drv2["ID"],
                            drv2["CNP"].ToString(), drv2["Imagine"].ToString(),
                            (DateTime)drv2["Data"], drv2["Diagnostic"].ToString(),
                            drv2["Comentarii"].ToString());
                        tableAdapterManager.UpdateAll(pacient2DataSet);
                       
                    }
                    pacientiTableAdapter.Delete(drv["CNP"].ToString(),
                      drv["Nume"].ToString(), drv["Adresa"].ToString());
                    
                    tableAdapterManager.UpdateAll(pacient2DataSet);

                    this.radiografiiTableAdapter.Fill(this.pacient2DataSet.Radiografii);
                    // TODO: This line of code loads data into the 'pacient2DataSet.Pacienti' table. You can move, or remove it, as needed.
                    this.pacientiTableAdapter.Fill(this.pacient2DataSet.Pacienti);


                }
            }
            
        }
    }
}
