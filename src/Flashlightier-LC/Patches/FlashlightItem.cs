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
                __instance.flashlightBulb.ModifyLight(Plugin.Flashlights.ProFlashlight);
                break;
            //Smol flash
            case 1:
                __instance.flashlightBulb.ModifyLight(Plugin.Flashlights.SmallFlashlight);
                break;
            default:
                return;
        }
    }
}
