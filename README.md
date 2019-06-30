# Use ClashRoyaleAPI

Get API token on https://developer.clashroyale.com
### Initialize
```C#
Core.Init(ReceivedApiToken, ClashRoyaleAPI.Enums.VersionAPI.v1);
ClashRoyaleAPI.BL.Players player = new ClashRoyaleAPI.BL.Players();
ClashRoyaleAPI.BL.Clans clan = new ClashRoyaleAPI.BL.Clans();
ClashRoyaleAPI.BL.Cards CardList = new ClashRoyaleAPI.BL.Cards();    
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

# Use ClashRoyaleClanMonitorWF
### Settings
Steps:
1. Your player tag
2. Your API Token

![alt text](https://pp.userapi.com/c851136/v851136649/15f2f1/DKDnYvhSciY.jpg "App settings")

3. Click "refresh" button in left bottom angle or restart application

### Another picture

![alt text](https://pp.userapi.com/c851136/v851136649/15f2e8/rqj3mf5AAIk.jpg "Main window contain information about the player and his cheasts")
![alt text](https://pp.userapi.com/c851136/v851136649/15f2c4/sB9Ev5sLTB4.jpg "Contain information about the clan in which is the player")
![alt text](https://pp.userapi.com/c851136/v851136649/15f2df/DgenkSG0dYk.jpg "Clan member list")
![alt text](https://pp.userapi.com/c851136/v851136649/15f2d6/TJPBn1oCZVc.jpg "Detailed information about selected clan member")
![alt text](https://pp.userapi.com/c851136/v851136649/15f2cd/z_JAFKpagfY.jpg "Contain information about clan wars")
