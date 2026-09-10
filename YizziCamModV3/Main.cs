using BepInEx;
#pragma warning disable CS0618
namespace YizziCamModV3
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Main : BaseUnityPlugin
    {
        void Awake()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            DontDestroyOnLoad(this);
        }
    }
}
