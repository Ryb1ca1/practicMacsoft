using System;
using System.Collections.Generic;
using System.Data;
namespace smile67Kata
{
    using System;

    public class Kata
    {
        public double crazyCalculate(string input)
        {
            string crazyExpression = input
            .Replace('*', '÷')
            .Replace('/', '*')
            .Replace('÷', '/')
            .Replace('+', '−')
            .Replace('-', '+')
            .Replace('−', '-');

            var table = new DataTable();
            double result = Convert.ToDouble(table.Compute(crazyExpression, string.Empty));
            return result;
        }
    }
}