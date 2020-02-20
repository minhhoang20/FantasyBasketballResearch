using Core.DTOs.GetCommonAllPlayers;
using Core.DTOs.GetPlayerDashboardByYearOverYear;
using Core.PlayerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Core.Tests
{
    public class PlayerServiceTest
    {
        [Fact]
        public async Task GetPlayerDashboardDataByYearTest()
        {
            int playerID = 1628973;
            string season = "2019-20";
            PlayerService playerService = new PlayerService();
            GetPlayerDashboardByYearOverYearResponseDTO result = await playerService.GetPlayerDashboardDataByYear(playerID, season);

            Assert.NotNull(result);
            Assert.Equal(playerID, int.Parse(result.Parameters.PlayerID));
            Assert.Equal(season, result.Parameters.Season);
        }

        [Fact]
        public async Task GetCommonAllPlayersTest()
        {
            string leagueID = "00";
            string season = "2019-20";
            bool onlyCurrentSeason = true;
            PlayerService playerService = new PlayerService();
            GetCommonAllPlayersResponseDTO result = await playerService.GetCommonAllPlayers(leagueID, season, onlyCurrentSeason);

            Assert.NotNull(result);

            List<CommonPlayerProfileDTO> playerProfiles = CommonPlayerProfileDTO.ParsePlayerListFromResultSet(result.ResultSets.FirstOrDefault());

            Assert.NotNull(playerProfiles);
            Assert.NotEmpty(playerProfiles);
        }
    }
}
