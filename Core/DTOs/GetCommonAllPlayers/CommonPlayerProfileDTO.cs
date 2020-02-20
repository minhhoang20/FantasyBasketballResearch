using System;
using System.Collections.Generic;

namespace Core.DTOs.GetCommonAllPlayers
{
    public class CommonPlayerProfileDTO
    {
        public string PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RosterStatus { get; set; }
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        public string PlayerCode { get; set; }
        public string TeamID { get; set; }
        public string TeamCity { get; set; }
        public string TeamName { get; set; }
        public string TeamAbbreviation { get; set; }

        public static List<CommonPlayerProfileDTO> ParsePlayerListFromResultSet(ResultSetDTO resultSet)
        {
            string[] headers = resultSet.Headers;
            int playerIDIndex = -1;
            int lastNameCommaFirstNameIndex = -1;
            int rosterStatusIndex = -1;
            int fromYearIndex = -1;
            int toYearIndex = -1;
            int playerCodeIndex = -1;
            int teamIDIndex = -1;
            int teamCityIndex = -1;
            int teamNameIndex = -1;
            int teamAbbrvIndex = -1;

            for (int i = 0; i < headers.Length; i++)
            {
                string header = headers[i];
                switch (header)
                {
                    case "PERSON_ID":
                        playerIDIndex = i;
                        break;
                    case "DISPLAY_LAST_COMMA_FIRST":
                        lastNameCommaFirstNameIndex = i;
                        break;
                    case "ROSTERSTATUS":
                        rosterStatusIndex = i;
                        break;
                    case "FROM_YEAR":
                        fromYearIndex = i;
                        break;
                    case "TO_YEAR":
                        toYearIndex = i;
                        break;
                    case "PLAYERCODE":
                        playerCodeIndex = i;
                        break;
                    case "TEAM_ID":
                        teamIDIndex = i;
                        break;
                    case "TEAM_CITY":
                        teamCityIndex = i;
                        break;
                    case "TEAM_NAME":
                        teamNameIndex = i;
                        break;
                    case "TEAM_ABBREVIATION":
                        teamAbbrvIndex = i;
                        break;
                }
            }

            List<CommonPlayerProfileDTO> playerProfiles = new List<CommonPlayerProfileDTO>();
            foreach (string[] playerRawData in resultSet.RowSet)
            {
                CommonPlayerProfileDTO playerProfileDTO = new CommonPlayerProfileDTO();
                playerProfileDTO.PersonID = playerRawData[playerIDIndex];
                string lastNameCommaFirstName = playerRawData[lastNameCommaFirstNameIndex];
                if (!string.IsNullOrEmpty(lastNameCommaFirstName))
                {
                    string[] splittedNames = lastNameCommaFirstName.Split(",");
                    playerProfileDTO.FirstName = splittedNames[0].Trim();
                    if (splittedNames.Length >= 2)
                    {
                        playerProfileDTO.LastName = splittedNames[1].Trim();
                    }  
                }
                playerProfileDTO.RosterStatus = int.Parse(playerRawData[rosterStatusIndex]);
                playerProfileDTO.FromYear = int.Parse(playerRawData[fromYearIndex]);
                playerProfileDTO.ToYear = int.Parse(playerRawData[toYearIndex]);
                playerProfileDTO.PlayerCode = playerRawData[playerCodeIndex];
                playerProfileDTO.TeamID = playerRawData[teamIDIndex];
                playerProfileDTO.TeamCity = playerRawData[teamCityIndex];
                playerProfileDTO.TeamName = playerRawData[teamNameIndex];
                playerProfileDTO.TeamAbbreviation = playerRawData[teamAbbrvIndex];

                playerProfiles.Add(playerProfileDTO);
            }

            return playerProfiles;
        }
    }
}
