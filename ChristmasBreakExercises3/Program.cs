using System;
using System.Collections.Generic;
using System.Linq;

namespace ChristmasBreakExercises3
{
    class Program
    {
        //1.  Skapa ett program som innehåller en array som har plats för tre nummer
        //2.  Fyll arrayen nummer.T.ex. 5, 7 och 2
        //3.  Skapa en int i som du sätter till noll.
        //4.  Skriv en while-loop körs så länge i är mindre än arrayens längd(Length), och öka i med 1 varje steg i loopen.
        //5.  I while-loopen skriv ut numret på den i:te positionen i arrayen.  
        //static void Main(string[] args)
        //{
        //    int[] myArray = new int[3] {5, 7, 2 };
        //    int i = 0;

        //    while (i < myArray.Length)
        //    {
        //        Console.WriteLine($"{i}. {myArray[i]}");
        //        i++;
        //    }
        //    Console.ReadLine();
        //}
        //----------------------------------------------------------------------------------------------------------------
        
        //6.  Skapa ett program som innehåller en lista för strängar.
        //7.  Lägg till en bool keepGoing som du sätter till false. 
        //8.  Skriv en do-while loop som har keepGoing booleanen som villkor.
        //9.  Be användaren mata in ett namn i do-while loopen.
        //10. Om användarens inmatning är en tom sträng(antingen genom att kolla om strängens längd är noll eller genom att kolla om den är lika med "") sätt sätt keepGoing till false
        //11. Annars sätt keepGoing till true och spara namnet till listan.
        //12. Skriv ut listan med namn.
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            bool keepGoing = false;

            do
            {
                Console.WriteLine("Skriv ett namn: ");
                Console.WriteLine("Tryck på enter utan att skriva ett namn om du vill avsluta programmet");
                string name = Console.ReadLine();
                Console.Clear();

                if (name.Length == 0)
                {
                    keepGoing = false;
                    Console.WriteLine("Du lade till dessa namn i listan: ");
                }
                else
                {
                    keepGoing = true;
                    myList.Add(name);
                }

            } while (keepGoing == true);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
