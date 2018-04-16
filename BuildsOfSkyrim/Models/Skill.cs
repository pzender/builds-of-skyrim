using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildsOfSkyrim.Models
{
    public class Skill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SkillID { get; set; }
        public int Value { get; set; }
        public List<Perk> PerksTaken { get; set; }
        public PerkTree PerksAvailable { get; set; }
        public string Name { get; set; }
        public string ModSet { get; set; }
    }
}