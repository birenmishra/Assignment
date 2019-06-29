using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class RemoveDuplicates
    {
        List<string> input = new List<string>() { "I", "am", "I" };
        HashSet<string> uniqueSet = new HashSet<string>();
        public void RemoveDuplicatesString()
        {
            input.ForEach(x =>
            {
                if (!uniqueSet.Contains(x))
                {
                    uniqueSet.Add(x);
                }
            });

            foreach (string s in uniqueSet)
            {
                Console.WriteLine(s);
            }
        }

        public void RemoveDuplicatesStringUsingLinq()
        {
            List<string> output = input.Distinct().ToList();
            output.ForEach(x => Console.WriteLine(x));
        }
    }
}
