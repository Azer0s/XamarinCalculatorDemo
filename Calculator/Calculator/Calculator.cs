using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public static string Calculate(List<string> calculation)
        {
            for (var i = 0; i < calculation.Count-1; i += 2)
            {
                switch (calculation[i+1])
                {
                    case "+":
                        calculation[i + 2] =
                            decimal.Round(decimal.Parse(calculation[i]) + decimal.Parse(calculation[i + 2]), 3).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "-":
                        calculation[i + 2] =
                            decimal.Round(decimal.Parse(calculation[i]) - decimal.Parse(calculation[i + 2]), 3).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "×":
                        calculation[i + 2] =
                            decimal.Round(decimal.Parse(calculation[i]) * decimal.Parse(calculation[i + 2]),3).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "÷":
                        calculation[i + 2] =
                            decimal.Round(decimal.Parse(calculation[i]) / decimal.Parse(calculation[i + 2]), 3).ToString(CultureInfo.InvariantCulture);
                        break;
                }
            }
            return calculation.Last();
        }
    }
}
