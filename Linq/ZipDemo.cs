using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTips
{
    /// <summary>
    /// Demonstrates how to merge Ienumerable Sequences with LINQ
    /// </summary>
    public class ZipDemo : IRunableProgram
    {
        /*  
         The Zip method allows the joining together of IEnumerable sequences by interleaving the
         elements in the sequences.
         Zip is an extension method on IEnumerable.
         */

        public void Run()
        {
            var names = new[] { "David", "Lisa", "Amanda" };

            var ages = new[] { 23, 34, 65 };
            
            //Generates an IEnumerable of String
            var namesandAges = names.Zip(ages, (name, age) => name + " " + age);
            foreach (var item in namesandAges)
            {
                Console.WriteLine(item);
            }

            //Generates an IEnuerable of two element Tuples
            var namesandAgesTuple = names.Zip(ages, (name, age) => Tuple.Create(name,age));
            foreach (var item in namesandAgesTuple)
            {
                Console.WriteLine(item);
            }
        }
    }
}
