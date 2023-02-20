using BepInEx;
using HarmonyLib;

namespace ExampleMod
{
    // TODO: Change the GUID
    [BepInPlugin("some.unique.name.here", PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class ExampleMod : BaseUnityPlugin
    {
        // The plugin is a MonoBehaviour, so you're free to use MonoBehaviour callbacks
        // i.e. Awake, OnEnable, Update, and so forth
        private void Awake()
        {
            Logger.LogInfo("Hello World.");

            // If you have harmony patch to stuff, this will execute all patches
            // within this assembly
            Harmony.CreateAndPatchAll(GetType().Assembly);
        }
    }
}