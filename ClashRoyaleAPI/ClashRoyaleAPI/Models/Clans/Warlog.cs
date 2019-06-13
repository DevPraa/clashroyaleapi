using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Clans
{
    [Serializable]
    public class Warlog
    {
        [JsonProperty("items")]
        public WarDetail[] items { get; set; }
        [JsonProperty("paging")]
        public Page paging { get; set; }
    }

    [Serializable]
    public class WarDetail
    {
        public int seasonId { get; set; } //13,
        public string createdDate { get; set; } //"20181009T052848.000Z",
        public Participant[] participants { get; set; }
        public Standing[] standings { get; set; }
    }

    [Serializable]
    /// <summary>
    /// Союзники
    /// </summary>
    public class Participant
    {
        public string tag { get; set; } //"string",
        public string name { get; set; } //"string",
        public int? cardsEarned { get; set; } //0,
        public int? battlesPlayed { get; set; } //0,
        public int? wins { get; set; } //0
        public int? collectionDayBattlesPlayed { get; set; }
        public int? numberOfBattles { get; set; }
    }

    [Serializable]
    public class Standing
    {
        public StandingClan clan { get; set; }
        public int? trophyChange { get; set; } //129
    }

    [Serializable]
    public class Page
    {
        public Cursor cursors { get; set; }
    }

    [Serializable]
    public class Cursor
    {

    }

}
