using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefanginIp
{
    public class MaximumNumber
    {
        /// <summary>
        /// Test Case
        /// </summary>
        string[] test1 = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
        string[] test2 = new string[] { "please wait", "continue to fight", "continue to win" };

        public int MostWordsFound(string[] sentences)
        {
            //MySolution

            //int maxWords = 0;
            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    string[] mas = sentences[i].Split(' ');

            //    if(maxWords < mas.Length)
            //    {
            //        maxWords = mas.Length;
            //    }
            //}
            //return maxWords;

            //Form LeetCode
            return sentences.Select(s => s.Count(c => c == ' ') + 1).OrderByDescending(n => n).ElementAt(0);


        }
    }
}
