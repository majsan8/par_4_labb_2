using System;
using System.Numerics;
namespace par_4_labb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Välkomstmeddelande 
            Console.WriteLine("Välkommen till windchill beräknaren! \n");
            
            /* Vilkoret while som en oändlig loop för att programmet ska kunna köras till användaren väljer att avsluta programmet.  */
            while (true)
            {
                Console.WriteLine("Välj ett av nedanstående alternativ. \n 1. Beräkna windchill-faktor. \n 2. Avsluta.\n");
                int i = int.Parse(Console.ReadLine());

                /*Vägval med switchcase, för att avgöra vad programmet ska göra baserat på ett val från användaren.*/
                switch (i)
                {   
                    /* Om användaren väljer alternativ 1, tolkar vi det som att den vill fortsätta räkna ut windchill*/
                    case 1:

                        Console.WriteLine("\nSkriv in med siffror hur många grader celsius du har hos dig\n");
                        string userInput1 = Console.ReadLine();
                        Console.WriteLine("\nSkriv också i siffror hur snabbt vinden blåser (i km/h)\n");

                        /* Här har vi samlat datatyper. String och double är datatyper. 
                         Vi använder variabelnamn som är identifierare som beskriver vad variablen är tilldelad för värde. */
                        string userInput2 = Console.ReadLine();
                        double temperature = Double.Parse(userInput1);
                        double windspeed = Double.Parse(userInput2);

                        double basenumber = windspeed;
                        double exponent = 0.16;

                        /* Här använder vi en metod benämd Math.Pow vilket gör det möjligt att beräkna exponsiella tal i en beräkning. */
                        double WCTCelsius​ = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(basenumber, exponent) + 0.3965 * temperature * Math.Pow(basenumber, exponent);
                        string realcold = string.Format("{0:F1}", WCTCelsius);
                        Console.WriteLine("\nVädret utomhus känns just nu som:" + " " + realcold + " " + "C°\n");


                        /* Vi använder en if-else-sats för att skriva ut olika meddelande till användaren beroende på hur 
                         kallt det är hos användaren baserat på resultatet av beräkningen. */
                        if (WCTCelsius > -25)
                        {
                            Console.WriteLine("Kallt\n");
                        }

                        else if (WCTCelsius <= -25 && WCTCelsius >= -35)
                        {
                            Console.WriteLine("Mycket kallt\n");
                        }

                        else if (WCTCelsius < -35 && WCTCelsius >= -60)
                        {
                            Console.WriteLine("Risk för frostskada\n");
                        }

                        else if (WCTCelsius < -60)
                        {
                            Console.WriteLine("Stor risk för frostskada\n");
                        }
                        break;
                        
                        /* Om användaren väljer alternativ 2, tolkar vi det som att användaren vill avsluta programmet. 
                        Användaren kan göra detta val igenom hela loopen vilket gör att vi avslutar med ett avslutningsmeddelande.
                        Här finns också en metod (Environment.Exit(0)) som avslutar programmet*/
                    case 2:
                        Console.WriteLine("Tack för att du ville beräkna windchill! Nu avslutas programmet.");
                        Environment.Exit(0);
                        break;
                }
            }
        } 
                
        

    }
}
