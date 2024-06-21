using BepInEx;
using BepInEx.Logging;
using Skins;
using System.IO;
using WizGunCosmeticsAPI;

namespace WizGunCosmeticsExample
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    [BepInDependency("cyantist.wwag.cosmeticsapi", BepInDependency.DependencyFlags.HardDependency)]
    public class WizGunCosmeticsExample : BaseUnityPlugin
    {
        public const string pluginGuid = "cyantist.wwag.cosmeticsexample";
        public const string pluginName = "Cosmetics Example Mod";
        public const string pluginVersion = "1.0.0";

        internal static ManualLogSource Log;
        internal static string ModPath;

        public void Awake()
        {
            Log = Logger;
            ModPath = Path.GetDirectoryName(Info.Location);

            Log.LogInfo("Cosmetics Example Mod Loaded");

            GlamourManager.New(ItemType.Robes, "custom", "Custom Robes", "Custom Robes by Cyantist")
                                            .AddIcon(Path.Combine(ModPath, "Assets/robes-custom.png"))
                                            .AddSkin(SkinID.BodyForward, Path.Combine(ModPath, "Assets/custom-body-forward.png"))
                                            .AddSkin(SkinID.BodyBackward, Path.Combine(ModPath, "Assets/custom-body-backward.png"))
                                            .AddSkin(SkinID.ArmLeftForward, Path.Combine(ModPath, "Assets/custom-arm-left-forward.png"))
                                            .AddSkin(SkinID.ArmLeftBackward, Path.Combine(ModPath, "Assets/custom-arm-left-backward.png"))
                                            .AddSkin(SkinID.ArmRightForward, Path.Combine(ModPath, "Assets/custom-arm-right-forward.png"))
                                            .AddSkin(SkinID.ArmRightBackward, Path.Combine(ModPath, "Assets/custom-arm-right-backward.png"));

            GlamourManager.New(ItemType.Robes, "test", "Test Robes", "Test Robes by Cyantist")
                                            .AddIcon(Path.Combine(ModPath, "Assets/robes-custom.png"))
                                            .AddSkin(SkinID.BodyForward, Path.Combine(ModPath, "Assets/custom-body-forward.png"))
                                            .AddSkin(SkinID.BodyBackward, Path.Combine(ModPath, "Assets/custom-body-backward.png"))
                                            .AddSkin(SkinID.ArmLeftForward, Path.Combine(ModPath, "Assets/custom-arm-left-forward.png"))
                                            .AddSkin(SkinID.ArmLeftBackward, Path.Combine(ModPath, "Assets/custom-arm-left-backward.png"))
                                            .AddSkin(SkinID.ArmRightForward, Path.Combine(ModPath, "Assets/custom-arm-right-forward.png"))
                                            .AddSkin(SkinID.ArmRightBackward, Path.Combine(ModPath, "Assets/custom-arm-right-backward.png"));

            Log.LogInfo("Glamours Added");
        }
    }

    
}
