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
     * Displays a toast to the user
     * @param toastText - Text to display on the toast
     * @param showLongToast - Should a long toast be shown?
     */
    @Keep
    public static void ShowToast(String toastText, boolean showLongToast) {

        int toastLength = showLongToast ? Toast.LENGTH_LONG : Toast.LENGTH_SHORT;

        Toast.makeText(UnityPlayer.currentActivity, toastText, toastLength).show();
    }
}