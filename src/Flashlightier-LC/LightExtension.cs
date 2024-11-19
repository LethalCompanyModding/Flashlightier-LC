using UnityEngine;
using FlashlightierLC.Config;

namespace FlashlightierLC;

internal static class LightExt
{
    internal static void ModifyLight(this Light self, FlashlightDefinition def)
    {
        if (!def.Enabled.Value)
            return;

        self.colorTemperature = def.ColorTemp.Value;
        self.intensity = def.Intensity.Value;
        self.spotAngle = def.Size.Value;
    }

    internal static void ModifyFlashlight(this FlashlightItem self, FlashlightDefinition def)
    {
        if (!def.Enabled.Value)
            return;

        self.initialIntensity = def.Intensity.Value;
        self.flashlightBulb.ModifyLight(def);
    }
}
