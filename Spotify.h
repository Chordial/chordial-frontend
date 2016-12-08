//
//  Spotify.h
//  Chordial-Music
//
//  Created by Ziv Kaputa on 12/3/16.
//  Copyright © 2016 Ziv Kaputa. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <SpotifyAuthentication/SpotifyAuthentication.h>
#import <SpotifyAudioPlayback/SpotifyAudioPlayback.h>
#import <SafariServices/SafariServices.h>




@interface Spotify : UIResponder <UIApplicationDelegate,SPTAudioStreamingDelegate>


@property (strong, nonatomic) id someProperty;
@property (nonatomic, strong) SPTAuth *auth;
@property (nonatomic, strong) NSString *loggedIn;


-(void)authenticate:(UIViewController*) vc;
-(BOOL)callback:(NSURL*) url;
-(void)playSong:(NSString *) spURI;


@end
