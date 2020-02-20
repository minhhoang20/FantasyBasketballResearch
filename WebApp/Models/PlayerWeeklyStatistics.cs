using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PlayerWeeklyStatistics
    {
        public PlayerSeasonStatistics SeasonStats { get; set; }
        public int WeekNumber { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int ScheduledGameNumber { get; set; }
    }
}
