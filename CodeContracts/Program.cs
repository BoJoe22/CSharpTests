using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = null;
            Greet(input);
        }

        public static int Greet(string[] args)
        {
            Contract.Requires(args != null);
            Contract.Requires(args.Length != 0);
            Contract.Requires(args[0] != null);

            return args.Length;
        }
    }
}
