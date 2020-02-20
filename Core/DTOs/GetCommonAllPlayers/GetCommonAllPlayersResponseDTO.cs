namespace Core.DTOs.GetCommonAllPlayers
{
    public class GetCommonAllPlayersResponseDTO
    {
        public string Resource { get; set; }
        public GetCommonAllPlayersParametersDTO Parameters { get; set; }
        public ResultSetDTO[] ResultSets { get; set; }
    }
}
