using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson05
{
    public class Sampler
    {
        public Unit[] CreateSampleWithSize(Unit[] population, int sampleSize)
        {
            throw new NotImplementedException();
        }

        public Unit[] GetSampleableUnits(Unit[] population, DateTime sampleFrom)
        {
            throw new NotImplementedException();
        }

        public Unit[] RemoveQuarantines(Unit[] population, string[] quarantine)
        {
            throw new NotImplementedException();
        }

        public Unit[] GetUnitsForTargetGroup(Unit[] population, string targetGroup)
        {
            throw new NotImplementedException();
        }

        public Unit[] CreateSampleForTargetGroups(Unit[] population, TargetGroup[] targetGroups)
        {
            throw new NotImplementedException();
        }
    }

    public class Unit
    {
        public string Id { get; set; }
        public DateTime VisitDate { get; set; }
        public string TargetGroup { get; set; }
    }

    public class TargetGroup
    {
        public string Id { get; set; }
        public int SampleSize { get; set; }
    }
}
