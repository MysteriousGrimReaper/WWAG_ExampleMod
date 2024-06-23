using BepInEx;
using BepInEx.Logging;
using Skins;
using System.IO;
using UnityEngine;
using WizGunCosmeticsAPI;

namespace WizGunCosmeticsExample
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    [BepInDependency("cyantist.wwag.cosmeticsapi", BepInDependency.DependencyFlags.HardDependency)]
    public class WizGunCosmeticsExample : BaseUnityPlugin
    {
        public const string pluginGuid = "cyantist.wwag.cosmeticsexample";
        public const string pluginName = "Cosmetics Example Mod";
        public const string pluginVersion = "1.1.0";

        internal static ManualLogSource Log;
        internal static string ModPath;

        public void Awake()
        {
            Log = Logger;
            ModPath = Path.GetDirectoryName(Info.Location);

            Log.LogInfo("Cosmetics Example Mod Loaded");

            GlamourManager.New(ItemType.Robes, "customrobe", "Custom Robes", "Custom Example Robes")
                                            .AddIcon(Path.Combine(ModPath, "Assets/robes-custom.png"))
                                            .AddSkin(SkinID.BodyForward, Path.Combine(ModPath, "Assets/custom-body-forward.png"))
                                            .AddSkin(SkinID.BodyBackward, Path.Combine(ModPath, "Assets/custom-body-backward.png"))
                                            .AddSkin(SkinID.ArmLeftForward, Path.Combine(ModPath, "Assets/custom-arm-left-forward.png"))
                                            .AddSkin(SkinID.ArmLeftBackward, Path.Combine(ModPath, "Assets/custom-arm-left-backward.png"))
                                            .AddSkin(SkinID.ArmRightForward, Path.Combine(ModPath, "Assets/custom-arm-right-forward.png"))
                                            .AddSkin(SkinID.ArmRightBackward, Path.Combine(ModPath, "Assets/custom-arm-right-backward.png"));

            GlamourManager.New(ItemType.Hat, "customhat", "Custom Hat", "Custom Example Hat")
                                            .AddIcon(Path.Combine(ModPath, "Assets/hat-custom.png"))
                                            .AddSkin(SkinID.HatFrontForward)
                                            .AddSkin(SkinID.HatFrontBackward)
                                            .AddSkin(SkinID.HatBackForward, Path.Combine(ModPath, "Assets/hat-back-forward.png"))
                                            .AddSkin(SkinID.HatBackBackward, Path.Combine(ModPath, "Assets/hat-back-backward.png"))
                                            .AddSkin(SkinID.HatMiddleForward, Path.Combine(ModPath, "Assets/hat-middle-forward.png"))
                                            .AddSkin(SkinID.HatMiddleBackward, Path.Combine(ModPath, "Assets/hat-middle-backward.png"));

            GlamourManager.New(ItemType.Gloves, "customgloves", "Custom Gloves", "Custom Example Gloves")
                                            .AddIcon(Path.Combine(ModPath, "Assets/elbow-custom.png"))
                                            .AddSkin(SkinID.ElbowLeftForward, Path.Combine(ModPath, "Assets/elbow-left-forward.png"))
                                            .AddSkin(SkinID.ElbowLeftBackward, Path.Combine(ModPath, "Assets/elbow-left-backward.png"))
                                            .AddSkin(SkinID.ElbowRightForward, Path.Combine(ModPath, "Assets/elbow-right-forward.png"))
                                            .AddSkin(SkinID.ElbowRightBackward, Path.Combine(ModPath, "Assets/elbow-right-backward.png"))
                                            .AddColorSlot(ColorSlot.Gloves, Color.white);

            GlamourManager.New(ItemType.Boots, "customboots", "Custom Boots", "Custom Example Boots")
                                            .AddIcon(Path.Combine(ModPath, "Assets/foot-custom.png"))
                                            .AddSkin(SkinID.FootLeft, Path.Combine(ModPath, "Assets/foot-left.png"))
                                            .AddSkin(SkinID.FootRight, Path.Combine(ModPath, "Assets/foot-right.png"));

            GlamourManager.New(ItemType.Backpack, "custombackpack", "Custom Backpack", "Custom Example Backpack")
                                            .AddIcon(Path.Combine(ModPath, "Assets/backpack-custom.png"))
                                            .AddSkin(SkinID.BackpackForward, Path.Combine(ModPath, "Assets/backpack-forward.png"))
                                            .AddSkin(SkinID.BackpackBackward, Path.Combine(ModPath, "Assets/backpack-backward.png"));

            GlamourManager.New(ItemType.Amulet, "customamulet", "Custom Amulet", "Custom Example Amulet")
                                            .AddIcon(Path.Combine(ModPath, "Assets/amulet-custom.png"))
                                            .AddSkin(SkinID.CollarForward, Path.Combine(ModPath, "Assets/amulet-forward.png"))
                                            .AddSkin(SkinID.CollarBackward, Path.Combine(ModPath, "Assets/amulet-backward.png"));

            GlamourManager.New(ItemType.Mask, "custommask", "Custom Mask", "Custom Example Mask")
                                            .AddIcon(Path.Combine(ModPath, "Assets/mask-custom.png"))
                                            .AddSkin(SkinID.MaskForward, Path.Combine(ModPath, "Assets/mask-forward.png"))
                                            .AddSkin(SkinID.MaskBackward, Path.Combine(ModPath, "Assets/mask-backward.png"));

            Log.LogInfo("Glamours Added");
        }
    }

    
}
