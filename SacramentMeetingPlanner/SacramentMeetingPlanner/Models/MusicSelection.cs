using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public enum MusicTime
    {
        Opening, Sacrament, Closing
    }

    public class MusicSelection
    {
        [Key]
        public int ID { get; set; }
        public MusicTime Time { get; set; }

        public int SongID { get; set; }
        public Song Song { get; set; }

        public int MeetingID { get; set; }
        public Meeting Meeting { get; set; }
    }
}
