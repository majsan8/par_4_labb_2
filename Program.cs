using System;
using System.Numerics;
namespace par_4_labb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till windchill beräknaren! \n");

            while (true)
            {
                Console.WriteLine("Välj ett av nedanstående alternativ. \n 1. Beräkna windchill-faktor. \n 2. Avsluta.\n");
                int i = int.Parse(Console.ReadLine());

           
                switch (i)
                {
                    case 1:

                        Console.WriteLine("Skriv in med siffror hur många grader celsius du har hos dig)");
                        string userInput1 = Console.ReadLine();
                        Console.WriteLine("Skriv också i siffror hur snabbt vinden blåser (i km/h)");


                        string userInput2 = Console.ReadLine();
                        double temperature = Double.Parse(userInput1);
                        double windspeed = Double.Parse(userInput2);

                        double basenumber = windspeed;
                        double exponent = 0.16;


                        double WCTCelsius​ = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(basenumber, exponent) + 0.3965 * temperature * Math.Pow(basenumber, exponent);
                        string realcold = string.Format("{0:F2}", WCTCelsius);
                        Console.WriteLine("\nVädret utomhus känns just nu som:" + " " + realcold + " " + "C°\n");
                        break;

                    case 2:
                        Console.WriteLine("Nu avslutas programmet.");
                        Environment.Exit(0);
                        break;
                }
            }
        } 
                
        

    }
}
