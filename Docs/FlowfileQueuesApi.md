# IO.Swagger.Api.FlowfileQueuesApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDropRequest**](FlowfileQueuesApi.md#createdroprequest) | **POST** /flowfile-queues/{id}/drop-requests | Creates a request to drop the contents of the queue in this connection.
[**CreateFlowFileListing**](FlowfileQueuesApi.md#createflowfilelisting) | **POST** /flowfile-queues/{id}/listing-requests | Lists the contents of the queue in this connection.
[**DeleteListingRequest**](FlowfileQueuesApi.md#deletelistingrequest) | **DELETE** /flowfile-queues/{id}/listing-requests/{listing-request-id} | Cancels and/or removes a request to list the contents of this connection.
[**DownloadFlowFileContent**](FlowfileQueuesApi.md#downloadflowfilecontent) | **GET** /flowfile-queues/{id}/flowfiles/{flowfile-uuid}/content | Gets the content for a FlowFile in a Connection.
[**GetDropRequest**](FlowfileQueuesApi.md#getdroprequest) | **GET** /flowfile-queues/{id}/drop-requests/{drop-request-id} | Gets the current status of a drop request for the specified connection.
[**GetFlowFile**](FlowfileQueuesApi.md#getflowfile) | **GET** /flowfile-queues/{id}/flowfiles/{flowfile-uuid} | Gets a FlowFile from a Connection.
[**GetListingRequest**](FlowfileQueuesApi.md#getlistingrequest) | **GET** /flowfile-queues/{id}/listing-requests/{listing-request-id} | Gets the current status of a listing request for the specified connection.
[**RemoveDropRequest**](FlowfileQueuesApi.md#removedroprequest) | **DELETE** /flowfile-queues/{id}/drop-requests/{drop-request-id} | Cancels and/or removes a request to drop the contents of this connection.


<a name="createdroprequest"></a>
# **CreateDropRequest**
> DropRequestEntity CreateDropRequest (string id)

Creates a request to drop the contents of the queue in this connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDropRequestExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.

            try
            {
                // Creates a request to drop the contents of the queue in this connection.
                DropRequestEntity result = apiInstance.CreateDropRequest(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.CreateDropRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 

### Return type

[**DropRequestEntity**](DropRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createflowfilelisting"></a>
# **CreateFlowFileListing**
> ListingRequestEntity CreateFlowFileListing (string id)

Lists the contents of the queue in this connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFlowFileListingExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.

            try
            {
                // Lists the contents of the queue in this connection.
                ListingRequestEntity result = apiInstance.CreateFlowFileListing(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.CreateFlowFileListing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 

### Return type

[**ListingRequestEntity**](ListingRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelistingrequest"></a>
# **DeleteListingRequest**
> ListingRequestEntity DeleteListingRequest (string id, string listingRequestId)

Cancels and/or removes a request to list the contents of this connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteListingRequestExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.
            var listingRequestId = listingRequestId_example;  // string | The listing request id.

            try
            {
                // Cancels and/or removes a request to list the contents of this connection.
                ListingRequestEntity result = apiInstance.DeleteListingRequest(id, listingRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.DeleteListingRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **listingRequestId** | **string**| The listing request id. | 

### Return type

[**ListingRequestEntity**](ListingRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadflowfilecontent"></a>
# **DownloadFlowFileContent**
> StreamingOutput DownloadFlowFileContent (string id, string flowfileUuid, string clientId = null, string clusterNodeId = null)

Gets the content for a FlowFile in a Connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadFlowFileContentExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.
            var flowfileUuid = flowfileUuid_example;  // string | The flowfile uuid.
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where the content exists if clustered. (optional) 

            try
            {
                // Gets the content for a FlowFile in a Connection.
                StreamingOutput result = apiInstance.DownloadFlowFileContent(id, flowfileUuid, clientId, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.DownloadFlowFileContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **flowfileUuid** | **string**| The flowfile uuid. | 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **clusterNodeId** | **string**| The id of the node where the content exists if clustered. | [optional] 

### Return type

[**StreamingOutput**](StreamingOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdroprequest"></a>
# **GetDropRequest**
> DropRequestEntity GetDropRequest (string id, string dropRequestId)

Gets the current status of a drop request for the specified connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDropRequestExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.
            var dropRequestId = dropRequestId_example;  // string | The drop request id.

            try
            {
                // Gets the current status of a drop request for the specified connection.
                DropRequestEntity result = apiInstance.GetDropRequest(id, dropRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.GetDropRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **dropRequestId** | **string**| The drop request id. | 

### Return type

[**DropRequestEntity**](DropRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowfile"></a>
# **GetFlowFile**
> FlowFileEntity GetFlowFile (string id, string flowfileUuid, string clusterNodeId = null)

Gets a FlowFile from a Connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowFileExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.
            var flowfileUuid = flowfileUuid_example;  // string | The flowfile uuid.
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where the content exists if clustered. (optional) 

            try
            {
                // Gets a FlowFile from a Connection.
                FlowFileEntity result = apiInstance.GetFlowFile(id, flowfileUuid, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.GetFlowFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **flowfileUuid** | **string**| The flowfile uuid. | 
 **clusterNodeId** | **string**| The id of the node where the content exists if clustered. | [optional] 

### Return type

[**FlowFileEntity**](FlowFileEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistingrequest"></a>
# **GetListingRequest**
> ListingRequestEntity GetListingRequest (string id, string listingRequestId)

Gets the current status of a listing request for the specified connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetListingRequestExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.
            var listingRequestId = listingRequestId_example;  // string | The listing request id.

            try
            {
                // Gets the current status of a listing request for the specified connection.
                ListingRequestEntity result = apiInstance.GetListingRequest(id, listingRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.GetListingRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **listingRequestId** | **string**| The listing request id. | 

### Return type

[**ListingRequestEntity**](ListingRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedroprequest"></a>
# **RemoveDropRequest**
> DropRequestEntity RemoveDropRequest (string id, string dropRequestId)

Cancels and/or removes a request to drop the contents of this connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveDropRequestExample
    {
        public void main()
        {
            var apiInstance = new FlowfileQueuesApi();
            var id = id_example;  // string | The connection id.
            var dropRequestId = dropRequestId_example;  // string | The drop request id.

            try
            {
                // Cancels and/or removes a request to drop the contents of this connection.
                DropRequestEntity result = apiInstance.RemoveDropRequest(id, dropRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowfileQueuesApi.RemoveDropRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **dropRequestId** | **string**| The drop request id. | 

### Return type

[**DropRequestEntity**](DropRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

