#if UNITY_IOS

namespace UnityNative.Toasts
{
    public class IosUnityNativeToastsAdapter : IUnityNativeToastsAdapter
    {
        [System.Runtime.InteropServices.DllImport("__Internal")]
        private static extern void UnityNative_Toasts_ShowLongToast(string toastText);

        [System.Runtime.InteropServices.DllImport("__Internal")]
        private static extern void UnityNative_Toasts_ShowShortToast(string toastText);

        public void ShowLongToast(string toastText)
        {
            UnityNative_Toasts_ShowLongToast(toastText);
        }

        public void ShowShortToast(string toastText)
        {
            UnityNative_Toasts_ShowShortToast(toastText);
        }
    }
}

#endif //UNITY_IOS
