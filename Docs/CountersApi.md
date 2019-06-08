# IO.Swagger.Api.CountersApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCounters**](CountersApi.md#getcounters) | **GET** /counters | Gets the current counters for this NiFi
[**UpdateCounter**](CountersApi.md#updatecounter) | **PUT** /counters/{id} | Updates the specified counter. This will reset the counter value to 0


<a name="getcounters"></a>
# **GetCounters**
> CountersEntity GetCounters (bool? nodewise = null, string clusterNodeId = null)

Gets the current counters for this NiFi

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
    public class GetCountersExample
    {
        public void main()
        {
            var apiInstance = new CountersApi();
            var nodewise = true;  // bool? | Whether or not to include the breakdown per node. Optional, defaults to false (optional)  (default to false)
            var clusterNodeId = clusterNodeId_example;  // string | The id of the node where to get the status. (optional) 

            try
            {
                // Gets the current counters for this NiFi
                CountersEntity result = apiInstance.GetCounters(nodewise, clusterNodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountersApi.GetCounters: " + e.Message );
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

[**CountersEntity**](CountersEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecounter"></a>
# **UpdateCounter**
> CounterEntity UpdateCounter (string id)

Updates the specified counter. This will reset the counter value to 0

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
    public class UpdateCounterExample
    {
        public void main()
        {
            var apiInstance = new CountersApi();
            var id = id_example;  // string | The id of the counter.

            try
            {
                // Updates the specified counter. This will reset the counter value to 0
                CounterEntity result = apiInstance.UpdateCounter(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountersApi.UpdateCounter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the counter. | 

### Return type

[**CounterEntity**](CounterEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

