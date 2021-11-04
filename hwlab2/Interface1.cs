using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwlab2
{
    interface IClassMember
    {
        int Id { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        eGender Cinsiyet { get; set; }
        void WriteInformations();
    }
}
