using System;
using System.Collections.Generic;
using System.Text;

namespace OvningNr4
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {


            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                  
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

      

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            Console.WriteLine("Welcome to to Examine a List menu");
            Console.WriteLine("Please Add to the list by pressing '+' follewd by the name you wish to add");
            Console.WriteLine("Please Add to the list by pressing '-' follewd by the name you wish to remove");
            Console.WriteLine("Please type Exit to ");
            List<string> theList = new List<string>();
            bool exit = false;
            string input;
            do
            {

                input = Console.ReadLine();
                string value = input.Substring(1);

                string close = "Exit";
                char nav = input[0];
                if (input.Equals(close, StringComparison.OrdinalIgnoreCase)) break;


                switch (nav)
                {
                    case '+':
                        theList.Add(value);

                        break;

                    case '-':
                        theList.Remove(value);
                        break;
                    default:
                        exit = false;
                        Console.WriteLine("Please start with either '+' to add or '-' to remove");
                        break;
                }
            }
            while (!exit);
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"The list's capasity is {theList.Capacity}");
            Console.WriteLine($"the list has {theList.Count} items");
            #region Övning1Frågorna
            /*
             * 2-3: Listans kapasitet böjrar med värdet "0". den ökar precis när man läggar till
             * en elemnt i det. Kapaciteten blir 4 när man läggar 4 eller mindre elementer i listan
             * när listans count blir mer än kapsiteten skaps en ny underliggande array som
             * har ett värde dubbelt så stor som första underliggande arrayens värde.
             * dvs 4 - 8 -16 - 32 ..osv.
             *  
             *  4: kapasiteten behöver inte ökas så länge count:en är mindre eller likamed kapasiteten.
             *  5: Nej
             *  6: det är fördelaktigt att använda Arrays istället för listor när vi vet exakt 
             *  storleken och när vi behöver en multidemenssionell lista. generic lists 
             *  är bara en-demenssionella listor.
             */
            #endregion
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            #region FirstWay

            //Queue<string> kö = new Queue<string>();
            //kö.Enqueue("Kalle");
            //kö.Enqueue("greta");
            //kö.Dequeue();
            //kö.Enqueue("Stina");
            //kö.Dequeue();
            //kö.Enqueue("Olle");

            //bool qClear = false;
            //string qInput;
            //do
            //{
            //    Console.WriteLine("please Enqueue by typing '+' followed by name and dequeue by typing '-'");
            //    qInput = Console.ReadLine();
            //    string qValue = qInput.Substring(1);

            //    string close = "Exit";
            //    char qNav = qInput[0];
            //    if (qInput.Equals(close, StringComparison.OrdinalIgnoreCase)) break;


            //    switch (qNav)
            //    {
            //        case '+':
            //            kö.Enqueue(qValue);
            //            break;

            //        case '-':
            //            kö.Dequeue();
            //            break;
            //        default:
            //            qClear = false;
            //            Console.WriteLine("Please start with either '+' to add or '-' to remove");
            //            break;
            //    }
            //}
            //while (!qClear);
            //foreach (var item in kö)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region SecondBetterWay

            Queue<int> intKö = new Queue<int>();
            bool success = false;
            int i = intKö.Count;
            Console.WriteLine("Please enter '+' to enqueue , '-' to dequeue or 'Q' to exit");
            do
            {
                string input = Console.ReadLine();
                char nav = input[0];
                if (input.Length == 1)
                {
                    if (input == "+" || input == "-")
                    {
                        switch (nav)
                        {
                            case '+':
                                intKö.Enqueue(i);
                                i = intKö.Count;
                                Console.WriteLine($"There are {i} people in the queue");
                                break;
                            case '-':
                                try
                                {
                                    intKö.Dequeue();
                                    i = intKö.Peek();
                                    Console.WriteLine($"nubmer {i} please step forword");
                                }
                                catch (InvalidOperationException)
                                {
                                    Console.WriteLine("no one is in the queue!");
                                    Console.WriteLine("Please enter '+' to enqueue , '-' to dequeue or 'Q' to exit");
                                    success = false;
                                }
                                break;

                        }
                    }
                    else if (input == "q" || input == "Q")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter '+' , '-' or 'Q'");
                        success = false;
                    }
                }
                else if (input.Length > 1 || input.Length < 1)
                {
                    Console.WriteLine("Please enter '+' , '-' or 'Q'");
                    success = false;
                }
            }
            while (!success);
            #endregion

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            #region Övning3Fråga
            /* F1: Det är inte smart att använda stacken i det här fallet för att stack är 
             *först in sist out så i det här fallet kommer första kunden hanteras sist 
             * ingen förklaring behövs till att varför den första kommande kund inte bör hanteras sist :D
             */
            #endregion

            Stack<string> reversWords = new Stack<string>();
            bool success = false;
            Console.WriteLine("Please enter at least 2 words to get your text reversed");
            do
            {
                string input = Console.ReadLine();
                string[] sInput = input.Trim().Split(' ');

                if (sInput.Length > 1)
                {
                    success = true;
                    foreach (var word in sInput)
                    {
                        reversWords.Push(word);
                    }
                    foreach (var line in reversWords)
                    {
                        Console.Write($"{line} ");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    success = false;
                    Console.WriteLine("Please enter at leaset 2 word");
                }

            } while (!success);



        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Console.WriteLine("Please enter a sentence with paranthesis to check if they are balanced");
            if (IsBalanced() == true)
            {
                Console.WriteLine("Right input!");
            }
            else { Console.WriteLine("Wrong input!"); }


        }

        private static bool IsBalanced()
        {
            bool success = false;
            string input = Console.ReadLine();
            var paranthesisCheck = new Stack<char>();
            foreach (var characters in input)
            {
                switch (characters)
                {
                    case '(': paranthesisCheck.Push('('); break;
                    case '[': paranthesisCheck.Push('['); break;
                    case '{': paranthesisCheck.Push('{'); break;
                    case ')':
                        if (paranthesisCheck.Count == 0 || paranthesisCheck.Pop() != '(')
                        {
                            success = false;
                            break;
                        }
                        else
                        {
                            success = true;
                        }
                        break;

                    case ']':
                        if (paranthesisCheck.Count == 0 || paranthesisCheck.Pop() != '[')
                        {
                            success = false;
                            break;
                        }
                        else
                        {
                            success = true;
                        }
                        break;
                    case '}':
                        if (paranthesisCheck.Count == 0 || paranthesisCheck.Pop() != '{')
                        {
                            success = false;
                            break;
                        }
                        else
                        {
                            success = true;
                        }
                        break;
                }
                if (paranthesisCheck.Count != 0)
                {
                    success = false;
                }

            }

            return success;
        }

    }
}
#region SvarPåFrågorna
#region Fråga1

