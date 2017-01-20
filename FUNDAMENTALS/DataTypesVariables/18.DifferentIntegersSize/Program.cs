using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            string result = $"{n} can fit in:\n";
            try
            {
                var typeSbyte = sbyte.Parse(n);
                result += "* sbyte\n";
            }
            catch (OverflowException)
            {
            }
            try
            {
                var typeByte = byte.Parse(n);
                result += "* byte\n";
            }
            catch (OverflowException)
            {
            }
            try
            {
                var typeShort = short.Parse(n);
                result += "* short\n";
            }
            catch (OverflowException)
            {
            }
            try
            {
                var typeUshort = ushort.Parse(n);
                result += "* ushort\n";
            }
            catch (OverflowException)
            {
            }
            try
            {
                var typeInt = int.Parse(n);
                result += "* int\n";
            }
            catch (OverflowException)
            {
            }
            try
            {
                var typeUint = uint.Parse(n);
                result += "* uint\n";
            }
            catch (OverflowException)
            {
            }
            try
            {
                var typeLong = long.Parse(n);
                result += "* long\n";
            }
            catch (OverflowException)
            {
            }
            if (result != $"{n} can fit in:\n")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"{n} can't fit in any type\n");
            }
        }
    }
}
