using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Mock
{
    public class MockDataGenerator
    {
        public List<PlayerSeasonStatistics> TeamSeasonStats => GenerateTeamSeasonStats();
        public List<PlayerWeeklyStatistics> TeamWeeklyStats { get; set; }

        public List<PlayerSeasonStatistics> GenerateTeamSeasonStats()
        {
            List<PlayerSeasonStatistics> teamSeasonStats = new List<PlayerSeasonStatistics>()
            {
                new PlayerSeasonStatistics()
                {
                    DisplayName = "Anthony Davis",
                    TeamName = "Los Angeles Lakers",
                    TeamAbbreviation = "LAL",
                    Status = "DTD",
                    MinutesPerGame = 34.3,
                    FieldGoalsMadePerGame = 9.7,
                    FieldGoalAttemptsPerGame = 19,
                    FieldGoalPercentage = 0.507,
                    FreeThrowsMadePerGame = 7.3,
                    FreeThrowAttemptsPerGame = 8.3,
                    FreeThrowPercentage = 0.87,
                    ThreePointersMadePerGame = 1.1,
                    ReboundsPerGame = 9,
                    AssistsPerGame = 3.3,
                    StealsPerGame = 1.5,
                    BlocksPerGame = 2.7,
                    TurnoversPerGame = 2.3,
                    PointsPerGame = 27.7,
                    PlusMinus = 3
                },
                new PlayerSeasonStatistics()
                {
                    DisplayName = "Deandre Ayton",
                    TeamName = "Phoenix Suns",
                    TeamAbbreviation = "PHO",
                    Status = "SSPD",
                    MinutesPerGame = 33,
                    FieldGoalsMadePerGame = 9,
                    FieldGoalAttemptsPerGame = 14,
                    FieldGoalPercentage = 0.643,
                    FreeThrowsMadePerGame = 0,
                    FreeThrowAttemptsPerGame = 0,
                    FreeThrowPercentage = 0,
                    ThreePointersMadePerGame = 0,
                    ReboundsPerGame = 11,
                    AssistsPerGame = 0,
                    StealsPerGame = 1,
                    BlocksPerGame = 4,
                    TurnoversPerGame = 0,
                    PointsPerGame = 18,
                    PlusMinus = 0
                },
                new PlayerSeasonStatistics()
                {
                    DisplayName = "Kyrie Irving",
                    TeamName = "Brooklyn Nets",
                    TeamAbbreviation = "BKN",
                    Status = "O",
                    MinutesPerGame = 33.8,
                    FieldGoalsMadePerGame = 10.2,
                    FieldGoalAttemptsPerGame = 22.9,
                    FieldGoalPercentage = 0.444,
                    FreeThrowsMadePerGame = 5.4,
                    FreeThrowAttemptsPerGame = 5.7,
                    FreeThrowPercentage = 0.937,
                    ThreePointersMadePerGame = 2.8,
                    ReboundsPerGame = 5.4,
                    AssistsPerGame = 7.2,
                    StealsPerGame = 1.1,
                    BlocksPerGame = 0.5,
                    TurnoversPerGame = 2.4,
                    PointsPerGame = 28.5,
                    PlusMinus = 0
                }
            };
            return teamSeasonStats;
        }
    }
}
