using BepInEx;
using HarmonyLib;

namespace ValheimSherpentHunter
{
  [BepInPlugin("org.bepinex.plugins.valheim_serpent_hunter", "Valheim Serpent Hunter", version)]
  public class BepInExMod : BaseUnityPlugin
  {
    public const string version = "0.0.1";

    void Awake()
    {
      BepInEx.Logging.Logger.Listeners.Add(new SerpentLogListner());

      var harmony = new Harmony("mod.valheim_serpent_hunter");
      harmony.PatchAll();
    }
  }
}
