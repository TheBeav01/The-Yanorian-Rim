using System;
using Verse;
using RimWorld;
using System.Collections;
using System.Collections.Generic;

namespace The_Yanorian_Rim
{
    public class SoulDragonSpawnHelper
    {
        private PawnGenerationRequest req;
        private PawnKindDef kindDef;
        private string pawnRace;
        private IList<string> races;
        public SoulDragonSpawnHelper(PawnGenerationRequest request)
        {
            req = request;
            kindDef = request.KindDef;
            
        }
        public Boolean exec()
        {
            //TODO: Check if Drael race and spawn bonded dragon w/ hediff
            if(kindDef.race.ToString() == "")
            {

            }
            Log.Message("Race: " + kindDef.race.ToString());
            return false;
        }
    }
}

