using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson08
{
    public static class TeamBuilder
    {
        public static TeamMember[] GetBoomers(this TeamMember[] team)
        {
            return team
                .Where(t => t.Age >= 40)
                .ToArray();
        }

        public static TeamMember[] WhereDelegate(this TeamMember[] teamMember, Func<TeamMember, bool> predicate)
        {
            // You can NOT use the linq method Where here =)

            // Debug this row, what does it return and why?
            var result = predicate(teamMember[0]);

            return new TeamMember[0];
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
