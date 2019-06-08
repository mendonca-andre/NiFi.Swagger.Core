# IO.Swagger.Model.LineageDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of this lineage query. | [optional] 
**Uri** | **string** | The URI for this lineage query for later retrieval and deletion. | [optional] 
**SubmissionTime** | **string** | When the lineage query was submitted. | [optional] 
**Expiration** | **string** | When the lineage query will expire. | [optional] 
**PercentCompleted** | **int?** | The percent complete for the lineage query. | [optional] 
**Finished** | **bool?** | Whether the lineage query has finished. | [optional] 
**Request** | [**LineageRequestDTO**](LineageRequestDTO.md) | The initial lineage result. | [optional] 
**Results** | [**LineageResultsDTO**](LineageResultsDTO.md) | The results of the lineage query. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

