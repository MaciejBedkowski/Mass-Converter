using System;
using MassConverterLibrary;

namespace MassConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            string convertType;
            string input;
            double mass;
            double result;

            Console.WriteLine("Enter You're mass number:");
            input = Console.ReadLine();

            if (!Double.TryParse(input, out mass))
                throw new Exception("Incorrect weight entered!");

            Console.WriteLine("grams - g");
            Console.WriteLine("pound - lbs");
            Console.WriteLine("ounce - oz");
            Console.WriteLine("miligram - mg");
            Console.WriteLine("Enter You're type of mass:");
            type = Console.ReadLine();

            Console.WriteLine("grams - g");
            Console.WriteLine("pound - lbs");
            Console.WriteLine("ounce - oz");
            Console.WriteLine("miligram - mg");
            Console.WriteLine("To what convert:");
            convertType = Console.ReadLine();

            Console.Clear();

            var massVariable = new MassVariable(mass);
            result = massVariable.ConvertMass(type, convertType);
            Console.WriteLine(@"{0}{1} = {2}{3}", mass, type, result, convertType);
            
        }
    }
}
