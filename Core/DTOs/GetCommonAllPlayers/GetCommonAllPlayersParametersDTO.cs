namespace Core.DTOs.GetCommonAllPlayers
{
    public class GetCommonAllPlayersParametersDTO
    {
        public string LeagueID { get; set; }
        public string Season { get; set; }
        public string IsOnlyCurrentSeason { get; set; }
    }
}
