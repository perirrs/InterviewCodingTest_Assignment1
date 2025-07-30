using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BMIResult
    {
        public double BMI { get; set; }
        public string Result { get; set; }
    }

    public class BMIInput
    {
        public double WeightinKgs { get; set; }
        public double HeightinMts { get; set; }
    }
    public class BMIAlgorithm : IAlgorithm<BMIInput, BMIResult> //googled the syntax
    {
        public BMIResult RunAlgorithm(BMIInput input)
        {
            input.HeightinMts = (input.HeightinMts * 0.01);
            double BMIValue = input.WeightinKgs / Math.Pow(input.HeightinMts, 2);
            BMIValue = Math.Round(BMIValue, 1); // incase we need to redefine the logic to 2 decimals

            string category;

            if (BMIValue < 18.5)
            {
                category = " Underweight = <18.5";
            }
            else if (BMIValue >= 18.5 && BMIValue <= 24.9)
            {
                category = " Normal weight = 18.5–24.9";
            }
            else if (BMIValue >= 25.0 && BMIValue <= 29.9)
            {
                category = " Overweight = 25–29.9";
            }
            else if (BMIValue > 29.9)
            {
                category = " Obesity = BMI of 30 or greater";
            }
            else
            {
                category = "There is a problem with the application, please contact support ";
            }
            return new BMIResult { BMI = BMIValue, Result = category };

        }

    }
}

