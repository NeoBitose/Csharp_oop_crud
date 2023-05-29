namespace OOP_TM
{
    public partial class Form1 : Form
    {
        List<Mahasiswa> listMahasiswa = new List<Mahasiswa>();

        public Form1()
        {
            InitializeComponent();

            Mahasiswa mahasiswa = new Mahasiswa();

            mahasiswa.Nim = "21001";
            mahasiswa.Nama = "Ratih Anggraini";
            mahasiswa.Alamat = "Jl. Jawa no 20";
            mahasiswa.TglLahir = new DateOnly(2005, 05, 17);
            mahasiswa.ProgramStudi = "Sistem Informasi";
            mahasiswa.IsActive = true;

            listMahasiswa.Add(mahasiswa);

            dataGridView1.DataSource = listMahasiswa;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (FormDataBaru frmDataBaru = new FormDataBaru())
            {
                if (frmDataBaru.ShowDialog() == DialogResult.OK)
                {
                    Mahasiswa newMahasiswa = frmDataBaru.GetMahasiswa();
                    listMahasiswa.Add(newMahasiswa);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listMahasiswa;

                    frmDataBaru.Close();
                }
            }
        }
    }
}