using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Models
{
    public class PerkTree
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TreeID { get; set; }
        public List<Perk> Perks { get; set; }
        public List<Connection> Connections { get; set; }
        public Skill Skill { get; set; }
    }
}