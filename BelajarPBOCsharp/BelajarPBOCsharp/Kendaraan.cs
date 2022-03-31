using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarPBOCsharp
{
    internal class Kendaraan
    {
        private string env;
        private string warna;
        
        
        public Kendaraan(string env, string warna)
        {
            this.env = env;
            this.warna = warna;
        }

        public void tes1()
        {
            Console.WriteLine("Sekarang di parent tapi ditiban child"); 
        }

        public virtual void tes2()
        {
            Console.WriteLine("Sekarang di parent tapi ditiban child");
        }
    }
}
