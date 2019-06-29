using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountChar cc = new CountChar();
            //cc.TakeInput();
            //cc.countChar();
            Console.WriteLine("************");
            //RemoveDuplicates rd = new RemoveDuplicates();
            //rd.RemoveDuplicatesString();
            //rd.RemoveDuplicatesStringUsingLinq();

            //ReverseString rs = new ReverseString();
            //rs.ReverseStringUsingSplit();
            //rs.ReverseStringWithOutSplit();
            NestedNode nn = new NestedNode();
            nn.FindNodes();
            Console.ReadKey();
        }
    }
}