// F:1
//  * a. Stack är en linjär datastruktur medan Heap är en hierarkisk datastruktur. 
//  * b. Stack får endast åtkomst till lokala variabler 
//  *    medan Heap låter dig komma åt variabler överallt.
//  * c. Stackallokering och deallocation görs av kompilatorinstruktioner medan 
//  *  Heapallokering och deallocation görs av programmeraren. ToDo : change: garbage collector
/* Ex:
 *      public static int AskForInteger()
        {
            int choise;
        // code .. 
}           
    choise här lagras i stacken för att den är instansierad i en metod och den kan nås bara 
    i den här metoden dvs att de {}:erna är ett skåp i stacken som körs när metoden i anroppat
    och efter metoden körs så kastas den - choise-  från stacken
            * Medan följande choise är en variable som kan nås överallt 
            * class WhatEver
            * {
            * public/private int choise = whatever;
            * }
            * 
 * 
  */
#endregion
#region Fraga2
/* En variabel av value type innehåller en instans av typen
 * medan en variabel av reference type innehåller en referens till en instans av typen.
 * dvs Variabler av reference type lagrar referenser till sina data (objekt)
 * medan variabler av value type direkt innehåller sina data
 * i reference type kan 2 eller mer refernser vara instanser till samma objekt
 * och de påverkar varandras värde.
 * medan i value type varje objekt har sitt eget värde och kan inte påverkas av 
 * en annan instans.
 * 
 */
#endregion
#region Fråga3
/*i den första metoden datatypen av x och y är av value type (int) och tilldelningen y = x; ändrar 
 * bara värdet av variabeln y för att här körs det i stacken " linjär " 
 * medan i den andra metoden så datatypen av variablerna x och y är reference type (MyInt)
 * och de ligger i heapen.  x och y i den här metoden är både referenser till samma objekt (MyInt)
 * och därför tildelningen y = x; i den här metoden påverkar både x och y.
 * 
 */
#endregion

#endregion
