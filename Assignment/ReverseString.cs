using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ReverseString
    {
        public void ReverseStringUsingSplit()
        {
            string input = "abc dev inf iop";
            StringBuilder sb = new StringBuilder();// output = "";
            foreach (string str in input.Split(' '))
            {
                sb.Append(String.Join("",str.Reverse().ToArray()));
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }

        public void ReverseStringWithOutSplit()
        {
            string input = "abc dev";
            StringBuilder sb = new StringBuilder();
            int beginIndex = 0;
            for(int i =0; i < input.Length; i++)
            {
                if(input[i] == char.Parse(" "))
                {
                    var tempStr = input.Substring(beginIndex, i);
                    Reverse(sb, tempStr);
                    beginIndex = i + 1;
                }
                else if(i == input.Length - 1)
                {
                    var tempStr = input.Substring(beginIndex);
                    Reverse(sb, tempStr);
                }
            }
            Console.WriteLine(sb.ToString());
        }

        private static void Reverse(StringBuilder sb, string s)
        {
            for(int i = s.Length - 1; i>=0; i--)
            {
                sb.Append(String.Join("", s[i]));
                
            }
            sb.Append(" ");
            //return sb;
        }
    }
}
