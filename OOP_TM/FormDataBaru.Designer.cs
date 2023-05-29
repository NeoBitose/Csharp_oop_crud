namespace OOP_TM
{
    partial class FormDataBaru
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
            this.title_form = new System.Windows.Forms.Label();
            this.label_nim = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.label_tgl_lahir = new System.Windows.Forms.Label();
            this.label_prodi = new System.Windows.Forms.Label();
            this.label_ukt = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.dtpTgl = new System.Windows.Forms.DateTimePicker();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.tbUkt = new System.Windows.Forms.TextBox();
            this.cekbStatus = new System.Windows.Forms.CheckBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_form
            // 
            this.title_form.AutoSize = true;
            this.title_form.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_form.ForeColor = System.Drawing.Color.Green;
            this.title_form.Location = new System.Drawing.Point(322, 25);
            this.title_form.Name = "title_form";
            this.title_form.Size = new System.Drawing.Size(188, 32);
            this.title_form.TabIndex = 0;
            this.title_form.Text = "Entri Data Baru";
            // 
            // label_nim
            // 
            this.label_nim.AutoSize = true;
            this.label_nim.Location = new System.Drawing.Point(38, 104);
            this.label_nim.Name = "label_nim";
            this.label_nim.Size = new System.Drawing.Size(33, 15);
            this.label_nim.TabIndex = 1;
            this.label_nim.Text = "NIM ";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(38, 138);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(39, 15);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Nama";
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.Location = new System.Drawing.Point(38, 173);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(45, 15);
            this.label_alamat.TabIndex = 3;
            this.label_alamat.Text = "Alamat";
            // 
            // label_tgl_lahir
            // 
            this.label_tgl_lahir.AutoSize = true;
            this.label_tgl_lahir.Location = new System.Drawing.Point(38, 210);
            this.label_tgl_lahir.Name = "label_tgl_lahir";
            this.label_tgl_lahir.Size = new System.Drawing.Size(54, 15);
            this.label_tgl_lahir.TabIndex = 4;
            this.label_tgl_lahir.Text = "Tgl. Lahir";
            // 
            // label_prodi
            // 
            this.label_prodi.AutoSize = true;
            this.label_prodi.Location = new System.Drawing.Point(38, 244);
            this.label_prodi.Name = "label_prodi";
            this.label_prodi.Size = new System.Drawing.Size(83, 15);
            this.label_prodi.TabIndex = 5;
            this.label_prodi.Text = "Program Studi";
            // 
            // label_ukt
            // 
            this.label_ukt.AutoSize = true;
            this.label_ukt.Location = new System.Drawing.Point(38, 279);
            this.label_ukt.Name = "label_ukt";
            this.label_ukt.Size = new System.Drawing.Size(59, 15);
            this.label_ukt.TabIndex = 6;
            this.label_ukt.Text = "Besar UKT";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(38, 312);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(39, 15);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "Status";
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(154, 98);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(231, 23);
            this.tbNim.TabIndex = 8;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(154, 132);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(329, 23);
            this.tbNama.TabIndex = 9;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(154, 170);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(412, 23);
            this.tbAlamat.TabIndex = 10;
            // 
            // dtpTgl
            // 
            this.dtpTgl.Location = new System.Drawing.Point(155, 206);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(278, 23);
            this.dtpTgl.TabIndex = 11;
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Location = new System.Drawing.Point(154, 241);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(329, 23);
            this.cbProdi.TabIndex = 12;
            // 
            // tbUkt
            // 
            this.tbUkt.Location = new System.Drawing.Point(155, 276);
            this.tbUkt.Name = "tbUkt";
            this.tbUkt.Size = new System.Drawing.Size(230, 23);
            this.tbUkt.TabIndex = 13;
            // 
            // cekbStatus
            // 
            this.cekbStatus.AutoSize = true;
            this.cekbStatus.Location = new System.Drawing.Point(156, 312);
            this.cekbStatus.Name = "cekbStatus";
            this.cekbStatus.Size = new System.Drawing.Size(51, 19);
            this.cekbStatus.TabIndex = 14;
            this.cekbStatus.Text = "Aktif";
            this.cekbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSimpan.Location = new System.Drawing.Point(501, 378);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(117, 46);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(641, 378);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(117, 46);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // FormDataBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cekbStatus);
            this.Controls.Add(this.tbUkt);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.dtpTgl);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNim);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_ukt);
            this.Controls.Add(this.label_prodi);
            this.Controls.Add(this.label_tgl_lahir);
            this.Controls.Add(this.label_alamat);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_nim);
            this.Controls.Add(this.title_form);
            this.Name = "FormDataBaru";
            this.Text = "Entri Data Baru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title_form;
        private Label label_nim;
        private Label label_name;
        private Label label_alamat;
        private Label label_tgl_lahir;
        private Label label_prodi;
        private Label label_ukt;
        private Label label_status;
        private TextBox tbNim;
        private TextBox tbNama;
        private TextBox tbAlamat;
        private DateTimePicker dtpTgl;
        private ComboBox cbProdi;
        private TextBox tbUkt;
        private CheckBox cekbStatus;
        private Button btnSimpan;
        private Button btnBatal;
    }
}