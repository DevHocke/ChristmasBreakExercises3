using System;

namespace ChristmasBreakExercises3
{
    class Program
    {
        //1.  Skapa ett program som innehåller en array som har plats för tre nummer
        //2.  Fyll arrayen nummer.T.ex. 5, 7 och 2
        //3.  Skapa en int i som du sätter till noll.
        //4.  Skriv en while-loop körs så länge i är mindre än arrayens längd(Length), och öka i med 1 varje steg i loopen.
        //5.  I while-loopen skriv ut numret på den i:te positionen i arrayen.  
        static void Main(string[] args)
        {
            int[] myArray = new int[3] {5, 7, 2 };
            int i = 0;

            while (i < myArray.Length)
            {
                Console.WriteLine($"{i} {myArray[i]}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
