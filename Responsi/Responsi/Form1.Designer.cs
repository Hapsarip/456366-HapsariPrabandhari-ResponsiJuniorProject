namespace Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgvKaryawan = new System.Windows.Forms.DataGridView();
            this.btLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(13, 72);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(105, 15);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Karyawan   :";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(13, 101);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(106, 15);
            this.lblDep.TabIndex = 2;
            this.lblDep.Text = "Dep. Karyawan      :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(128, 69);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(190, 23);
            this.tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Items.AddRange(new object[] {
            "HR",
            "Engineer",
            "Developer",
            "Product Manager",
            "Finance"});
            this.cbDep.Location = new System.Drawing.Point(128, 98);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(190, 23);
            this.cbDep.TabIndex = 4;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(13, 135);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 5;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(128, 135);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(243, 135);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // dgvKaryawan
            // 
            this.dgvKaryawan.BackgroundColor = System.Drawing.Color.White;
            this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKaryawan.Location = new System.Drawing.Point(12, 174);
            this.dgvKaryawan.Name = "dgvKaryawan";
            this.dgvKaryawan.RowTemplate.Height = 25;
            this.dgvKaryawan.Size = new System.Drawing.Size(306, 150);
            this.dgvKaryawan.TabIndex = 8;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(243, 330);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 9;
            this.btLoad.Text = "Lihat Data";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 363);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.dgvKaryawan);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.cbDep);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNama;
        private Label lblDep;
        private TextBox tbNama;
        private ComboBox cbDep;
        private Button btInsert;
        private Button btEdit;
        private Button btDelete;
        private DataGridView dgvKaryawan;
        private Button btLoad;
    }
}