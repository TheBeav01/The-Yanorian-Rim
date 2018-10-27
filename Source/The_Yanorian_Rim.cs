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
        class PawnGenPatch
		{
			static void Postfix(Pawn __result, PawnGenerationRequest request)
			{
                Pawn res = __result;
                SoulDragonSpawnHelper sd = new SoulDragonSpawnHelper(request);
                string progState = Current.ProgramState.ToString();

                //First time load. Does not fire upon loading a save, I think.
                if (progState.Equals("MapInitializing"))
                {
                    Log.Message("State: " + Current.ProgramState + " Pawn ID: " + res.thingIDNumber);
                    Log.Message("Executing first time SD spawning");
                    if(sd.exec() == false)
                    {
                        Log.Warning("SD spawn not implemented yet");
                    }

                }
                //Game in progress
                else if(progState.Equals("Playing"))
                {
                    //Do nothing?
                }
			}
		}
        /*[HarmonyPatch(typeof(Game))]
        [HarmonyPatch("InitNewGame")]
        
        class InitThing
        {
            static void Postfix()
            {
                Log.Message("Works?");
                
            }
        } */
    }
}