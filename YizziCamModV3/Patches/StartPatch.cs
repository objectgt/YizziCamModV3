using HarmonyLib;
using UnityEngine;
using YizziCamModV3;
namespace YizziCamModV3.Patches
{
    [HarmonyPatch(typeof(GorillaTagger))]
    [HarmonyPatch("Start", MethodType.Normal)]
    internal class StartPatch
    {
        private static void Postfix()
        {
            new GameObject().AddComponent<CameraController>();
            CameraController.Instance.YizziStart();
        }
    }
}