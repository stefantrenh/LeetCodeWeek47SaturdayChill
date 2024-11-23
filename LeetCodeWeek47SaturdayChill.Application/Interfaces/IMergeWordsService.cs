using LeetCodeWeek47SaturdayChill.Application.Commands;
using LeetCodeWeek47SaturdayChill.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeWeek47SaturdayChill.Application.Interfaces
{
    public interface IMergeWordsService
    {
        CreateWordResultDTO MergeWords(MergeWordsCommand command);
    }
}
