using UnityEngine;

namespace UnityNative.Toasts.Example
{
    public class ShowShortToastButton : MonoBehaviour
    {
        /// <summary>
        /// Toast text to show
        /// </summary>
        [SerializeField] private string toastText = "This is an example of a short toast text";

        /// <summary>
        /// Shows a short toast, called via button
        /// </summary>
        public void ShowShortToast()
        {
            UnityNativeToastsHelper.ShowShortText(toastText);
        }
    }
}
