using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoeeAmzaleg_HWS_Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator simple = new SimpleCalculator();
            AtomicCalculator calculator = new AtomicCalculator(simple.NumberGetter, simple.PrintMenu, simple.GetUserChoice, simple.Calculate, simple.PrintResultNicely);
            //AtomicCalculator calculator = new AtomicCalculator(simple.NumberGetter, simple.PrintMenu ,simple.GetUserChoice, simple.Calculate, simple.PrintResultNicelyWithLambda);
            calculator.Run();
        }
    }

}
