using HarmonyLib;
using JetBrains.Annotations;
using System.Reflection;
using Verse;

namespace NierAutomataWeapon.HarmonyPatches
{
    [UsedImplicitly]
    [StaticConstructorOnStartup]
    public class PatchMain
    {
        static PatchMain()
        {
            var instance = new Harmony("NierAutomataWeapon_HarmonyPatches");
            instance.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
