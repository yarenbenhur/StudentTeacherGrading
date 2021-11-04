using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwlab2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<IClassMember> teachers = new List<IClassMember>();
            
            string answer = "e";
            int id = 0;

            while (answer == "e")
            {
                id++;
                
                Console.WriteLine("eğitmen adını giriniz: ");
                string ad = Console.ReadLine();
                Console.WriteLine("eğitmen soyadını giriniz: ");
                string soyad = Console.ReadLine();
                Console.WriteLine("eğitmen cinsiyetini seçiniz k ->1 /e->2 :");
                eGender cinsiyet = (eGender)Convert.ToInt32(Console.ReadLine());

                
                IClassMember teacher = new Teacher(id,ad,soyad,cinsiyet);
                teachers.Add(teacher);

                

                Console.WriteLine("eğitmen eklemeye devam etmek istiyor musunuz?  evet ->e / hayır->h :");
                answer = Console.ReadLine();
                
                

            }
            foreach(IClassMember item in teachers)
            {
                item.WriteInformations();


            }





            //answer = "e";
            //while (answer == "e")
            //{
            //    id++;


            //    Console.WriteLine("öğrenci adını giriniz: ");
            //    string ad = Console.ReadLine();
            //    Console.WriteLine("öğrenci soyadını giriniz: ");
            //    string soyad = Console.ReadLine();
            //    Console.WriteLine("öğrenci cinsiyetini seçiniz k ->1 /e->2 :");
            //    eGender cinsiyet = (eGender)Convert.ToInt32(Console.ReadLine());

            //    Student student1 = new Student(id,ad,soyad,cinsiyet);

            //    student1.WriteInformations();
            //    Console.WriteLine("öğrenci eklemeye devam etmek istiyor musunuz?  evet ->e / hayır->h :");
            //    answer = Console.ReadLine();


            //}


        }
        
           
    
                 
    
    }
}
