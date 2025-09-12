using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitRace_
{
    public class RabbitRace
    {
        
        public int x = 0; // apollo poz
        public int y = 0; // bubbles poz
        public int m = 0; // apollo ugrashossz
        public int n = 0; // bubbles ugrashossz
        public int L = 0; //teljespaly
        public int poz = 0;

        public RabbitRace(string[] sz) {
            x = Convert.ToInt32(sz[0]);
            y = Convert.ToInt32(sz[1]);
            m = Convert.ToInt32(sz[2]);
            n= Convert.ToInt32(sz[3]);
            L = Convert.ToInt32(sz[4]);

        }
        public bool XY(ref int a, int L)
        {
            return a >= L;
        }
        public string Run() 
        {
            if (x < 0 || y < 0 || m <= 0 || n <= 0 || L <= 0)
            {
                return "Impossible";
            }

            int i = 0;
              while (x != y && i < 1)
                {
                  x = x + m;
                  y = y + n;

                  if (x > L)
                    {
                        x = x - L;

                    }
                    if (y > L)
                    {
                        y = y - L;

                    }
                    if (x == y)
                    {
                        i++;
                        return Convert.ToString(x);
                    }

                }
                return "Impossible";
              // hogyan oldjuk meg hogy vizsgaljuk a imposseblet ?
           




        }

    }
}
