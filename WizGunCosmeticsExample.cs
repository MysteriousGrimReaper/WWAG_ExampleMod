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
        public const string pluginVersion = "1.0.1";

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
                                            .AddIcon(Path.Combine(ModPath, "Assets/hat_custom.png"))
                                            .AddSkin(SkinID.HatFrontForward, Path.Combine(ModPath, "Assets/hat_front_forward.png"))
                                            .AddSkin(SkinID.HatFrontBackward, Path.Combine(ModPath, "Assets/hat_front_backward.png"))
                                            .AddSkin(SkinID.HatBackForward, Path.Combine(ModPath, "Assets/hat_back_forward.png"))
                                            .AddSkin(SkinID.HatBackBackward, Path.Combine(ModPath, "Assets/hat_back_backward.png"))
                                            .AddSkin(SkinID.HatMiddleForward, Path.Combine(ModPath, "Assets/hat_middle_forward.png"))
                                            .AddSkin(SkinID.HatMiddleBackward, Path.Combine(ModPath, "Assets/hat_middle_backward.png"));

            /*GlamourManager.New(ItemType.Gloves, "customgloves", "Custom Gloves", "Custom Example Gloves")
                                            .AddIcon(Path.Combine(ModPath, "Assets/elbow_custom.png"))
                                            .AddSkin(SkinID.ElbowLeftForward, Path.Combine(ModPath, "Assets/elbow_left_forward.png"))
                                            .AddSkin(SkinID.ElbowLeftBackward, Path.Combine(ModPath, "Assets/elbow_left_backward.png"))
                                            .AddSkin(SkinID.ElbowRightForward, Path.Combine(ModPath, "Assets/elbow_right_forward.png"))
                                            .AddSkin(SkinID.ElbowRightBackward, Path.Combine(ModPath, "Assets/elbow_right_backward.png"))
                                            .AddColorSlot(ColorSlot.Gloves, Color.white);*/

            GlamourManager.New(ItemType.Boots, "customboots", "Custom Boots", "Custom Example Boots")
                                            .AddIcon(Path.Combine(ModPath, "Assets/foot_custom.png"))
                                            .AddSkin(SkinID.FootLeft, Path.Combine(ModPath, "Assets/foot_left.png"))
                                            .AddSkin(SkinID.FootRight, Path.Combine(ModPath, "Assets/foot_right.png"));

            GlamourManager.New(ItemType.Backpack, "custombackpack", "Custom Backpack", "Custom Example Backpack")
                                            .AddIcon(Path.Combine(ModPath, "Assets/backpack_custom.png"))
                                            .AddSkin(SkinID.BackpackForward, Path.Combine(ModPath, "Assets/backpack_forward.png"))
                                            .AddSkin(SkinID.BackpackBackward, Path.Combine(ModPath, "Assets/backpack_backward.png"));

            GlamourManager.New(ItemType.Amulet, "customamulet", "Custom Amulet", "Custom Example Amulet")
                                            .AddIcon(Path.Combine(ModPath, "Assets/amulet_custom.png"))
                                            .AddSkin(SkinID.CollarForward, Path.Combine(ModPath, "Assets/amulet_forward.png"))
                                            .AddSkin(SkinID.CollarBackward, Path.Combine(ModPath, "Assets/amulet_backward.png"));

            GlamourManager.New(ItemType.Mask, "custommask", "Custom Mask", "Custom Example Mask")
                                            .AddIcon(Path.Combine(ModPath, "Assets/mask_custom.png"))
                                            .AddSkin(SkinID.MaskForward, Path.Combine(ModPath, "Assets/mask_forward.png"))
                                            .AddSkin(SkinID.MaskBackward, Path.Combine(ModPath, "Assets/mask_backward.png"));
            // Empty sprite example
            //.AddSkin(SkinID.HatMiddleBackward)

            Log.LogInfo("Glamours Added");
        }
    }

    
}
