using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int width = size * 2 - 1;
            int height = 2 * (size - 2) + 1;
            int leftRight = size - 1;

            char asterix = '*';
            char dash = '-';
            char at = '@';
            char upLdownR = '\\';
            char upRdownL = '/';
            char space = ' ';

            string assWingUp = string.Format("{0}{1}{2}{3}{0}",
                                                             new string(asterix, size - 2),
                                                             upLdownR,
                                                             space,
                                                             upRdownL);
            string dashWingUp = string.Format("{0}{1}{2}{3}{0}",
                                                             new string(dash, size - 2),
                                                             upLdownR,
                                                             space,
                                                             upRdownL);
            string mid = string.Format("{0}{1}{0}", new string(space, size - 1), at);

            string assWingDown = string.Format("{0}{1}{2}{3}{0}",
                                                             new string(asterix, size - 2),
                                                             upRdownL,
                                                             space,
                                                             upLdownR);
            string dashWingDown = string.Format("{0}{1}{2}{3}{0}",
                                                             new string(dash, size - 2),
                                                             upRdownL,
                                                             space,
                                                             upLdownR);
            for (int i = 0; i < size - 2; i++)
            {
                if (i % 2 != 0) Console.WriteLine(dashWingUp);
                else Console.WriteLine(assWingUp);
            }

            Console.WriteLine(mid);

            for (int i = 0; i < size - 2; i++)
            {
                if (i % 2 != 0) Console.WriteLine(dashWingDown);
                else Console.WriteLine(assWingDown);
            }
        }
    }
}
