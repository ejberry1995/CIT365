using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public enum Assignment
    {
        ConductingLeader, OpeningPrayer, ClosingPrayer, Speaker
    }

    public class RoleAssignment
    {
        [Key]
        public int ID { get; set; }
        public Assignment Assignment { get; set; }
        public string Topic { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int MeetingID { get; set; }
        public Meeting Meeting { get; set; }
    }
}
