using HarmonyLib;
using System;
using System.Reflection;

namespace DefaultGameName
{
    [HarmonyPatch]
    internal class HostGameNamePatchPatch
    {
        internal static bool SetName = false;

        [HarmonyTargetMethod]
        static MethodBase GetMethod()
        {
            return AccessTools.Method(AccessTools.TypeByName("VoidManager.MPModChecks.HostGameNamePatch"), "SetGameName", new Type[] { typeof(string) });
        }

        [HarmonyPrefix]
        static void SetGameName(ref string name)
        {
            if (SetName)
            {
                SetName = false;
                name = Configs.GameNameConfig.Value;
            }
        }
    }

    [HarmonyPatch(typeof(PhotonService))]
    internal class PhotonServicePatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("PhotonCreateRoom")]
        static void PhotonCreateRoom()
        {
            HostGameNamePatchPatch.SetName = true;
        }
    }
}
