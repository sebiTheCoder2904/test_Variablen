using System.Data;
using System.Linq.Expressions;

namespace test_Variablen
{
    class Program
    {
        static void typeString(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine("");
        }

        static void typeString_middle(int yPoss, string text, int delay)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), yPoss);
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine("");
        }

        static void printPlayer(int x, int y, string player, int delay)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(player);
            Thread.Sleep(delay);
        }

        static void Rechner()
        {
            string rechnung;

            typeString_middle(0, "Willkommen zu meinem Taschenrechner", 20);
            Console.WriteLine("");
            Console.WriteLine("");
            typeString("Einfach Rechnung eingeben:", 20);
            Console.WriteLine("");  

            rechnung = Console.ReadLine();
            var result = new DataTable().Compute(rechnung, null);
            //typeString(".....", 500);
            //Console.SetCursorPosition(0, Console.GetCursorPosition().Top);
            Console.WriteLine("= " + result.ToString());
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            
            // int alter;
            string name = "Sebastian";
            int alter = 15;
            string message = "ich heiße " + name + " und bin " + alter.ToString() + " Jahre alt";
            string player = "o_o";


            Rechner();
            Console.WriteLine("");
            Console.WriteLine("Press Key to exit");
            Console.ReadKey();
        }   
    }
}