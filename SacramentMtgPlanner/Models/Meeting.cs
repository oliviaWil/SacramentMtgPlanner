using System.ComponentModel.DataAnnotations;

namespace SacramentMtgPlanner.Models
{
    
    public class Meeting
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        public DateTime DateOfMeeting { get; set; }
        public DayOfWeek DayOfMeeting => DateOfMeeting.DayOfWeek;

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Conducting Leader")]
        [Required]
        public string ConductingLeader { get; set; }

        [Display(Name = "Opening Hymn")]
        [Required]
        public string OpeningHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        [Required]
        public string ClosingHymn { get; set; }

        [Display(Name = "Musical Number")]
        public string? MusicalNumber { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public string? IntermediateHymn { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

        [Required]

        public List<String> Speakers { get; set; } = new List<String>();
        [Required]
        public List<String> Topics { get; set; } = new List<String>();
    }

     
    
    
}
