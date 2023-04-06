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
            List<int> result = new List<int>(nums);

            for (int i = 0; i < result.Count; i++)
            {
                int a = k - result[i];
                if (result.Contains(k - result[i]))
                {
                    int y = result[i];
                    result.Remove(result.Find(x => x == k - y));
                    result.Remove(y);
                    max++;
                }
            }


            return max;

        }
    }
}
