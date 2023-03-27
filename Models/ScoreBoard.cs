using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasketballScores.Models
{
    public class ScoreBoard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Team Name")]
        public string TeamName1 { get; set; }
        [Required]
        [DisplayName("First Team Score")]
        [Range(0,1000,ErrorMessage ="The Score must be between 0 and 1000 points!")]
        public int Score1 { get; set; }
        [Required]
        [DisplayName("Second Team Name")]
        public string TeamName2 { get; set; }
        [Required]
        [DisplayName("Second Team Score")]
        [Range(0, 1000, ErrorMessage = "The Score must be between 0 and 1000 points!")]
        public int Score2 { get; set; }

        public DateTime PlayTime { get; set; } = DateTime.Now;

    }
}
