# IO.Swagger.Api.ControllerServicesApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearState**](ControllerServicesApi.md#clearstate) | **POST** /controller-services/{id}/state/clear-requests | Clears the state for a controller service
[**GetControllerService**](ControllerServicesApi.md#getcontrollerservice) | **GET** /controller-services/{id} | Gets a controller service
[**GetControllerServiceReferences**](ControllerServicesApi.md#getcontrollerservicereferences) | **GET** /controller-services/{id}/references | Gets a controller service
[**GetPropertyDescriptor**](ControllerServicesApi.md#getpropertydescriptor) | **GET** /controller-services/{id}/descriptors | Gets a controller service property descriptor
[**GetState**](ControllerServicesApi.md#getstate) | **GET** /controller-services/{id}/state | Gets the state for a controller service
[**RemoveControllerService**](ControllerServicesApi.md#removecontrollerservice) | **DELETE** /controller-services/{id} | Deletes a controller service
[**UpdateControllerService**](ControllerServicesApi.md#updatecontrollerservice) | **PUT** /controller-services/{id} | Updates a controller service
[**UpdateControllerServiceReferences**](ControllerServicesApi.md#updatecontrollerservicereferences) | **PUT** /controller-services/{id}/references | Updates a controller services references
[**UpdateRunStatus**](ControllerServicesApi.md#updaterunstatus) | **PUT** /controller-services/{id}/run-status | Updates run status of a controller service


<a name="clearstate"></a>
# **ClearState**
> ComponentStateEntity ClearState (string id)

Clears the state for a controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearStateExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.

            try
            {
                // Clears the state for a controller service
                ComponentStateEntity result = apiInstance.ClearState(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.ClearState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 

### Return type

[**ComponentStateEntity**](ComponentStateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontrollerservice"></a>
# **GetControllerService**
> ControllerServiceEntity GetControllerService (string id)

Gets a controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetControllerServiceExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.

            try
            {
                // Gets a controller service
                ControllerServiceEntity result = apiInstance.GetControllerService(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.GetControllerService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 

### Return type

[**ControllerServiceEntity**](ControllerServiceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontrollerservicereferences"></a>
# **GetControllerServiceReferences**
> ControllerServiceReferencingComponentsEntity GetControllerServiceReferences (string id)

Gets a controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetControllerServiceReferencesExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.

            try
            {
                // Gets a controller service
                ControllerServiceReferencingComponentsEntity result = apiInstance.GetControllerServiceReferences(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.GetControllerServiceReferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 

### Return type

[**ControllerServiceReferencingComponentsEntity**](ControllerServiceReferencingComponentsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpropertydescriptor"></a>
# **GetPropertyDescriptor**
> PropertyDescriptorEntity GetPropertyDescriptor (string id, string propertyName)

Gets a controller service property descriptor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPropertyDescriptorExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.
            var propertyName = propertyName_example;  // string | The property name to return the descriptor for.

            try
            {
                // Gets a controller service property descriptor
                PropertyDescriptorEntity result = apiInstance.GetPropertyDescriptor(id, propertyName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.GetPropertyDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 
 **propertyName** | **string**| The property name to return the descriptor for. | 

### Return type

[**PropertyDescriptorEntity**](PropertyDescriptorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstate"></a>
# **GetState**
> ComponentStateEntity GetState (string id)

Gets the state for a controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStateExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.

            try
            {
                // Gets the state for a controller service
                ComponentStateEntity result = apiInstance.GetState(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.GetState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 

### Return type

[**ComponentStateEntity**](ComponentStateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecontrollerservice"></a>
# **RemoveControllerService**
> ControllerServiceEntity RemoveControllerService (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveControllerServiceExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a controller service
                ControllerServiceEntity result = apiInstance.RemoveControllerService(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.RemoveControllerService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**ControllerServiceEntity**](ControllerServiceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontrollerservice"></a>
# **UpdateControllerService**
> ControllerServiceEntity UpdateControllerService (string id, ControllerServiceEntity body)

Updates a controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateControllerServiceExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.
            var body = new ControllerServiceEntity(); // ControllerServiceEntity | The controller service configuration details.

            try
            {
                // Updates a controller service
                ControllerServiceEntity result = apiInstance.UpdateControllerService(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.UpdateControllerService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 
 **body** | [**ControllerServiceEntity**](ControllerServiceEntity.md)| The controller service configuration details. | 

### Return type

[**ControllerServiceEntity**](ControllerServiceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontrollerservicereferences"></a>
# **UpdateControllerServiceReferences**
> ControllerServiceReferencingComponentsEntity UpdateControllerServiceReferences (string id, UpdateControllerServiceReferenceRequestEntity body)

Updates a controller services references

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateControllerServiceReferencesExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.
            var body = new UpdateControllerServiceReferenceRequestEntity(); // UpdateControllerServiceReferenceRequestEntity | The controller service request update request.

            try
            {
                // Updates a controller services references
                ControllerServiceReferencingComponentsEntity result = apiInstance.UpdateControllerServiceReferences(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.UpdateControllerServiceReferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 
 **body** | [**UpdateControllerServiceReferenceRequestEntity**](UpdateControllerServiceReferenceRequestEntity.md)| The controller service request update request. | 

### Return type

[**ControllerServiceReferencingComponentsEntity**](ControllerServiceReferencingComponentsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterunstatus"></a>
# **UpdateRunStatus**
> ControllerServiceEntity UpdateRunStatus (string id, ControllerServiceRunStatusEntity body)

Updates run status of a controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRunStatusExample
    {
        public void main()
        {
            var apiInstance = new ControllerServicesApi();
            var id = id_example;  // string | The controller service id.
            var body = new ControllerServiceRunStatusEntity(); // ControllerServiceRunStatusEntity | The controller service run status.

            try
            {
                // Updates run status of a controller service
                ControllerServiceEntity result = apiInstance.UpdateRunStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerServicesApi.UpdateRunStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The controller service id. | 
 **body** | [**ControllerServiceRunStatusEntity**](ControllerServiceRunStatusEntity.md)| The controller service run status. | 

### Return type

[**ControllerServiceEntity**](ControllerServiceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

