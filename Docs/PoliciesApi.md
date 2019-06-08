# IO.Swagger.Api.PoliciesApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccessPolicy**](PoliciesApi.md#createaccesspolicy) | **POST** /policies | Creates an access policy
[**GetAccessPolicy**](PoliciesApi.md#getaccesspolicy) | **GET** /policies/{id} | Gets an access policy
[**GetAccessPolicyForResource**](PoliciesApi.md#getaccesspolicyforresource) | **GET** /policies/{action}/{resource} | Gets an access policy for the specified action and resource
[**RemoveAccessPolicy**](PoliciesApi.md#removeaccesspolicy) | **DELETE** /policies/{id} | Deletes an access policy
[**UpdateAccessPolicy**](PoliciesApi.md#updateaccesspolicy) | **PUT** /policies/{id} | Updates a access policy


<a name="createaccesspolicy"></a>
# **CreateAccessPolicy**
> AccessPolicyEntity CreateAccessPolicy (AccessPolicyEntity body)

Creates an access policy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccessPolicyExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var body = new AccessPolicyEntity(); // AccessPolicyEntity | The access policy configuration details.

            try
            {
                // Creates an access policy
                AccessPolicyEntity result = apiInstance.CreateAccessPolicy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.CreateAccessPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccessPolicyEntity**](AccessPolicyEntity.md)| The access policy configuration details. | 

### Return type

[**AccessPolicyEntity**](AccessPolicyEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccesspolicy"></a>
# **GetAccessPolicy**
> AccessPolicyEntity GetAccessPolicy (string id)

Gets an access policy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccessPolicyExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var id = id_example;  // string | The access policy id.

            try
            {
                // Gets an access policy
                AccessPolicyEntity result = apiInstance.GetAccessPolicy(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetAccessPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The access policy id. | 

### Return type

[**AccessPolicyEntity**](AccessPolicyEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccesspolicyforresource"></a>
# **GetAccessPolicyForResource**
> AccessPolicyEntity GetAccessPolicyForResource (string action, string resource)

Gets an access policy for the specified action and resource

Will return the effective policy if no component specific policy exists for the specified action and resource. Must have Read permissions to the policy with the desired action and resource. Permissions for the policy that is returned will be indicated in the response. This means the client could be authorized to get the policy for a given component but the effective policy may be inherited from an ancestor Process Group. If the client does not have permissions to that policy, the response will not include the policy and the permissions in the response will be marked accordingly. If the client does not have permissions to the policy of the desired action and resource a 403 response will be returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccessPolicyForResourceExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var action = action_example;  // string | The request action.
            var resource = resource_example;  // string | The resource of the policy.

            try
            {
                // Gets an access policy for the specified action and resource
                AccessPolicyEntity result = apiInstance.GetAccessPolicyForResource(action, resource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetAccessPolicyForResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| The request action. | 
 **resource** | **string**| The resource of the policy. | 

### Return type

[**AccessPolicyEntity**](AccessPolicyEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeaccesspolicy"></a>
# **RemoveAccessPolicy**
> AccessPolicyEntity RemoveAccessPolicy (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes an access policy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveAccessPolicyExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var id = id_example;  // string | The access policy id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes an access policy
                AccessPolicyEntity result = apiInstance.RemoveAccessPolicy(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.RemoveAccessPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The access policy id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**AccessPolicyEntity**](AccessPolicyEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccesspolicy"></a>
# **UpdateAccessPolicy**
> AccessPolicyEntity UpdateAccessPolicy (string id, AccessPolicyEntity body)

Updates a access policy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAccessPolicyExample
    {
        public void main()
        {
            var apiInstance = new PoliciesApi();
            var id = id_example;  // string | The access policy id.
            var body = new AccessPolicyEntity(); // AccessPolicyEntity | The access policy configuration details.

            try
            {
                // Updates a access policy
                AccessPolicyEntity result = apiInstance.UpdateAccessPolicy(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.UpdateAccessPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The access policy id. | 
 **body** | [**AccessPolicyEntity**](AccessPolicyEntity.md)| The access policy configuration details. | 

### Return type

[**AccessPolicyEntity**](AccessPolicyEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

