# IO.Swagger.Api.ProvenanceEventsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInputContent**](ProvenanceEventsApi.md#getinputcontent) | **GET** /provenance-events/{id}/content/input | Gets the input content for a provenance event
[**GetOutputContent**](ProvenanceEventsApi.md#getoutputcontent) | **GET** /provenance-events/{id}/content/output | Gets the output content for a provenance event
[**GetProvenanceEvent**](ProvenanceEventsApi.md#getprovenanceevent) | **GET** /provenance-events/{id} | Gets a provenance event
[**SubmitReplay**](ProvenanceEventsApi.md#submitreplay) | **POST** /provenance-events/replays | Replays content from a provenance event


<a name="getinputcontent"></a>
# **GetInputContent**
> StreamingOutput GetInputContent (string id, string clusterNodeId = null)

Gets the input content for a provenance event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInputContentExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceEventsApi();
            var id = id_example;  // string | The provenance event id.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where the content exists if clustered. (optional) 

            try
            {
                // Gets the input content for a provenance event
                StreamingOutput result = apiInstance.GetInputContent(id, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceEventsApi.GetInputContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The provenance event id. | 
 **clusterNodeId** | **string**| The id of the node where the content exists if clustered. | [optional] 

### Return type

[**StreamingOutput**](StreamingOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoutputcontent"></a>
# **GetOutputContent**
> StreamingOutput GetOutputContent (string id, string clusterNodeId = null)

Gets the output content for a provenance event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOutputContentExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceEventsApi();
            var id = id_example;  // string | The provenance event id.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where the content exists if clustered. (optional) 

            try
            {
                // Gets the output content for a provenance event
                StreamingOutput result = apiInstance.GetOutputContent(id, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceEventsApi.GetOutputContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The provenance event id. | 
 **clusterNodeId** | **string**| The id of the node where the content exists if clustered. | [optional] 

### Return type

[**StreamingOutput**](StreamingOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovenanceevent"></a>
# **GetProvenanceEvent**
> ProvenanceEventEntity GetProvenanceEvent (string id, string clusterNodeId = null)

Gets a provenance event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProvenanceEventExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceEventsApi();
            var id = id_example;  // string | The provenance event id.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where this event exists if clustered. (optional) 

            try
            {
                // Gets a provenance event
                ProvenanceEventEntity result = apiInstance.GetProvenanceEvent(id, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceEventsApi.GetProvenanceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The provenance event id. | 
 **clusterNodeId** | **string**| The id of the node where this event exists if clustered. | [optional] 

### Return type

[**ProvenanceEventEntity**](ProvenanceEventEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitreplay"></a>
# **SubmitReplay**
> ProvenanceEventEntity SubmitReplay (SubmitReplayRequestEntity body)

Replays content from a provenance event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitReplayExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceEventsApi();
            var body = new SubmitReplayRequestEntity(); // SubmitReplayRequestEntity | The replay request.

            try
            {
                // Replays content from a provenance event
                ProvenanceEventEntity result = apiInstance.SubmitReplay(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceEventsApi.SubmitReplay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitReplayRequestEntity**](SubmitReplayRequestEntity.md)| The replay request. | 

### Return type

[**ProvenanceEventEntity**](ProvenanceEventEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

