# Use ClashRoyaleAPI

Get API token on https://developer.clashroyale.com
### Initialize
```C#
Core.Init(ReceivedApiToken, ClashRoyaleAPI.Enums.VersionAPI.v1);
ClashRoyaleAPI.BL.Players player = new ClashRoyaleAPI.BL.Players();
ClashRoyaleAPI.BL.Clans clan = new ClashRoyaleAPI.BL.Clans();
Cards CardList = new Cards();    
```
### After initialize available
```C#
var MyPlayerProfile = await player.GetPlayerInfoAsync(ClashRoyaleClanMonitorWF.Properties.Settings.Default.PlayerID);
var MyChests = await player.GetChestsInfoAsync(MyPlayerProfile.tag);
var ClanInfo = await clan.GetClanInfoAsync(MyPlayerProfile.clan.tag);
var ClanCurrentWar = await clan.GetCurrentClanWarAsync(MyPlayerProfile.clan.tag);
var ClanWarLog = await clan.GetClanWarLogAsync(MyPlayerProfile.clan.tag);
var ClanMembers = await clan.GetClanMembersInfoAsync(MyPlayerProfile.clan.tag);
var Cards = CardList.GetAllCards();
```