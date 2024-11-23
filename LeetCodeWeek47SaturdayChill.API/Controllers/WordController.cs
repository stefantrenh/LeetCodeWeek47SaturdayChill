using LeetCodeWeek47SaturdayChill.API.Models;
using LeetCodeWeek47SaturdayChill.Application.Commands;
using LeetCodeWeek47SaturdayChill.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeetCodeWeek47SaturdayChill.API.Controllers
{
    public class WordController : Controller
    {
        private readonly MergeWordsHandler _mergeWordsHandler;

        public WordController(MergeWordsHandler mergeWordsHandler)
        {
            _mergeWordsHandler = mergeWordsHandler;
        }

        public ActionResult Index()
        { 
            return View(new MergeWordsModel());
        }


        [HttpPost]
        public ActionResult MergeJson(MergeWordsModel dto)
        {

            if (dto == null || string.IsNullOrWhiteSpace(dto.Word1) || string.IsNullOrWhiteSpace(dto.Word2))
            {
                return new HttpStatusCodeResult(400, "Both words must be provided.");
            }

            var command = new MergeWordsCommand(dto.Word1, dto.Word2);

            var result = _mergeWordsHandler.Handle(command);

            return Json(result);
        }

        [HttpPost]
        public ActionResult Index(MergeWordsModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new MergeWordsCommand(model.Word1,model.Word2);

            var resultDto = _mergeWordsHandler.Handle(command);
            model.MergedWord = resultDto.MergedWord;

            return View(model);
        }
    }
}