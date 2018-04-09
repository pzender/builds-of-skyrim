using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuildsOfSkyrim.Models;

namespace BuildsOfSkyrim.Service
{
    public class BuildDAO
    {
        public static Build Example() {
            return new Build()
            {
                Name = "Bragi",
                Description = "Meet Bragi, my 4th or 5th character within the recent month or so. Bragi is a 20-ish y.o., very conservative, Skyrim-belongs-to-the-Nords kind of Nord. He isn't, however, much of a warrior, being much more interested in telling the old stories than being a part of them. Which means that out of combat, I'm playing him as a lorekeeper/bard kind of character, in combat he's a support with healing, courage & fear spells, sometimes summoning ghosts courtesy of the Apocalypse: Magic of Skyrim spell pack. And probably a lot of shouting later on, that sounds really fitting. ",
                ImgLink = "https://imgur.com/a/AlKwG",
                StatHealth = 0.5f,
                StatMagicka = 0.5f,
                StatStamina = 0f,
                Skills = new List<Skill>()
                {
                    SkillDAO.Example()
                }
            };
        }
    }
}