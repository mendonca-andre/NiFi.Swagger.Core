# IO.Swagger.Api.FlowApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateControllerServices**](FlowApi.md#activatecontrollerservices) | **PUT** /flow/process-groups/{id}/controller-services | Enable or disable Controller Services in the specified Process Group.
[**GenerateClientId**](FlowApi.md#generateclientid) | **GET** /flow/client-id | Generates a client id.
[**GetAboutInfo**](FlowApi.md#getaboutinfo) | **GET** /flow/about | Retrieves details about this NiFi to put in the About dialog
[**GetAction**](FlowApi.md#getaction) | **GET** /flow/history/{id} | Gets an action
[**GetBanners**](FlowApi.md#getbanners) | **GET** /flow/banners | Retrieves the banners for this NiFi
[**GetBuckets**](FlowApi.md#getbuckets) | **GET** /flow/registries/{id}/buckets | Gets the buckets from the specified registry for the current user
[**GetBulletinBoard**](FlowApi.md#getbulletinboard) | **GET** /flow/bulletin-board | Gets current bulletins
[**GetBulletins**](FlowApi.md#getbulletins) | **GET** /flow/controller/bulletins | Retrieves Controller level bulletins
[**GetClusterSummary**](FlowApi.md#getclustersummary) | **GET** /flow/cluster/summary | The cluster summary for this NiFi
[**GetComponentHistory**](FlowApi.md#getcomponenthistory) | **GET** /flow/history/components/{componentId} | Gets configuration history for a component
[**GetConnectionStatus**](FlowApi.md#getconnectionstatus) | **GET** /flow/connections/{id}/status | Gets status for a connection
[**GetConnectionStatusHistory**](FlowApi.md#getconnectionstatushistory) | **GET** /flow/connections/{id}/status/history | Gets the status history for a connection
[**GetControllerServiceTypes**](FlowApi.md#getcontrollerservicetypes) | **GET** /flow/controller-service-types | Retrieves the types of controller services that this NiFi supports
[**GetControllerServicesFromController**](FlowApi.md#getcontrollerservicesfromcontroller) | **GET** /flow/controller/controller-services | Gets controller services for reporting tasks
[**GetControllerServicesFromGroup**](FlowApi.md#getcontrollerservicesfromgroup) | **GET** /flow/process-groups/{id}/controller-services | Gets all controller services
[**GetControllerStatus**](FlowApi.md#getcontrollerstatus) | **GET** /flow/status | Gets the current status of this NiFi
[**GetCurrentUser**](FlowApi.md#getcurrentuser) | **GET** /flow/current-user | Retrieves the user identity of the user making the request
[**GetFlow**](FlowApi.md#getflow) | **GET** /flow/process-groups/{id} | Gets a process group
[**GetFlowConfig**](FlowApi.md#getflowconfig) | **GET** /flow/config | Retrieves the configuration for this NiFi flow
[**GetFlows**](FlowApi.md#getflows) | **GET** /flow/registries/{registry-id}/buckets/{bucket-id}/flows | Gets the flows from the specified registry and bucket for the current user
[**GetInputPortStatus**](FlowApi.md#getinputportstatus) | **GET** /flow/input-ports/{id}/status | Gets status for an input port
[**GetOutputPortStatus**](FlowApi.md#getoutputportstatus) | **GET** /flow/output-ports/{id}/status | Gets status for an output port
[**GetPrioritizers**](FlowApi.md#getprioritizers) | **GET** /flow/prioritizers | Retrieves the types of prioritizers that this NiFi supports
[**GetProcessGroupStatus**](FlowApi.md#getprocessgroupstatus) | **GET** /flow/process-groups/{id}/status | Gets the status for a process group
[**GetProcessGroupStatusHistory**](FlowApi.md#getprocessgroupstatushistory) | **GET** /flow/process-groups/{id}/status/history | Gets status history for a remote process group
[**GetProcessorStatus**](FlowApi.md#getprocessorstatus) | **GET** /flow/processors/{id}/status | Gets status for a processor
[**GetProcessorStatusHistory**](FlowApi.md#getprocessorstatushistory) | **GET** /flow/processors/{id}/status/history | Gets status history for a processor
[**GetProcessorTypes**](FlowApi.md#getprocessortypes) | **GET** /flow/processor-types | Retrieves the types of processors that this NiFi supports
[**GetRegistries**](FlowApi.md#getregistries) | **GET** /flow/registries | Gets the listing of available registries
[**GetRemoteProcessGroupStatus**](FlowApi.md#getremoteprocessgroupstatus) | **GET** /flow/remote-process-groups/{id}/status | Gets status for a remote process group
[**GetRemoteProcessGroupStatusHistory**](FlowApi.md#getremoteprocessgroupstatushistory) | **GET** /flow/remote-process-groups/{id}/status/history | Gets the status history
[**GetReportingTaskTypes**](FlowApi.md#getreportingtasktypes) | **GET** /flow/reporting-task-types | Retrieves the types of reporting tasks that this NiFi supports
[**GetReportingTasks**](FlowApi.md#getreportingtasks) | **GET** /flow/reporting-tasks | Gets all reporting tasks
[**GetTemplates**](FlowApi.md#gettemplates) | **GET** /flow/templates | Gets all templates
[**GetVersions**](FlowApi.md#getversions) | **GET** /flow/registries/{registry-id}/buckets/{bucket-id}/flows/{flow-id}/versions | Gets the flow versions from the specified registry and bucket for the specified flow for the current user
[**QueryHistory**](FlowApi.md#queryhistory) | **GET** /flow/history | Gets configuration history
[**ScheduleComponents**](FlowApi.md#schedulecomponents) | **PUT** /flow/process-groups/{id} | Schedule or unschedule components in the specified Process Group.
[**SearchCluster**](FlowApi.md#searchcluster) | **GET** /flow/cluster/search-results | Searches the cluster for a node with the specified address
[**SearchFlow**](FlowApi.md#searchflow) | **GET** /flow/search-results | Performs a search against this NiFi using the specified search term


<a name="activatecontrollerservices"></a>
# **ActivateControllerServices**
> ActivateControllerServicesEntity ActivateControllerServices (string id, ActivateControllerServicesEntity body)

Enable or disable Controller Services in the specified Process Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActivateControllerServicesExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The process group id.
            var body = new ActivateControllerServicesEntity(); // ActivateControllerServicesEntity | The request to schedule or unschedule. If the comopnents in the request are not specified, all authorized components will be considered.

            try
            {
                // Enable or disable Controller Services in the specified Process Group.
                ActivateControllerServicesEntity result = apiInstance.ActivateControllerServices(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.ActivateControllerServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**ActivateControllerServicesEntity**](ActivateControllerServicesEntity.md)| The request to schedule or unschedule. If the comopnents in the request are not specified, all authorized components will be considered. | 

### Return type

[**ActivateControllerServicesEntity**](ActivateControllerServicesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateclientid"></a>
# **GenerateClientId**
> string GenerateClientId ()

Generates a client id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateClientIdExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Generates a client id.
                string result = apiInstance.GenerateClientId();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GenerateClientId: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaboutinfo"></a>
# **GetAboutInfo**
> AboutEntity GetAboutInfo ()

Retrieves details about this NiFi to put in the About dialog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAboutInfoExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Retrieves details about this NiFi to put in the About dialog
                AboutEntity result = apiInstance.GetAboutInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetAboutInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AboutEntity**](AboutEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaction"></a>
# **GetAction**
> ActionEntity GetAction (string id)

Gets an action

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
    public class GetActionExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The action id.

            try
            {
                // Gets an action
                ActionEntity result = apiInstance.GetAction(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The action id. | 

### Return type

[**ActionEntity**](ActionEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbanners"></a>
# **GetBanners**
> BannerEntity GetBanners ()

Retrieves the banners for this NiFi

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBannersExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Retrieves the banners for this NiFi
                BannerEntity result = apiInstance.GetBanners();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetBanners: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BannerEntity**](BannerEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuckets"></a>
# **GetBuckets**
> BucketsEntity GetBuckets (string id)

Gets the buckets from the specified registry for the current user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBucketsExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The registry id.

            try
            {
                // Gets the buckets from the specified registry for the current user
                BucketsEntity result = apiInstance.GetBuckets(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetBuckets: " + e.Message );
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

[**BucketsEntity**](BucketsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbulletinboard"></a>
# **GetBulletinBoard**
> BulletinBoardEntity GetBulletinBoard (string after = null, string sourceName = null, string message = null, string sourceId = null, string groupId = null, string limit = null)

Gets current bulletins

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBulletinBoardExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var after = after_example;  // string | Includes bulletins with an id after this value. (optional) 
            var sourceName = sourceName_example;  // string | Includes bulletins originating from this sources whose name match this regular expression. (optional) 
            var message = message_example;  // string | Includes bulletins whose message that match this regular expression. (optional) 
            var sourceId = sourceId_example;  // string | Includes bulletins originating from this sources whose id match this regular expression. (optional) 
            var groupId = groupId_example;  // string | Includes bulletins originating from this sources whose group id match this regular expression. (optional) 
            var limit = limit_example;  // string | The number of bulletins to limit the response to. (optional) 

            try
            {
                // Gets current bulletins
                BulletinBoardEntity result = apiInstance.GetBulletinBoard(after, sourceName, message, sourceId, groupId, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetBulletinBoard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **string**| Includes bulletins with an id after this value. | [optional] 
 **sourceName** | **string**| Includes bulletins originating from this sources whose name match this regular expression. | [optional] 
 **message** | **string**| Includes bulletins whose message that match this regular expression. | [optional] 
 **sourceId** | **string**| Includes bulletins originating from this sources whose id match this regular expression. | [optional] 
 **groupId** | **string**| Includes bulletins originating from this sources whose group id match this regular expression. | [optional] 
 **limit** | **string**| The number of bulletins to limit the response to. | [optional] 

### Return type

[**BulletinBoardEntity**](BulletinBoardEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbulletins"></a>
# **GetBulletins**
> ControllerBulletinsEntity GetBulletins ()

Retrieves Controller level bulletins

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBulletinsExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Retrieves Controller level bulletins
                ControllerBulletinsEntity result = apiInstance.GetBulletins();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetBulletins: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ControllerBulletinsEntity**](ControllerBulletinsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclustersummary"></a>
# **GetClusterSummary**
> ClusteSummaryEntity GetClusterSummary ()

The cluster summary for this NiFi

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterSummaryExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // The cluster summary for this NiFi
                ClusteSummaryEntity result = apiInstance.GetClusterSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetClusterSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ClusteSummaryEntity**](ClusteSummaryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomponenthistory"></a>
# **GetComponentHistory**
> ComponentHistoryEntity GetComponentHistory (string componentId)

Gets configuration history for a component

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
    public class GetComponentHistoryExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var componentId = componentId_example;  // string | The component id.

            try
            {
                // Gets configuration history for a component
                ComponentHistoryEntity result = apiInstance.GetComponentHistory(componentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetComponentHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **componentId** | **string**| The component id. | 

### Return type

[**ComponentHistoryEntity**](ComponentHistoryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnectionstatus"></a>
# **GetConnectionStatus**
> ConnectionStatusEntity GetConnectionStatus (string id, bool? nodewise = null, string clusterNodeId = null)

Gets status for a connection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectionStatusExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The connection id.
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets status for a connection
                ConnectionStatusEntity result = apiInstance.GetConnectionStatus(id, nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetConnectionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **nodewise** | **bool?**| Whether or not to include the breakdown per node. Optional, defaults to false | [optional] [default to false]
 **clusterNodeId** | **string**| The id of the node where to get the status. | [optional] 

### Return type

[**ConnectionStatusEntity**](ConnectionStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnectionstatushistory"></a>
# **GetConnectionStatusHistory**
> StatusHistoryEntity GetConnectionStatusHistory (string id)

Gets the status history for a connection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectionStatusHistoryExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The connection id.

            try
            {
                // Gets the status history for a connection
                StatusHistoryEntity result = apiInstance.GetConnectionStatusHistory(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetConnectionStatusHistory: " + e.Message );
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

[**StatusHistoryEntity**](StatusHistoryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontrollerservicetypes"></a>
# **GetControllerServiceTypes**
> ControllerServiceTypesEntity GetControllerServiceTypes (string serviceType = null, string serviceBundleGroup = null, string serviceBundleArtifact = null, string serviceBundleVersion = null, string bundleGroupFilter = null, string bundleArtifactFilter = null, string typeFilter = null)

Retrieves the types of controller services that this NiFi supports

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
    public class GetControllerServiceTypesExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var serviceType = serviceType_example;  // string | If specified, will only return controller services that are compatible with this type of service. (optional) 
            var serviceBundleGroup = serviceBundleGroup_example;  // string | If serviceType specified, is the bundle group of the serviceType. (optional) 
            var serviceBundleArtifact = serviceBundleArtifact_example;  // string | If serviceType specified, is the bundle artifact of the serviceType. (optional) 
            var serviceBundleVersion = serviceBundleVersion_example;  // string | If serviceType specified, is the bundle version of the serviceType. (optional) 
            var bundleGroupFilter = bundleGroupFilter_example;  // string | If specified, will only return types that are a member of this bundle group. (optional) 
            var bundleArtifactFilter = bundleArtifactFilter_example;  // string | If specified, will only return types that are a member of this bundle artifact. (optional) 
            var typeFilter = typeFilter_example;  // string | If specified, will only return types whose fully qualified classname matches. (optional) 

            try
            {
                // Retrieves the types of controller services that this NiFi supports
                ControllerServiceTypesEntity result = apiInstance.GetControllerServiceTypes(serviceType, serviceBundleGroup, serviceBundleArtifact, serviceBundleVersion, bundleGroupFilter, bundleArtifactFilter, typeFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetControllerServiceTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceType** | **string**| If specified, will only return controller services that are compatible with this type of service. | [optional] 
 **serviceBundleGroup** | **string**| If serviceType specified, is the bundle group of the serviceType. | [optional] 
 **serviceBundleArtifact** | **string**| If serviceType specified, is the bundle artifact of the serviceType. | [optional] 
 **serviceBundleVersion** | **string**| If serviceType specified, is the bundle version of the serviceType. | [optional] 
 **bundleGroupFilter** | **string**| If specified, will only return types that are a member of this bundle group. | [optional] 
 **bundleArtifactFilter** | **string**| If specified, will only return types that are a member of this bundle artifact. | [optional] 
 **typeFilter** | **string**| If specified, will only return types whose fully qualified classname matches. | [optional] 

### Return type

[**ControllerServiceTypesEntity**](ControllerServiceTypesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontrollerservicesfromcontroller"></a>
# **GetControllerServicesFromController**
> ControllerServicesEntity GetControllerServicesFromController ()

Gets controller services for reporting tasks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetControllerServicesFromControllerExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Gets controller services for reporting tasks
                ControllerServicesEntity result = apiInstance.GetControllerServicesFromController();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetControllerServicesFromController: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ControllerServicesEntity**](ControllerServicesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontrollerservicesfromgroup"></a>
# **GetControllerServicesFromGroup**
> ControllerServicesEntity GetControllerServicesFromGroup (string id, bool? includeAncestorGroups = null, bool? includeDescendantGroups = null)

Gets all controller services

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetControllerServicesFromGroupExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The process group id.
            var includeAncestorGroups = true;  // bool? | Whether or not to include parent/ancestory process groups (optional)  (default to true)
            var includeDescendantGroups = true;  // bool? | Whether or not to include descendant process groups (optional)  (default to false)

            try
            {
                // Gets all controller services
                ControllerServicesEntity result = apiInstance.GetControllerServicesFromGroup(id, includeAncestorGroups, includeDescendantGroups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetControllerServicesFromGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **includeAncestorGroups** | **bool?**| Whether or not to include parent/ancestory process groups | [optional] [default to true]
 **includeDescendantGroups** | **bool?**| Whether or not to include descendant process groups | [optional] [default to false]

### Return type

[**ControllerServicesEntity**](ControllerServicesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontrollerstatus"></a>
# **GetControllerStatus**
> ControllerStatusEntity GetControllerStatus ()

Gets the current status of this NiFi

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetControllerStatusExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Gets the current status of this NiFi
                ControllerStatusEntity result = apiInstance.GetControllerStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetControllerStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ControllerStatusEntity**](ControllerStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentuser"></a>
# **GetCurrentUser**
> CurrentUserEntity GetCurrentUser ()

Retrieves the user identity of the user making the request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentUserExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Retrieves the user identity of the user making the request
                CurrentUserEntity result = apiInstance.GetCurrentUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetCurrentUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrentUserEntity**](CurrentUserEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflow"></a>
# **GetFlow**
> ProcessGroupFlowEntity GetFlow (string id)

Gets a process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets a process group
                ProcessGroupFlowEntity result = apiInstance.GetFlow(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetFlow: " + e.Message );
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

[**ProcessGroupFlowEntity**](ProcessGroupFlowEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowconfig"></a>
# **GetFlowConfig**
> FlowConfigurationEntity GetFlowConfig ()

Retrieves the configuration for this NiFi flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowConfigExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Retrieves the configuration for this NiFi flow
                FlowConfigurationEntity result = apiInstance.GetFlowConfig();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetFlowConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**FlowConfigurationEntity**](FlowConfigurationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflows"></a>
# **GetFlows**
> VersionedFlowsEntity GetFlows (string registryId, string bucketId)

Gets the flows from the specified registry and bucket for the current user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowsExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var registryId = registryId_example;  // string | The registry id.
            var bucketId = bucketId_example;  // string | The bucket id.

            try
            {
                // Gets the flows from the specified registry and bucket for the current user
                VersionedFlowsEntity result = apiInstance.GetFlows(registryId, bucketId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registryId** | **string**| The registry id. | 
 **bucketId** | **string**| The bucket id. | 

### Return type

[**VersionedFlowsEntity**](VersionedFlowsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinputportstatus"></a>
# **GetInputPortStatus**
> PortStatusEntity GetInputPortStatus (string id, bool? nodewise = null, string clusterNodeId = null)

Gets status for an input port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInputPortStatusExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The input port id.
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets status for an input port
                PortStatusEntity result = apiInstance.GetInputPortStatus(id, nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetInputPortStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The input port id. | 
 **nodewise** | **bool?**| Whether or not to include the breakdown per node. Optional, defaults to false | [optional] [default to false]
 **clusterNodeId** | **string**| The id of the node where to get the status. | [optional] 

### Return type

[**PortStatusEntity**](PortStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoutputportstatus"></a>
# **GetOutputPortStatus**
> PortStatusEntity GetOutputPortStatus (string id, bool? nodewise = null, string clusterNodeId = null)

Gets status for an output port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOutputPortStatusExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The output port id.
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets status for an output port
                PortStatusEntity result = apiInstance.GetOutputPortStatus(id, nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetOutputPortStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The output port id. | 
 **nodewise** | **bool?**| Whether or not to include the breakdown per node. Optional, defaults to false | [optional] [default to false]
 **clusterNodeId** | **string**| The id of the node where to get the status. | [optional] 

### Return type

[**PortStatusEntity**](PortStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprioritizers"></a>
# **GetPrioritizers**
> PrioritizerTypesEntity GetPrioritizers ()

Retrieves the types of prioritizers that this NiFi supports

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
    public class GetPrioritizersExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Retrieves the types of prioritizers that this NiFi supports
                PrioritizerTypesEntity result = apiInstance.GetPrioritizers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetPrioritizers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PrioritizerTypesEntity**](PrioritizerTypesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessgroupstatus"></a>
# **GetProcessGroupStatus**
> ProcessGroupStatusEntity GetProcessGroupStatus (string id, bool? recursive = null, bool? nodewise = null, string clusterNodeId = null)

Gets the status for a process group

The status for a process group includes status for all descendent components. When invoked on the root group with recursive set to true, it will return the current status of every component in the flow.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessGroupStatusExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The process group id.
            var recursive = true;  // bool? | Whether all descendant groups and the status of their content will be included. Optional, defaults to false (optional)  (default to false)
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets the status for a process group
                ProcessGroupStatusEntity result = apiInstance.GetProcessGroupStatus(id, recursive, nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetProcessGroupStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **recursive** | **bool?**| Whether all descendant groups and the status of their content will be included. Optional, defaults to false | [optional] [default to false]
 **nodewise** | **bool?**| Whether or not to include the breakdown per node. Optional, defaults to false | [optional] [default to false]
 **clusterNodeId** | **string**| The id of the node where to get the status. | [optional] 

### Return type

[**ProcessGroupStatusEntity**](ProcessGroupStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessgroupstatushistory"></a>
# **GetProcessGroupStatusHistory**
> StatusHistoryEntity GetProcessGroupStatusHistory (string id)

Gets status history for a remote process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessGroupStatusHistoryExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets status history for a remote process group
                StatusHistoryEntity result = apiInstance.GetProcessGroupStatusHistory(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetProcessGroupStatusHistory: " + e.Message );
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

[**StatusHistoryEntity**](StatusHistoryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessorstatus"></a>
# **GetProcessorStatus**
> ProcessorStatusEntity GetProcessorStatus (string id, bool? nodewise = null, string clusterNodeId = null)

Gets status for a processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessorStatusExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The processor id.
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets status for a processor
                ProcessorStatusEntity result = apiInstance.GetProcessorStatus(id, nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetProcessorStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 
 **nodewise** | **bool?**| Whether or not to include the breakdown per node. Optional, defaults to false | [optional] [default to false]
 **clusterNodeId** | **string**| The id of the node where to get the status. | [optional] 

### Return type

[**ProcessorStatusEntity**](ProcessorStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessorstatushistory"></a>
# **GetProcessorStatusHistory**
> StatusHistoryEntity GetProcessorStatusHistory (string id)

Gets status history for a processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessorStatusHistoryExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The processor id.

            try
            {
                // Gets status history for a processor
                StatusHistoryEntity result = apiInstance.GetProcessorStatusHistory(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetProcessorStatusHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 

### Return type

[**StatusHistoryEntity**](StatusHistoryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessortypes"></a>
# **GetProcessorTypes**
> ProcessorTypesEntity GetProcessorTypes (string bundleGroupFilter = null, string bundleArtifactFilter = null, string type = null)

Retrieves the types of processors that this NiFi supports

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
    public class GetProcessorTypesExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var bundleGroupFilter = bundleGroupFilter_example;  // string | If specified, will only return types that are a member of this bundle group. (optional) 
            var bundleArtifactFilter = bundleArtifactFilter_example;  // string | If specified, will only return types that are a member of this bundle artifact. (optional) 
            var type = type_example;  // string | If specified, will only return types whose fully qualified classname matches. (optional) 

            try
            {
                // Retrieves the types of processors that this NiFi supports
                ProcessorTypesEntity result = apiInstance.GetProcessorTypes(bundleGroupFilter, bundleArtifactFilter, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetProcessorTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bundleGroupFilter** | **string**| If specified, will only return types that are a member of this bundle group. | [optional] 
 **bundleArtifactFilter** | **string**| If specified, will only return types that are a member of this bundle artifact. | [optional] 
 **type** | **string**| If specified, will only return types whose fully qualified classname matches. | [optional] 

### Return type

[**ProcessorTypesEntity**](ProcessorTypesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistries"></a>
# **GetRegistries**
> RegistryClientsEntity GetRegistries ()

Gets the listing of available registries

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRegistriesExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Gets the listing of available registries
                RegistryClientsEntity result = apiInstance.GetRegistries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetRegistries: " + e.Message );
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

<a name="getremoteprocessgroupstatus"></a>
# **GetRemoteProcessGroupStatus**
> RemoteProcessGroupStatusEntity GetRemoteProcessGroupStatus (string id, bool? nodewise = null, string clusterNodeId = null)

Gets status for a remote process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemoteProcessGroupStatusExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The remote process group id.
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets status for a remote process group
                RemoteProcessGroupStatusEntity result = apiInstance.GetRemoteProcessGroupStatus(id, nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetRemoteProcessGroupStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **nodewise** | **bool?**| Whether or not to include the breakdown per node. Optional, defaults to false | [optional] [default to false]
 **clusterNodeId** | **string**| The id of the node where to get the status. | [optional] 

### Return type

[**RemoteProcessGroupStatusEntity**](RemoteProcessGroupStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremoteprocessgroupstatushistory"></a>
# **GetRemoteProcessGroupStatusHistory**
> StatusHistoryEntity GetRemoteProcessGroupStatusHistory (string id)

Gets the status history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemoteProcessGroupStatusHistoryExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The remote process group id.

            try
            {
                // Gets the status history
                StatusHistoryEntity result = apiInstance.GetRemoteProcessGroupStatusHistory(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetRemoteProcessGroupStatusHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 

### Return type

[**StatusHistoryEntity**](StatusHistoryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportingtasktypes"></a>
# **GetReportingTaskTypes**
> ReportingTaskTypesEntity GetReportingTaskTypes (string bundleGroupFilter = null, string bundleArtifactFilter = null, string type = null)

Retrieves the types of reporting tasks that this NiFi supports

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
    public class GetReportingTaskTypesExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var bundleGroupFilter = bundleGroupFilter_example;  // string | If specified, will only return types that are a member of this bundle group. (optional) 
            var bundleArtifactFilter = bundleArtifactFilter_example;  // string | If specified, will only return types that are a member of this bundle artifact. (optional) 
            var type = type_example;  // string | If specified, will only return types whose fully qualified classname matches. (optional) 

            try
            {
                // Retrieves the types of reporting tasks that this NiFi supports
                ReportingTaskTypesEntity result = apiInstance.GetReportingTaskTypes(bundleGroupFilter, bundleArtifactFilter, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetReportingTaskTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bundleGroupFilter** | **string**| If specified, will only return types that are a member of this bundle group. | [optional] 
 **bundleArtifactFilter** | **string**| If specified, will only return types that are a member of this bundle artifact. | [optional] 
 **type** | **string**| If specified, will only return types whose fully qualified classname matches. | [optional] 

### Return type

[**ReportingTaskTypesEntity**](ReportingTaskTypesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportingtasks"></a>
# **GetReportingTasks**
> ReportingTasksEntity GetReportingTasks ()

Gets all reporting tasks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReportingTasksExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Gets all reporting tasks
                ReportingTasksEntity result = apiInstance.GetReportingTasks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetReportingTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReportingTasksEntity**](ReportingTasksEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplates"></a>
# **GetTemplates**
> TemplatesEntity GetTemplates ()

Gets all templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplatesExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();

            try
            {
                // Gets all templates
                TemplatesEntity result = apiInstance.GetTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TemplatesEntity**](TemplatesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getversions"></a>
# **GetVersions**
> VersionedFlowSnapshotMetadataSetEntity GetVersions (string registryId, string bucketId, string flowId)

Gets the flow versions from the specified registry and bucket for the specified flow for the current user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVersionsExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var registryId = registryId_example;  // string | The registry id.
            var bucketId = bucketId_example;  // string | The bucket id.
            var flowId = flowId_example;  // string | The flow id.

            try
            {
                // Gets the flow versions from the specified registry and bucket for the specified flow for the current user
                VersionedFlowSnapshotMetadataSetEntity result = apiInstance.GetVersions(registryId, bucketId, flowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.GetVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registryId** | **string**| The registry id. | 
 **bucketId** | **string**| The bucket id. | 
 **flowId** | **string**| The flow id. | 

### Return type

[**VersionedFlowSnapshotMetadataSetEntity**](VersionedFlowSnapshotMetadataSetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistory"></a>
# **QueryHistory**
> HistoryEntity QueryHistory (string offset, string count, string sortColumn = null, string sortOrder = null, string startDate = null, string endDate = null, string userIdentity = null, string sourceId = null)

Gets configuration history

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
    public class QueryHistoryExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var offset = offset_example;  // string | The offset into the result set.
            var count = count_example;  // string | The number of actions to return.
            var sortColumn = sortColumn_example;  // string | The field to sort on. (optional) 
            var sortOrder = sortOrder_example;  // string | The direction to sort. (optional) 
            var startDate = startDate_example;  // string | Include actions after this date. (optional) 
            var endDate = endDate_example;  // string | Include actions before this date. (optional) 
            var userIdentity = userIdentity_example;  // string | Include actions performed by this user. (optional) 
            var sourceId = sourceId_example;  // string | Include actions on this component. (optional) 

            try
            {
                // Gets configuration history
                HistoryEntity result = apiInstance.QueryHistory(offset, count, sortColumn, sortOrder, startDate, endDate, userIdentity, sourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.QueryHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **string**| The offset into the result set. | 
 **count** | **string**| The number of actions to return. | 
 **sortColumn** | **string**| The field to sort on. | [optional] 
 **sortOrder** | **string**| The direction to sort. | [optional] 
 **startDate** | **string**| Include actions after this date. | [optional] 
 **endDate** | **string**| Include actions before this date. | [optional] 
 **userIdentity** | **string**| Include actions performed by this user. | [optional] 
 **sourceId** | **string**| Include actions on this component. | [optional] 

### Return type

[**HistoryEntity**](HistoryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulecomponents"></a>
# **ScheduleComponents**
> ScheduleComponentsEntity ScheduleComponents (string id, ScheduleComponentsEntity body)

Schedule or unschedule components in the specified Process Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ScheduleComponentsExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var id = id_example;  // string | The process group id.
            var body = new ScheduleComponentsEntity(); // ScheduleComponentsEntity | The request to schedule or unschedule. If the comopnents in the request are not specified, all authorized components will be considered.

            try
            {
                // Schedule or unschedule components in the specified Process Group.
                ScheduleComponentsEntity result = apiInstance.ScheduleComponents(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.ScheduleComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**ScheduleComponentsEntity**](ScheduleComponentsEntity.md)| The request to schedule or unschedule. If the comopnents in the request are not specified, all authorized components will be considered. | 

### Return type

[**ScheduleComponentsEntity**](ScheduleComponentsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcluster"></a>
# **SearchCluster**
> ClusterSearchResultsEntity SearchCluster (string q)

Searches the cluster for a node with the specified address

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
    public class SearchClusterExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var q = q_example;  // string | Node address to search for.

            try
            {
                // Searches the cluster for a node with the specified address
                ClusterSearchResultsEntity result = apiInstance.SearchCluster(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.SearchCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Node address to search for. | 

### Return type

[**ClusterSearchResultsEntity**](ClusterSearchResultsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchflow"></a>
# **SearchFlow**
> SearchResultsEntity SearchFlow (string q = null)

Performs a search against this NiFi using the specified search term

Only search results from authorized components will be returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchFlowExample
    {
        public void main()
        {
            var apiInstance = new FlowApi();
            var q = q_example;  // string |  (optional) 

            try
            {
                // Performs a search against this NiFi using the specified search term
                SearchResultsEntity result = apiInstance.SearchFlow(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowApi.SearchFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**|  | [optional] 

### Return type

[**SearchResultsEntity**](SearchResultsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

