using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class addemployee
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Niana");
            list.Add("Athul");
            list.Add("Nishanth");
            list.Add("Mia");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("total number of employes" + ':' + list.Count);
            Console.ReadLine();
        }
    }
}