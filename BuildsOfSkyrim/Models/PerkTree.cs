using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Models
{
    public class PerkTree
    {
        public List<Perk> Perks { get; set; }
        public List<Connection> Connections { get; set; }
        public Skill Skill { get; set; }
    }
}