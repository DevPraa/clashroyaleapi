using ClashRoyaleClanMonitorWF.Controls.Cards;
using ClashRoyaleClanMonitorWF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ClashRoyaleClanMonitorWF.Models.LocalResource;

namespace ClashRoyaleClanMonitorWF.Utils
{
    public class CardHelper
    {
        public static CardRare GetCardRare(string Name)
        {
            switch (Name)
            {
                case "Ice Spirit":
                case "Skeletons":
                case "Giant Snowball":
                case "Bats":
                case "Fire Spirits":
                case "Goblins":
                case "Zap":
                case "Spear Goblins":
                case "Arrows":
                case "Skeleton Barrel":
                case "Knight":
                case "Goblin Gang":
                case "Bomber":
                case "Minions":
                case "Archers":
                case "Cannon":
                case "Mortar":
                case "Tesla":
                case "Minion Horde":
                case "Barbarians":
                case "Rascals":
                case "Royal Giant":
                case "Elite Barbarians":
                case "Royal Recruits": return CardRare.Common;

                case "Ice Golem":
                case "Mega Minion":
                case "Heal":
                case "Tombstone":
                case "Dart Goblin":
                case "Zappies":
                case "Musketeer":
                case "Bomb Tower":
                case "Hog Rider":
                case "Battle Ram":
                case "Flying Machine":
                case "Fireball":
                case "Valkyrie":
                case "Furnace":
                case "Mini P.E.K.K.A":
                case "Giant":
                case "Royal Hogs":
                case "Inferno Tower":
                case "Goblin Hut":
                case "Wizard":
                case "Rocket":
                case "Elixir Collector":
                case "Barbarian Hut":
                case "Three Musketeers":
                case "Earthquake": return CardRare.Rare;

                case "Mirror":
                case "Barbarian Barrel":
                case "Rage":
                case "Skeleton Army":
                case "Goblin Barrel":
                case "Guards":
                case "Tornado":
                case "Clone":
                case "Hunter":
                case "Dark Prince":
                case "Poison":
                case "Freeze":
                case "Baby Dragon":
                case "Executioner":
                case "Electro Dragon":
                case "Witch":
                case "Bowler":
                case "Cannon Cart":
                case "Balloon":
                case "Prince":
                case "Goblin Giant":
                case "X-Bow":
                case "Lightning":
                case "Giant Skeleton":
                case "P.E.K.K.A":
                case "Golem":
                case "Wall Breakers": return CardRare.Epic;

                case "The Log":
                case "Royal Ghost":
                case "Miner":
                case "Ice Wizard":
                case "Bandit":
                case "Princess":
                case "Magic Archer":
                case "Inferno Dragon":
                case "Electro Wizard":
                case "Lumberjack":
                case "Night Witch":
                case "Graveyard":
                case "Sparky":
                case "Mega Knight":
                case "Lava Hound":
                case "Ram Rider": return CardRare.Legendary;

                default:
                    return CardRare.Unknown;
            }
        }

        public static CardType GetCardType(string Name)
        {
            switch (Name)
            {
                case "Ice Spirit":
                case "Skeletons":
                case "Bats":
                case "Fire Spirits":
                case "Goblins":
                case "Spear Goblins":
                case "Skeleton Barrel":
                case "Knight":
                case "Goblin Gang":
                case "Bomber":
                case "Minions":
                case "Archers":
                case "Minion Horde":
                case "Barbarians":
                case "Rascals":
                case "Royal Giant":
                case "Elite Barbarians":
                case "Royal Recruits":
                case "Ice Golem":
                case "Mega Minion":
                case "Dart Goblin":
                case "Zappies":
                case "Musketeer":
                case "Hog Rider":
                case "Battle Ram":
                case "Flying Machine":
                case "Valkyrie":
                case "Mini P.E.K.K.A":
                case "Giant":
                case "Royal Hogs":
                case "Wizard":
                case "Three Musketeers":
                case "Skeleton Army":
                case "Guards":
                case "Hunter":
                case "Dark Prince":
                case "Baby Dragon":
                case "Executioner":
                case "Electro Dragon":
                case "Witch":
                case "Bowler":
                case "Cannon Cart":
                case "Balloon":
                case "Prince":
                case "Goblin Giant":
                case "Giant Skeleton":
                case "P.E.K.K.A":
                case "Golem":
                case "Royal Ghost":
                case "Miner":
                case "Ice Wizard":
                case "Bandit":
                case "Princess":
                case "Magic Archer":
                case "Inferno Dragon":
                case "Electro Wizard":
                case "Lumberjack":
                case "Night Witch":
                case "Sparky":
                case "Mega Knight":
                case "Lava Hound":
                case "Ram Rider":
                case "Wall Breakers": return CardType.Troop;

                case "Goblin Hut":
                case "Barbarian Hut":
                case "Bomb Tower":
                case "Furnace":
                case "Inferno Tower":
                case "Elixir Collector":
                case "Tombstone":
                case "Cannon":
                case "Mortar":
                case "Tesla":
                case "X-Bow": return CardType.Building;

                case "The Log":
                case "Graveyard":
                case "Mirror":
                case "Rage":
                case "Barbarian Barrel":
                case "Goblin Barrel":
                case "Tornado":
                case "Poison":
                case "Freeze":
                case "Lightning":
                case "Clone":
                case "Fireball":
                case "Rocket":
                case "Heal":
                case "Giant Snowball":
                case "Zap":
                case "Arrows":
                case "Earthquake": return CardType.Spell;

                default:
                    return CardType.Unknown;
            }
        }

