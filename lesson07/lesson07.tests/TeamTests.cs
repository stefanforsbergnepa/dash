using System;
using System.Linq;
using Shouldly;
using Xunit;

namespace lesson07.tests
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
        public void Get_boomers()
        {
            var boomers = team.GetBoomers();

            // Boomers are people over 40
            boomers.Length.ShouldBe(1);
            boomers.Single().ShouldBe("Niklas Melinder");
        }

        [Fact]
        public void Get_average_age()
        {
            var average = team.GetAverageAge();

            average.ShouldBe(37);
        }

        [Fact]
        public void Get_cyclists()
        {
            var cyclists = team.GetCyclists();

            // Team members interested in Cycling
            cyclists.Length.ShouldBe(2);
            cyclists[0].FirstName.ShouldBe("John");
            cyclists[1].FirstName.ShouldBe("Ulrika");
        }

        [Fact]
        public void Get_party_people()
        {
            var partyPeople = team.GetPartyPeople();

            // Team members interested in Dancing OR Champagne
            partyPeople.Length.ShouldBe(3);
            partyPeople[0].FirstName.ShouldBe("Ulrika");
            partyPeople[1].FirstName.ShouldBe("Stefan");
            partyPeople[2].FirstName.ShouldBe("Daria");
        }

        [Fact]
        public void Get_first()
        {
            var firstFemale = team.GetFirstOfGender("Female");
            var firstMale = team.GetFirstOfGender("Male");

            firstFemale.FirstName.ShouldBe("Ulrika");
            firstMale.FirstName.ShouldBe("John");
        }

        [Fact]
        public void Get_last()
        {
            var lastFemale = team.GetLastOfGender("Female");
            var lastMale = team.GetLastOfGender("Male");

            lastFemale.FirstName.ShouldBe("Daria");
            lastMale.FirstName.ShouldBe("Niklas");
        }

        [Fact]
        public void Whos_the_boss()
        {
            var namesOfBosses = new []
            {
                "Tobbe Gyllebring",
                "John Cirverius",
                "Marketa Trnkova"
            };

            var boss = team.WhosTheBoss(namesOfBosses);

            // Team members that also is a boss
            boss.Single().ShouldBe("John Cirverius");
        }
    }
}
