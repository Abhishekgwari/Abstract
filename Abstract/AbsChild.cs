using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class AbsChild :AbsParent
    {
        public override void Mul(int x, int y)
        {
           Console.WriteLine(x*y);  
        }
        public override void Div(int x, int y) { 
            Console.WriteLine(x / y); 
        }
        public static void Main(string[] args)  
        {
            AbsChild c = new AbsChild();
            AbsParent p = c;

            p.Add(150, 45);
            p.Sub(78, 30);
            p.Mul(134, 65);
            p.Div(250, 5);

            c.Add(150, 45);
            c.Sub(78, 30);
            c.Mul(134, 65);
            c.Div(250, 5);
            Console.ReadLine();
        }
    }
}
