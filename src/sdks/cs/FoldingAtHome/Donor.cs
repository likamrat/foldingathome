using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoldingAtHome
{
    public class Donor
    {
        #region ctor

        public Donor()
        {
            Teams = new List<Team>();
        }

        #endregion

        #region props

        [JsonProperty("wus")]
        public int? WorkUnits { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("rank")]
        public int? Rank { get; set; }
        
        [JsonProperty("credit")]
        public int? Credit { get; set; }
        
        [JsonProperty("team")]
        public int? TeamId { get; set; }
        
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }

        #endregion

        #region overrides

        public override string ToString()
        {
            return string.Format("{0} | {1}", Name, Credit);
        }

        #endregion

        #region statics

        public static async Task<Donor> Get(string name)
        {
            var uri = string.Format("{0}donor/{1}", Host.Uri, name);

            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<Donor>(content);
            }
        }

        #endregion
    }
}
