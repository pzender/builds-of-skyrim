using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Models
{
    public class Build
    {   
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuildID { get; set; }
        public string Name { get; set; }
        public float StatHealth { get; set; }
        public float StatMagicka { get; set; }
        public float StatStamina { get; set; }
        public string Description { get; set; }
        public string ImgLink { get; set; }

        public List<Skill> Skills { get; set; }
        public CharacterTrait Race { get; set; }
        public CharacterTrait StandingStone { get; set; }
        public string GetClass()
        {

            throw new NotImplementedException();
        }
        public int GetLevel()
        {
            int level = 1;
            foreach(Skill s in Skills)
            {
                level += s.PerksTaken.Count;
            }
            return level;  
        }
    }
}