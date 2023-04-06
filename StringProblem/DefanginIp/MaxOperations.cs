using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefanginIp
{
    internal class MaxOperations
    {
        public int MaxOperation(int[] nums, int k)
        {
            int max = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                int res = k - i;

                if (dict.ContainsKey(res) && dict[res] > 0)
                {
                    max++;
                    dict[res]--;
                }
                else
                {
                    if (dict.ContainsKey(i))
                    {
                        int a = dict[i];
                        a = a + 1;
                        dict[i] = a;
                    }

                    else
                        dict.Add(i, 1);
                }
            }



            return max;

        }
    }
}
