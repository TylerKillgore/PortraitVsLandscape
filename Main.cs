using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LandscapeVSportrait
{
    class Program
    {
        static void Main(string[] args)
        {
            string outcome = string.Empty;
            int heightNow = new int();
            int widthNow = new int();

            Console.Write("Please enter the width of your picture? ");
            
            string width = Console.ReadLine();
            Convert.ToInt32(Regex.Replace(width, "[^0-9]", ""));
            
            Console.Write("Please enter the height of your picture? ");
            
            string height = Console.ReadLine();
            heightNow = Convert.ToInt32(Regex.Replace(height, "[^0-9]", ""));

            if (heightNow > widthNow)
            {
              Console.WriteLine(width + " x " + height + " and it is a portrait.");
            }
            
            if (widthNow > heightNow)
            {
                Console.WriteLine("" + width + " x " + height + " and it is a landscape.");
            }
            Console.ReadLine();
        }
    }
}
