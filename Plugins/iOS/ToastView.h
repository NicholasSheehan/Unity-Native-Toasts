//
//  ToastView.h
//
//  Created by Nicholas Sheehan on 31/08/2020.
//  Sourced from: https://stackoverflow.com/a/20904416
//

#import <UIKit/UIKit.h>

@interface ToastView : UIView

@property (strong, nonatomic) NSString *text;

+ (void)showToastInParentView: (UIView *)parentView withText:(NSString *)text withDuaration:(float)duration;

@end
