# IO.Swagger.Model.VersionedFlow
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Link** | [**Link**](Link.md) | An WebLink to this entity. | [optional] 
**Identifier** | **string** | An ID to uniquely identify this object. | [optional] 
**Name** | **string** | The name of the item. | 
**Description** | **string** | A description of the item. | [optional] 
**BucketIdentifier** | **string** | The identifier of the bucket this items belongs to. This cannot be changed after the item is created. | 
**BucketName** | **string** | The name of the bucket this items belongs to. | [optional] 
**CreatedTimestamp** | **long?** | The timestamp of when the item was created, as milliseconds since epoch. | [optional] 
**ModifiedTimestamp** | **long?** | The timestamp of when the item was last modified, as milliseconds since epoch. | [optional] 
**Type** | **string** | The type of item. | 
**Permissions** | [**Permissions**](Permissions.md) | The access that the current user has to the bucket containing this item. | [optional] 
**VersionCount** | **long?** | The number of versions of this flow. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

