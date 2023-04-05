using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefanginIp
{
    public class FinalValueOfVariable
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            for(int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "--X" || operations[i] == "X--")
                {
                    x--;
                }
                else
                {
                    x++;
                }
            }
            return x;

        }

        /// <summary>
        /// Test Case
        /// </summary>
        string[] mas = new string[] { "--X", "X++", "X++" };
        string[] mas2 = new string[] { "++X", "++X", "X++" };
        string[] mas3 = new string[] { "X++", "++X", "--X", "X--" };

    }
}
