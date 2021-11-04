using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwlab2
{
    class Teacher
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public eGender Cinsiyet { get; set; }

        public Teacher(int id, string ad, string soyad, eGender cinsiyet)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }

        public void WriteInformations()
        {
            Console.WriteLine("Eğitmen \t" + Id + "\t" + Ad + "\t" + Soyad + "\t" + Cinsiyet);
        }
    }
}
