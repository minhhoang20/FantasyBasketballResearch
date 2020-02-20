using Core.DTOs.GetCommonAllPlayers;
using Core.DTOs.GetPlayerDashboardByYearOverYear;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Core.PlayerServices
{
    public class PlayerService
    {
        private HttpClient _httpClient;
        public static readonly string Referrer = "individual";
        public static readonly string XNbaStatsOrigin = "stats";
        public static readonly string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.116 Safari/537.36";

        public PlayerService()
        {
            this._httpClient = new HttpClient();
            this._httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            this._httpClient.DefaultRequestHeaders.Add("Referer", Referrer);
            this._httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            this._httpClient.DefaultRequestHeaders.Add("x-nba-stats-origin", XNbaStatsOrigin);
        }

        public async Task<GetPlayerDashboardByYearOverYearResponseDTO> GetPlayerDashboardDataByYear(int userId, string season)
        {
            string seasonType = HttpUtility.UrlEncode("Regular Season");
            string split = HttpUtility.UrlEncode("yoy");

            string baseUrl = "https://stats.nba.com";
            string query = $"DateFrom=&DateTo=&GameSegment=&LastNGames=0&LeagueID=00&Location=&MeasureType=Base&Month=0&OpponentTeamID=0&Outcome=&PORound=0" +
                $"&PaceAdjust=N&PerMode=PerGame&Period=0&PlayerID={userId}&PlusMinus=N&Rank=N&Season={season}&SeasonSegment=&SeasonType={seasonType}&ShotClockRange=" +
                $"&Split={split}&VsConference=&VsDivision=";
            string fullUrl = $"{baseUrl}/stats/playerdashboardbyyearoveryear?{query}";

            HttpResponseMessage response = await this._httpClient.GetAsync(fullUrl);

            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            GetPlayerDashboardByYearOverYearResponseDTO playerDashboardData = JsonConvert.DeserializeObject<GetPlayerDashboardByYearOverYearResponseDTO>(content);
            return playerDashboardData;
        }

        public async Task<GetCommonAllPlayersResponseDTO> GetCommonAllPlayers(string leagueID, string season, bool onlyCurrentSeason)
        {
            string onlyCurrentSeasonQuery = onlyCurrentSeason ? "1" : "0";

            string baseUrl = "https://stats.nba.com";
            string query = $"LeagueID={leagueID}&Season={season}&IsOnlyCurrentSeason={onlyCurrentSeasonQuery}";
            string fullUrl = $"{baseUrl}/stats/commonallplayers?{query}";

            HttpResponseMessage response = await this._httpClient.GetAsync(fullUrl);

            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            GetCommonAllPlayersResponseDTO commonAllPlayersData = JsonConvert.DeserializeObject<GetCommonAllPlayersResponseDTO>(content);
            return commonAllPlayersData;
        }
    }
}
