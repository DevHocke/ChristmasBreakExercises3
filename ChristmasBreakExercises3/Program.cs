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
        //static void Main(string[] args)
        //{
        //    List<string> myList = new List<string>();
        //    bool keepGoing = false;

        //    do
        //    {
        //        Console.WriteLine("Skriv ett namn: ");
        //        Console.WriteLine("Tryck på enter utan att skriva ett namn om du vill avsluta programmet");
        //        string name = Console.ReadLine();
        //        Console.Clear();

        //        if (name.Length == 0)
        //        {
        //            keepGoing = false;
        //            Console.WriteLine("Du lade till dessa namn i listan: ");
        //        }
        //        else
        //        {
        //            keepGoing = true;
        //            myList.Add(name);
        //        }

        //    } while (keepGoing == true);
        //    foreach (var item in myList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}
        //----------------------------------------------------------------------------------------------------------

        //13. Skapa ett program som frågar användaren efter ett heltal.
        //14. Skriv sedan en loop som sparar det talets gångertabell(1 till 10) i en array.
        //15. Skriv sedan ut arrayen till consollen.

        //static void Main(string[] args)
        //{
        //    int[] numbers = new int[10];
        //    Console.WriteLine("Skriv ett heltal");
        //    int numbIn = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = numbIn * (i + 1);
        //    }
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}



        //----------------------------------------------------------------------------------------------------------
        //16. Skapa ett program som ber användaren mata in sitt namn.
        //17. Använd sedan en loop för att spara namnet baklänges i en lista. 
        //18. Se till så att första bokstaven i det nya namnet är storbokstav och de andra bokstäverna är små. 
        //19. Skriv ut det nya namnet.
        //Exempel: Robin blir Nibor

        static void Main(string[] args)
        {
            List<char> reversed = new List<char>();
            Console.WriteLine("Skriv ditt namn");
            string name = Console.ReadLine();
            char[] stringToChar = name.ToCharArray();

            Array.Reverse(stringToChar);

            for (int i = 0; i < stringToChar.Length; i++)
            {
                if (i == 0)
                {
                    reversed.Add(char.ToUpper(stringToChar[i]));
                }
                else if (i == stringToChar.Length - 1)
                {
                    reversed.Add(Char.ToLower(stringToChar[i]));
                }
                else
                {
                    reversed.Add(stringToChar[i]);
                }
            }
            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }



        //static void Main(string[] args)
        //{
        //    List<char> backwards = new List<char>();
        //    Console.WriteLine("Skriv ditt namn: ");
        //    string nameIn = Console.ReadLine();
        //    char[] stringToChar = nameIn.ToCharArray();
        //    Array.Reverse(stringToChar);


        //    for (int i = 0; i < stringToChar.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            backwards.Add(char.ToUpper(stringToChar[i]));
        //        }
        //        else if (i == stringToChar.Length - 1)
        //        {
        //            backwards.Add(char.ToLower(stringToChar[i]));
        //        }
        //        else 
        //        {
        //            backwards.Add(stringToChar[i]);
        //        }
        //    }

        //    foreach (var item in backwards)
        //    {
        //        Console.Write($"{item}");
        //    }     

        //    Console.ReadLine();
        //}

        //------------------------------------------------------------------------------------------------------------------

        //En mer avancerad uppgift att ge till er som vill ha en liten utmaning: 
        //20. Skapa ett program som ber användaren mata in en sträng.
        //21. Loopa över varje char i strängen och om tecknet är en konsonant.Skriv ut konsonanten följt av ett o och sedan kononanten igen.Annars skriv bara ut tecknet.
        //Exempel: Hej.Net20D blir Hohejoj.Nonetot20Dod
        //https://sv.wikipedia.org/wiki/Rövarspråket 

        //Hint 1: Man kan kolla om ett tecken är en bokstav med hjälp av Char.IsLetter()
        //Hint 2: Skapa en array som innehåller vokaler och använd en loop för kolla om tecknet inte är en vokal.  

        //static void Main(string[] args)
        //{

        //}


    }
}
