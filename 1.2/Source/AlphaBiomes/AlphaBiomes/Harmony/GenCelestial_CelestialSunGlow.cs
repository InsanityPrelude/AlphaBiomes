﻿using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
using System.Collections.Generic;
using RimWorld.Planet;
using System.Linq;
using System;
using RimWorld.BaseGen;

// So, let's comment this code, since it uses Harmony and has moderate complexity

namespace AlphaBiomes
{

   



   

    /*This Harmony Postfix allows us to reduce the amount of light that reaches the Forsaken Crags
*/
    [HarmonyPatch(typeof(GenCelestial))]
    [HarmonyPatch("CelestialSunGlow")]
    public static class AlphaBiomes_GenCelestial_CelestialSunGlow_Patch
    {
        [HarmonyPostfix]
        public static void AvoidTheLight(ref Map map, ref float __result)

        {
           
            if (map.Biome.defName == "AB_RockyCrags")
            {


               // Log.Message("I have detected the biome, and light should be "+ __result);
               
                __result= __result*0.4f;
            }



        }

    }

   
}
