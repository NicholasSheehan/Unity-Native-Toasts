using UnityEngine;

namespace UnityNative.Toasts.Example
{
    public class ShowLongToastButton : MonoBehaviour
    {
        /// <summary>
        /// Toast text to show
        /// </summary>
        [SerializeField]
        private string toastText = "This is an example of a long toast text";

        /// <summary>
        /// Shows a long toast, called via button
        /// </summary>
        public void ShowLongToast()
        {
            UnityNativeToastsHelper.ShowLongToast(toastText);
        }
    }
}
