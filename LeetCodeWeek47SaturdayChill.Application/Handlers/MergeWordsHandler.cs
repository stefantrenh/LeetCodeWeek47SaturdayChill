using LeetCodeWeek47SaturdayChill.Application.Commands;
using LeetCodeWeek47SaturdayChill.Application.DTOs;
using LeetCodeWeek47SaturdayChill.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeWeek47SaturdayChill.Application.Handlers
{
    public class MergeWordsHandler
    {
        private readonly IMergeWordsService _mergeWordsService;

        public MergeWordsHandler(IMergeWordsService mergeWordsService)
        {
            _mergeWordsService = mergeWordsService;
        }

        public CreateWordResultDTO Handle(MergeWordsCommand command)
        { 
            return _mergeWordsService.MergeWords(command);
        }
    }
}
