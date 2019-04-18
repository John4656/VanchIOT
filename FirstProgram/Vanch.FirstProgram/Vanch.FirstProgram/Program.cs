using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanch.FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => Console.WriteLine("Hello VANCH"));
        }
    }
}
