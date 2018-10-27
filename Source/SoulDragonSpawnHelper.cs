using System;
using Verse;
using RimWorld;
using System.Collections;
using System.Collections.Generic;

namespace The_Yanorian_Rim
{
    public class SoulDragonSpawnHelper
    {
        public PawnGenerationRequest req { get; set; }
        public PawnKindDef kindDef { get; set; }
        public Boolean gameHasStarted { get; set; }
        public SoulDragonSpawnHelper()
        {
            gameHasStarted = false;
        }
        public SoulDragonSpawnHelper(PawnGenerationRequest request)
        {
            req = request;
            kindDef = request.KindDef;
            
        }
        public Boolean exec()
        {
            //TODO: Check if Drael race and spawn bonded dragon w/ hediff
            //TODO: Get if the pawn is downed or dead.
            if(kindDef.race.ToString() == "")
            {

            }
            return false;
        }
    }
}

