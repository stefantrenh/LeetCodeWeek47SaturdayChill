
using System.ComponentModel.DataAnnotations;


namespace LeetCodeWeek47SaturdayChill.Model
{
    public class WordsDTO
    {
        [Required]
        public string Word1 { get; set; }
        [Required]
        public string Word2 { get; set; }
    }

}
