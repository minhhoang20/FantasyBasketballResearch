namespace Core.DTOs.GetPlayerDashboardByYearOverYear
{
    public class GetPlayerDashboardByYearOverYearResponseDTO
    {
        public string Resource { get; set; } 
        public GetPlayerDashboardByYearOverYearParametersDTO Parameters { get; set; }
        public ResultSetDTO[] ResultSets { get; set; }
    }
}
