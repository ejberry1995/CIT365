using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        [Key]
        public int ID { get; set; }

        public DateTime MeetingDate { get; set; }

        public ICollection<RoleAssignment> RoleAssignments { get; set; }
        public ICollection<MusicSelection> MusicSelections { get; set; }

    }
}
