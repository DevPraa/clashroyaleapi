using ClashRoyaleAPI.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ClashRoyaleAPI.Models.Players
{
    [Serializable]
    public class Player
    {
        public string tag { get; set; } //public int #P2RQGRP9G  ,
        public string name { get; set; } //public int Anakom  ,
        public int expLevel { get; set; } //10,
        public int trophies { get; set; } //4074,
        public int bestTrophies { get; set; } //4074,
        public int wins { get; set; } //380,
        public int losses { get; set; } //324,
        public int battleCount { get; set; } //848,
        public int threeCrownWins { get; set; } //213,
        public int challengeCardsWon { get; set; } //16,
        public int challengeMaxWins { get; set; } //3,
        public int tournamentCardsWon { get; set; } //0,
        public int tournamentBattleCount { get; set; } //0,
        public string role { get; set; } //public int coLeader  ,
        public int donations { get; set; } //134,
        public int donationsReceived { get; set; } //160,
        public int totalDonations { get; set; } //2082,
        public int warDayWins { get; set; } //1,
        public int clanCardsCollected { get; set; } //3043,
        public Clan clan { get; set; }
        public Arena arena { get; set; }
        public LeagueStatistics leagueStatistics { get; set; }
        public Achievements[] achievements { get; set; }
        public List<Сard> cards { get; set; }
        public List<Сard> currentDeck { get; set; }
        public FavouriteCard currentFavouriteCard { get; set; }
    }
}
