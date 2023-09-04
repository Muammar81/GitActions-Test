using System;
using System.Threading;
using Born.Maji.StageSystem;
using BornCore.Scene;
using Cysharp.Threading.Tasks;
using UnityEngine;
using VContainer;

namespace Born.Maji.Player
{
    [RequireComponent(typeof(Collider))]
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerStageController : SceneBehaviour
    {
        [Inject] private IStage currentStage;
        private CancellationTokenSource cts;
        private bool isUpdating;

        protected override void Awake()
        {
            base.Awake();
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Rigidbody>().isKinematic = true;
            cts = new CancellationTokenSource();
        }

        private void OnDestroy() => cts?.Cancel();

        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent<IStage>(out var newStage)) return;
            if (newStage == currentStage) return;

            cts?.Cancel();
            cts = new CancellationTokenSource();
            currentStage = newStage;
            currentStage.EnterStageAsync(cts.Token).Forget();
        }

        private void OnTriggerExit(Collider other)
        {
            if (!other.TryGetComponent<IStage>(out var newStage)) return;
            if (currentStage != newStage) return;

            cts?.Cancel();
            currentStage.ExitStageAsync(cts.Token).Forget();
            currentStage = null;
            cts = new CancellationTokenSource();
        }


        async void Update()
        {
            if (currentStage == null || isUpdating) return;

            isUpdating = true;
            try
            {
                await currentStage.UpdateStageAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Reset isUpdating flag here so Update can run again if needed
            }
            finally
            {
                isUpdating = false;
            }
        }
    }
}