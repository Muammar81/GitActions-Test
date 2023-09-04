using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Born.Maji.StageSystem
{
    public interface IStage
    {
        UniTask EnterStageAsync(CancellationToken token);
        UniTask UpdateStageAsync(CancellationToken token);
        UniTask ExitStageAsync(CancellationToken token);
    }

    public class StageStep
    {
        public AudioClip VoiceOver;
        public List<GameObject> GameObjectsToActivate;
        public Color TintColor;
    }
}