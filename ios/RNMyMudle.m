
#import "RNMyMudle.h"

@implementation RNMyMudle

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE();

RCT_EXPORT_METHOD(sayHello:(NSString *) msg)
{
    NSLog(@"打印Hello World%@",msg);
}

@end
  
