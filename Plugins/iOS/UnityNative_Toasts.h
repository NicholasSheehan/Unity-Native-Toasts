//
//  UnityNative_Toasts.h
//
//  Created by Nicholas Sheehan on 01/06/2018.
//

#import "UnityAppController.h"

extern UIViewController* UnityGetGLViewController();

#ifdef __cplusplus
extern "C" {
#endif
    void UnityNative_Toasts_ShowLongToast(const char* toastText);
    void UnityNative_Toasts_ShowShortToast(const char* toastText);
#ifdef __cplusplus
}
#endif
