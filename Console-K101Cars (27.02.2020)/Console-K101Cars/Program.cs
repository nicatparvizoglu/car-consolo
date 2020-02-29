using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_K101Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars("Bmw","M5",80,15,50);
            Cars mer = new Cars("Mercedes", "E220", 80, 12);
          
            string input;
            Console.WriteLine("***Please write only bottom number***");
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top Up");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Exit");
                Console.Write(">>>>>>>>>>");
                input = Console.ReadLine();
                
                if (IsEmpty(input))
                {
                    switch (input)
                    {
                        case "1":
                            car.Go();
                            break;

                        case "2":
                            car.TopUp();
                            break;
                        case "3":
                            Console.WriteLine("Masin gedr");
                            break;
                        case "4":
                            Console.WriteLine("Xidmetlerimizden istifade etdiyiniz üçün teşekkür edirik!");
                            break;
                        default:
                            Console.WriteLine("Please write only top numeric number!");
                            break;
                    }
                }
            } while (input!="4");



        }
        static bool IsEmpty(string soz)
        {
            try
            {
                Convert.ToDouble(soz);
                return true;

            }
            catch (Exception)
            {

                Console.WriteLine("Zehmet olmasa reqem daxil edin");
                return false;
            }
        }
    }


    static class  Person
    {
        public static string Name;
        public static string Email;
        //public Person(string Name,string Email)
        //{
        //    this.Name = Name;
        //    this.Email = Email;
        //    say++;
        //    Console.WriteLine(say);

        //}
    }
}
