using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace CodeContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertStringToInteger("");
        }

        public static int ConvertStringToInteger(string input)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(input));
            return 0;
        }
    }
}
