using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class InputValidator : IInputValidator
    {
        public int Number { get; set; } 

        public InputValidator()
        {

        }

        public InputValidator(int number)
        {
            Number = number;
        }

        public bool Validate(string input)
        {
            return int.TryParse(input, out int result);
        }
    }
}
