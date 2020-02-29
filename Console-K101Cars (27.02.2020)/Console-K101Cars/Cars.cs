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
                        globalKm += neededKm;
                        LocalKM += neededKm;
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
            double neededPower = 0;
            string inp= Console.ReadLine();

            while (neededPower==0)
            {
                if(IsEmpty(inp))

                {
                    neededPower = Convert.ToDouble(inp);
                    if (IsEmpty(inp))
                    {
                        neededPower = Convert.ToDouble(inp);
                        if (CurrentFuel + neededPower <= FuelPower)
                        {
                            CurrentFuel += neededPower;
                            Console.WriteLine($"Ugurla benzin dolduruldu.{CurrentFuel}lr benzin var.");
                        }
                        else
                        {
                            Console.WriteLine("Siz maksimum benzin tutumunu aşdınız");
                        }
                    }
                }
            }
        }
        public void Stop()
        {
            LocalKM = 0;
            Console.WriteLine("------------------------")
            Console.WriteLine($"Local km sifirlandi. Global km :{globalKm}km -dir");
            Console.WriteLine("------------------------");

        }
        public void LcKm()
        {
            Console.WriteLine($"Global km: {globalKm}. Local km: {LocalKM }");
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
