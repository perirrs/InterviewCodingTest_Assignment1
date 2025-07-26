using System;
using System.ComponentModel.Design;

public class Algorithms
{
    public string BMIAlgorithm(double Height, double Weight)
    {
        string BMIResults;
        double HeightinMts = (Height * 0.01);
        double BMIValue = Weight / Math.Pow(HeightinMts, 2);
        BMIValue = Math.Round(BMIValue, 1); // incase we need to redefine the logic to 2 decimals
        if (BMIValue < 18.5)
        {
            BMIResults = BMIValue.ToString() + "\n Underweight = <18.5";
            return BMIResults;
        }
        else if (BMIValue >= 18.5 && BMIValue <= 24.9)
        {
            BMIResults = BMIValue.ToString() + "\n Normal weight = 18.5–24.9";
            return BMIResults;
        }
        else if (BMIValue >= 25.0 && BMIValue <= 29.9)
        {
            BMIResults = BMIValue.ToString() + "\n Overweight = 25–29.9";
            return BMIResults;
        }
        else if (BMIValue > 29.9)
        {
            BMIResults = BMIValue.ToString() + " \n Obesity = BMI of 30 or greater";
            return BMIResults;
        }
        else
        {
            BMIResults = "There is a problem with the application, please contact support ";
            return BMIResults;
        }

    }
}