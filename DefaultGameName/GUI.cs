using VoidManager.CustomGUI;
using VoidManager.Utilities;

namespace DefaultGameName
{
    internal class GUI : ModSettingsMenu
    {
        public override string Name() => "Default Game Name";

        public override void Draw()
        {
            GUITools.DrawTextField("Game Name", ref Configs.GameNameConfig);
        }
    }
}
