using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwlab2
{
    public enum eGender { kadin = 1, erkek = 2 }
    public struct Grade
    {
        double Not { get; set; }
        string HarfNot { 
            get 
            {
                if (Not >= 90)
                {
                    return "A";

                }
                else if (Not >= 80)
                {
                    return "B";

                }
                else if (Not >= 70)
                {
                    return "C";


                }
                else if (Not >= 60)
                {
                    return "D";

                }
                else
                {
                    return "F";

                }
            }
        public eGender Cinsiyet { get; set; }


    }
}
