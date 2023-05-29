using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace OOP_TM.Models
{
    public class MhsContext
    {
        #region Properties
        public List<Mhs> listMahasiswa = new List<Mhs>();
        #endregion

        public bool Insert(Mhs mhs)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=oop_mahasiswa;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = @"INSERT INTO mahasiswa(nim, nama, alamat, tgl_lahir, kd_prodi, ukt, is_active)
                               VALUES (:nim, :nama, :alamat, :tgl_lahir, :kd_prodi, :ukt, :is_active);";

                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":nim", mhs.Nim)); 
                    cmd.Parameters.Add(new NpgsqlParameter(":nama", mhs.Nama)); 
                    cmd.Parameters.Add(new NpgsqlParameter(":alamat", mhs.Alamat)); 
                    cmd.Parameters.Add(new NpgsqlParameter(":tgl_lahir", mhs.TglLahir)); 
                    cmd.Parameters.Add(new NpgsqlParameter(":kd_prodi", mhs.KdProdi)); 
                    cmd.Parameters.Add(new NpgsqlParameter(":ukt", mhs.UKT));
                    cmd.Parameters.Add(new NpgsqlParameter(":is_active", mhs.IsActive));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();

                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.listMahasiswa.Add(mhs);
                    }
                }
            }

            return isSuccess;
        }

        public bool Read()
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=oop_mahasiswa;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = @"SELECT t1.nim, t1.nama, t1.alamat, t1.tgl_lahir, t1.kd_prodi, t2.nama_prodi, 
                              t1.ukt, t1.is_active FROM mahasiswa as t1, prodi as t2
                              WHERE t1.kd_prodi = t2.kd_prodi;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listMahasiswa.Clear(); 
                    while (reader.Read())
                    {
                        Mhs newMhs = new Mhs();
                        newMhs.Nim = (string)reader["nim"];
                        newMhs.Nama = (string)reader["nama"];
                        newMhs.Alamat = (string)reader["alamat"];
                        newMhs.TglLahir = DateOnly.FromDateTime((DateTime)reader["tgl_lahir"]); 
                        newMhs.KdProdi = (string)reader["kd_prodi"];
                        newMhs.NamaProdi = (string)reader["nama_prodi"];
                        newMhs.UKT = (decimal)reader["ukt"];
                        newMhs.IsActive = (bool)reader["is_active"];
                        listMahasiswa.Add(newMhs);
                    }
                }       
            }

            return isSuccess;
        }
    }
    

    
}
