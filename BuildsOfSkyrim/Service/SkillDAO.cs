using BuildsOfSkyrim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Service
{
    public class SkillDAO
    {
        public static Skill Example()
        {
            Skill twohanded = new Skill()
            {
                Name = "Two-handed",
                ModSet = "Vanilla",
                PerksTaken = new List<Perk>(),
                PerksAvailable = new PerkTree()
                {
                    //Skill = null, //FIXME
                    Perks = new List<Perk>() {
                        new Perk(){Name = "Barbarian"            , GraphX = 0, GraphY = 0, SkillLevelRequired = 0, Description = "Two-Handed weapons do 20% more damage."},
                        new Perk(){Name = "Champion's Stance"    , GraphX = 0, GraphY = 2, SkillLevelRequired = 20, Description = "Power attacks with two-handed weapons cost 25% less stamina."},
                        new Perk(){Name = "Devastating Blow"     , GraphX = -3, GraphY = 7, SkillLevelRequired = 50, Description = "Standing power attacks do 25% bonus damage with a chance to decapitate your enemies."},
                        new Perk(){Name = "Great Critical Charge", GraphX = 3, GraphY = 7, SkillLevelRequired = 50, Description = "Can do a two-handed power attack while sprinting that does double critical damage."},
                        new Perk(){Name = "Sweep"                , GraphX = 0, GraphY = 12, SkillLevelRequired = 70, Description = "Sideways power attacks with two-handed weapons hit all targets in front of you."},
                        new Perk(){Name = "Warmaster"            , GraphX = 0, GraphY = 14, SkillLevelRequired = 100, Description = "Backwards power attack has a 25% chance to paralyze the target."},
                        new Perk(){Name = "Deep Wounds"          , GraphX = 3, GraphY = 4, SkillLevelRequired = 30, Description = "Attacks with greatswords have a 10% chance of doing critical damage."},
                        new Perk(){Name = "Limbsplitter"         , GraphX = -5, GraphY = 4, SkillLevelRequired = 30, Description = "Attacks with battle axes cause extra bleeding damage."},
                        new Perk(){Name = "Skullcrusher"         , GraphX = 6, GraphY = 4, SkillLevelRequired = 30, Description = "Attacks with warhammers ignore 25% of armor."},

                    },
                    Connections = new List<Connection>()
                  
                }
            };
            twohanded.PerksAvailable.Skill = twohanded;
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[0], End = twohanded.PerksAvailable.Perks[1] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[0], End = twohanded.PerksAvailable.Perks[6] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[0], End = twohanded.PerksAvailable.Perks[7] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[0], End = twohanded.PerksAvailable.Perks[8] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[1], End = twohanded.PerksAvailable.Perks[2] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[1], End = twohanded.PerksAvailable.Perks[3] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[2], End = twohanded.PerksAvailable.Perks[4] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[3], End = twohanded.PerksAvailable.Perks[4] });
            twohanded.PerksAvailable.Connections.Add(new Connection() { Start = twohanded.PerksAvailable.Perks[4], End = twohanded.PerksAvailable.Perks[5] });
            return twohanded;
        }
    }
}