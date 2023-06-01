using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalDamage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            while (true)
            {
                Console.WriteLine("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: 0");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int num))
                {
                    if (num == 0)
                    {
                        Environment.Exit(0);
                    }
                    if (num == 1)
                    {
                       swordDamage.CalculateDamage();
                    }
                }
            }
        }
    }
}
