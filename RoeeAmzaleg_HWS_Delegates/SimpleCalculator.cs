using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Delegates
{
    internal class SimpleCalculator
    {
        public int NumberGetter()
        {
            Console.WriteLine("type a positive number.");
            int number = int.Parse(Console.ReadLine());
            if (number <=0)
            {
                Console.WriteLine("try again...");
                NumberGetter();
            }
            return number;
        }
        public void PrintMenu(int menu)
        {
            Console.WriteLine("choose your action:\n\n1-Add 2-Substruct 3-Divide 4-Multiply");
        }
        public int GetUserChoice()
        {
            int number = int.Parse(Console.ReadLine());
            if (number <1 || number >4)
            {
                Console.WriteLine("enter only a number between 1-4");
            }
            return number;
        }
        public double Calculate(int n1, int n2, int operatorType)
        {
            double result = operatorType;
            switch (operatorType)
            {
                case 1:
                    return n1 + n2;
                case 2:
                    return n1 - n2;
                case 3:
                    return n1 / n2;
                case 4:
                    return n1 * n2;
                default:
                    break;
            }
            return result;
        }
        public void PrintResultNicely(int n1, int n2, int operatorType, double result)
        {
            string str = operatorType.ToString();
            switch (operatorType)
            {
                case 1:
                    str = "+";
                    break;
                case 2:
                    str = "-";
                    break;
                case 3:
                    str = "/";
                    break;
                case 4:
                    str = "*";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"\n*********** {n1} {str} {n2} = {result} *****************");
        }
        //print the same method with lambda
        public void PrintResultNicelyWithLambda(int n1, int n2, int operatorType, double result)
        {
            Func<int, int, int> func = null;

            string str = operatorType.ToString();
            switch (operatorType)
            {
                case 1:
                    str = "+";
                    func = (n1, n2) => n1 + n2;
                    break;
                case 2:
                    str = "-";
                    func = (n1, n2) => n1 - n2;
                    break;
                case 3:
                    str = "/";
                    func = (n1, n2) => n1 / n2;
                    break;
                case 4:
                    str = "*";
                    func = (n1, n2) => n1 * n2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"\n*********** {n1} {str} {n2} = {result} *****************");

        }

    }
}