//
//  RNTheSurfingFunnyShow.h
//  RNTheSurfingFunnyStory
//
//  Created by Tsing on 10/18/23.
//  Copyright © 2023 Facebook. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <React/RCTBridgeDelegate.h>
#import <UserNotifications/UNUserNotificationCenter.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNTheSurfingFunnyShow : UIResponder<RCTBridgeDelegate, UNUserNotificationCenterDelegate>

+ (instancetype)locharmee_shared;
- (UIViewController *)locharmee_changeRootController:(UIApplication *)application withOptions:(NSDictionary *)launchOptions;

@end

NS_ASSUME_NONNULL_END
