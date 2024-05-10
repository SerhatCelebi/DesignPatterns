using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

public abstract class DenemeBase(string name2)
    {
        public abstract string name { get; set; }
        public void Doit(string name2)
        {
            Console.WriteLine("Name");
        }
}
}
