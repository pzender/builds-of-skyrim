using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Models
{
    public enum TraitType { StandingStone, Race }
    public class CharacterTrait
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TraitID { get; set; }
        public string ModSet { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TraitType { get; set; }
        
    }
}