namespace UnityNative.Toasts.Example
{
    public static class UnityNativeToastsHelper
    {
        private static readonly IUnityNativeToasts unityNativeToasts;

        static UnityNativeToastsHelper()
        {
            unityNativeToasts = UnityNativeToasts.Create();
        }

        /// <summary>
        /// Shows a long toast with the specified text
        /// </summary>
        /// <param name="toastText">Text to display on the toast</param>
        public static void ShowLongToast(string toastText)
        {
            unityNativeToasts.ShowLongToast(toastText);
        }

        /// <summary>
        /// Shows a short toast with the specified text
        /// </summary>
        /// <param name="toastText">Text to display on the toast</param>
        public static void ShowShortText(string toastText)
        {
            unityNativeToasts.ShowShortToast(toastText);
        }
    }
}
