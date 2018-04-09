using System.Collections.Generic;

namespace BuildsOfSkyrim.Models
{
    public class Perk
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int GraphX { get; set; }
        public int GraphY { get; set; }
        //public Skill BelongsTo { get; set; }
        public int SkillLevelRequired { get; set; }
    }
}
