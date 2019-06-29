using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NestedNode
    {
        public void FindNodes()
        {
            List<string> nodes = new List<string>();
            string input = "{  a: 5, b: { c: { d: 10 } }}";
            var splittedByComma = input.Split(',');
            foreach (string splt in splittedByComma)
            {
                RecursiveMethod(nodes, splt);
            }
            nodes.ForEach(x => Console.WriteLine(x));
        }

        public void RecursiveMethod(List<string> nodes, string splt)
        {
            var value = splt.Split(':');
            if (value[0].Contains(":"))
            {
                nodes.Add(value[0].Replace("{ ", "").Replace(" ", ""));
                RecursiveMethod(nodes, value[0]);
            }
            else
            {
                nodes.Add(value[0].Replace("{ ", "").Replace(" ", ""));
            }
        }
    }
}
