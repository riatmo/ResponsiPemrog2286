using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2286
{
    class Karyawan
    {
        //Properties
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        //Constructor
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;

            //Agar default GajiBulanan menjadi 0 ketika nilai gajibulanan < 0
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }

        }

    }
}
