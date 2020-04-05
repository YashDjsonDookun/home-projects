using System;
using System.Collections.Generic;
using System.Text;

namespace TestSimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumber(String argTextInput)
        {
            double convertedNumber;

            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a Numeric Value.");
            }
            return convertedNumber;
        }
    }
}