        public static int GetCardCost(string Name)
        {
            switch (Name)
            {
                case "Ice Spirit":
                case "Skeletons":
                case "Mirror":
                case "Heal": return 1;

                case "Bats":
                case "Fire Spirits":
                case "Goblins":
                case "Zap":
                case "Spear Goblins":
                case "Giant Snowball":
                case "Ice Golem":
                case "Barbarian Barrel":
                case "Rage":
                case "The Log": return 2;

                case "Arrows":
                case "Skeleton Barrel":
                case "Knight":
                case "Goblin Gang":
                case "Bomber":
                case "Minions":
                case "Archers":
                case "Cannon":
                case "Mega Minion":
                case "Tombstone":
                case "Dart Goblin":
                case "Skeleton Army":
                case "Goblin Barrel":
                case "Guards":
                case "Tornado":
                case "Clone":
                case "Royal Ghost":
                case "Miner":
                case "Ice Wizard":
                case "Bandit":
                case "Princess":
                case "Wall Breakers":
                case "Earthquake": return 3;


                case "Mortar":
                case "Tesla":
                case "Zappies":
                case "Musketeer":
                case "Bomb Tower":
                case "Hog Rider":
                case "Battle Ram":
                case "Flying Machine":
                case "Fireball":
                case "Valkyrie":
                case "Furnace":
                case "Mini P.E.K.K.A":
                case "Hunter":
                case "Dark Prince":
                case "Poison":
                case "Freeze":
                case "Baby Dragon":
                case "Magic Archer":
                case "Inferno Dragon":
                case "Electro Wizard":
                case "Lumberjack":
                case "Night Witch": return 4;

                case "Minion Horde":
                case "Barbarians":
                case "Rascals":
                case "Giant":
                case "Royal Hogs":
                case "Inferno Tower":
                case "Goblin Hut":
                case "Wizard":
                case "Executioner":
                case "Electro Dragon":
                case "Witch":
                case "Bowler":
                case "Cannon Cart":
                case "Balloon":
                case "Prince":
                case "Graveyard":
                case "Ram Rider": return 5;

                case "Royal Giant":
                case "Elite Barbarians":
                case "Rocket":
                case "Elixir Collector":
                case "Goblin Giant":
                case "X-Bow":
                case "Lightning":
                case "Giant Skeleton":
                case "Sparky": return 6;

                case "Barbarian Hut":
                case "P.E.K.K.A":
                case "Mega Knight":
                case "Lava Hound":
                case "Royal Recruits": return 7;


                case "Golem": return 8;

                case "Three Musketeers": return 10;

                default:
                    return 0;
            }
        }

        public static int GetStartLvl(CardRare cardType)
        {
            switch (cardType)
            {
                case CardRare.Common:
                    return 0;
                case CardRare.Rare:
                    return 2;
                case CardRare.Epic:
                    return 5;
                case CardRare.Legendary:
                    return 8;
                case CardRare.Unknown:
                    return 0;
                default:
                    return 0;
            }
        }

        public static void GenerateXML(ImageCardsOfDisk[] Cards)
        {
            XDocument xdoc = new XDocument(
                new XElement("Translation",
                    new XElement("Cards"
                        )));

            for (int i = 0; i < Cards.Length; i++)
            {
                xdoc.Element("Translation").Element("Cards").Add(
                new XElement("Card",
                            new XAttribute("Name", Cards[i].Name),
                            new XAttribute("Rare", Cards[i].Rare),
                            new XAttribute("Cost", Cards[i].Cost),
                            new XAttribute("Type", Cards[i].Type),
                            new XAttribute("StartLvl", Cards[i].StartLvl),
                            new XAttribute("RusName", "")
                            )); 
            }
            
            xdoc.Save("Cards_En.xml");
        }
    }
}
