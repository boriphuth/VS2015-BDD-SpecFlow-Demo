using System;
using System.Collections.Generic;

namespace MyDemoLibrary
{
    public class Calculator
    {
        private List<int> numbers;
        public int Total { get; private set; }

        public Calculator()
        {
            numbers = new List<int>();
        }

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public void DoCalculate()
        {
            Total = 0;
            foreach (int number in numbers)
            {
                Total += number;
            }
        }
    }
}