using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarPBOCsharp
{
    internal class mobil:Kendaraan
    {
        private int jumlahRoda;
        public mobil(string env, string warna ,int jumlahRoda):base(env,warna)
        {
            this.jumlahRoda = jumlahRoda;
        }


        public void jalan(string n)
        {
            Console.WriteLine($"mobil ini jalan {n}"); 
        }
        public void jalan(float n)
        {
            Console.WriteLine($"mobil ini jalan {n}");
        }

        public void tes1(string tes)
        {
            Console.WriteLine("Sekarang di child tapi ditiban parent" + tes);
        }

        public override void tes2()
        {
            Console.WriteLine("Sekarang di child tapi ditiban parent");
        }
    }
}
