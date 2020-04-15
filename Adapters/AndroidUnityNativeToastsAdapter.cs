#if UNITY_ANDROID

using UnityEngine;

namespace UnityNative.Toasts
{
    public class AndroidUnityNativeToastsAdapter : IUnityNativeToastsAdapter
    {
        /// <summary>
        /// Android package name and class
        /// </summary>
        private const string AndroidClass = "com.UnityNative.Toasts.UnityNativeToastsAdapter";

        /// <summary>
        /// Android method name to call to show a short toast
        /// </summary>
        private const string ShowShortToastMethodName = "ShowShortToast";

        /// <summary>
        /// Android method name to call to show a long toast
        /// </summary>
        private const string ShowLongToastMethodName = "ShowLongToast";

        /// <summary>
        /// UnityNativeToastsAdapter.java
        /// </summary>
        private readonly AndroidJavaClass toastsJavaClass;

        public AndroidUnityNativeToastsAdapter()
        {
            AndroidJNI.AttachCurrentThread();

            toastsJavaClass = new AndroidJavaClass(AndroidClass);
        }

        public void ShowLongToast(string toastText)
        {
            AndroidJNI.AttachCurrentThread();
            
            toastsJavaClass.Call(ShowLongToastMethodName, toastText);
        }

        public void ShowShortToast(string toastText)
        {
            AndroidJNI.AttachCurrentThread();
            
            toastsJavaClass.Call(ShowShortToastMethodName, toastText);
        }
    }
}

#endif //UNITY_ANDROID
