using System;
using System.Collections.Generic;

namespace MyDemoLibrary
{
    public class Calculator
    {
        private List<int> numbers;

        public Calculator()
        {
            numbers = new List<int>();
        }

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }
    }
}