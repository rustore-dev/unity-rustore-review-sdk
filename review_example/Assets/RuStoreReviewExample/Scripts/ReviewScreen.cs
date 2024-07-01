using RuStore.Review;
using System;
using UnityEngine;

namespace RuStore.UnitySample.UI {

    public class ReviewScreen : MonoBehaviour {

        [SerializeField]
        private MessageBox _messageBox;

        private void Awake() {
            RuStoreReviewManager.Instance.Init();
        }

        public void RequestReviewFlow() {
            RuStoreReviewManager.Instance.RequestReviewFlow(
                onFailure: (error) => {
                    ShowMessage("Error", string.Format("{0}: {1}", error.name, error.description));
                },
                onSuccess: () => {
                    ShowMessage("Success", "");
                });
        }

        public void LaunchReviewFlow() {
            RuStoreReviewManager.Instance.LaunchReviewFlow(
                onFailure: (error) => {
                    ShowMessage("Error", string.Format("{0}: {1}", error.name, error.description));
                },
                onSuccess: () => {
                });
        }
        private void ShowMessage(string title, string message, Action onClose = null) {
            _messageBox.Show(
                title: title,
                message: message,
                onClose: onClose);
        }
    }
}
