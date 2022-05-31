using RimWorld;
using System;
using Verse;
using Verse.AI;

namespace WakeMeUp
{

    class WakeMeUp : ThinkNode
    {
        public override ThinkResult TryIssueJobPackage(Pawn pawn, JobIssueParams jobParams)
        {
            if (pawn == null || !pawn.IsColonist || pawn.IsPrisoner) return ThinkResult.NoJob;

            Need_Rest needRest = pawn.needs.rest;
            if (needRest == null && needRest.CurLevel > 0.1f) return ThinkResult.NoJob;

            var drug = FindWakeUp(pawn);
            if (drug == null) return ThinkResult.NoJob;

            var job = new Job(JobDefOf.Ingest, drug)
            {
                count = 1
            };

            return new ThinkResult(job, this);

            throw new NotImplementedException();

        }

        public static Thing FindWakeUp(Pawn pawn)
        {
            var innerContainer = pawn.inventory.innerContainer;
            foreach (var defThing in innerContainer)
            {
                if (defThing.def.defName == "WakeUp")
                {
                    return defThing;
                }
            }

            return null;
        }
    }
}
