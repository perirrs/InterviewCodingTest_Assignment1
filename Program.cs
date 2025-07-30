using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Clear();
            Console.WriteLine("Please enter the Algorithm Name,Value 1 , Value 2 \n For Example : For BMI please Enter BMI,  Height in Centimeters and Weight in Kilos in the format below \n BMI, 180, 78.6");
            string[] SplitAlgorithmArguments = Console.ReadLine().Split(','); // I have googled the split syntax , I remember the keywords IndexOf and Split
            Helper help = new Helper();
            try // want to catch the exception in case the input was in a different format or any other error
            {
                help.AlgorithmName = (SplitAlgorithmArguments[0]).ToUpper(); // incase user enters small letters
                help.AlgorithmValue1 = Convert.ToDouble((SplitAlgorithmArguments[1]));
                help.AlgorithmValue2 = Convert.ToDouble((SplitAlgorithmArguments[2]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Please try again or contact support team");
                System.Environment.Exit(0);
            }

            try
            {
                switch (help.AlgorithmName)
                {
                    case "BMI":
                        var bmiAlgorithm = new BMIAlgorithm();
                        var input = new BMIInput { HeightinMts = help.AlgorithmValue1, WeightinKgs = help.AlgorithmValue2 };
                        var result = bmiAlgorithm.RunAlgorithm(input);
                        Console.WriteLine($"BMI: {result.BMI}, Category: {result.Result}");
                        break;

                    case "Algorithm2":
                        Console.WriteLine("Algorithm2 Results");
                        break;

                    case "Algorithm3":
                        Console.WriteLine("Algorithm3 Results");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Please try again or contact support team");
                System.Environment.Exit(0);
            }

        }
    }
}
