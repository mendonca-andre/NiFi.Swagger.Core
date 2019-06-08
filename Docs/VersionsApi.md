# IO.Swagger.Api.VersionsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVersionControlRequest**](VersionsApi.md#createversioncontrolrequest) | **POST** /versions/active-requests | Create a version control request
[**DeleteRevertRequest**](VersionsApi.md#deleterevertrequest) | **DELETE** /versions/revert-requests/{id} | Deletes the Revert Request with the given ID
[**DeleteUpdateRequest**](VersionsApi.md#deleteupdaterequest) | **DELETE** /versions/update-requests/{id} | Deletes the Update Request with the given ID
[**DeleteVersionControlRequest**](VersionsApi.md#deleteversioncontrolrequest) | **DELETE** /versions/active-requests/{id} | Deletes the version control request with the given ID
[**GetRevertRequest**](VersionsApi.md#getrevertrequest) | **GET** /versions/revert-requests/{id} | Returns the Revert Request with the given ID
[**GetUpdateRequest**](VersionsApi.md#getupdaterequest) | **GET** /versions/update-requests/{id} | Returns the Update Request with the given ID
[**GetVersionInformation**](VersionsApi.md#getversioninformation) | **GET** /versions/process-groups/{id} | Gets the Version Control information for a process group
[**InitiateRevertFlowVersion**](VersionsApi.md#initiaterevertflowversion) | **POST** /versions/revert-requests/process-groups/{id} | Initiate the Revert Request of a Process Group with the given ID
[**InitiateVersionControlUpdate**](VersionsApi.md#initiateversioncontrolupdate) | **POST** /versions/update-requests/process-groups/{id} | Initiate the Update Request of a Process Group with the given ID
[**SaveToFlowRegistry**](VersionsApi.md#savetoflowregistry) | **POST** /versions/process-groups/{id} | Save the Process Group with the given ID
[**StopVersionControl**](VersionsApi.md#stopversioncontrol) | **DELETE** /versions/process-groups/{id} | Stops version controlling the Process Group with the given ID
[**UpdateFlowVersion**](VersionsApi.md#updateflowversion) | **PUT** /versions/process-groups/{id} | Update the version of a Process Group with the given ID
[**UpdateVersionControlRequest**](VersionsApi.md#updateversioncontrolrequest) | **PUT** /versions/active-requests/{id} | Updates the request with the given ID


<a name="createversioncontrolrequest"></a>
# **CreateVersionControlRequest**
> string CreateVersionControlRequest (CreateActiveRequestEntity body)

Create a version control request

Creates a request so that a Process Group can be placed under Version Control or have its Version Control configuration changed. Creating this request will prevent any other threads from simultaneously saving local changes to Version Control. It will not, however, actually save the local flow to the Flow Registry. A POST to /versions/process-groups/{id} should be used to initiate saving of the local flow to the Flow Registry. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateVersionControlRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var body = new CreateActiveRequestEntity(); // CreateActiveRequestEntity | The versioned flow details.

            try
            {
                // Create a version control request
                string result = apiInstance.CreateVersionControlRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.CreateVersionControlRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateActiveRequestEntity**](CreateActiveRequestEntity.md)| The versioned flow details. | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterevertrequest"></a>
# **DeleteRevertRequest**
> VersionedFlowUpdateRequestEntity DeleteRevertRequest (string id, bool? disconnectedNodeAcknowledged = null)

Deletes the Revert Request with the given ID

Deletes the Revert Request with the given ID. After a request is created via a POST to /versions/revert-requests/process-groups/{id}, it is expected that the client will properly clean up the request by DELETE'ing it, once the Revert process has completed. If the request is deleted before the request completes, then the Revert request will finish the step that it is currently performing and then will cancel any subsequent steps. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRevertRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The ID of the Revert Request
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes the Revert Request with the given ID
                VersionedFlowUpdateRequestEntity result = apiInstance.DeleteRevertRequest(id, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.DeleteRevertRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the Revert Request | 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**VersionedFlowUpdateRequestEntity**](VersionedFlowUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteupdaterequest"></a>
# **DeleteUpdateRequest**
> VersionedFlowUpdateRequestEntity DeleteUpdateRequest (string id, bool? disconnectedNodeAcknowledged = null)

Deletes the Update Request with the given ID

Deletes the Update Request with the given ID. After a request is created via a POST to /versions/update-requests/process-groups/{id}, it is expected that the client will properly clean up the request by DELETE'ing it, once the Update process has completed. If the request is deleted before the request completes, then the Update request will finish the step that it is currently performing and then will cancel any subsequent steps. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUpdateRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The ID of the Update Request
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes the Update Request with the given ID
                VersionedFlowUpdateRequestEntity result = apiInstance.DeleteUpdateRequest(id, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.DeleteUpdateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the Update Request | 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**VersionedFlowUpdateRequestEntity**](VersionedFlowUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteversioncontrolrequest"></a>
# **DeleteVersionControlRequest**
> void DeleteVersionControlRequest (string id, bool? disconnectedNodeAcknowledged = null)

Deletes the version control request with the given ID

Deletes the Version Control Request with the given ID. This will allow other threads to save flows to the Flow Registry. See also the documentation for POSTing to /versions/active-requests for information regarding why this is done. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteVersionControlRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The request ID.
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes the version control request with the given ID
                apiInstance.DeleteVersionControlRequest(id, disconnectedNodeAcknowledged);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.DeleteVersionControlRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The request ID. | 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrevertrequest"></a>
# **GetRevertRequest**
> VersionedFlowUpdateRequestEntity GetRevertRequest (string id)

Returns the Revert Request with the given ID

Returns the Revert Request with the given ID. Once a Revert Request has been created by performing a POST to /versions/revert-requests/process-groups/{id}, that request can subsequently be retrieved via this endpoint, and the request that is fetched will contain the updated state, such as percent complete, the current state of the request, and any failures. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRevertRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The ID of the Revert Request

            try
            {
                // Returns the Revert Request with the given ID
                VersionedFlowUpdateRequestEntity result = apiInstance.GetRevertRequest(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetRevertRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the Revert Request | 

### Return type

[**VersionedFlowUpdateRequestEntity**](VersionedFlowUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupdaterequest"></a>
# **GetUpdateRequest**
> VersionedFlowUpdateRequestEntity GetUpdateRequest (string id)

Returns the Update Request with the given ID

Returns the Update Request with the given ID. Once an Update Request has been created by performing a POST to /versions/update-requests/process-groups/{id}, that request can subsequently be retrieved via this endpoint, and the request that is fetched will contain the updated state, such as percent complete, the current state of the request, and any failures. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUpdateRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The ID of the Update Request

            try
            {
                // Returns the Update Request with the given ID
                VersionedFlowUpdateRequestEntity result = apiInstance.GetUpdateRequest(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetUpdateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the Update Request | 

### Return type

[**VersionedFlowUpdateRequestEntity**](VersionedFlowUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getversioninformation"></a>
# **GetVersionInformation**
> VersionControlInformationEntity GetVersionInformation (string id)

Gets the Version Control information for a process group

Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVersionInformationExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets the Version Control information for a process group
                VersionControlInformationEntity result = apiInstance.GetVersionInformation(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.GetVersionInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 

### Return type

[**VersionControlInformationEntity**](VersionControlInformationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiaterevertflowversion"></a>
# **InitiateRevertFlowVersion**
> VersionedFlowUpdateRequestEntity InitiateRevertFlowVersion (string id, VersionControlInformationEntity body)

Initiate the Revert Request of a Process Group with the given ID

For a Process Group that is already under Version Control, this will initiate the action of reverting any local changes that have been made to the Process Group since it was last synchronized with the Flow Registry. This will result in the flow matching the Versioned Flow that exists in the Flow Registry. This can be a lengthy process, as it will stop any Processors and disable any Controller Services necessary to perform the action and then restart them. As a result, the endpoint will immediately return a VersionedFlowUpdateRequestEntity, and the process of updating the flow will occur asynchronously in the background. The client may then periodically poll the status of the request by issuing a GET request to /versions/revert-requests/{requestId}. Once the request is completed, the client is expected to issue a DELETE request to /versions/revert-requests/{requestId}. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitiateRevertFlowVersionExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The process group id.
            var body = new VersionControlInformationEntity(); // VersionControlInformationEntity | The controller service configuration details.

            try
            {
                // Initiate the Revert Request of a Process Group with the given ID
                VersionedFlowUpdateRequestEntity result = apiInstance.InitiateRevertFlowVersion(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.InitiateRevertFlowVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**VersionControlInformationEntity**](VersionControlInformationEntity.md)| The controller service configuration details. | 

### Return type

[**VersionedFlowUpdateRequestEntity**](VersionedFlowUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiateversioncontrolupdate"></a>
# **InitiateVersionControlUpdate**
> VersionedFlowUpdateRequestEntity InitiateVersionControlUpdate (string id, VersionControlInformationEntity body)

Initiate the Update Request of a Process Group with the given ID

For a Process Group that is already under Version Control, this will initiate the action of changing from a specific version of the flow in the Flow Registry to a different version of the flow. This can be a lengthy process, as it will stop any Processors and disable any Controller Services necessary to perform the action and then restart them. As a result, the endpoint will immediately return a VersionedFlowUpdateRequestEntity, and the process of updating the flow will occur asynchronously in the background. The client may then periodically poll the status of the request by issuing a GET request to /versions/update-requests/{requestId}. Once the request is completed, the client is expected to issue a DELETE request to /versions/update-requests/{requestId}. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitiateVersionControlUpdateExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The process group id.
            var body = new VersionControlInformationEntity(); // VersionControlInformationEntity | The controller service configuration details.

            try
            {
                // Initiate the Update Request of a Process Group with the given ID
                VersionedFlowUpdateRequestEntity result = apiInstance.InitiateVersionControlUpdate(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.InitiateVersionControlUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**VersionControlInformationEntity**](VersionControlInformationEntity.md)| The controller service configuration details. | 

### Return type

[**VersionedFlowUpdateRequestEntity**](VersionedFlowUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savetoflowregistry"></a>
# **SaveToFlowRegistry**
> VersionControlInformationEntity SaveToFlowRegistry (string id, StartVersionControlRequestEntity body)

Save the Process Group with the given ID

Begins version controlling the Process Group with the given ID or commits changes to the Versioned Flow, depending on if the provided VersionControlInformation includes a flowId. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveToFlowRegistryExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The process group id.
            var body = new StartVersionControlRequestEntity(); // StartVersionControlRequestEntity | The versioned flow details.

            try
            {
                // Save the Process Group with the given ID
                VersionControlInformationEntity result = apiInstance.SaveToFlowRegistry(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.SaveToFlowRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**StartVersionControlRequestEntity**](StartVersionControlRequestEntity.md)| The versioned flow details. | 

### Return type

[**VersionControlInformationEntity**](VersionControlInformationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stopversioncontrol"></a>
# **StopVersionControl**
> VersionControlInformationEntity StopVersionControl (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Stops version controlling the Process Group with the given ID

Stops version controlling the Process Group with the given ID. The Process Group will no longer track to any Versioned Flow. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StopVersionControlExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The process group id.
            var version = version_example;  // string | The version is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, a new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Stops version controlling the Process Group with the given ID
                VersionControlInformationEntity result = apiInstance.StopVersionControl(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.StopVersionControl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **version** | **string**| The version is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, a new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**VersionControlInformationEntity**](VersionControlInformationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateflowversion"></a>
# **UpdateFlowVersion**
> VersionControlInformationEntity UpdateFlowVersion (string id, VersionedFlowSnapshotEntity body)

Update the version of a Process Group with the given ID

For a Process Group that is already under Version Control, this will update the version of the flow to a different version. This endpoint expects that the given snapshot will not modify any Processor that is currently running or any Controller Service that is enabled. Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFlowVersionExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The process group id.
            var body = new VersionedFlowSnapshotEntity(); // VersionedFlowSnapshotEntity | The controller service configuration details.

            try
            {
                // Update the version of a Process Group with the given ID
                VersionControlInformationEntity result = apiInstance.UpdateFlowVersion(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.UpdateFlowVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**VersionedFlowSnapshotEntity**](VersionedFlowSnapshotEntity.md)| The controller service configuration details. | 

### Return type

[**VersionControlInformationEntity**](VersionControlInformationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateversioncontrolrequest"></a>
# **UpdateVersionControlRequest**
> VersionControlInformationEntity UpdateVersionControlRequest (string id, VersionControlComponentMappingEntity body)

Updates the request with the given ID

Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateVersionControlRequestExample
    {
        public void main()
        {
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | The request ID.
            var body = new VersionControlComponentMappingEntity(); // VersionControlComponentMappingEntity | The version control component mapping.

            try
            {
                // Updates the request with the given ID
                VersionControlInformationEntity result = apiInstance.UpdateVersionControlRequest(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.UpdateVersionControlRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The request ID. | 
 **body** | [**VersionControlComponentMappingEntity**](VersionControlComponentMappingEntity.md)| The version control component mapping. | 

### Return type

[**VersionControlInformationEntity**](VersionControlInformationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

