using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using ModelReplacement;
using BepInEx.Configuration;
using LethalFortress2.Replacements;
using System.Collections.Generic;
using System;
//using System.Numerics;

namespace LethalFortress2
{




    [BepInPlugin("meow.LethalFortress2", "Lethal Fortress 2", "0.1.1")]
    [BepInDependency("meow.ModelReplacementAPI", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("x753.More_Suits", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigFile config;

        // Universal config options 
        public static ConfigEntry<bool> defaultScoutSkin { get; private set; }

        private static void InitConfig()
        {
            defaultScoutSkin = config.Bind<bool>("Suits to Replace Settings", "Enable Scout as default", false, "Enable to replace every non-TF2 suit with Scout.");

        }
        private void Awake()
        {
            config = base.Config;
            InitConfig();
            Assets.PopulateAssets();

            // Plugin startup logic
            
            ModelReplacementAPI.RegisterSuitModelReplacement("Engineer", typeof(EngineerReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Spy", typeof(SpyReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Sniper", typeof(SniperReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Pyro", typeof(PyroReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Demoman", typeof(DemoReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Scout", typeof(ScoutReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Soldier", typeof(SoldierReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Heavy", typeof(HeavyReplacement));
            ModelReplacementAPI.RegisterSuitModelReplacement("Medic", typeof(MedicReplacement));

            if (defaultScoutSkin.Value){
                ModelReplacementAPI.RegisterModelReplacementDefault(typeof(ScoutReplacement));
            }
            

            Harmony harmony = new Harmony("meow.LethalFortress2");
            harmony.PatchAll();
            Logger.LogInfo($"Plugin {"meow.LethalFortress2"} is loaded!");
        }
    }
    public static class Assets
    {
        // Replace mbundle with the Asset Bundle Name from your unity project 
        public static string mainAssetBundleName = "tf2bundle";
        public static AssetBundle MainAssetBundle = null;

        public static RandomAudioClip scoutE1 = new RandomAudioClip();
        public static RandomAudioClip scoutE2 = new RandomAudioClip();
        public static RandomAudioClip engineerE1 = new RandomAudioClip();
        public static RandomAudioClip engineerE2 = new RandomAudioClip();
        public static RandomAudioClip spyE1 = new RandomAudioClip();
        public static RandomAudioClip spyE2 = new RandomAudioClip();
        public static RandomAudioClip sniperE1 = new RandomAudioClip();
        public static RandomAudioClip sniperE2 = new RandomAudioClip();
        public static RandomAudioClip pyroE1 = new RandomAudioClip();
        public static RandomAudioClip pyroE2 = new RandomAudioClip();
        public static RandomAudioClip demoE1 = new RandomAudioClip();
        public static RandomAudioClip demoE2 = new RandomAudioClip();
        public static RandomAudioClip soldierE1 = new RandomAudioClip();
        public static RandomAudioClip soldierE2 = new RandomAudioClip();
        public static RandomAudioClip heavyE1 = new RandomAudioClip();
        public static RandomAudioClip heavyE2 = new RandomAudioClip();
        public static RandomAudioClip medicE1 = new RandomAudioClip();
        public static RandomAudioClip medicE2 = new RandomAudioClip();


        private static string GetAssemblyName() => Assembly.GetExecutingAssembly().FullName.Split(',')[0];
        public static void PopulateAssets()
        {
            if (MainAssetBundle == null)
            {
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetAssemblyName() + "." + mainAssetBundleName))
                {
                    MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }

            }
            //E1 => dance E2 => point
            scoutE1.AddAudio("Scout_cheers01");
            scoutE1.AddAudio("Scout_battlecry01");
            scoutE1.AddAudio("Scout_cheers05");

            scoutE2.AddAudio("Scout_jeers02");
            scoutE2.AddAudio("Scout_invinciblenotready02");
            scoutE2.AddAudio("Scout_invinciblenotready02");
            scoutE2.AddAudio("Scout_award09");
            scoutE2.AddAudio("Scout_cloakedspy03");

            engineerE1.AddAudio("Engineer_cheers02");
            engineerE1.AddAudio("Engineer_battlecry07");

            engineerE2.AddAudio("Engineer_dominationspy07");
            engineerE2.AddAudio("Engineer_cloakedspy03");

            spyE1.AddAudio("Spy_autocappedintelligence03");
            spyE1.AddAudio("Spy_battlecry01");

            spyE2.AddAudio("Spy_DominationScout01");
            spyE2.AddAudio("Spy_taunts05");

            sniperE1.AddAudio("Cm_sniper_matchwon_08");
            sniperE1.AddAudio("Sniper_cheers04");
            sniperE1.AddAudio("Sniper_cheers02");
            sniperE1.AddAudio("Sniper_battlecry05");

            sniperE2.AddAudio("Sniper_domination13");
            sniperE2.AddAudio("Sniper_specialcompleted13");
            sniperE2.AddAudio("Sniper_jeers03");
            sniperE2.AddAudio("Sniper_cloakedspy02");
            sniperE2.AddAudio("Sniper_go01");


            pyroE1.AddAudio("Pyro_laughevil04");
            pyroE1.AddAudio("Pyro_positivevocalization01");
            pyroE1.AddAudio("Pyro_laughevil02");

            pyroE2.AddAudio("Pyro_jeers02");
            pyroE2.AddAudio("Pyro_battlecry02");
            pyroE2.AddAudio("Pyro_cloakedspy01");

            demoE1.AddAudio("Demoman_goodjob01");
            demoE1.AddAudio("Demoman_cheers02");
            demoE1.AddAudio("Demoman_battlecry06");
            demoE1.AddAudio("Demoman_battlecry01");

            demoE2.AddAudio("Demoman_jeers01");
            demoE2.AddAudio("Demoman_cloakedspy01");
            demoE2.AddAudio("Demoman_cloakedspy02");
            demoE2.AddAudio("Demoman_go01");

            soldierE1.AddAudio("Soldier_sf12_badmagic12");
            soldierE1.AddAudio("Soldier_cheers01");
            soldierE1.AddAudio("Soldier_cheers06");
            soldierE1.AddAudio("Soldier_cheers03");

            soldierE2.AddAudio("Cm_soldier_summary_callout_01");
            soldierE2.AddAudio("Soldier_DominationSpy05");
            soldierE2.AddAudio("Soldier_HatOverHeartTaunt02");
            soldierE2.AddAudio("Soldier_HatOverHeartTaunt01");
            soldierE2.AddAudio("Soldier_jeers01");
            soldierE2.AddAudio("Soldier_cloakedspy02");

            heavyE1.AddAudio("Cm_heavy_summary_callout_06");
            heavyE1.AddAudio("Cm_heavy_matchwon_10");
            heavyE1.AddAudio("Cm_heavy_pregamefirst_09");
            heavyE1.AddAudio("Heavy_specialcompleted11");
            heavyE1.AddAudio("Heavy_laughterbig01");
            heavyE1.AddAudio("Heavy_positivevocalization02");

            heavyE2.AddAudio("Heavy_jeers03");
            heavyE2.AddAudio("Heavy_specialcompleted09");
            heavyE2.AddAudio("Heavy_meleedare07");
            heavyE2.AddAudio("Heavy_cloakedspy03");
            heavyE2.AddAudio("Heavy_go03");

            medicE1.AddAudio("Medic_positivevocalization02");
            medicE1.AddAudio("Medic_cheers01");

            medicE2.AddAudio("Medic_autocappedintelligence02");
            medicE2.AddAudio("Medic_jeers05");
            medicE2.AddAudio("Medic_cloakedspy02");
        }

        public static AudioClip GetAudioClipFromName(string name) =>  Assets.MainAssetBundle.LoadAsset(name) as AudioClip;

        public class RandomAudioClip
        {
            List<AudioClip> audioClipList = new List<AudioClip>();

            public AudioClip GetRandomAudio(int seed)
            {
                System.Random r = new System.Random();
                int n = r.Next(audioClipList.Count);
                Console.WriteLine($"Get audio N {audioClipList.Count} > {n}");
                return audioClipList[n];
            }

            public void AddAudio(string name)
            {
                var clip = Assets.GetAudioClipFromName(name);
                if (clip != null) { audioClipList.Add(clip); }
                else
                {
                    Console.WriteLine($"clip {name} null");
                }
               
            }




        }
    }

}