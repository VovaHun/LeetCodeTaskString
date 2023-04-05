using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefanginIp
{
    internal class Stone
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int x = 0;

            for (int i = 0; i < jewels.Length; i++)
            {
               x += stones.Count(x => x == jewels[i]);
            }

            
            return x;
        }
    }
}
