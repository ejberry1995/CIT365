using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Song
    {
        [Key]
        public int ID { get; set; }

        public int Number;
        public string Title;

        public ICollection<MusicSelection> MusicSelections { get; set; }
    }
}
