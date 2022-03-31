using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarPBOCsharp
{
    internal class Mahasiswa : Orang
    {
        //konstruktor => nunjukin dia itu punya apa aja
        int nim = 0;
        public Mahasiswa(string nama, int umur, string jk, int nim) : base(nama, umur, jk)
        {
            this.nim = nim;
        }

        //method
        public void SayHello()
        {
            Console.WriteLine("Hello " + GetNama() + " dengan nim: " + this.nim);
        }

    }
}
