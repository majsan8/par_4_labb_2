using System;
namespace par_4_labb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till windchill beräknaren!");
            Console.WriteLine("Skriv in med siffror hur många grader celsius du har hos dig)");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Skriv i siffror hur snabbt vinden blåser (i km/h)");

            
            string userInput2 = Console.ReadLine();
            double temperature = Double.Parse(userInput1);
            double windspeed = Double.Parse(userInput2);
        }
                
        

    }
}
