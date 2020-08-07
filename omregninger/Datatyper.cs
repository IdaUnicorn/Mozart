using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omregninger
{
    class Datatyper
    {
        public static void omregninger()
        {
            //            Skriv et program som omregner Celciusgrader til Fahrenheit-og Reamurgrader.
            //Celciusgraden skal indlæses fra konsolvinduet og resultaterne skal også udskrives til konsolvinduet.

            //Formlen for omregningen

            //Reamur = Celcius * 0.8

            //Fahrenheit = Celcius * 1.8 + 32

            //Eksempel på indlæsning fra konsollen

            //  double c = double.Parse(Console.ReadLine());

            double Celcius = double.Parse(Console.ReadLine()); //bruger double.Parse for at konenterer til double, ellers bliver det string.
            double Reamur = Celcius * 0.8;
            double Fahrenheit = Celcius * 1.8 + 32;
            Console.WriteLine(Reamur);
            Console.WriteLine(Fahrenheit);
            

            //double.Parse forsøger at omdanne det der kommer fra konsollen til en doubleværdi


        }
        public static void VALUTAOMREGNER()
        {
            ////Skriv et program som kan omregne danske kroner, til US Dollars, Britiske Pund, 
            ////Euro og Svenske kroner. Som input skal du indlæse danske kroner(fra konsollen) og 
            ////du skal udskrive de omregnetværdier til konsollen. Det skal være muligt fra konsolvinduet, 
            ////at se både navnet og den omregnet valuta på samme linie.
            //double danskekr = double.Parse(Console.ReadLine());
            //double USdollars = danskekr * 6;
            //double Britiskepund = danskekr * 5;
            //double Euro = danskekr * 8.5;
            //double Svenskekr = danskekr * 0.8;
            //Console.WriteLine("US dollars er " + USdollars);
            //Console.WriteLine("Britiske pund er " + Britiskepund);
            //Console.WriteLine("Euro er " + Euro);
            //Console.WriteLine("Svenske kr er " + Svenskekr);
            //Console.ReadLine(); ////gør så at jeg skal trykke enter før vinduet lukker. 
        }

        public static void RUMFANGET()
        {
            //        Lav et program som kan beregne rumfanget for en kasse. Længde, bredde og højde skal indlæses 3 
            //værdier fra konsolvinduet og rumfanget udskrives til konsolvinduet.

            //Rumfanget(V) beregnes på følgende måde
            //V = h * b * l
            Console.WriteLine("Indtast høje");
            double højde = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast brede");
            double brede = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast længde");
            double længde = double.Parse(Console.ReadLine());
            double rumfang = højde * brede * længde;
            Console.WriteLine("Rumfanget er " + rumfang);
            Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
        }

    }


}
