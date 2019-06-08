# IO.Swagger.Model.ProvenanceDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the provenance query. | [optional] 
**Uri** | **string** | The URI for this query. Used for obtaining/deleting the request at a later time | [optional] 
**SubmissionTime** | **string** | The timestamp when the query was submitted. | [optional] 
**Expiration** | **string** | The timestamp when the query will expire. | [optional] 
**PercentCompleted** | **int?** | The current percent complete. | [optional] 
**Finished** | **bool?** | Whether the query has finished. | [optional] 
**Request** | [**ProvenanceRequestDTO**](ProvenanceRequestDTO.md) | The provenance request. | [optional] 
**Results** | [**ProvenanceResultsDTO**](ProvenanceResultsDTO.md) | The provenance results. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

