using System;
using System.Collections.Generic;
using System.Linq;

namespace LexiconCalculator
{
    public class CalculatorProgram
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;
            double num1, num2, result;
            string selectedOption;

            while (continueCalculating)
            {
                selectedOption = DisplayAndCheckCalculationOptions();

                if (selectedOption != "q")
                {
                    if(selectedOption != "++" && selectedOption != "--")
                    {
                        num1 = EnterANumber(true);
                        num2 = EnterANumber(false);
                        result = PerformSelectedCalculationOnNumbers(selectedOption, num1, num2);
                    }
                    else
                    {
                        double[] numbersArray = EnterAnArrayOfNumbers();
                        result = PerformSelectedCalculationOnNumbersFromArray(selectedOption, numbersArray);
                    }
                    
                    Console.WriteLine($"The result is: {result}. {Environment.NewLine}Press enter to countinue.");
                    Console.ReadLine();
                }
                else
                {
                    continueCalculating = false;
                }
            }
            Console.WriteLine("Application has stopped.");
        }

        

        private static double PerformSelectedCalculationOnNumbers(string selectedOption, double num1, double num2)
        {
            double result = 0;

            switch (selectedOption)
            {
                case "+":
                    result = Addition(num1, num2);
                    break;
                case "-":
                    result = Substraction(num1, num2);
                    break;
                case "*":
                    result = Multiplication(num1, num2);
                    break;
                case "/":
                    result = Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Something went wrong.");
                    break;
            }
            return result;
        }

        private static double PerformSelectedCalculationOnNumbersFromArray(string selectedOption, double[] numbersArray)
        {
            double result = 0;

            switch (selectedOption)
            {
                case "++":
                    result = AdditionWithArray(numbersArray);
                    break;
                case "--":
                    result = SubstractionWithArray(numbersArray);
                    break;
                default:
                    Console.WriteLine("Something went wrong.");
                    break;
            }
            return result;
        }

        public static double Addition(double num1, double num2) => Math.Round(num1 + num2, 2);

        public static double AdditionWithArray(double[] arrayOfNumbers) => Math.Round(arrayOfNumbers.Sum(), 2);

        public static double Substraction(double num1, double num2) => Math.Round(num1 - num2, 2);

        public static double SubstractionWithArray(double[] arrayOfNumbers)
        {
            if (arrayOfNumbers.Length < 2)
            {
                Console.WriteLine("Number of inputs were less than two, result will be set to 0");
                return 0;
            }
            return Math.Round(arrayOfNumbers[0] - arrayOfNumbers.Skip(1).Sum(), 2);
        }
        
        public static double Multiplication(double num1, double num2) => Math.Round(num1 * num2, 2);

        public static double Division(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Division by Zero is not allowed, result will be set to 0.");
                return 0;
            }
            return Math.Round(num1 / num2, 2);
        }

        private static double EnterANumber(bool isFirstNumber)
        {
            string firstOrSecondNum = isFirstNumber ? "first" : "second";
            Console.Write($"Enter your {firstOrSecondNum} number: ");
            string enteredNum = Console.ReadLine();
            double enteredNumToDouble;

            if (!double.TryParse(enteredNum, out enteredNumToDouble))
            {
                Console.WriteLine("Input was not a valid number.");
                enteredNumToDouble = EnterANumber(isFirstNumber);
            }
            return enteredNumToDouble;

        }


        private static double[] EnterAnArrayOfNumbers()
        {
            Console.Write($"Enter your numbers: ");
            string[] enteredNumbers = Console.ReadLine().Split(' ');
            List<double> parsedNumbers = new List<double>();

            foreach (var strItem in enteredNumbers)
            {
                if (double.TryParse(strItem, out double aRealNumber))
                    parsedNumbers.Add(aRealNumber);
            }
            return parsedNumbers.ToArray();
        }


        private static string DisplayAndCheckCalculationOptions()
        {
            Console.Clear();
            Console.Write("Welcome to the Calculator application, select type of mathematical operattion." + Environment.NewLine
                + "For addition enter: + " + Environment.NewLine
                + "For addition of multiple inline numbers enter: ++ " + Environment.NewLine
                + "For substracion enter: - " + Environment.NewLine
                + "For substraction of multiple inline numbers enter --, the result is the first number substracted by the subsequent numbers." + Environment.NewLine
                + "For multiplication enter: * " + Environment.NewLine
                + "For division enter: / " + Environment.NewLine
                + "To quit application enter: q " + Environment.NewLine);

            string selOpt = Console.ReadLine();

            if (selOpt != "+" && selOpt != "++" && selOpt != "-" && selOpt != "--" && selOpt != "*" && selOpt != "/" && selOpt != "q")
            {
                Console.Write("Entered character is not a valid selection." + Environment.NewLine
                   + "Press enter to select again.");
                Console.ReadLine();
                selOpt = DisplayAndCheckCalculationOptions();
            }
            
            return selOpt;
            
        }
    }
}
