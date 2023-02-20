using HarmonyLib;

namespace ExampleMod.Patches
{
    // Example patch that skips the launcher and immediately continues the last save
    [HarmonyPatch(typeof(SSceneLauncher), "OnInit")]
    internal static class SSceneLauncher_OnInit_SkipLauncher
    {
        private static void Postfix()
        {
            AccessTools.PropertySetter(typeof(SScenesManager), nameof(SScenesManager.LaunchMode)).Invoke(SScenesManager.Inst, new object[] { SScene.LaunchMode.AutoContinue });
        }
    }
}
