using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetvrta
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> statsX = new Dictionary<int, int>();
            Dictionary<int, int> statsY = new Dictionary<int, int>();
            
            for (int i = 0; i < 3; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);

                int value;

                if (statsX.TryGetValue(x, out value))
                {
                    statsX[x]++;
                }
                else
                {
                    statsX.Add(x, 1);

                }

                if (statsY.TryGetValue(y, out value))
                {
                    statsY[y]++;
                }
                else
                {
                    statsY.Add(y, 1);
                }
            }
            
            Console.WriteLine($"{statsX.OrderBy(v => v.Value).FirstOrDefault().Key.ToString()} {statsY.OrderBy(v => v.Value).FirstOrDefault().Key.ToString()}");

        }
    }
}
