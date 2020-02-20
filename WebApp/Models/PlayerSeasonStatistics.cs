using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class PlayerSeasonStatistics
    {
        [Display(Name = "Name")]
        public string DisplayName { get; set; }
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Display(Name = "Team Abbrv")]
        public string TeamAbbreviation { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Display(Name = "MIN")]
        public double MinutesPerGame { get; set; }
        [Display(Name = "FGM")]
        public double FieldGoalsMadePerGame { get; set; }
        [Display(Name = "FGA")]
        public double FieldGoalAttemptsPerGame { get; set; }
        [Display(Name = "FG%")]
        public double FieldGoalPercentage { get; set; }
        [Display(Name = "FTM")]
        public double FreeThrowsMadePerGame { get; set; }
        [Display(Name = "FTA")]
        public double FreeThrowAttemptsPerGame { get; set; }
        [Display(Name = "FT%")]
        public double FreeThrowPercentage { get; set; }
        [Display(Name = "3PT")]
        public double ThreePointersMadePerGame { get; set; }
        [Display(Name = "RB")]
        public double ReboundsPerGame { get; set; }
        [Display(Name = "AST")]
        public double AssistsPerGame { get; set; }
        [Display(Name = "STL")]
        public double StealsPerGame { get; set; }
        [Display(Name = "BLK")]
        public double BlocksPerGame { get; set; }
        [Display(Name = "TO")]
        public double TurnoversPerGame { get; set; }
        [Display(Name = "PT")]
        public double PointsPerGame { get; set; }
        [Display(Name = "+/-")]
        public double PlusMinus { get; set; }
    }
}
