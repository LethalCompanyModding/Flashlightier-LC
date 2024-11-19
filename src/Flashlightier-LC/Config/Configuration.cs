using BepInEx.Configuration;
using UnityEngine;

namespace FlashlightierLC.Config;

internal class FlashlightConfig
{

    public readonly FlashlightDefinition SmallFlashlight;
    public readonly FlashlightDefinition ProFlashlight;

    internal FlashlightConfig(ConfigFile Config)
    {
        //Small Flashlight
        SmallFlashlight = new(
            Config.Bind("SmallFlash", "ReplaceEnabled", false, "Is this mod enabled for small flashlights?"),
            Config.Bind("SmallFlash", "Color", 4678, "The temperature color of the light's beam.\n  2700 is a very warm orange\n  4650 is the in-game weak flashlight\n  5000-6500 is roughly daylight or a fluorescent light\n  8000 is the in-game pro flashlight "),
            Config.Bind("SmallFlash", "Intensity", 397f, "The light's intensity.\nIf you have sensitive eyes lowering this to 275 can help"),
            Config.Bind("SmallFlash", "Size", 55.4f, "The width of the beam as an angle."),
            Config.Bind("SmallFlash", "UseColorTempValue", true, "The game uses color temp to describe the light\nSetting this to false uses the RGB color instead"),
            Config.Bind("SmallFlash", "LightColor", "128,128,128", "The color to use for the light.\nFollows the format 'Red,Green,Blue'\nIf you don't know what to put here google 'color picker'")
        );

        ProFlashlight = new(
            Config.Bind("ProFlash", "ReplaceEnabled", false, "Is this mod enabled for pro flashlights?"),
            Config.Bind("ProFlash", "Color", 8088, "The temperature color of the light's beam.\n  2700 is a very warm orange\n  4650 is the in-game weak flashlight\n  5000-6500 is roughly daylight or a fluorescent light\n  8000 is the in-game pro flashlight "),
            Config.Bind("ProFlash", "Intensity", 486f, "The light's intensity.\nIf you have sensitive eyes lowering this to 275 can help"),
            Config.Bind("ProFlash", "Size", 73f, "The width of the beam as an angle."),
            Config.Bind("ProFlash", "UseColorTempValue", true, "The game uses color temp to describe the light\nSetting this to false uses the RGB color instead"),
            Config.Bind("ProFlash", "LightColor", "128,128,128", "The color to use for the light.\nFollows the format 'Red,Green,Blue'\nIf you don't know what to put here google 'color picker'")
        );
    }
}
