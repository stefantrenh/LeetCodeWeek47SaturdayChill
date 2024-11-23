using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeWeek47SaturdayChill.Application.DTOs
{
    public class CreateWordResultDTO
    {
        public string MergedWord { get; set; }

        public CreateWordResultDTO(string mergedWord)
        {
            MergedWord = mergedWord;
        }
    }
}
