# IO.Swagger.Api.ProvenanceApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLineage**](ProvenanceApi.md#deletelineage) | **DELETE** /provenance/lineage/{id} | Deletes a lineage query
[**DeleteProvenance**](ProvenanceApi.md#deleteprovenance) | **DELETE** /provenance/{id} | Deletes a provenance query
[**GetLineage**](ProvenanceApi.md#getlineage) | **GET** /provenance/lineage/{id} | Gets a lineage query
[**GetProvenance**](ProvenanceApi.md#getprovenance) | **GET** /provenance/{id} | Gets a provenance query
[**GetSearchOptions**](ProvenanceApi.md#getsearchoptions) | **GET** /provenance/search-options | Gets the searchable attributes for provenance events
[**SubmitLineageRequest**](ProvenanceApi.md#submitlineagerequest) | **POST** /provenance/lineage | Submits a lineage query
[**SubmitProvenanceRequest**](ProvenanceApi.md#submitprovenancerequest) | **POST** /provenance | Submits a provenance query


<a name="deletelineage"></a>
# **DeleteLineage**
> LineageEntity DeleteLineage (string id, string clusterNodeId = null)

Deletes a lineage query

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLineageExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceApi();
            var id = id_example;  // string | The id of the lineage query.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where this query exists if clustered. (optional) 

            try
            {
                // Deletes a lineage query
                LineageEntity result = apiInstance.DeleteLineage(id, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceApi.DeleteLineage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the lineage query. | 
 **clusterNodeId** | **string**| The id of the node where this query exists if clustered. | [optional] 

### Return type

[**LineageEntity**](LineageEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprovenance"></a>
# **DeleteProvenance**
> ProvenanceEntity DeleteProvenance (string id, string clusterNodeId = null)

Deletes a provenance query

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProvenanceExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceApi();
            var id = id_example;  // string | The id of the provenance query.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where this query exists if clustered. (optional) 

            try
            {
                // Deletes a provenance query
                ProvenanceEntity result = apiInstance.DeleteProvenance(id, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceApi.DeleteProvenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the provenance query. | 
 **clusterNodeId** | **string**| The id of the node where this query exists if clustered. | [optional] 

### Return type

[**ProvenanceEntity**](ProvenanceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlineage"></a>
# **GetLineage**
> LineageEntity GetLineage (string id, string clusterNodeId = null)

Gets a lineage query

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLineageExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceApi();
            var id = id_example;  // string | The id of the lineage query.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where this query exists if clustered. (optional) 

            try
            {
                // Gets a lineage query
                LineageEntity result = apiInstance.GetLineage(id, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceApi.GetLineage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the lineage query. | 
 **clusterNodeId** | **string**| The id of the node where this query exists if clustered. | [optional] 

### Return type

[**LineageEntity**](LineageEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovenance"></a>
# **GetProvenance**
> ProvenanceEntity GetProvenance (string id, string clusterNodeId = null, bool? summarize = null, bool? incrementalResults = null)

Gets a provenance query

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProvenanceExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceApi();
            var id = id_example;  // string | The id of the provenance query.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where this query exists if clustered. (optional) 
            var summarize = true;  // bool? | Whether or not incremental results are returned. If false, provenance events are only returned once the query completes. This property is true by default. (optional)  (default to false)
            var incrementalResults = true;  // bool? | Whether or not to summarize provenance events returned. This property is false by default. (optional)  (default to true)

            try
            {
                // Gets a provenance query
                ProvenanceEntity result = apiInstance.GetProvenance(id, clusterNodeId, summarize, incrementalResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceApi.GetProvenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the provenance query. | 
 **clusterNodeId** | **string**| The id of the node where this query exists if clustered. | [optional] 
 **summarize** | **bool?**| Whether or not incremental results are returned. If false, provenance events are only returned once the query completes. This property is true by default. | [optional] [default to false]
 **incrementalResults** | **bool?**| Whether or not to summarize provenance events returned. This property is false by default. | [optional] [default to true]

### Return type

[**ProvenanceEntity**](ProvenanceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearchoptions"></a>
# **GetSearchOptions**
> ProvenanceOptionsEntity GetSearchOptions ()

Gets the searchable attributes for provenance events

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSearchOptionsExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceApi();

            try
            {
                // Gets the searchable attributes for provenance events
                ProvenanceOptionsEntity result = apiInstance.GetSearchOptions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceApi.GetSearchOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProvenanceOptionsEntity**](ProvenanceOptionsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitlineagerequest"></a>
# **SubmitLineageRequest**
> LineageEntity SubmitLineageRequest (LineageEntity body)

Submits a lineage query

Lineage queries may be long running so this endpoint submits a request. The response will include the current state of the query. If the request is not completed the URI in the response can be used at a later time to get the updated state of the query. Once the query has completed the lineage request should be deleted by the client who originally submitted it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitLineageRequestExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceApi();
            var body = new LineageEntity(); // LineageEntity | The lineage query details.

            try
            {
                // Submits a lineage query
                LineageEntity result = apiInstance.SubmitLineageRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceApi.SubmitLineageRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LineageEntity**](LineageEntity.md)| The lineage query details. | 

### Return type

[**LineageEntity**](LineageEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitprovenancerequest"></a>
# **SubmitProvenanceRequest**
> ProvenanceEntity SubmitProvenanceRequest (ProvenanceEntity body)

Submits a provenance query

Provenance queries may be long running so this endpoint submits a request. The response will include the current state of the query. If the request is not completed the URI in the response can be used at a later time to get the updated state of the query. Once the query has completed the provenance request should be deleted by the client who originally submitted it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitProvenanceRequestExample
    {
        public void main()
        {
            var apiInstance = new ProvenanceApi();
            var body = new ProvenanceEntity(); // ProvenanceEntity | The provenance query details.

            try
            {
                // Submits a provenance query
                ProvenanceEntity result = apiInstance.SubmitProvenanceRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvenanceApi.SubmitProvenanceRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProvenanceEntity**](ProvenanceEntity.md)| The provenance query details. | 

### Return type

[**ProvenanceEntity**](ProvenanceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

