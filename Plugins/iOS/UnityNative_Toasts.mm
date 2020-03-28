//
//  UnityNative_Toasts.mm
//
//  Created by Nicholas Sheehan on 01/06/2018.
//

#import "UnityNative_Toasts.h"

inline void ShowToast(const char* toastText, float toastLengthInSeconds)
{
    NSString *message = [NSString stringWithUTF8String:toastText];

    UIAlertController *alert = [UIAlertController alertControllerWithTitle:nil
                                                                   message:message
                                                            preferredStyle:UIAlertControllerStyleAlert];

    UIViewController *rootViewController = UnityGetGLViewController();
    
    [rootViewController presentViewController:alert animated:YES completion:nil];

    dispatch_after(dispatch_time(DISPATCH_TIME_NOW, toastLengthInSeconds * NSEC_PER_SEC), dispatch_get_main_queue(), ^{
        [alert dismissViewControllerAnimated:YES completion:nil];
    });
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
