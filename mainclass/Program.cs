using System.Runtime.Serialization;
using ClassLibrary1;

namespace mainprogram //CALUYA, CHRISTIAN L. PROGRAM IN INTEGRATIVE. BSIT 2-1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            orderlist Listionary = new orderlist();


            Console.WriteLine("WELCOME TO Cafe La Vida!");
            Console.WriteLine("Choose your Drink");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Latte");
            Console.WriteLine("2. Capuccino");
            Console.WriteLine("3. Caramel Macchiato");
            Console.WriteLine("4. Mochaccino");
            Console.WriteLine("5. Americano");
            Console.WriteLine("------------------");

            Listionary.Drinks();





        }
    }
}