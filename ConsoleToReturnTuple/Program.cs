using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToReturnTuple
{
    class Program
    {
        static void Main(string[] args)
        {

            var tupTestTuple = Tuple.Create("hello", 1, true);
            Console.WriteLine("string: {0}", tupTestTuple.Item1);
            Console.WriteLine("int: {0}", tupTestTuple.Item2.ToString());
            Console.WriteLine("boolean: {0}", tupTestTuple.Item3.ToString());
            Console.ReadLine();

            //Comment on Test Branch
        }
    }
}
