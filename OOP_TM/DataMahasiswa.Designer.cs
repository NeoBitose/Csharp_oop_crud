namespace OOP_TM
{
    partial class DataMahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDataBaru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(742, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDataBaru
            // 
            this.btnDataBaru.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDataBaru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDataBaru.ForeColor = System.Drawing.Color.White;
            this.btnDataBaru.Location = new System.Drawing.Point(661, 10);
            this.btnDataBaru.Name = "btnDataBaru";
            this.btnDataBaru.Size = new System.Drawing.Size(110, 35);
            this.btnDataBaru.TabIndex = 1;
            this.btnDataBaru.Text = "Tambah";
            this.btnDataBaru.UseVisualStyleBackColor = false;
            this.btnDataBaru.Click += new System.EventHandler(this.btnDataBaru_Click);
            // 
            // DataMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDataBaru);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataMahasiswa";
            this.Text = "DataMahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDataBaru;
    }
}