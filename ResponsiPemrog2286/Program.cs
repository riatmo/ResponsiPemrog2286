using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2286
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek
            Karyawan karyawan1 = new Karyawan("12345", "Reno", 3000000);
            Karyawan karyawan2 = new Karyawan("67890", "Asri", -555);

            //Menampilkan nilai properties dari objek
            Console.WriteLine("No. NIK / Nama\t\tGaji Bulanan");
            Console.WriteLine("1.  {0} {1} \t\t{2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.  {0} {1} \t\t{2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.ReadKey();

            Console.WriteLine("\nAsik, gaji naik 10% !");

            //Modifikasi properties Gaji
            karyawan1.GajiBulanan = karyawan1.GajiBulanan * 110 / 100;
            karyawan2.GajiBulanan = karyawan2.GajiBulanan * 110 / 100;

            //Menampilkan hasil modifikasi properties gaji
            Console.WriteLine("\nNo. NIK / Nama\t\tGaji Bulanan");
            Console.WriteLine("1.  {0} {1} \t\t{2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.  {0} {1} \t\t{2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.ReadKey();

        }
    }
}
