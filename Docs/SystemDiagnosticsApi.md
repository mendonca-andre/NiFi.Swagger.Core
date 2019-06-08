# IO.Swagger.Api.SystemDiagnosticsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSystemDiagnostics**](SystemDiagnosticsApi.md#getsystemdiagnostics) | **GET** /system-diagnostics | Gets the diagnostics for the system NiFi is running on


<a name="getsystemdiagnostics"></a>
# **GetSystemDiagnostics**
> SystemDiagnosticsEntity GetSystemDiagnostics (bool? nodewise = null, string clusterNodeId = null)

Gets the diagnostics for the system NiFi is running on

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemDiagnosticsExample
    {
        public void main()
        {
            var apiInstance = new SystemDiagnosticsApi();
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets the diagnostics for the system NiFi is running on
                SystemDiagnosticsEntity result = apiInstance.GetSystemDiagnostics(nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemDiagnosticsApi.GetSystemDiagnostics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodewise** | **bool?**| Whether or not to include the breakdown per node. Optional, defaults to false | [optional] [default to false]
 **clusterNodeId** | **string**| The id of the node where to get the status. | [optional] 

### Return type

[**SystemDiagnosticsEntity**](SystemDiagnosticsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

