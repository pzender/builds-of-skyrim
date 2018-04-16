using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildsOfSkyrim.Models
{
    public class Perk
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PerkID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GraphX { get; set; }
        public int GraphY { get; set; }
        //public Skill BelongsTo { get; set; }
        public int SkillLevelRequired { get; set; }
    }
}
