using LeetCodeWeek47SaturdayChill.Application.Commands;
using LeetCodeWeek47SaturdayChill.Application.DTOs;
using LeetCodeWeek47SaturdayChill.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeWeek47SaturdayChill.Application.MergeWordService
{
    public class MergeWordsService : IMergeWordsService
    {
        public CreateWordResultDTO MergeWords(MergeWordsCommand mergeWordsCommand)
        {
            var wordLenght1 = mergeWordsCommand.Word1.Length;
            var wordLenght2 = mergeWordsCommand.Word2.Length;

            var minLenght = Math.Min(mergeWordsCommand.Word1.Length, mergeWordsCommand.Word2.Length);

            var stringbuilder = new StringBuilder();

            for (int i = 0; i < minLenght; i++)
            {
                stringbuilder.Append($"{mergeWordsCommand.Word1[i]}{mergeWordsCommand.Word2[i]}");
            }

            if (wordLenght1 == wordLenght2)
            {
                return new CreateWordResultDTO(stringbuilder.ToString());
            }

            var lastCharsArray = mergeWordsCommand.Word1.Length > mergeWordsCommand.Word2.Length ?
                                     mergeWordsCommand.Word1.Skip(minLenght).ToArray() : mergeWordsCommand.Word2.Skip(minLenght).ToArray();

            for (int i = 0; i < lastCharsArray.Length; i++)
            {
                stringbuilder.Append($"{lastCharsArray[i]}");
            }

            return new CreateWordResultDTO(stringbuilder.ToString());
        }
    }
}
