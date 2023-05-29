using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_TM
{
    public partial class FormDataBaru : Form
    {
        public FormDataBaru()
        {
            InitializeComponent();

            //Statis
            //object[] dataProdi = new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" };
            //cbProdi.Items.AddRange(dataProdi);

            //Dinamis
            SetComboBoxProdi();

        }

        public void SetComboBoxProdi()
        {
            List<Prodi> listProdi = new List<Prodi>();
            listProdi.Add(new Prodi() { KdProdi = "10", NamaProdi = "Sistem Informasi" });
            listProdi.Add(new Prodi() { KdProdi = "20", NamaProdi = "Teknologi Informasi" });
            listProdi.Add(new Prodi() { KdProdi = "30", NamaProdi = "Informatika" });

            cbProdi.DataSource = listProdi;
            cbProdi.ValueMember = "KdProdi";
            cbProdi.DisplayMember = "NamaProdi";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        public Mahasiswa GetMahasiswa()
        {
            Mahasiswa newMahasiswa = new Mahasiswa();

            newMahasiswa.Nim = tbNim.Text;
            newMahasiswa.Nama = tbNama.Text;
            newMahasiswa.Alamat = tbAlamat.Text;
            newMahasiswa.TglLahir = DateOnly.Parse(dtpTgl.Value.ToShortDateString());
            newMahasiswa.ProgramStudi = ((Prodi)cbProdi.SelectedItem).KdProdi;
            newMahasiswa.UKT = decimal.Parse(tbUkt.Text);
            newMahasiswa.IsActive = cekbStatus.Checked;

            return newMahasiswa;

        }
    }
}
