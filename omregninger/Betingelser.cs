using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace omregninger
{
    class Betingelser
    {
        public static void terningskast()
        {
            //            I denne opgave skal du arbejde med variable og betingelser i C#.
            //Du skal i denne opgave skrive et program som kan simulere et terningskast med en 6 - sidet terning.

            //Random
            //For at kunne generere et tilfældigt tal mellem 1 og 6, skal du bruge et af C#’s standard-biblioteker.
            //Inden du begynder på opgaverne skal du indsætte følgende i din kode:

            //Random random = new Random();
            //            int terningskast = random.Next(1, 7);

            //            Random er en klasse der giver mulighed for at ryste posen med bingotal og trække et 
            //tilfældigt tal.
            //            random.Next(1, 7); Next metoden genererer det næste tal. 
            //Denne metode leverer altid et tal fra min til max værdi - 1.I dette tilfælde er 
            //minimumsværdien 1 og max værdien - 1 = 6, så du vil altid få et tal mellem 1 og 6

            //Opgave a)
            //Du skal i din main metode nu indsætte et if/else statement, der udskiver dit terningkast for hvert 
            //antal øjne der slås, se nedestående eksempel(Tip: Du kan bare kopiere nedestående og selv udfylde resten)

            //if (terningskast == 1)
            //                {
            //                    Console.WriteLine("Du slog en etter");
            //                }
            //                else if (terningskast == 2)
            //                {
            //                    Console.WriteLine("Du slog en to'er");
            {
                Random random = new Random();
                int terningskast = random.Next(1, 7);
                if (terningskast == 1)
                {
                    Console.WriteLine("1");
                }
                else if (terningskast == 2)
                {
                    Console.WriteLine("2");
                }
                else if (terningskast == 3)
                {
                    Console.WriteLine("3");
                }
                else if (terningskast == 4)
                {
                    Console.WriteLine("4");
                }
                else if (terningskast == 5)
                {
                    Console.WriteLine("5");
                }
                else
                    Console.WriteLine("6");
                Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
                Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
                Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
                Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 


            }
        }

        public static void farver()
        {
            //            Opgave b)
            //Konsol programmering behøves ikke at være kedelig sort og hvid. Du kan lynhurtigt ændre 
            //forgrund eller baggrundsfarven i konsollen.Desværre kan du kun vælge mellem 16 farver, se 
            //billede. Hvis du ønsker at ændre tekstfarven til f.eks.gul kan du skrive følgende kommando

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //            Hvis du ønsker at ændre baggrundsfarven til f.eks.blå kan du skrive

            //Console.BackgroundColor = ConsoleColor.Blue;

            //            Skift nu forgrundsfarven for hvert terningsslag, så den tekst der udskrives, 
            //hvis man slår en etter – udskrives med rød, toer med blå osv.

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("farveskift");
            Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
        }
        public static void PYTHAGORAS()
        {
            //            Få brugeren til at indtaste 2 tal.


            //Brug Pythagoras’ sætning(a² +b² = c²) til at udregne c.

            //-Hvilket tal er egentlig størst – a eller b ? – output resultatet med hjælp fra en if-sætning.

            Console.WriteLine("Indtast a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c er ");
            Console.WriteLine(Math.Pow(a, 2) + Math.Pow(b, 2));
            {
                if (a > b)
                    Console.WriteLine("a is bigger than b");
                else if (b > a)
                    Console.WriteLine("b is bigger than a");
                else
                    Console.WriteLine("error");
                Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
            }

        }
        public static void ALDER()
        {
            //            Få brugeren til at indtaste sit navn og alder, fx ”Camilla” og 29.

            //- Hvis alder < 3 skal I udskrive ” Camilla, du må gå med ble”

            //-Hvis alderen er mellem 3 og 15 skal I udskrive ” Camilla, du må ingenting” 

            //-Hvis alderen er mellem 15 og 18(ikke inklusive) skal I udskrive ” Camilla, du må drikke” 

            //-Hvis alderen er 18 eller derover, skal I udskrive ” Camilla, du må stemme og køre bil”
            Console.WriteLine("Write your name ");
            string name = (Console.ReadLine());
            Console.WriteLine("Write your age ");
            double age = double.Parse(Console.ReadLine());
            if (age < 3)
            {
                Console.WriteLine(name + " you can wear a diper");
            }
            else if (age > 3 && age <= 15)
            {
                Console.WriteLine(name + " you are not alloved to do anything");
            }
            else if (age > 15 && age < 18)
            {
                Console.WriteLine(name + " you are alloved to dring");
            }
            else if (age >= 18)
            {
                Console.WriteLine(name + " you are alloved to vote and drive a car");
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
        }

        public static void GætEtTal()
        {
            //            -Lav et hemmeligt tilfældigt tal.

            //-Lad brugeren gætte tallet.

            //- Hvis brugeren gætter forkert skal I fortælle om tallet er højere eller lavere.

            //-Hold styr på hvor mange gæt brugeren har brugt, og brug passende ris / ros når tallet bliver gættet afhængig 
            //af antallet af forsøg.
            Console.WriteLine("Write a secret number ");
            double secret = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your number ");
            double YourNumber = double.Parse(Console.ReadLine());
            int counter = 0;
            counter++;

            while (secret != YourNumber)
            {
                Console.WriteLine("wrong number");

                if (YourNumber < secret)

                {
                    Console.WriteLine("Your number is too small");

                }

                else if (YourNumber > secret)
                {
                    Console.WriteLine("Your number is too big");
                }

                Console.WriteLine(counter + " Write your number ");
                counter++; // er inde i løkken og tæller dermed op gen.
                YourNumber = double.Parse(Console.ReadLine());

                if (counter > 10)
                {
                    Console.WriteLine("You are horrible");
                }
                else
                {
                    Console.WriteLine("keep trying");

                }

            }

            Console.WriteLine("Correct number");
            Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 


            if (counter > 10)
            {
                Console.WriteLine("You are horrible");
            }
            else
            {
                Console.WriteLine("keep trying");

            }
        }
        public static void PORTO()
        {
            //        Du skal skrive et lille program som kan finde portoen for et brev.Som input til programmet '
            //skal være brevets størrelse, vægt og hvilket land brevet skal sendes til og outputtet skal 
            //være den pågældende pris / porto.

            //Du kan finde mere http://www.postnord.dk

            //Udvid dit program til også at håndtere pakker.
            Console.WriteLine("Type ");
            string type = (Console.ReadLine());
            if (type == "Letter")
            {
                {
                    Console.WriteLine("Size of letter ");
                    double SizeLetter = double.Parse(Console.ReadLine());
                    if (SizeLetter <= 1)
                    {
                        Console.WriteLine("Priceclass 1");
                    }
                    else if (SizeLetter > 1 && SizeLetter <= 2)
                    {
                        Console.WriteLine("Priceclass 2");
                    }
                    else if (SizeLetter > 2 && SizeLetter <= 3)
                    {
                        Console.WriteLine("Priceclass 3");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                {
                    Console.WriteLine("Weight of letter ");
                    double WeightLetter = double.Parse(Console.ReadLine());
                    if (WeightLetter <= 50)
                    {
                        Console.WriteLine("The price is 10 kr.");
                    }
                    else if (WeightLetter > 50 && WeightLetter <= 100)
                    {
                        Console.WriteLine("The price is 20 kr.");
                    }
                    else if (WeightLetter > 100 && WeightLetter <= 150)
                    {
                        Console.WriteLine("The price is 40 kr.");
                    }
                    else
                    {
                        Console.WriteLine("Expensive");
                    }
                }
                {
                    Console.WriteLine("Country ");
                    string Country = (Console.ReadLine());
                    if (Country == "Denmark")
                    {
                        Console.WriteLine("Max 160 kr.");
                    }
                    else if (Country == "Bermuda")
                    {
                        Console.WriteLine("Max 1645 kr.");
                    }
                    else if (Country == "Belize")
                    {
                        Console.WriteLine("Max 1645 kr.");
                    }
                    else
                    {
                        Console.WriteLine("Not a walid country");
                    }
                }

            }

            else if (type == "pakke")
            {

                {
                    Console.WriteLine("Size of packed ");
                    double SizePacked = double.Parse(Console.ReadLine());
                    if (SizePacked <= 1)
                    {
                        Console.WriteLine("Priceclass 1");
                    }
                    else if (SizePacked > 1 && SizePacked <= 2)
                    {
                        Console.WriteLine("Priceclass 2");
                    }
                    else if (SizePacked > 2 && SizePacked <= 3)
                    {
                        Console.WriteLine("Priceclass 3");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                {
                    Console.WriteLine("Weight of packed ");
                    double WeightPacked = double.Parse(Console.ReadLine());
                    if (WeightPacked <= 50)
                    {
                        Console.WriteLine("The price is 10 kr.");
                    }
                    else if (WeightPacked > 50 && WeightPacked <= 100)
                    {
                        Console.WriteLine("The price is 20 kr.");
                    }
                    else if (WeightPacked > 100 && WeightPacked <= 150)
                    {
                        Console.WriteLine("The price is 40 kr.");
                    }
                    else
                    {
                        Console.WriteLine("Expensive");
                    }
                }
                {
                    Console.WriteLine("Country ");
                    string Country = (Console.ReadLine());
                    if (Country == "Denmark")
                    {
                        Console.WriteLine("Max 160 kr.");
                    }
                    else if (Country == "Bermuda")
                    {
                        Console.WriteLine("Max 1645 kr.");
                    }
                    else if (Country == "Belize")
                    {
                        Console.WriteLine("Max 1645 kr.");
                    }
                    else
                    {
                        Console.WriteLine("Not a walid country");
                    }


                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
            
            public static void morsekode()
            {
            // her bruger jeg SWICH 
                //Skriv et lille program, som indlæser en tekst fra konsolvinduet og som via en 
                //switch ”konverterer” det indtastede til morsekode.
                  Console.WriteLine("Indtast den tekst du ønsker at få oversat til morsekode");
                
                //al tekst indtastet af en bruger læses over i variablen text
                string text = Console.ReadLine();
               
                //konverterer text variablen til char array,
                //så vi kan få fat i hvert tegn i teksten
                char[] chararray = text.ToCharArray();

                //Ved at bruge en for-løkke kan der loopes igennem alle elementerne i arrayet
                for (int i = 0; i < chararray.Length; i++)
                {
                
                switch (chararray[i])
                {
                    case 'a':
                        Console.Write(" .-");
                        break;
                    case 'b':
                        Console.Write(" -...");
                        break;
                    //udfyld selv resten
                    default:
                        Console.Write(" ");
                        break;
                
                }

            }
            Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 



        }
        }
}





