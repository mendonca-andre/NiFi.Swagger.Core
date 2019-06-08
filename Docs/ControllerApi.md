# IO.Swagger.Api.ControllerApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBulletin**](ControllerApi.md#createbulletin) | **POST** /controller/bulletin | Creates a new bulletin
[**CreateControllerService**](ControllerApi.md#createcontrollerservice) | **POST** /controller/controller-services | Creates a new controller service
[**CreateRegistryClient**](ControllerApi.md#createregistryclient) | **POST** /controller/registry-clients | Creates a new registry client
[**CreateReportingTask**](ControllerApi.md#createreportingtask) | **POST** /controller/reporting-tasks | Creates a new reporting task
[**DeleteHistory**](ControllerApi.md#deletehistory) | **DELETE** /controller/history | Purges history
[**DeleteNode**](ControllerApi.md#deletenode) | **DELETE** /controller/cluster/nodes/{id} | Removes a node from the cluster
[**DeleteRegistryClient**](ControllerApi.md#deleteregistryclient) | **DELETE** /controller/registry-clients/{id} | Deletes a registry client
[**GetCluster**](ControllerApi.md#getcluster) | **GET** /controller/cluster | Gets the contents of the cluster
[**GetControllerConfig**](ControllerApi.md#getcontrollerconfig) | **GET** /controller/config | Retrieves the configuration for this NiFi Controller
[**GetNode**](ControllerApi.md#getnode) | **GET** /controller/cluster/nodes/{id} | Gets a node in the cluster
[**GetRegistryClient**](ControllerApi.md#getregistryclient) | **GET** /controller/registry-clients/{id} | Gets a registry client
[**GetRegistryClients**](ControllerApi.md#getregistryclients) | **GET** /controller/registry-clients | Gets the listing of available registry clients
[**UpdateControllerConfig**](ControllerApi.md#updatecontrollerconfig) | **PUT** /controller/config | Retrieves the configuration for this NiFi
[**UpdateNode**](ControllerApi.md#updatenode) | **PUT** /controller/cluster/nodes/{id} | Updates a node in the cluster
[**UpdateRegistryClient**](ControllerApi.md#updateregistryclient) | **PUT** /controller/registry-clients/{id} | Updates a registry client


<a name="createbulletin"></a>
# **CreateBulletin**
> BulletinEntity CreateBulletin (BulletinEntity body)

Creates a new bulletin

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBulletinExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var body = new BulletinEntity(); // BulletinEntity | The reporting task configuration details.

            try
            {
                // Creates a new bulletin
                BulletinEntity result = apiInstance.CreateBulletin(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.CreateBulletin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulletinEntity**](BulletinEntity.md)| The reporting task configuration details. | 

### Return type

[**BulletinEntity**](BulletinEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontrollerservice"></a>
# **CreateControllerService**
> ControllerServiceEntity CreateControllerService (ControllerServiceEntity body)

Creates a new controller service

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateControllerServiceExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var body = new ControllerServiceEntity(); // ControllerServiceEntity | The controller service configuration details.

            try
            {
                // Creates a new controller service
                ControllerServiceEntity result = apiInstance.CreateControllerService(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.CreateControllerService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ControllerServiceEntity**](ControllerServiceEntity.md)| The controller service configuration details. | 

### Return type

[**ControllerServiceEntity**](ControllerServiceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createregistryclient"></a>
# **CreateRegistryClient**
> RegistryClientEntity CreateRegistryClient (RegistryClientEntity body)

Creates a new registry client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRegistryClientExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var body = new RegistryClientEntity(); // RegistryClientEntity | The registry configuration details.

            try
            {
                // Creates a new registry client
                RegistryClientEntity result = apiInstance.CreateRegistryClient(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.CreateRegistryClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegistryClientEntity**](RegistryClientEntity.md)| The registry configuration details. | 

### Return type

[**RegistryClientEntity**](RegistryClientEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreportingtask"></a>
# **CreateReportingTask**
> ReportingTaskEntity CreateReportingTask (ReportingTaskEntity body)

Creates a new reporting task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateReportingTaskExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var body = new ReportingTaskEntity(); // ReportingTaskEntity | The reporting task configuration details.

            try
            {
                // Creates a new reporting task
                ReportingTaskEntity result = apiInstance.CreateReportingTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.CreateReportingTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportingTaskEntity**](ReportingTaskEntity.md)| The reporting task configuration details. | 

### Return type

[**ReportingTaskEntity**](ReportingTaskEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehistory"></a>
# **DeleteHistory**
> HistoryEntity DeleteHistory (string endDate)

Purges history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHistoryExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var endDate = endDate_example;  // string | Purge actions before this date/time.

            try
            {
                // Purges history
                HistoryEntity result = apiInstance.DeleteHistory(endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.DeleteHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endDate** | **string**| Purge actions before this date/time. | 

### Return type

[**HistoryEntity**](HistoryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenode"></a>
# **DeleteNode**
> NodeEntity DeleteNode (string id)

Removes a node from the cluster

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNodeExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var id = id_example;  // string | The node id.

            try
            {
                // Removes a node from the cluster
                NodeEntity result = apiInstance.DeleteNode(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.DeleteNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The node id. | 

### Return type

[**NodeEntity**](NodeEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteregistryclient"></a>
# **DeleteRegistryClient**
> RegistryClientEntity DeleteRegistryClient (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a registry client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRegistryClientExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var id = id_example;  // string | The registry id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a registry client
                RegistryClientEntity result = apiInstance.DeleteRegistryClient(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.DeleteRegistryClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The registry id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**RegistryClientEntity**](RegistryClientEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcluster"></a>
# **GetCluster**
> ClusterEntity GetCluster ()

Gets the contents of the cluster

Returns the contents of the cluster including all nodes and their status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();

            try
            {
                // Gets the contents of the cluster
                ClusterEntity result = apiInstance.GetCluster();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.GetCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ClusterEntity**](ClusterEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontrollerconfig"></a>
# **GetControllerConfig**
> ControllerConfigurationEntity GetControllerConfig ()

Retrieves the configuration for this NiFi Controller

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetControllerConfigExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();

            try
            {
                // Retrieves the configuration for this NiFi Controller
                ControllerConfigurationEntity result = apiInstance.GetControllerConfig();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.GetControllerConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ControllerConfigurationEntity**](ControllerConfigurationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnode"></a>
# **GetNode**
> NodeEntity GetNode (string id)

Gets a node in the cluster

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var id = id_example;  // string | The node id.

            try
            {
                // Gets a node in the cluster
                NodeEntity result = apiInstance.GetNode(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.GetNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The node id. | 

### Return type

[**NodeEntity**](NodeEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistryclient"></a>
# **GetRegistryClient**
> RegistryClientEntity GetRegistryClient (string id)

Gets a registry client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRegistryClientExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var id = id_example;  // string | The registry id.

            try
            {
                // Gets a registry client
                RegistryClientEntity result = apiInstance.GetRegistryClient(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.GetRegistryClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The registry id. | 

### Return type

[**RegistryClientEntity**](RegistryClientEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistryclients"></a>
# **GetRegistryClients**
> RegistryClientsEntity GetRegistryClients ()

Gets the listing of available registry clients

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRegistryClientsExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();

            try
            {
                // Gets the listing of available registry clients
                RegistryClientsEntity result = apiInstance.GetRegistryClients();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.GetRegistryClients: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RegistryClientsEntity**](RegistryClientsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontrollerconfig"></a>
# **UpdateControllerConfig**
> ControllerConfigurationEntity UpdateControllerConfig (ControllerConfigurationEntity body)

Retrieves the configuration for this NiFi

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateControllerConfigExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var body = new ControllerConfigurationEntity(); // ControllerConfigurationEntity | The controller configuration.

            try
            {
                // Retrieves the configuration for this NiFi
                ControllerConfigurationEntity result = apiInstance.UpdateControllerConfig(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.UpdateControllerConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ControllerConfigurationEntity**](ControllerConfigurationEntity.md)| The controller configuration. | 

### Return type

[**ControllerConfigurationEntity**](ControllerConfigurationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenode"></a>
# **UpdateNode**
> NodeEntity UpdateNode (string id, NodeEntity body)

Updates a node in the cluster

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateNodeExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var id = id_example;  // string | The node id.
            var body = new NodeEntity(); // NodeEntity | The node configuration. The only configuration that will be honored at this endpoint is the status.

            try
            {
                // Updates a node in the cluster
                NodeEntity result = apiInstance.UpdateNode(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.UpdateNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The node id. | 
 **body** | [**NodeEntity**](NodeEntity.md)| The node configuration. The only configuration that will be honored at this endpoint is the status. | 

### Return type

[**NodeEntity**](NodeEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateregistryclient"></a>
# **UpdateRegistryClient**
> RegistryClientEntity UpdateRegistryClient (string id, RegistryClientEntity body)

Updates a registry client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRegistryClientExample
    {
        public void main()
        {
            var apiInstance = new ControllerApi();
            var id = id_example;  // string | The registry id.
            var body = new RegistryClientEntity(); // RegistryClientEntity | The registry configuration details.

            try
            {
                // Updates a registry client
                RegistryClientEntity result = apiInstance.UpdateRegistryClient(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ControllerApi.UpdateRegistryClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The registry id. | 
 **body** | [**RegistryClientEntity**](RegistryClientEntity.md)| The registry configuration details. | 

### Return type

[**RegistryClientEntity**](RegistryClientEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

