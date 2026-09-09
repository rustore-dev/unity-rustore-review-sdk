using RuStore.Review;
using System;
using UnityEngine;

namespace RuStore.ReviewExample.UI {

    public class ReviewScreen : MonoBehaviour {

        const string CATALOG_APP = "https://www.rustore.ru/catalog/app/";

        [SerializeField]
        private MessageBox _messageBox;

        [SerializeField]
        private LoadingIndicator _loadingIndicator;

        private void Awake() {
            RuStoreReviewManager.Instance.Init();
        }

        public void RequestReviewFlow() {
            _loadingIndicator?.Show();

            RuStoreReviewManager.Instance.RequestReviewFlow(
                onFailure: (error) => {
                    _loadingIndicator?.Hide();
                    ShowError(error);
                },
                onSuccess: () => {
                    _loadingIndicator?.Hide();
                    ShowMessage("Success", "");
                });
        }

        public void LaunchReviewFlow() {
            _loadingIndicator?.Show();

            RuStoreReviewManager.Instance.LaunchReviewFlow(
                onFailure: (error) => {
                    _loadingIndicator?.Hide();
                    ShowError(error);
                },
                onSuccess: () => {
                    _loadingIndicator?.Hide();
                });
        }

        public void OpenReviewInRuStore() {
            var url = CATALOG_APP + Application.identifier;
            Application.OpenURL(url);
        }

        private void ShowError(RuStoreError error) {
            ShowMessage("Error", string.Format("{0}: {1}", error.name, error.description));
        }

        private void ShowMessage(string title, string message, Action onClose = null) {
            _messageBox.Show(
                title: title,
                message: message,
                onClose: onClose);
        }
    }
}
