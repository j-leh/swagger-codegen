#import <Foundation/Foundation.h>
#import <CoreData/CoreData.h>

/**
* Swagger Petstore
* This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.
*
* OpenAPI spec version: 1.0.0
* Contact: apiteam@swagger.io
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/


#import "SWGCategoryManagedObject.h"
#import "SWGTagManagedObject.h"


NS_ASSUME_NONNULL_BEGIN

@interface SWGPetManagedObject : NSManagedObject


@property (nullable, nonatomic, retain) NSNumber* _id;

@property (nullable, nonatomic, retain) SWGCategoryManagedObject* category;

@property (nullable, nonatomic, retain) NSString* name;

@property (nullable, nonatomic, retain) NSArray<NSString*>* photoUrls;

@property (nullable, nonatomic, retain) NSSet<SWGTagManagedObject*>* tags;
/* pet status in the store [optional]
 */
@property (nullable, nonatomic, retain) NSString* status;
@end

@interface SWGPetManagedObject (GeneratedAccessors)
- (void)addTagsObject:(SWGTagManagedObject *)value;
- (void)removeTagsObject:(SWGTagManagedObject *)value;
- (void)addTags:(NSSet<SWGTagManagedObject*> *)values;
- (void)removeTags:(NSSet<SWGTagManagedObject*> *)values;

@end


NS_ASSUME_NONNULL_END
