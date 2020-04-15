package com.UnityNative.Toasts;

import android.widget.Toast;

import com.unity3d.player.UnityPlayer;

import androidx.annotation.Keep;

/**
 * Created by Nicholas Sheehan on 28/05/2018.
 */
@Keep
public class UnityNativeToastsAdapter {

    /***
     * Displays a long toast to the user
     * @param toastText - Text to display on the toast
     */
    @Keep
    public static void ShowLongToast(String toastText) {

        Toast.makeText(UnityPlayer.currentActivity, toastText, Toast.LENGTH_LONG).show();
    }

    /***
     * Displays a short toast to the user
     * @param toastText - Text to display on the toast
     */
    @Keep
    public static void ShowShortToast(String toastText) {

        Toast.makeText(UnityPlayer.currentActivity, toastText, Toast.LENGTH_SHORT).show();
    }
}