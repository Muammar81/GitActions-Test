using System;
using System.Collections.Generic;
using System.Threading;
using BornCore.Scene;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Born.Maji.StageSystem
{
    [RequireComponent(typeof(Collider))]
    public abstract class BaseStage : SceneBehaviour, IStage
    {
        public event Action<IStage> OnStageEnter;
        public event Action<IStage> OnStageExit;

        [SerializeField] protected AudioClip myVoiceOverClip;
        [SerializeField] protected List<GameObject> gameObjectsToActivate;
        [SerializeField] protected Color myTintColor;
        
        protected List<StageStep> Steps;

        protected override void Awake()
        {
            base.Awake();
            GetComponent<Collider>().isTrigger = true;
            gameObjectsToActivate.ForEach(obj => obj.SetActive(false));
            
            Steps = new List<StageStep>
            {
                new StageStep
                {
                    VoiceOver = myVoiceOverClip,
                    GameObjectsToActivate = gameObjectsToActivate,
                    TintColor = myTintColor
                }
            };
        }

        public virtual async UniTask EnterStageAsync(CancellationToken token)
        {
            OnStageEnter?.Invoke(this);
            await ExecuteStepsAsync(token);
        }

        public virtual async UniTask UpdateStageAsync(CancellationToken token)
        {
            await UniTask.DelayFrame(1, cancellationToken: token);
        }

        public virtual async UniTask ExitStageAsync(CancellationToken token)
        {
            gameObjectsToActivate.ForEach(obj => obj.SetActive(false));
            OnStageExit?.Invoke(this);
            await UniTask.DelayFrame(1, cancellationToken: token);
        }

        private async UniTask ExecuteStepsAsync(CancellationToken token)
        {
            foreach (var step in Steps)
            {
                //TODO: Play VoiceOver and animation here
                await UniTask.DelayFrame(1, cancellationToken: token);
            }
        }
    }
}