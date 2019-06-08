# IO.Swagger.Model.ProvenanceResultsDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProvenanceEvents** | [**List&lt;ProvenanceEventDTO&gt;**](ProvenanceEventDTO.md) | The provenance events that matched the search criteria. | [optional] 
**Total** | **string** | The total number of results formatted. | [optional] 
**TotalCount** | **long?** | The total number of results. | [optional] 
**Generated** | **string** | Then the search was performed. | [optional] 
**OldestEvent** | **string** | The oldest event available in the provenance repository. | [optional] 
**TimeOffset** | **int?** | The time offset of the server that&#39;s used for event time. | [optional] 
**Errors** | **List&lt;string&gt;** | Any errors that occurred while performing the provenance request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

