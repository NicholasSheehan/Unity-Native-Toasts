namespace UnityNative.Toasts
{
    public interface IUnityNativeToastsAdapter
    {
        void ShowLongToast(string  toastText);
        void ShowShortToast(string toastText);
    }
}
