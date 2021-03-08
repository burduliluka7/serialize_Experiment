using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace serialize_Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 klas = new Class1(434, "Luka", "Burduli", 16);
            Console.WriteLine("Hello World!");
            Console.WriteLine(klas.GetInfo());



        }
    }
}
