using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_K101Cars
{
    class Cars
    {
        public string Marka;
        public string Model;
        public int FuelPower;
        public double FuelKm;
        public double CurrentFuel;
        public double LocalKM;
        public double globalKm;

        public Cars(string Marka,string Model,int FuelPower,double FuelKm,double CurrentFuel=40)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.FuelKm = FuelKm;
            this.FuelPower = FuelPower;
            this.CurrentFuel = CurrentFuel;
        }

           public void Go()
            {
            double neededKm = 0;

            while (neededKm == 0) 
             {
                Console.WriteLine("Nece km yol getmek isteyirsiniz?");
                string userInput = Console.ReadLine();
                if (IsEmpty(userInput))
                    {
                    neededKm = Convert.ToDouble(userInput);
                    if(CurrentFuel>=(neededKm/100)*FuelKm)
                    {
                        CurrentFuel-=(neededKm / 100) * FuelKm;
                        Console.WriteLine($"Siz {neededKm}km qeder yol getdiniz.{CurrentFuel}l benziniz qaldi;");
                    }
                    else
                    {
                        Console.WriteLine("Sizin masinda kifayet qeder benzin yoxdur! Zehmet olmasa benzin doldurun");
                    }
                }
                }
            }
        public void TopUp()
        {
            Console.WriteLine("nece l benzin yuklemek isteyirsiniz?");
            string user = Console.ReadLine();

        }
        bool IsEmpty(string soz)
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
}
