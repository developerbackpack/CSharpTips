using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTips
{
    class Program
    {
        static void Main(string[] args)
        {
            IRunableProgram program = new ZipDemo();
            program.Run();

            Console.ReadKey();
        }
    }
}
