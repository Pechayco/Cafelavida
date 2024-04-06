using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class orderlist
    {
        List<order> Listionary = new List<order>();
        public void Drinks()
        {
            order one = new order
            {
                cname = "Latte",
                sugarlvl = "70% sugar level",
                type1 = "Cold",
                type2 = "Moderate Sweet",
            };

            Listionary.Add(one);

            order two = new order
            {
                cname = "Capuccino",
                sugarlvl = "70% sugar level",
                type1 = "Cold",
                type2 = "Moderate Sweet",
            };

            Listionary.Add(two);
            order three = new order
            {
                cname = "Caramel Macchiato",
                sugarlvl = "100% sugar lvl",
                type1 = "Hot",
                type2 = "So sweet!",
            };

            Listionary.Add(three);
            order four = new order
            {
                cname = "Mochaccino",
                sugarlvl = "50% sugar level",
                type1 = "Hot",
                type2 = "Balance Sweet",
            };

            Listionary.Add(four);
            order five = new order
            {
                cname = "Americano",
                sugarlvl = "25% sugar level",
                type1 = "Hot",
                type2 = "Not to sweet",
            };

            Listionary.Add(five);

            Details call = new Details();

            int drinknumber = Convert.ToInt32(Console.ReadLine());
           

            switch (drinknumber)
            {
               
                case 1:
                    call.ShowHistory(one);
                    break;
                case 2:
                    call.ShowHistory(two);
                    break;
                case 3:
                    call.ShowHistory(three);
                    break;
                case 4:
                    call.ShowHistory(four);
                    break;
                case 5:
                    call.ShowHistory(five);
                    break;
                default:
                    Console.WriteLine("UNIDENTIFIED DRINK NUMBER");
                    break;
                    
                        
            }

        }

    }
}