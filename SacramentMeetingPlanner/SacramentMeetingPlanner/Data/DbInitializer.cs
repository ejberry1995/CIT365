using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(PlannerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any meetings.
            if (context.Meetings.Any())
            {
                return;   // DB has been seeded
            }

            var songs = new Song[]
            {
                new Song{Title="Come Follow Me",Number=116},
                new Song{Title="I Stand All Amazed",Number=193},
                new Song{Title="Israel, Israel, God is Calling",Number=7},
                new Song{Title="I Know That My Redeemer Lives",Number=136},
                new Song{Title="Put Your Shoulder to the Wheel",Number=252},
                new Song{Title="Did You Think To Pray",Number=140},
                new Song{Title="True to the Faith",Number=254},
                new Song{Title="Hope of Israel",Number=259}
            };
            foreach (Song s in songs)
            {
                context.Songs.Add(s);
            }
            context.SaveChanges();

            var persons = new Person[]
            {
                //new Person{FirstName="Thor",LastName="Osborne"},
                new Person{FirstName="Maddie",LastName="Sears"},
                new Person{FirstName="Josh",LastName="Hudson"},
                new Person{FirstName="Lauren",LastName="Moffet"},
                new Person{FirstName="Sean",LastName="Crone"},
                new Person{FirstName="Emma",LastName="Perez"}
            };
            foreach (Person p in persons) {
                context.Persons.Add(p);
            }
            context.SaveChanges();

            var meetings = new Meeting[]
            {
                new Meeting{MeetingDate=DateTime.Parse("2020-07-11")},

            };
            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var roleAssignments = new RoleAssignment[]
            {
                new RoleAssignment{MeetingID=1, PersonID=1, Assignment=Assignment.ConductingLeader},
                new RoleAssignment{MeetingID=1, PersonID=2, Assignment=Assignment.OpeningPrayer},
                new RoleAssignment{MeetingID=1, PersonID=3, Assignment=Assignment.Speaker,Topic="Eternal Families"},
                new RoleAssignment{MeetingID=1, PersonID=4, Assignment=Assignment.Speaker,Topic="Temple Marriage"},
                new RoleAssignment{MeetingID=1, PersonID=5, Assignment=Assignment.Speaker,Topic="Service" },
                new RoleAssignment{MeetingID=1, PersonID=6, Assignment=Assignment.ClosingPrayer}
            };
            foreach (RoleAssignment r in roleAssignments)
            {
                context.RoleAssignments.Add(r);
            }
            context.SaveChanges();

            var musicSelections = new MusicSelection[]
            {
                new MusicSelection{MeetingID=1,SongID=3,Time=MusicTime.Opening},
                new MusicSelection{MeetingID=1,SongID=2,Time=MusicTime.Sacrament},
                new MusicSelection{MeetingID=1,SongID=7,Time=MusicTime.Closing},
            };
            foreach(MusicSelection m in musicSelections)
            {
                context.MusicSelections.Add(m);
            }
            context.SaveChanges();
        }
    }
}
