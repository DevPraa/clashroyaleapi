using ClashRoyaleAPI;
using ClashRoyaleAPI.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi
{
    class Program
    {
        static  void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }

        static async void Test()
        {
            //Core core = new Core();
            Core.Init("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6ImQ2YjA0YzJhLTlkZGEtNDkzOS1iYzc5LTYzM2QzZDlkMThiMiIsImlhdCI6MTU0MTYxNTc3Nywic3ViIjoiZGV2ZWxvcGVyLzIxNTk3MzJkLTFmNjAtZGMyOS02MDRjLWEzNTk3NjE4YzBmNiIsInNjb3BlcyI6WyJyb3lhbGUiXSwibGltaXRzIjpbeyJ0aWVyIjoiZGV2ZWxvcGVyL3NpbHZlciIsInR5cGUiOiJ0aHJvdHRsaW5nIn0seyJjaWRycyI6WyIxODguMTY4LjIxNS42MiJdLCJ0eXBlIjoiY2xpZW50In1dfQ.A5xf1-MNNmygTYidGdTrFPgv0SLJglWY6_dcaZakiKpSyOKuTinQCaEQz-mV8_SHQgvNLCMt8EoNK667gHmvwQ", ClashRoyaleAPI.Enums.VersionAPI.v1);
            Players player = new Players();
            var t = player.GetPlayerInfo("P2RQGRP9G");
            var t2 = player.GetUpcomingChestsPlayer("P2RQGRP9G");
            //var t3 = player.GetPlayerInfoV2("80UGRY9V8");
            Clans clan = new Clans();
            //var T4 = clan.GetClanInfo("2LUGU2UY");
            //var T5 = clan.GetClanMembers("2LUGU2UY");
            //var T6 = clan.GetClanWarLog("2LUGU2UY");
            //var T7 = clan.GetClanCurrentWar("2LUGU2UY");
            //t.Wait()
            Console.ReadKey();
        }
    }
}
