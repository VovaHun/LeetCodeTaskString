using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefanginIp
{
    internal class GoalParserInterpretation
    {
        /// <summary>
        /// Test Case
        /// </summary>
        string one = "G()(al)";
        string two = "G()()()()(al)";
        string three = "(al)G(al)()()G";
        public string Interpret(string command)
        {
           string com =  command.Replace("()","o").Replace("(al)", "al");

            return com;
        }
    }
}
