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
    public partial class DataMahasiswa : Form
    {
        Models.MhsContext mhsContext;
        public DataMahasiswa()
        {
            InitializeComponent();
            mhsContext = new Models.MhsContext();

            mhsContext.Read();
            dataGridView1.DataSource = mhsContext.listMahasiswa;
        }

        private void btnDataBaru_Click(object sender, EventArgs e)
        {
            using (FormDataBaru frmDataBaru = new FormDataBaru())
            {
                DialogResult dr = frmDataBaru.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Models.Mhs newMahasiswa = frmDataBaru.GetMahasiswaNew();
                    mhsContext.Insert(newMahasiswa);
                    //mhsContext.listMahasiswa.Add(newMahasiswa);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mhsContext.listMahasiswa;
        }
    }
}
