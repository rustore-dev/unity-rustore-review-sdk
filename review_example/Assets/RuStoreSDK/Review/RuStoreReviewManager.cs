using UnityEngine;
using System;
using RuStore.Internal;
using RuStore.Response.Internal;

namespace RuStore.Review {

    public class RuStoreReviewManager {

        public static string PluginVersion = "2.0.0";

        private static RuStoreReviewManager _instance;
        private static bool _isInstanceInitialized;

        private bool _isInitialized;
        public bool IsInitialized => _isInitialized;
        private AndroidJavaObject _managerWrapper;

        public static RuStoreReviewManager Instance {
            get {
                if (!_isInstanceInitialized) {
                    _isInstanceInitialized = true;
                    _instance = new RuStoreReviewManager();
                }
                return _instance;
            }
        }

        private RuStoreReviewManager() {
        }

        public bool Init() {
            if (_isInitialized) {
                Debug.LogError("Error: RuStore In-App Review Manager is already initialized");
                return false;
            }

            if (Application.platform != RuntimePlatform.Android) {
                return false;
            }

            CallbackHandler.InitInstance();

            using (var managerClass = new AndroidJavaClass("ru.rustore.unitysdk.review.RuStoreUnityReviewManager")) {
                _managerWrapper = managerClass.GetStatic<AndroidJavaObject>("INSTANCE");
            }

            _managerWrapper.Call("init", "unity");
            _isInitialized = true;

            return true;
        }

        public void RequestReviewFlow(Action<RuStoreError> onFailure, Action onSuccess) {
            if (!IsPlatformSupported(onFailure)) {
                return;
            }

            var listener = new ReviewResponseListener(onFailure, onSuccess);
            _managerWrapper.Call("requestReviewFlow", listener);
        }

        public void LaunchReviewFlow(Action<RuStoreError> onFailure, Action onSuccess) {
            if (!IsPlatformSupported(onFailure)) {
                return;
            }

            var listener = new ReviewResponseListener(onFailure, onSuccess);
            _managerWrapper.Call("launchReviewFlow", listener);
        }

        private bool IsPlatformSupported(Action<RuStoreError> onFailure) {
            if (Application.platform != RuntimePlatform.Android) {
                onFailure?.Invoke(new RuStoreError() {
                    name = "RuStoreReviewManagerError",
                    description = "Unsupported platform"
                });
                return false;
            }

            return true;
        }
    }
}
