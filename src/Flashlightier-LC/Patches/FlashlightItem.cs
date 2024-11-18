using HarmonyLib;

namespace FlashlightierLC.Patches;

public class FlashLightItem_Patches
{
    [HarmonyPatch(typeof(FlashlightItem), nameof(FlashlightItem.Start))]
    [HarmonyPostfix]
    public static void OnStart(FlashlightItem __instance)
    {
        switch (__instance.flashlightTypeID)
        {
            //Pro flash
            case 0:
                __instance.ModifyFlashlight(Plugin.Flashlights.ProFlashlight);
                break;
            //Smol flash
            case 1:
                __instance.ModifyFlashlight(Plugin.Flashlights.SmallFlashlight);
                break;
            default:
                return;
        }
    }
}
