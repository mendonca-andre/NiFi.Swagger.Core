# IO.Swagger.Api.TenantsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](TenantsApi.md#createuser) | **POST** /tenants/users | Creates a user
[**CreateUserGroup**](TenantsApi.md#createusergroup) | **POST** /tenants/user-groups | Creates a user group
[**GetUser**](TenantsApi.md#getuser) | **GET** /tenants/users/{id} | Gets a user
[**GetUserGroup**](TenantsApi.md#getusergroup) | **GET** /tenants/user-groups/{id} | Gets a user group
[**GetUserGroups**](TenantsApi.md#getusergroups) | **GET** /tenants/user-groups | Gets all user groups
[**GetUsers**](TenantsApi.md#getusers) | **GET** /tenants/users | Gets all users
[**RemoveUser**](TenantsApi.md#removeuser) | **DELETE** /tenants/users/{id} | Deletes a user
[**RemoveUserGroup**](TenantsApi.md#removeusergroup) | **DELETE** /tenants/user-groups/{id} | Deletes a user group
[**SearchTenants**](TenantsApi.md#searchtenants) | **GET** /tenants/search-results | Searches for a tenant with the specified identity
[**UpdateUser**](TenantsApi.md#updateuser) | **PUT** /tenants/users/{id} | Updates a user
[**UpdateUserGroup**](TenantsApi.md#updateusergroup) | **PUT** /tenants/user-groups/{id} | Updates a user group


<a name="createuser"></a>
# **CreateUser**
> UserEntity CreateUser (UserEntity body)

Creates a user

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
    public class CreateUserExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var body = new UserEntity(); // UserEntity | The user configuration details.

            try
            {
                // Creates a user
                UserEntity result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserEntity**](UserEntity.md)| The user configuration details. | 

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createusergroup"></a>
# **CreateUserGroup**
> UserGroupEntity CreateUserGroup (UserGroupEntity body)

Creates a user group

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
    public class CreateUserGroupExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var body = new UserGroupEntity(); // UserGroupEntity | The user group configuration details.

            try
            {
                // Creates a user group
                UserGroupEntity result = apiInstance.CreateUserGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.CreateUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupEntity**](UserGroupEntity.md)| The user group configuration details. | 

### Return type

[**UserGroupEntity**](UserGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> UserEntity GetUser (string id)

Gets a user

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
    public class GetUserExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var id = id_example;  // string | The user id.

            try
            {
                // Gets a user
                UserEntity result = apiInstance.GetUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The user id. | 

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroup"></a>
# **GetUserGroup**
> UserGroupEntity GetUserGroup (string id)

Gets a user group

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
    public class GetUserGroupExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var id = id_example;  // string | The user group id.

            try
            {
                // Gets a user group
                UserGroupEntity result = apiInstance.GetUserGroup(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.GetUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The user group id. | 

### Return type

[**UserGroupEntity**](UserGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroups"></a>
# **GetUserGroups**
> UserGroupsEntity GetUserGroups ()

Gets all user groups

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
    public class GetUserGroupsExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();

            try
            {
                // Gets all user groups
                UserGroupsEntity result = apiInstance.GetUserGroups();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.GetUserGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserGroupsEntity**](UserGroupsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> UsersEntity GetUsers ()

Gets all users

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
    public class GetUsersExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();

            try
            {
                // Gets all users
                UsersEntity result = apiInstance.GetUsers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UsersEntity**](UsersEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuser"></a>
# **RemoveUser**
> UserEntity RemoveUser (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a user

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
    public class RemoveUserExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var id = id_example;  // string | The user id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a user
                UserEntity result = apiInstance.RemoveUser(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.RemoveUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The user id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeusergroup"></a>
# **RemoveUserGroup**
> UserGroupEntity RemoveUserGroup (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a user group

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
    public class RemoveUserGroupExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var id = id_example;  // string | The user group id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a user group
                UserGroupEntity result = apiInstance.RemoveUserGroup(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.RemoveUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The user group id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**UserGroupEntity**](UserGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchtenants"></a>
# **SearchTenants**
> TenantsEntity SearchTenants (string q)

Searches for a tenant with the specified identity

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
    public class SearchTenantsExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var q = q_example;  // string | Identity to search for.

            try
            {
                // Searches for a tenant with the specified identity
                TenantsEntity result = apiInstance.SearchTenants(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.SearchTenants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Identity to search for. | 

### Return type

[**TenantsEntity**](TenantsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> UserEntity UpdateUser (string id, UserEntity body)

Updates a user

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
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var id = id_example;  // string | The user id.
            var body = new UserEntity(); // UserEntity | The user configuration details.

            try
            {
                // Updates a user
                UserEntity result = apiInstance.UpdateUser(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The user id. | 
 **body** | [**UserEntity**](UserEntity.md)| The user configuration details. | 

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusergroup"></a>
# **UpdateUserGroup**
> UserGroupEntity UpdateUserGroup (string id, UserGroupEntity body)

Updates a user group

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
    public class UpdateUserGroupExample
    {
        public void main()
        {
            var apiInstance = new TenantsApi();
            var id = id_example;  // string | The user group id.
            var body = new UserGroupEntity(); // UserGroupEntity | The user group configuration details.

            try
            {
                // Updates a user group
                UserGroupEntity result = apiInstance.UpdateUserGroup(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.UpdateUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The user group id. | 
 **body** | [**UserGroupEntity**](UserGroupEntity.md)| The user group configuration details. | 

### Return type

[**UserGroupEntity**](UserGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

