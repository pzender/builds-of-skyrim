using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Models
{
    public class Build
    {
        public string Name;
        public float StatHealth, StatMagicka, StatStamina;
        public string Description;
        public string ImgLink;

        public List<Skill> Skills;


    }
}