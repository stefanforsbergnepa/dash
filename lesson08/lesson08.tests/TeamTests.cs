using System;
using System.Linq;
using Shouldly;
using Xunit;

namespace lesson08.tests
{
    public class TeamTests
    {
        private TeamMember[] team;

        public TeamTests()
        {
            team = new []
            {
                new TeamMember 
                { 
                    FirstName = "John", 
                    LastName = "Cirverius", 
                    Age = 39,
                    Gender = "Male",
                    Interests = new [] { "Swimming", "Cycling", "Running" }
                },
                new TeamMember 
                { 
                    FirstName = "Ulrika", 
                    LastName = "Malmgren", 
                    Age = 38,
                    Gender = "Female",
                    Interests = new [] { "Knitting", "Cycling", "Champagne" }
                },
                new TeamMember 
                { 
                    FirstName = "Stefan",
                    LastName = "Forsberg", 
                    Age = 39,
                    Gender = "Male",
                    Interests = new [] { "Cinema", "Dancing", "Champagne" }
                },
                new TeamMember 
                { 
                    FirstName = "Niklas",
                    LastName = "Melinder", 
                    Age = 41,
                    Gender = "Male",
                    Interests = new [] { "Running", "Skiing", "Climbing" }
                },
                new TeamMember 
                { 
                    FirstName = "Daria",
                    LastName = "Lykova", 
                    Age = 28,
                    Gender = "Female",
                    Interests = new [] { "Dancing", "Coding", "Spying" } 
                }
            };
        }

        [Fact]
        public void Get_boomers_with_own_method()
        {
            var boomers = team.GetBoomers();

            // Boomers are people over 40
            boomers.Length.ShouldBe(1);
            boomers[0].FirstName.ShouldBe("Niklas");
        }


        public bool IsBoomer(TeamMember teamMember) {
            return teamMember.Age >= 40;
        }

        [Fact]
        public void Get_boomers_with_predicate_method()
        {
            // Using defined method
            var boomersWithDefinedMethod = team.WhereDelegate(IsBoomer);
            // Using an expression
            var boomersWithExpression = team.WhereDelegate(t => t.Age >= 40);

            // Note that the call on 78 and 80 are functionally the same.

            // Boomers are people over 40
            boomersWithDefinedMethod.Length.ShouldBe(1);
            boomersWithExpression.Length.ShouldBe(1);

            boomersWithDefinedMethod[0].FirstName.ShouldBe("Niklas");
            boomersWithExpression[0].FirstName.ShouldBe("Niklas");
        }

        [Fact]
        public void Get_young_dancers()
        {

            // This t => true needs to change in order for the test to pass
            var youngDancers = team.WhereDelegate(t => true);

            // Young dancers are people under 39 that likes to dance
            youngDancers.Length.ShouldBe(1);

            youngDancers.ShouldContain(t => t.FirstName == "Daria");
        }
        
      
    }
}
