
namespace Lucrarea4_Remaster2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeCautat = new System.Windows.Forms.TextBox();
            this.btnAdaugaRadiografie = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.flw = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtComentarii = new System.Windows.Forms.TextBox();
            this.pacient2DataSet = new Lucrarea4_Remaster2.pacient2DataSet();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiTableAdapter = new Lucrarea4_Remaster2.pacient2DataSetTableAdapters.PacientiTableAdapter();
            this.tableAdapterManager = new Lucrarea4_Remaster2.pacient2DataSetTableAdapters.TableAdapterManager();
            this.pacientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiografiiTableAdapter = new Lucrarea4_Remaster2.pacient2DataSetTableAdapters.RadiografiiTableAdapter();
            this.radiografiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSterge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacient2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume cautat";
            // 
            // txtNumeCautat
            // 
            this.txtNumeCautat.Location = new System.Drawing.Point(86, 12);
            this.txtNumeCautat.Name = "txtNumeCautat";
            this.txtNumeCautat.Size = new System.Drawing.Size(231, 20);
            this.txtNumeCautat.TabIndex = 1;
            this.txtNumeCautat.TextChanged += new System.EventHandler(this.txtNumeCautat_TextChanged);
            // 
            // btnAdaugaRadiografie
            // 
            this.btnAdaugaRadiografie.Location = new System.Drawing.Point(229, 323);
            this.btnAdaugaRadiografie.Name = "btnAdaugaRadiografie";
            this.btnAdaugaRadiografie.Size = new System.Drawing.Size(127, 23);
            this.btnAdaugaRadiografie.TabIndex = 2;
            this.btnAdaugaRadiografie.Text = "Adauga radiografie";
            this.btnAdaugaRadiografie.UseVisualStyleBackColor = true;
            this.btnAdaugaRadiografie.Click += new System.EventHandler(this.btnAdaugaRadiografie_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(12, 323);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(127, 23);
            this.btnSalveaza.TabIndex = 3;
            this.btnSalveaza.Text = "Salveaza modificarile";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // flw
            // 
            this.flw.Location = new System.Drawing.Point(376, 19);
            this.flw.Name = "flw";
            this.flw.Size = new System.Drawing.Size(172, 351);
            this.flw.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(567, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 200);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtComentarii
            // 
            this.txtComentarii.Location = new System.Drawing.Point(567, 256);
            this.txtComentarii.Multiline = true;
            this.txtComentarii.Name = "txtComentarii";
            this.txtComentarii.Size = new System.Drawing.Size(216, 90);
            this.txtComentarii.TabIndex = 6;
            // 
            // pacient2DataSet
            // 
            this.pacient2DataSet.DataSetName = "pacient2DataSet";
            this.pacient2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.pacient2DataSet;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.RadiografiiTableAdapter = this.radiografiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lucrarea4_Remaster2.pacient2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacientiDataGridView
            // 
            this.pacientiDataGridView.AutoGenerateColumns = false;
            this.pacientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pacientiDataGridView.DataSource = this.pacientiBindingSource;
            this.pacientiDataGridView.Location = new System.Drawing.Point(12, 97);
            this.pacientiDataGridView.Name = "pacientiDataGridView";
            this.pacientiDataGridView.Size = new System.Drawing.Size(344, 220);
            this.pacientiDataGridView.TabIndex = 8;
            this.pacientiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientiDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // radiografiiTableAdapter
            // 
            this.radiografiiTableAdapter.ClearBeforeFill = true;
            // 
            // radiografiiBindingSource
            // 
            this.radiografiiBindingSource.DataMember = "FK__Radiografii__CNP__25869641";
            this.radiografiiBindingSource.DataSource = this.pacientiBindingSource;
            // 
            // txtSterge
            // 
            this.txtSterge.Location = new System.Drawing.Point(103, 50);
            this.txtSterge.Name = "txtSterge";
            this.txtSterge.Size = new System.Drawing.Size(144, 20);
            this.txtSterge.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sterge persoana";
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(253, 48);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(64, 23);
            this.btnSterge.TabIndex = 11;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 382);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.txtSterge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pacientiDataGridView);
            this.Controls.Add(this.txtComentarii);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flw);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAdaugaRadiografie);
            this.Controls.Add(this.txtNumeCautat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radiografii ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacient2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeCautat;
        private System.Windows.Forms.Button btnAdaugaRadiografie;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.FlowLayoutPanel flw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtComentarii;
        private pacient2DataSet pacient2DataSet;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private pacient2DataSetTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private pacient2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pacientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private pacient2DataSetTableAdapters.RadiografiiTableAdapter radiografiiTableAdapter;
        private System.Windows.Forms.BindingSource radiografiiBindingSource;
        private System.Windows.Forms.TextBox txtSterge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSterge;
    }
}

