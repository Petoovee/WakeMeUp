using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace WakeMeUp{

    class WakeMeUp : ThingComp
    {
        public override void TickRare() {
            Log.Error("Let's error on every tick!");
        }
    }
}
