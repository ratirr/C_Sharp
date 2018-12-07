using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class first
    {
        string _switch;
        string _bypass;

        //First constructor to initialize objects of the class before using it in methods
        public first(string parameter1, string parameter2)
        {
            this._switch = parameter1;
            this._bypass = parameter2;
        }

        //Second constructor to set it to default values, because an empty constructor is pretty much useless
        //public first() : this("use me instead of switch","use me instead of bypass")
        //    {
        //    }

        public void reverse()
        {
            
            string c = this._switch + " " + this._bypass;
            char[] p = c.ToCharArray();
           
            for (int i = 0, j =c.Length - 1; i < j; i++, j--)
            {
                p[i] = c[j];

                p[j] = c[i];
            }
            Console.WriteLine("Reversed value:\n");
            Console.WriteLine(p);
            return;

            


        }

    }
    class Subway
    {
        public static void Main(string[] args)
        {
            int r = 0;
            int e = 0;
            int f = 0;
            int y = 0;

            Diff_ref_val(ref r);
            Console.WriteLine(r);

            int[] p = new int[6];

            p[0] = 2;
            p[1] = 12;
            p[2] = 22;
            p[3] = 32;
            p[4] = 42;
            p[5] = 52;
          


            Calculate(7, 10, out f, out y);

            SoMany(p);
            

             void Diff_ref_val(ref int str)
            {
                str = 108;
            }

            void Calculate(int a, int b, out int sum, out int mult)
            {
                sum = a + b;
                mult = a*b;
                Console.WriteLine("The sum of {0} & {1} = {2}", a,b,sum);
                Console.WriteLine("The product of {0} & {1} = {2}", a, b, mult);
                    

            }

            first o = new first("rati","rajan");
            o.reverse();

            void SoMany(params  int[] values)
            {
                Console.WriteLine("\nThere are {0} elements in this variable\n", values.Length);
                //int i = 0;
                foreach (int i in values)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
