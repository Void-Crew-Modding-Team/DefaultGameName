using VoidManager.MPModChecks;

namespace DefaultGameName
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107";

        public override string Description => "Changes the default game name";
    }
}
