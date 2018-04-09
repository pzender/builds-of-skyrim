using System.Collections.Generic;

namespace BuildsOfSkyrim.Models
{
    public class Skill
    {

        public int Value { get; set; }
        public List<Perk> PerksTaken { get; set; }
        public PerkTree PerksAvailable { get; set; }
        public string Name { get; set; }
        public string ModSet { get; set; }
    }
}