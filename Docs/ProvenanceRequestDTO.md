# IO.Swagger.Model.ProvenanceRequestDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchTerms** | **Dictionary&lt;string, string&gt;** | The search terms used to perform the search. | [optional] 
**ClusterNodeId** | **string** | The id of the node in the cluster where this provenance originated. | [optional] 
**StartDate** | **string** | The earliest event time to include in the query. | [optional] 
**EndDate** | **string** | The latest event time to include in the query. | [optional] 
**MinimumFileSize** | **string** | The minimum file size to include in the query. | [optional] 
**MaximumFileSize** | **string** | The maximum file size to include in the query. | [optional] 
**MaxResults** | **int?** | The maximum number of results to include. | [optional] 
**Summarize** | **bool?** | Whether or not to summarize provenance events returned. This property is false by default. | [optional] 
**IncrementalResults** | **bool?** | Whether or not incremental results are returned. If false, provenance events are only returned once the query completes. This property is true by default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

