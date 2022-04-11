using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Delegates
{
    internal class AtomicCalculator
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int OperatorType { get; set; }
        public double Result { get; set; }


        public Func<int> GetNumberFromUser { get; set; }
        public Action<int> MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<int, int, int, double> ResultPrinter { get; set; }
        public AtomicCalculator(Func<int> getNumberFromUser, Action<int> menuPrinter, Func<int> getUserChoice,
                                Func<int, int, int, double> calculate, Action<int, int, int, double> resultPrinter)
        {
            GetNumberFromUser+=getNumberFromUser;
            MenuPrinter+=menuPrinter;
            GetUserChoice+=getUserChoice;
            Calculate+=calculate;
            ResultPrinter+=resultPrinter;
        }
        public void Run()
        {
            X = GetNumberFromUser();
            Y = GetNumberFromUser();
            MenuPrinter(1);
            OperatorType = GetUserChoice();
            Result = Calculate(X, Y, OperatorType);
            ResultPrinter(X, Y, OperatorType, Result);
        }

    }
}
