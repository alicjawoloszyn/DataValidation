using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string numberToValidate;

            IInputValidator inputValidator = new InputValidator()
            {
                Number = 5
            };
            //int[] numberArray = new int[3];

            List<int> numberList = new List<int>();
            try
            {


                for (int i = 0; i < 3; i++)
                {
                    numberToValidate = Console.ReadLine();
                    //number = inputValidator.Validate(numberToValidate)
                    //    ? number = int.Parse(numberToValidate) 
                    //    : 0;

                    if (inputValidator.Validate(numberToValidate))
                    {
                        number = int.Parse(numberToValidate);   //jezeli sie powiedzie
                    }
                    else
                    {
                        throw new ArgumentException();  //jezeli sie nie powiedzie
                    }
                    numberList.Add(number);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("To nie jest liczba!");
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
