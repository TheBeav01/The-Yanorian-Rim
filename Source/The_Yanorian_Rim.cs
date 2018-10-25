using System.Reflection;
using RimWorld;
using Verse;
using Harmony;
using UnityEngine;
using System;


namespace The_Yanorian_Rim
{

    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("rimworld.HeartTheWolf.TheYanorianRim");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
		[HarmonyPatch(typeof(PawnGenerator))]
		[HarmonyPatch("GeneratePawn")]
		[HarmonyPatch(new Type[] { typeof(PawnGenerationRequest) })]
        class TestPatch
		{
			static void Postfix(PawnGenerationRequest request)
			{
                Log.Message("Pawn Generated!");
			}
		}
    }
}