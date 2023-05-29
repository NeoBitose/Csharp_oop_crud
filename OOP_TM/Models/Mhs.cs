using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TM.Models
{
    public class Mhs
    {
        public String Nim { get; set; }
        public String Nama { get; set; }
        public String Alamat { get; set; }
        public DateOnly TglLahir { get; set; }
        public String KdProdi { get; set; }
        public String NamaProdi { get; set; }
        public decimal UKT { get; set; }
        public Boolean IsActive { get; set; }
    }
}
