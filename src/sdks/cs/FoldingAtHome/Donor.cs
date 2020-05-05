using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FoldingAtHome
{
    public class Donor
    {
        #region props

        [JsonPropertyName("wus")]
        public int WorkUnits { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("rank")]
        public int? Rank { get; set; }
        [JsonPropertyName("credit")]
        public int Credit { get; set; }
        [JsonPropertyName("team")]
        public int Team { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }

        #endregion
    }
}
