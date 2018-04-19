using BuildsOfSkyrim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Service
{
    public class CharacterTraitDAO
    {
        private DatabaseContext db = new DatabaseContext();
        public CharacterTrait FindByNameAndModset(string name, string modset)
        {
            CharacterTrait characterTrait = (from traits in db.CharacterTraits where traits.Name == name && traits.ModSet == modset select traits).FirstOrDefault();
            characterTrait.Description = HttpUtility.HtmlDecode(characterTrait.Description);
            return characterTrait;
        }
    }
}