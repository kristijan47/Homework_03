using System;

namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 01

            //            EXERCISE 01:

            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1



            //Console.Write("Enter a Number: ");
            //string inputNumber = Console.ReadLine();
            //int num;
            //bool parsedInput = int.TryParse(inputNumber, out num);
            //if (parsedInput == false)
            //    Console.WriteLine("Invalid Input");


            //Console.WriteLine("Enter a another number please: " +
            //    "");
            //string secondInput = Console.ReadLine();
            //int numberTwo;
            //bool secondParsedInput = int.TryParse(secondInput, out numberTwo);
            //if (secondParsedInput == false)
            //    Console.WriteLine("Invalid Input");


            //else
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    for (int i = numberTwo - 1; i >= 0; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Exercise 02
            //            EXERCISE 02:

            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1

            //Console.WriteLine("Enter a number");
            //var inputNumber02 = Console.ReadLine();
            //int numbers;
            //bool parsedNumbers2 = int.TryParse(inputNumber02, out numbers);
            //for (int i = 0; i < numbers; i++)
            //{
            //    if (i % 2 == 0)
            //    {

            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("Enter a second number");
            //var inputNumber03 = Console.ReadLine();
            //int numbers2;
            //bool parsedNumbers3 = int.TryParse(inputNumber03, out numbers2);
            //for (int i = 0; i < numbers2; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            #endregion


            #region EXERCISE 03:

            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop






            //string[] nameArray = new string[] { "Eric", "Stan", "Kyle", "Butters", "Kenny" };


            //Console.WriteLine("Please Enter A Name");

            //var counter = 0;
            //while (true)
            //{
            //    string newName = Console.ReadLine();
            //    counter++;
            //    if (newName.Length > 1)
            //    {
            //        Array.Resize(ref nameArray, nameArray.Length + 1);
            //        nameArray[nameArray.Length - 1] = newName;

            //    }

            //    Console.WriteLine("Would You Like To Enter Another Name?(Y/N)");


            // Tuka samo me machi zasto nekogas dvapati treba da stisnam N za da se prekine i da gi dade site iminja. Probav da go stavam ReadLine i pogore 
            // no vaka najubavo izleguvase

            //    if (newName.ToUpper()== "Y")
            //    {

            //        continue;
            //    }
            //    else if (newName.ToUpper() == "N")
            //    {
            //        foreach (var name in nameArray)
            //        {
            //            Console.WriteLine(name);
            //        }
            //        break;
            //    }
            //    Console.ReadLine();

            //}



            #endregion
        }
    }
    }
