using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace AlgorithmsTest
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
                help.AlgorithmName = (SplitAlgorithmArguments[0]);
                help.AlgorithmValue1 = Convert.ToDouble((SplitAlgorithmArguments[1]));
                help.AlgorithmValue2 = Convert.ToDouble((SplitAlgorithmArguments[2]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Please try again or contact support team");
                System.Environment.Exit(0);
            }


            // Googled , if i can Dynamically input algorithm name with some appended string to form the method name , check for the method if exists and execute 
            // helpful if there are hundreds of methods to check for instead of using if / switch conditions in the algorithms

            Algorithms algorithms = new Algorithms();

            // approach 1 : googled this approach


            try
            {
                var getmethod = algorithms.GetType();
                bool DoesTheMethodExists = getmethod.GetMethod(help.AlgorithmName + "Algorithm") != null;
                if (DoesTheMethodExists == true)
                {
                    MethodInfo method = typeof(Algorithms).GetMethod(help.AlgorithmName + "Algorithm");
                    object result = method?.Invoke(algorithms, new object[] { help.AlgorithmValue1, help.AlgorithmValue2 });
                    Console.WriteLine(result);
                }
            }
            catch (Exception)
            {

                throw;
            }



            // appraoch 2
            // 
            try
            {

                if (help.AlgorithmName == "BMI")
                {
                    Console.WriteLine(algorithms.BMIAlgorithm(help.AlgorithmValue1, help.AlgorithmValue2));
                }
                else
                {
                    Console.WriteLine("Try again");
                }

            }
            catch (Exception)
            {

                throw;
            }

            // approach 3 can explore Switch / Case 

        }
    }
}
