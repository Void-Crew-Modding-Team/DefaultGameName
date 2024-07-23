using BepInEx.Configuration;

namespace DefaultGameName
{
    internal class Configs
    {
        internal static ConfigEntry<string> GameNameConfig;

        internal static void Load(BepinPlugin plugin)
        {
            GameNameConfig = plugin.Config.Bind("DefaultGameName", "GameName", "Custom Name Room");
        }
    }
}
