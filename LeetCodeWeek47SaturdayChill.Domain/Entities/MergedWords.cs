using LeetCodeWeek47SaturdayChill.Model;
using System;
using System.Linq;
using System.Text;

namespace LeetCodeWeek47SaturdayChill.Domain.Entities
{
    public class MergedWords
    {
        public string MergedWord { get; set; }

        public MergedWords MergeWords(WordsDTO wordsDTO)
        {
            var wordLenght1 = wordsDTO.Word1.Length;
            var wordLenght2 = wordsDTO.Word2.Length;

            var minLenght = Math.Min(wordsDTO.Word1.Length, wordsDTO.Word2.Length);

            var stringbuilder = new StringBuilder();

            for (int i = 0; i < minLenght; i++)
            {
                stringbuilder.Append($"{wordsDTO.Word1[i]}{wordsDTO.Word2[i]}");
            }

            if (wordLenght1 == wordLenght2)
            {
                return new MergedWords { MergedWord = stringbuilder.ToString() };
            }

            var lastCharsArray = wordsDTO.Word1.Length > wordsDTO.Word2.Length ?
                                     wordsDTO.Word1.Skip(minLenght).ToArray() : wordsDTO.Word2.Skip(minLenght).ToArray();

            for (int i = 0; i < lastCharsArray.Length; i++)
            {
                stringbuilder.Append($"{lastCharsArray[i]}");
            }

            return new MergedWords { MergedWord = stringbuilder.ToString() };
        }
    }
}
