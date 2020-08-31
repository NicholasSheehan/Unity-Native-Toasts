//
//  UnityNative_Toasts.mm
//
//  Created by Nicholas Sheehan on 01/06/2018.
//

#import "UnityNative_Toasts.h"
#import "ToastView.h"

inline void ShowToast(const char* toastText, float toastLengthInSeconds)
{
    NSString *toastMessage = [NSString stringWithUTF8String:toastText];
    
    UIViewController* rootViewController = UnityGetGLViewController();
    
    UIView* view = rootViewController.view;
    
    [ToastView showToastInParentView:view withText:toastMessage withDuaration:toastLengthInSeconds];
}

//
// Shows a long toast which lasts 3.5 seconds
//
void UnityNative_Toasts_ShowLongToast(const char* toastText)
{
    ShowToast(toastText, 3.5f);
}

//
// Shows a short toast which lasts 2 seconds
//
void UnityNative_Toasts_ShowShortToast(const char* toastText)
{
    ShowToast(toastText, 2);
}
