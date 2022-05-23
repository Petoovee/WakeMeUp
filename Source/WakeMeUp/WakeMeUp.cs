using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace WakeMeUp{

    class WakeMeUp : ThingComp
    {
        public override void CompTick() {
            Log.Error("Let's error on every tick!");
        }
        public WakeMeUpProperties Props => (WakeMeUpProperties)this.props;
        public bool ExampleBool => Props.myExampleBool;
    }
    public class WakeMeUpProperties : CompProperties
    {
        public bool myExampleBool;
        public float myExampleFloat;

        /// <summary>
        /// These constructors aren't strictly required if the compClass is set in the XML.
        /// </summary>
        public WakeMeUpProperties()
        {
            this.compClass = typeof(WakeMeUp);
        }

        public WakeMeUpProperties(Type compClass) : base(compClass)
        {
            this.compClass = compClass;
        }
    }
}
