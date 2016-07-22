using System;
using System.Linq;
using System.Reflection;
using CommunityCoreLibrary;
using Verse;
using RimWorld;

namespace NicknameTweaks
{

    public class DetourInjector : SpecialInjector
    {

        public override bool Inject()
        {

            // Detour Verse.Dialog_ChangeNameTriple.DoWindowContents
            MethodInfo Verse_Dialog_ChangeNameTriple_DoWindowContents = typeof(Dialog_ChangeNameTriple).GetMethod("DoWindowContents", BindingFlags.Instance | BindingFlags.Public);
            MethodInfo NicknameTweaks_Dialog_ChangeNameTriple_DoWindowContents = typeof(_Dialog_ChangeNameTriple).GetMethod("DoWindowContents", BindingFlags.Instance | BindingFlags.Public);
            if (!Detours.TryDetourFromTo(Verse_Dialog_ChangeNameTriple_DoWindowContents, NicknameTweaks_Dialog_ChangeNameTriple_DoWindowContents))
            {
                return false;
            }

            return true;
		}
	}
}