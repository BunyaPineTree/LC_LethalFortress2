using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using ModelReplacement;
using GameNetcodeStuff;
using Unity.Netcode;

namespace LethalFortress2.Replacements
{
    public class EngineerReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "engineerPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.engineerE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.engineerE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }
    public class SpyReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "spyPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.spyE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.spyE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }
    public class SniperReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "sniperPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.sniperE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.sniperE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }
    public class PyroReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "pyroPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.pyroE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.pyroE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }
    public class DemoReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "demoPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.demoE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.demoE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }
    public class ScoutReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "scoutPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }

        protected override void OnEmoteStart(int emoteId)
        {
            if(emoteId == 1)
            {
                var clip = Assets.scoutE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.scoutE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }

    }
    public class SoldierReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "soldierPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.soldierE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.soldierE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }
    public class HeavyReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "heavyPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.heavyE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.heavyE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }
    public class MedicReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "medicPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
        protected override void OnEmoteStart(int emoteId)
        {
            if (emoteId == 1)
            {
                var clip = Assets.medicE1.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
            if (emoteId == 2)
            {
                var clip = Assets.medicE2.GetRandomAudio(StartOfRound.Instance.randomMapSeed);
                controller.movementAudio.PlayOneShot(clip, 0.8f);
            }
        }
    }

}
