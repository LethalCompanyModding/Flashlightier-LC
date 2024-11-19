using BepInEx.Configuration;

namespace FlashlightierLC.Config;

internal class FlashlightDefinition
{
    public readonly ConfigEntry<bool> Enabled;
    public readonly ConfigEntry<bool> UseColorTempValue;
    public readonly ConfigEntry<int> ColorTemp;
    public readonly ConfigEntry<float> Intensity;
    public readonly ConfigEntry<float> Size;
    public readonly ConfigEntry<string> LightColorString;
    public readonly UnityEngine.Color LightColor;

    internal FlashlightDefinition(ConfigEntry<bool> Enabled, ConfigEntry<int> ColorTemp, ConfigEntry<float> Intensity, ConfigEntry<float> Size, ConfigEntry<bool> UseColorTempValue, ConfigEntry<string> LightColorString)
    {
        this.Enabled = Enabled;
        this.ColorTemp = ColorTemp;
        this.Intensity = Intensity;
        this.Size = Size;
        this.UseColorTempValue = UseColorTempValue;
        this.LightColorString = LightColorString;

        var (Red, Green, Blue) = GetTupleFromString(LightColorString.Value);
        LightColor = new(Red, Green, Blue);
    }

    internal static (float Red, float Green, float Blue) GetTupleFromString(string Input)
    {
        //RED,GREEN,BLUE
        var values = Input.Split(',');

        if (values.Length < 3)
        {
            throw new("Unable to parse color value, not enough values");
        }
        if (!float.TryParse(values[0], out var Red))
        {
            throw new($"Unable to parse color value red | {values[0]}");
        }
        if (!float.TryParse(values[1], out var Green))
        {
            throw new($"Unable to parse color value green | {values[1]}");
        }
        if (!float.TryParse(values[2], out var Blue))
        {
            throw new($"Unable to parse color value blue | {values[2]}");
        }

        return (Red, Green, Blue);
    }
}
