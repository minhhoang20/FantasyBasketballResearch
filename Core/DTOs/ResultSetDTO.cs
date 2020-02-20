using System.Collections.Generic;

namespace Core.DTOs
{
    public class ResultSetDTO
    {
        public string Name { get; set; }
        public string[] Headers { get; set; }
        public string[][] RowSet { get; set; }
    }
}