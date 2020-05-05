using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FoldingAtHome
{
    public class Donor
    {
        #region props

        [JsonProperty("wus")]
        public int WorkUnits { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("rank")]
        public int? Rank { get; set; }
        
        [JsonProperty("credit")]
        public int Credit { get; set; }
        
        [JsonProperty("team")]
        public int Team { get; set; }
        
        [JsonProperty("id")]
        public int Id { get; set; }

        #endregion

        #region overrides

        public override string ToString()
        {
            return string.Format("{0} | {1}", Name, Credit);
        }

        #endregion
    }
}
