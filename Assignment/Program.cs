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
            CountChar countChar = new CountChar();
            countChar.TakeInput();
            countChar.countChar();

            //RemoveDuplicates removeDuplicates = new RemoveDuplicates();
            //removeDuplicates.RemoveDuplicatesString();
            //removeDuplicates.RemoveDuplicatesStringUsingLinq();

            //ReverseString reverseString = new ReverseString();
            //reverseString.ReverseStringUsingSplit();
            //reverseString.ReverseStringWithOutSplit();

            //NestedNode nestedNode = new NestedNode();
            //nestedNode.FindKeysFromJsonString();

            Console.ReadLine();
        }
    }
}
