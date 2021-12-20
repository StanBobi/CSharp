
namespace L3_L2_combination
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEchipa = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewEchipa = new System.Windows.Forms.Button();
            this.btnJucatorNou = new System.Windows.Forms.Button();
            this.pgd = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Cauta = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.txtSterge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume echipa";
            // 
            // cmbEchipa
            // 
            this.cmbEchipa.FormattingEnabled = true;
            this.cmbEchipa.Location = new System.Drawing.Point(101, 20);
            this.cmbEchipa.Name = "cmbEchipa";
            this.cmbEchipa.Size = new System.Drawing.Size(121, 21);
            this.cmbEchipa.TabIndex = 1;
            this.cmbEchipa.SelectedIndexChanged += new System.EventHandler(this.cmbEchipa_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 324);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnNewEchipa
            // 
            this.btnNewEchipa.Location = new System.Drawing.Point(229, 18);
            this.btnNewEchipa.Name = "btnNewEchipa";
            this.btnNewEchipa.Size = new System.Drawing.Size(83, 23);
            this.btnNewEchipa.TabIndex = 3;
            this.btnNewEchipa.Text = "Echipa noua";
            this.btnNewEchipa.UseVisualStyleBackColor = true;
            this.btnNewEchipa.Click += new System.EventHandler(this.btnNewEchipa_Click);
            // 
            // btnJucatorNou
            // 
            this.btnJucatorNou.Location = new System.Drawing.Point(229, 390);
            this.btnJucatorNou.Name = "btnJucatorNou";
            this.btnJucatorNou.Size = new System.Drawing.Size(83, 23);
            this.btnJucatorNou.TabIndex = 4;
            this.btnJucatorNou.Text = "Jucator nou";
            this.btnJucatorNou.UseVisualStyleBackColor = true;
            this.btnJucatorNou.Click += new System.EventHandler(this.btnJucatorNou_Click);
            // 
            // pgd
            // 
            this.pgd.Location = new System.Drawing.Point(338, 216);
            this.pgd.Name = "pgd";
            this.pgd.Size = new System.Drawing.Size(275, 197);
            this.pgd.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCNP);
            this.groupBox1.Controls.Add(this.txtVarsta);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.cmbPost);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(550, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii jucator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Varsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data nasterii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CNP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Post";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(82, 27);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(121, 20);
            this.txtNume.TabIndex = 5;
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Items.AddRange(new object[] {
            "Portar",
            "Fundas",
            "Mijlocas",
            "Atacant"});
            this.cmbPost.Location = new System.Drawing.Point(82, 52);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(121, 21);
            this.cmbPost.TabIndex = 6;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd.MM.yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(82, 105);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(121, 20);
            this.dtp.TabIndex = 7;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(82, 131);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(121, 20);
            this.txtVarsta.TabIndex = 8;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(82, 79);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(121, 20);
            this.txtCNP.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(338, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(193, 172);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "rude.png");
            this.imageList1.Images.SetKeyName(2, "prieteni.png");
            // 
            // Cauta
            // 
            this.Cauta.AutoSize = true;
            this.Cauta.Location = new System.Drawing.Point(629, 228);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(35, 13);
            this.Cauta.TabIndex = 8;
            this.Cauta.Text = "Cauta";
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(632, 244);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(146, 20);
            this.txtCautare.TabIndex = 9;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(704, 270);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(75, 23);
            this.btnCautare.TabIndex = 10;
            this.btnCautare.Text = "Cauta";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(705, 354);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 13;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // txtSterge
            // 
            this.txtSterge.Location = new System.Drawing.Point(633, 328);
            this.txtSterge.Name = "txtSterge";
            this.txtSterge.Size = new System.Drawing.Size(146, 20);
            this.txtSterge.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sterge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 435);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.txtSterge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pgd);
            this.Controls.Add(this.btnJucatorNou);
            this.Controls.Add(this.btnNewEchipa);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmbEchipa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LPF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEchipa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNewEchipa;
        private System.Windows.Forms.Button btnJucatorNou;
        private System.Windows.Forms.PropertyGrid pgd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Cauta;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.TextBox txtSterge;
        private System.Windows.Forms.Label label7;
    }
}

