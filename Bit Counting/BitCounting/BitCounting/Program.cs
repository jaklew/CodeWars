using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = (int)new Decimal(1);
            Console.WriteLine(CountBits( int.Parse(Console.ReadLine()) ) );
            Console.ReadLine();
        }

        public static int CountBits(int n)
        {
            var i = 0;
            var bitArr = new BitArray(new int[] { n });
            foreach(bool bit in bitArr)
            {
                if (bit == true) i++;
            }
            return i;
        }
    }
}
