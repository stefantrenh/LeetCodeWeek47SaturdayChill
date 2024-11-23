using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeWeek47SaturdayChill.Application.Commands
{
    public class MergeWordsCommand
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public MergeWordsCommand(string word1, string word2)
        {
            Word1 = word1;
            Word2 = word2;
        }
    }
}
