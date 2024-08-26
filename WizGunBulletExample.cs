using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Inventory;
using System;
using System.Text;
using System.Linq;
using WizGunBulletAPI;

namespace BulletExampleMod
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    [BepInDependency("mgr.wwag.bulletapi", BepInDependency.DependencyFlags.HardDependency)]
    public class WizGunBulletExample : BaseUnityPlugin
    {
        public const string pluginGuid = "mgr.wwag.bulletexample";
        public const string pluginName = "Bullet Example Mod";
        public const string pluginVersion = "1.0.0";
        internal static ManualLogSource Log;
        internal static string ModPath;
        private void Awake()
        {
            Log = Logger;
            ModPath = Path.GetDirectoryName(Info.Location);
            // Plugin startup logic
            Logger.LogInfo($"Bullet example is loaded!");
            List<IImpactor> impactors = new List<IImpactor>
            {
            };
            BulletManager.New("Poison Lightning", "1", "Bullet full of poison and lightning. Youchies!", impactors)
                .AddIcon(Path.Combine(ModPath, "Assets/poison-lightning.png"));
            SpellManager.New("Poison Lightning", "1", "0", impactors);
        }
    }

}
