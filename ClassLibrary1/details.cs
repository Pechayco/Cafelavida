using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Details
    {
        public void ShowHistory(order milktea)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Here's your Drink!");
            Console.WriteLine(milktea.cname);
            Console.WriteLine(milktea.sugarlvl);
            Console.WriteLine(milktea.type1);
            Console.WriteLine(milktea.type2);
            Console.WriteLine("-----------------------");

        }

    }
}