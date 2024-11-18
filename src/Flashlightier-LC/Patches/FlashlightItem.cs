using HarmonyLib;

namespace FlashlightierLC.Patches;

public class FlashLightItemPatches
{
    [HarmonyPatch(typeof(FlashlightItem), nameof(FlashlightItem.Start))]
    [HarmonyPostfix]
    public static void OnStart(FlashlightItem __instance)
    {
        switch (__instance.flashlightTypeID)
        {
            //Pro flash
            case 0:
                break;
            //Smol flash
            case 1:
                break;

        }
    }
}
