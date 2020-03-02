using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson07
{
    public static class TeamBuilder
    {
        public static string[] GetBoomers(this TeamMember[] team)
        {
            throw new NotImplementedException();
        }

        public static double GetAverageAge(this TeamMember[] team)
        {
            throw new NotImplementedException();            
        }

        public static TeamMember[] GetCyclists(this TeamMember[] team)
        {
            throw new NotImplementedException();
        }

        public static TeamMember[] GetPartyPeople(this TeamMember[] team)
        {
            throw new NotImplementedException();
        }

        public static TeamMember GetFirstOfGender(this TeamMember[] team, string gender)
        {
            throw new NotImplementedException();
        }

        public static TeamMember GetLastOfGender(this TeamMember[] team, string gender)
        {
            throw new NotImplementedException();
        }

        public static string[] WhosTheBoss(this TeamMember[] team, string[] namesOfBosses)
        {
            throw new NotImplementedException();
        }
    }

    public class TeamMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string[] Interests { get; set; }
    }
}
