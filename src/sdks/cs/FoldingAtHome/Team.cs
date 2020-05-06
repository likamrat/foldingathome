using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoldingAtHome
{
    public class Team
    {
        #region ctor

        public Team()
        {
            Donors = new List<Donor>();
        }

        #endregion

        #region props

        [JsonProperty("wus")]
        public int WorkUnits { get; set; }
        
        [JsonProperty("donors")]
        public List<Donor> Donors { get; set; }
        
        [JsonProperty("rank")]
        public int? Rank { get; set; }
        
        [JsonProperty("total_teams")]
        public int? TotalTeams { get; set; }
        
        [JsonProperty("active_50")]
        public int? ActiveCpus { get; set; }
        
        [JsonProperty("last")]
        public DateTime TimeStamp { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("credit")]
        public int? Score { get; set; }
        
        [JsonProperty("team")]
        public int? Id { get; set; }

        #endregion

        #region overrides

        public override string ToString()
        {
            return string.Format("{0} | {1}", Name, Score);
        }

        #endregion

        #region statics

        public static async Task<Team> Get(int id)
        {
            var uri = string.Format("{0}team/{1}", Host.Uri, id);

            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<Team>(content);
            }
        }

        #endregion
    }
}
