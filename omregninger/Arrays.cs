using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace omregninger
{
    public class Arrays
    {
        //public static void ARRAY1()
        //{
        //    //            Lav et array med plads til 9 elementer.Indsæt tallene 1-9 ved hjælp af en løkke.

        //    //-	Find tallet på index plads nr. 5 vha en løkke

        //    //-	Ændr dette element så det indeholder den dobbelte værdi af den forrige

        //    int[] numbers = new int[9];

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = i;
        //        Console.WriteLine(numbers[i]);

        //        Console.WriteLine(numbers[5]);
        //        Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
        //        Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker.
        //    }
        //}

        //public static void ARRAYS()
        //{
        //    //            Øvelse 1
        //    //Skriv en applikation program, som prompter en bruger for brugernavn og password.
        //    //•	Hvis brugeren er kendt, skal der spørges om password.
        //    //•	Hvis brugeren ikke er kendt, skal der gives en meddelelse om at brugeren ikke har adgang til systemet.
        //    //•	Password må kun forsøges 3 gange, herefter afsluttes.
        //    //•	Programmet skal kunne håndtere mindst 5 brugere med tilhørende password.
        //    //•	Brugere skal oprettes i et array.
        //    //Tip: lav evt.et array til brugernavne og et array til passwords og tjek på index
        //    string[] names = new string[5] { "Liza", "Ireen", "Sasha", "Jo", "Mario" };

        //    int[] passwords = new int[5] { 123, 456, 789, 101, 112 };

        //    Console.WriteLine("What is you name:  ");
        //    string CostumerName = (Console.ReadLine());

        //    for (int i = 0; i < 5; i++)
        //    {
        //        if (CostumerName == names[i])
        //        {
        //            for (int j = 0; j < 3; j++) //jeg har 3 forsøg til at logge ind, derfor denne linje
        //            {
        //                Console.WriteLine("Write your password: ");
        //                int CostumerPassword = int.Parse(Console.ReadLine());
        //                if (CostumerPassword == passwords[i]) // i tjekker hvilken plads det ligger på således at
        //                                                      //Liza har koden 123 osv. 
        //                {
        //                    Console.WriteLine("you typed the right password, you used " + j + "attemps");
        //                }
        //                else

        //                {
        //                    Console.WriteLine("You are not in the system");
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are not in the system");


        //        }
        //    }
        //}
        ////public static void ARRAYSOGBUBBLESORT()
        ////{
        ////    //            Opgave a) – Oprettelse af et array og tildeling af tilfældig værdi
        ////    //1. Opret et array med plads til 100 elementer.
        ////    //int[] tal = new int[100];
        ////    int[] elementer = new int[100];

        ////    //            2.Nu skal der indsættes tilfældige tal i arrayet på alle pladser, dette kan gøres 
        ////    //ved at bruge en forløkke, i stedet for 100 gange at indsætte et tal i arrayet.
        ////    //En for-løkke kræver en start - og en stopværdi for at kunne køre.Start værdien i denne løkke kan
        ////    //passende være 0, da et array jo altid starter på index 0.Stopværdien er 99, da der startes med 0.
        ////    //Det er rigtig usmart at skrive 99 som stopværdi en for-løkke, for hvis vi vil ændre på arrayets
        ////    //størrelse skal vi rette mange steder i vores kode, derfor at det smartere at bruge den indbyggede
        ////    //Length metode, der findes på et array.
        ////    //for (int i = 0; i < tal.Length; i++)
        ////    //{
        ////    //    //Her skal der indsættes tilfældige tal
        ////    //    //for alle elementer i arrayet
        ////    //}
        ////    Random random = new Random();

        ////    for (int i = 0; i < elementer.Length; i++)
        ////    {
        ////        elementer[i] = random.Next(0, 99);
        ////        Console.WriteLine(elementer[i]);

        ////    }
        ////    Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker. 
        ////    Console.ReadLine(); //gør så at jeg skal trykke enter før vinduet lukker.

        ////}
        //public static void LISTE()
        //{
        //    // Lav en liste listeB bestående af de lige tal mellem 1-20 -	
        //    //Fjern alle tal som 3 går op i -	Hvor mange elementer er der nu i listen? -	
        //    //Indsæt værdien 17 på plads nr. 3 -	Lav en ny liste der består af listeB’s elementer – 
        //    //men i omvendt rækkefølge

        //    List<int> numbers = new List<int>();

        //    for (int i = 0; i < 20-2; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            numbers.Add(i);
        //            Console.WriteLine(i);

        //        }
        //    }
        //    for (int i = 0; i< numbers.Count; i++)
        //    { 
        //        if (numbers[i] % 3 == 0)
        //        {
        //            numbers.RemoveAt(i);


        //    }
        //}
        //numbers.Insert(3, 17);
        //foreach (int i in numbers)
        //    Console.WriteLine(i);

        //List<int> reverslist = numbers;
        //reverslist.Reverse();
        //foreach (int i in reverslist)
        //    Console.WriteLine(i);
        //Console.ReadKey();

        //public static void LOTTO()
        //{
        //    //            I denne opgave skal i bruge en tilfældighedsgenerator.
        //    //Man kan genere tilfældige tal i C# vha Random klassen. Nedenstående giver et tilfældigt tal mellem 1 og 100.


        //    //Random r = new Random();

        //    //        int ran = r.Next(1, 100);

        //    //-	Lav et array der indeholder 7 tilfældige lottoTal mellem 1 og 20. Dette er vinder-kuponen.

        //    //-	Lav nu endnu et array med 7 tal der repræsenterer en brugers kupon.

        //    //-	I kan lade brugeren indtaste de 7 tal, eller i kan ”hardcode” brugerens kupon. 

        //    //-	Undersøg hvor mange rigtige tal der er på brugerens kupon, og udbetal forskellige gevinster 
        //    //på kuponer der har mere end to rigtige.


        //    int[] kupon = new int[7];
        //    Random r = new Random();
        //    int ran = r.Next(1, 20);
        //    for (int i = 0; i <= 6; i++) //laver en løkke der sætter et tal ind på de 7 pladser i arrayet.
        //    {
        //        kupon[i] = r.Next(1, 20); //denne sørger for at det er tilfældige tal der bliver sat ind i arrayet.
        //    }
        //    for (int i = 0; i <= 6; i++)
        //    {
        //        Console.WriteLine(kupon[i]);
        //    }
        //    int[] userkupon = new int[7];

        //    for (int i = 0; i <= 6; i++)
        //    {
        //        Console.WriteLine("Type in your numbers for your kupon " + i);
        //        userkupon[i] = int.Parse(Console.ReadLine());

        //    }

        //    for (int i = 0; i <= 6; i++)
        //    {
        //        if (userkupon[i] == kupon[i]) //så sammenligner den alle pladser i begge arrays.
        //        {
        //            Console.WriteLine("Winner");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Looser");
        //        }
        //    }
        //    Console.ReadKey();
        //}

        static public void MOZART()
        {
            int[,] trio = new int[6, 16] 
            {
            {72, 6, 59, 25, 81, 41, 89, 13, 36, 5, 46, 79, 30, 95, 19, 66},
            {56, 82, 42, 74, 14, 7, 26, 71, 76, 20, 64, 84, 8, 35, 47, 88},
            {75, 39, 54, 1, 65, 43, 15, 80, 9, 34, 93, 48, 69, 58, 90, 21},
            {40, 73, 16, 68, 29, 55, 2, 61, 22, 67, 49, 77, 57, 87, 33, 10},
            {83, 3, 28, 53, 37, 17, 44, 70, 63, 85, 32, 96, 12, 23, 50, 91},
            {18, 45, 62, 38, 4, 27, 52, 94, 11, 92, 24, 86, 51, 60, 78, 31},
            };
            int[] arraytrio = new int[16];
                Random r = new Random();   

            for (int i = 0; i< 16; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    int ran = r.Next(0, 6);

                    arraytrio[i] = trio[ran, i];
                    Console.WriteLine(trio[ j, i]);
                }
            }
            string[] arraySamlet = new string[32];

            for (int i_files_1 = 0; i_files_1 < 16; i_files_1++)
            {
                arraySamlet[i_files_1 + 15] = @"..\..\SolutionFolder\T" + arraytrio[i_files_1] + ".wav";
            }
     
                for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(i);
            }



            int[,] minutten = new int[11, 16]
            {
                {96, 22, 141, 41, 105, 122, 11, 30, 70, 121, 26, 9, 112, 49, 109, 14},
                {32, 6, 128, 63, 146, 46, 134, 81, 117, 39, 126, 56, 174, 18, 116, 83},
                {69, 95, 158, 13, 153, 55, 110, 24, 66, 139, 15, 132, 73, 58, 145, 79},
                {40, 17, 113, 85, 161, 2, 159, 100, 90, 176, 7, 34, 67, 160, 52, 170},
                {148, 74, 163, 45, 80, 97, 36, 107, 25, 143, 64, 125, 76, 136, 1, 93},
                {104, 157, 27, 167, 154, 68, 118, 91, 138, 71, 150, 29, 101, 162, 23, 151},
                {152, 60, 171, 53, 99, 133, 21, 127, 16, 155, 57, 175, 43, 168, 89, 172},
                {119, 84, 114, 50, 140, 86, 169, 94, 120, 88, 48, 166, 51, 115, 72, 111},
                {98, 142, 42, 156, 75, 129, 62, 23, 65, 77, 19, 82, 137, 38, 149, 8},
                {3, 87, 165, 61, 135, 47, 147, 33, 102, 4, 31, 164, 144, 59, 173, 78},
                {53, 130, 10 ,103, 28, 37, 106, 5, 35, 20, 108, 92, 12, 124, 44, 131}
            };
        for(int k = 0; k< 11; k++)
            {
                for (int l = 0; l <= 15; l++)
                {
                    //Console.WriteLine(minutten[l, k]);
                }
            
            }

            for (int i_files_2 = 0; i_files_2 < 16; i_files_2++)
            {
                arraySamlet[i_files_2] = @"..\..\SolutionFolder\M" + arraySamlet[i_files_2] + ".wav";
            }
            for (int i = 0; i < 16; i++)
                {
                    Console.WriteLine(i);
                }

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            foreach (string musicelement in arraySamlet)

            {

                sp.SoundLocation = musicelement;

                sp.Load();

                sp.PlaySync();

            }
        }



    }
    }

