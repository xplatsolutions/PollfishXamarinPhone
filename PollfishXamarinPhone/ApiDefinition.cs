using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
//using pollfish;

namespace PollfishXamarinPhone
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//

	// @interface UserAttributesDictionary : NSMutableDictionary
	[BaseType (typeof(NSMutableDictionary))]
	interface UserAttributesDictionary
	{
//		NSMutableDictionary _dict;

		// -(id)initWithObjects:(const id *)objects forKeys:(const id<NSCopying> *)keys count:(NSUInteger)count;
		[Export ("initWithObjects:forKeys:count:")]
		IntPtr Constructor (NSObject[] objects, NSCopying[] keys, nuint count);

		// -(id)objectForKey:(id)aKey;
		[Export ("objectForKey:")]
		NSObject ObjectForKey (NSObject aKey);

		// -(NSEnumerator *)keyEnumerator;
		[Export ("keyEnumerator")]
//		[Verify (MethodToProperty)]
		NSEnumerator KeyEnumerator { get; }

		// -(void)setObject:(id)anObject forKey:(id)aKey;
		[Export ("setObject:forKey:")]
		void SetObject (NSObject anObject, NSObject aKey);

		// -(void)removeObjectForKey:(id)aKey;
		[Export ("removeObjectForKey:")]
		void RemoveObjectForKey (NSObject aKey);

		// -(NSUInteger)count;
		[Export ("count")]
//		[Verify (MethodToProperty)]
		nuint Count { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(UserAttributesDictionary *)setFacebookId:(NSString *)facebook_id;
		[Export ("setFacebookId:")]
		UserAttributesDictionary SetFacebookId (string facebook_id);

		// -(UserAttributesDictionary *)setTwitterId:(NSString *)twitter_id;
		[Export ("setTwitterId:")]
		UserAttributesDictionary SetTwitterId (string twitter_id);

		// -(UserAttributesDictionary *)setCustomAtributesWithKey:(NSString *)attr_key andAttrValue:(NSString *)attr_value;
		[Export ("setCustomAtributesWithKey:andAttrValue:")]
		UserAttributesDictionary SetCustomAtributesWithKey (string attr_key, string attr_value);

		// -(UserAttributesDictionary *)setLinkedInId:(NSString *)linkedin_id;
		[Export ("setLinkedInId:")]
		UserAttributesDictionary SetLinkedInId (string linkedin_id);

		// -(UserAttributesDictionary *)setGoogleId:(NSString *)google_id;
		[Export ("setGoogleId:")]
		UserAttributesDictionary SetGoogleId (string google_id);

		// -(UserAttributesDictionary *)setEmail:(NSString *)email;
		[Export ("setEmail:")]
		UserAttributesDictionary SetEmail (string email);

		// -(UserAttributesDictionary *)setPhone:(NSString *)phone;
		[Export ("setPhone:")]
		UserAttributesDictionary SetPhone (string phone);

		// -(UserAttributesDictionary *)setName:(NSString *)name;
		[Export ("setName:")]
		UserAttributesDictionary SetName (string name);

		// -(UserAttributesDictionary *)setSurname:(NSString *)surname;
		[Export ("setSurname:")]
		UserAttributesDictionary SetSurname (string surname);

		// -(UserAttributesDictionary *)setAge:(NSString *)age;
		[Export ("setAge:")]
		UserAttributesDictionary SetAge (string age);

		// -(UserAttributesDictionary *)setGender:(NSString *)gender;
		[Export ("setGender:")]
		UserAttributesDictionary SetGender (string gender);

		// -(UserAttributesDictionary *)setAgeGroup:(NSString *)age_group;
		[Export ("setAgeGroup:")]
		UserAttributesDictionary SetAgeGroup (string age_group);

		// -(UserAttributesDictionary *)setYearOfBirth:(NSString *)year_of_birth;
		[Export ("setYearOfBirth:")]
		UserAttributesDictionary SetYearOfBirth (string year_of_birth);

		// -(UserAttributesDictionary *)setPlaceOfBirth:(NSString *)place_of_birth;
		[Export ("setPlaceOfBirth:")]
		UserAttributesDictionary SetPlaceOfBirth (string place_of_birth);

		// -(UserAttributesDictionary *)setPlaceOfRecidence:(NSString *)place_of_residence;
		[Export ("setPlaceOfRecidence:")]
		UserAttributesDictionary SetPlaceOfRecidence (string place_of_residence);

		// -(UserAttributesDictionary *)setNationality:(NSString *)nationality;
		[Export ("setNationality:")]
		UserAttributesDictionary SetNationality (string nationality);

		// -(UserAttributesDictionary *)setMaritalStatus:(NSString *)marital_status;
		[Export ("setMaritalStatus:")]
		UserAttributesDictionary SetMaritalStatus (string marital_status);

		// -(UserAttributesDictionary *)setReligion:(NSString *)religion;
		[Export ("setReligion:")]
		UserAttributesDictionary SetReligion (string religion);

		// -(UserAttributesDictionary *)setPoliticalView:(NSString *)political_view;
		[Export ("setPoliticalView:")]
		UserAttributesDictionary SetPoliticalView (string political_view);

		// -(UserAttributesDictionary *)setRace:(NSString *)race;
		[Export ("setRace:")]
		UserAttributesDictionary SetRace (string race);
	}

	// @interface Pollfish : NSObject
	[BaseType (typeof(NSObject))]
	interface Pollfish
	{
		// +(void)initAtPosition:(int)pos withPadding:(int)margin andDeveloperKey:(NSString *)key andDebuggable:(BOOL)isDebuggable andCustomMode:(BOOL)isCustomMode;
		[Static]
		[Export ("initAtPosition:withPadding:andDeveloperKey:andDebuggable:andCustomMode:")]
		void InitAtPosition (int pos, int margin, string key, bool isDebuggable, bool isCustomMode);

		// +(void)initAtPosition:(int)pos withPadding:(int)margin andDeveloperKey:(NSString *)key andDebuggable:(BOOL)isDebuggable andCustomMode:(BOOL)isCustomMode andRequestUUID:(NSString *)request_uuid;
		[Static]
		[Export ("initAtPosition:withPadding:andDeveloperKey:andDebuggable:andCustomMode:andRequestUUID:")]
		void InitAtPosition (int pos, int margin, string key, bool isDebuggable, bool isCustomMode, string request_uuid);

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(void)hide;
		[Static]
		[Export ("hide")]
		void Hide ();

		// +(void)destroy;
		[Static]
		[Export ("destroy")]
		void Destroy ();

		// +(void)updateLocationWithLatitude:(double)lat andLongitude:(double)lon andHorizontalAccuracy:(double)acc;
		[Static]
		[Export ("updateLocationWithLatitude:andLongitude:andHorizontalAccuracy:")]
		void UpdateLocationWithLatitude (double lat, double lon, double acc);

		// +(void)setAttributeDictionary:(NSMutableDictionary *)dict;
		[Static]
		[Export ("setAttributeDictionary:")]
		void SetAttributeDictionary (NSMutableDictionary dict);
	}
}

