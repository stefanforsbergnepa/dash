using System;
using System.Linq;
using Shouldly;
using Xunit;

namespace lesson05.tests
{
    public class SamplerTests
    {
        [Fact]
        public void Sample_with_size()
        {
            var population = new []
            {
                new Unit { Id = "unit1@email.com" },
                new Unit { Id = "unit2@email.com" },
                new Unit { Id = "unit3@email.com" },
                new Unit { Id = "unit4@email.com" }
            };

            var sampler = new Sampler();
            var sample = sampler.CreateSampleWithSize(population, 3);

            // Sample should contain 3 units
            sample.Length.ShouldBe(3);
        }

        [Fact]
        public void Ordering_sample_decending()
        {
            var population = new []
            {
                new Unit { Id = "unit1@email.com" },
                new Unit { Id = "unit2@email.com" },
                new Unit { Id = "unit3@email.com" }
            };

            var sampler = new Sampler();
            var sample = sampler.CreateSampleWithSize(population, 3);

            // Sample should be sorted in descending order on id
            sample.Length.ShouldBe(3);
            sample[0].Id.ShouldBe("unit3@email.com");
            sample[1].Id.ShouldBe("unit2@email.com");
            sample[2].Id.ShouldBe("unit1@email.com");
        }

        [Fact]
        public void Get_units_for_targetgroup()
        {
            var population = new []
            {
                new Unit { Id = "unit1@email.com", TargetGroup = "TG1" },
                new Unit { Id = "unit2@email.com", TargetGroup = "TG2" },
                new Unit { Id = "unit3@email.com", TargetGroup = "TG1" },
                new Unit { Id = "unit4@email.com", TargetGroup = "TG3" }
            };

            var sampler = new Sampler();
            var sample = sampler.GetUnitsForTargetGroup(population, "TG1");

            // Sample should only contain units for targetgroup TG1
            sample.Length.ShouldBe(2);
            sample.ShouldAllBe(x => x.TargetGroup == "TG1");
        }

        [Fact]
        public void Get_sampleable_units()
        {
            var population = new []
            {
                new Unit { Id = "unit1@email.com", VisitDate = DateTime.Today.AddDays(-1) },
                new Unit { Id = "unit2@email.com", VisitDate = DateTime.Today.AddDays(-1) },
                new Unit { Id = "unit3@email.com", VisitDate = DateTime.Today.AddDays(-5) },
                new Unit { Id = "unit4@email.com", VisitDate = DateTime.Today.AddDays(-5) }
            };

            var sampler = new Sampler();
            var sample = sampler.GetSampleableUnits(population, DateTime.Today.AddDays(-2));

            // Sample should only contain units that are at most 2 days old
            sample.Length.ShouldBe(2);
            sample.ShouldAllBe(x => x.VisitDate == DateTime.Today.AddDays(-1));
        }

        [Fact]
        public void Remove_quarantined_units()
        {
            var population = new []
            {
                new Unit { Id = "unit1@email.com", VisitDate = DateTime.Now.AddDays(-1) },
                new Unit { Id = "unit2@email.com", VisitDate = DateTime.Now.AddDays(-1) },
                new Unit { Id = "unit3@email.com", VisitDate = DateTime.Now.AddDays(-1) }
            };

            var quarantine = new [] { "unit1@email.com", "unit2@email.com" };

            var sampler = new Sampler();
            var sample = sampler.RemoveQuarantines(population, quarantine);

            // Sample should not contain units in quarantine
            sample.Length.ShouldBe(1);
            sample[0].Id.ShouldBe("unit3@email.com");
        }

        [Fact]
        public void Sample_on_targetgroups()
        {
            var population = new []
            {
                new Unit { Id = "unit1@email.com", TargetGroup = "TG1" },
                new Unit { Id = "unit2@email.com", TargetGroup = "TG1" },
                new Unit { Id = "unit3@email.com", TargetGroup = "TG1" },
                new Unit { Id = "unit4@email.com", TargetGroup = "TG2" },
                new Unit { Id = "unit5@email.com", TargetGroup = "TG2" },
                new Unit { Id = "unit6@email.com", TargetGroup = "TG2" }
            };

            var targetGroups = new []
            {
                new TargetGroup { Id = "TG1", SampleSize = 2 },
                new TargetGroup { Id = "TG2", SampleSize = 2 }
            };

            var sampler = new Sampler();
            var sample = sampler.CreateSampleForTargetGroups(population, targetGroups);

            // TG1 should have 2 units sampled
            // TG2 should have 2 units sampled
            sample.Length.ShouldBe(4);
            sample.Count(x => x.TargetGroup == "TG1").ShouldBe(2);
            sample.Count(x => x.TargetGroup == "TG2").ShouldBe(2);
        }
    }
}
