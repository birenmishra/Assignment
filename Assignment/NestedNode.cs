using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Assignment
{
    class NestedNode
    {
        public void FindKeysFromJsonString()
        {
            string jsonString = "{  a: 5, b: { c: { d: 10 } }}";

            JObject jsonObj = JObject.Parse(jsonString);

            RecursiveMethod(jsonObj);
        }

        public void RecursiveMethod(JObject parent)
        {
            Dictionary < string, string> dictObj = new Dictionary<string, string>();
            foreach (JObject child in parent.Children())
            {
                if (child.HasValues)
                {
                     dictObj = parent.ToObject<Dictionary<string, string>>();
                    RecursiveMethod(child);
                }
            }
            Console.WriteLine("Output: ");
            foreach (var key in dictObj.Keys)
            {
                Console.WriteLine(key);
            }
        }

    }
}
