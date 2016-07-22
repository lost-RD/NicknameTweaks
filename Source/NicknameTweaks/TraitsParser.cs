using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;

namespace NicknameTweaks
{
    public class TraitsParser
    {
        public static string Parse(Pawn p)
        {
            string result = "";
            if (p.story.WorkTagIsDisabled(WorkTags.Violent))
            {
                result += "NV";
            } else {
                if (p.story.traits.HasTrait(TraitDefOf.Brawler))
                {
                    result += "B";
                } else {
                    result += "S";
                }
            }
            if (p.story.WorkTagIsDisabled(WorkTags.ManualDumb) || p.story.WorkTypeIsDisabled(WorkTypeDefOf.Hauling))
            {
                result += "NH";
            } else {
                result += "H";
            }
            return result;
        }
    }
}
