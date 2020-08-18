namespace UnityNative.Toasts
{
    public interface IUnityNativeToasts
    {
        void ShowLongToast(string  toastText);
        void ShowShortToast(string toastText);
    }

    public class UnityNativeToasts : IUnityNativeToasts
    {
        private readonly IUnityNativeToastsAdapter adapter;

        public UnityNativeToasts(IUnityNativeToastsAdapter adapter)
        {
            this.adapter = adapter;
        }

        public void ShowLongToast(string toastText)
        {
            adapter.ShowLongToast(toastText);
        }

        public void ShowShortToast(string toastText)
        {
            adapter.ShowShortToast(toastText);
        }

        /// <summary>
        /// Creates a UnityNativeToasts object with the correct platform setup. Use this if not being used with an IoC container
        /// </summary>
        /// <returns>Interface for the detected platform</returns>
        public static IUnityNativeToasts Create()
        {
#if UNITY_ANDROID
            return new UnityNativeToasts(new AndroidUnityNativeToastsAdapter());
#elif UNITY_IOS
            return new UnityNativeToasts(new IosUnityNativeToastsAdapter());
#else
            return new UnityNativeToasts(new NullUnityNativeSharingAdapter());
#endif
        }
    }
}
