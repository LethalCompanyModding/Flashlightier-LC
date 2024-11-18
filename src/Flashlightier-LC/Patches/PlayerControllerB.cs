using HarmonyLib;
using GameNetcodeStuff;

namespace FlashlightierLC.Patches;

public class PlayerControllerB_Patches
{
    [HarmonyPatch(typeof(PlayerControllerB), nameof(PlayerControllerB.Start))]
    [HarmonyPostfix]
    public static void OnStart(PlayerControllerB __instance)
    {
        __instance.allHelmetLights[0].ModifyLight(Plugin.Flashlights.ProFlashlight);
        __instance.allHelmetLights[1].ModifyLight(Plugin.Flashlights.SmallFlashlight);
    }
}
