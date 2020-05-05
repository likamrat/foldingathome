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

        [JsonPropertyName("wus")]
        public int WorkUnits { get; set; }
        [JsonPropertyName("donors")]
        public List<Donor> Donors { get; set; }
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
        [JsonPropertyName("total_teams")]
        public int TotalTeams { get; set; }
        [JsonPropertyName("active_50")]
        public int ActiveCpus { get; set; }
        [JsonPropertyName("last")]
        public DateTime TimeStamp { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("credit")]
        public int Score { get; set; }
        [JsonPropertyName("team")]
        public int Id { get; set; }

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
