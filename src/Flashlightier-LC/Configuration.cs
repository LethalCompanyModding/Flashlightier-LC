using BepInEx.Configuration;

namespace FlashlightierLC;

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
            Config.Bind("SmallFlash", "Size", 55.4f, "The width of the beam as an angle.")
        );

        ProFlashlight = new(
            Config.Bind("ProFlash", "ReplaceEnabled", false, "Is this mod enabled for pro flashlights?"),
            Config.Bind("ProFlash", "Color", 8088, "The temperature color of the light's beam.\n  2700 is a very warm orange\n  4650 is the in-game weak flashlight\n  5000-6500 is roughly daylight or a fluorescent light\n  8000 is the in-game pro flashlight "),
            Config.Bind("ProFlash", "Intensity", 486f, "The light's intensity.\nIf you have sensitive eyes lowering this to 275 can help"),
            Config.Bind("ProFlash", "Size", 73f, "The width of the beam as an angle.")
        );
    }

    internal class FlashlightDefinition
    {
        public readonly ConfigEntry<bool> Enabled;
        public readonly ConfigEntry<int> ColorTemp;
        public readonly ConfigEntry<float> Intensity;
        public readonly ConfigEntry<float> Size;

        internal FlashlightDefinition(ConfigEntry<bool> Enabled, ConfigEntry<int> ColorTemp, ConfigEntry<float> Intensity, ConfigEntry<float> Size)
        {
            this.Enabled = Enabled;
            this.ColorTemp = ColorTemp;
            this.Intensity = Intensity;
            this.Size = Size;
        }
    }
}
