using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CountChar
    {
        List<string> input = new List<string>();
        Dictionary<char, int> countDict = new Dictionary<char, int>();

        public void TakeInput()
        {
            Console.WriteLine("Please enter the number of String you want to enter : ");
            try
            {
                int a = int.Parse(Console.ReadLine());

                for (int i = 0; i < a; i++)
                {
                    Console.Write($"Enter the  String {i + 1 } - ");
                    input.Add(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //Console.WriteLine("Please enter the strings to count char -");
            
        }
        public void countChar()
        {
            input.ForEach(x =>
            {
                foreach(char c in x.ToLower())
                {
                    if (countDict.ContainsKey(c))
                    {
                        countDict[c] += 1;
                    }else
                    {
                        countDict.Add(c, 1);
                    }
                }
            });
            Console.WriteLine("Output:");
            foreach (KeyValuePair<char, int> kvp in countDict)
            {   
                Console.WriteLine($"{ kvp.Key } - {kvp.Value}");
            }
        }
    }
}
