using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BuildsOfSkyrim.Models
{
    public class Connection
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConnectionID { get; set; }        
        public Perk Start { get; set; }
        public Perk End { get; set; }
    }
}