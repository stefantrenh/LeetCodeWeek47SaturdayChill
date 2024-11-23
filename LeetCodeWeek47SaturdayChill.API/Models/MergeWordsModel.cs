using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeetCodeWeek47SaturdayChill.API.Models
{
    public class MergeWordsModel
    {
        [Required(ErrorMessage = "Word 1 is required")]
        [StringLength(50, ErrorMessage = "Word 1 cannot exceed 50 characters.")]
        public string Word1 { get; set; }

        [Required(ErrorMessage = "Word 1 is required")]
        [StringLength(50, ErrorMessage = "Word 1 cannot exceed 50 characters.")]
        public string Word2 { get; set; }

        public string MergedWord { get; set; }
        public string ErrorMessage { get; set; }
    }
}