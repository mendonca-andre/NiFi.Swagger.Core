# IO.Swagger.Api.LabelsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLabel**](LabelsApi.md#getlabel) | **GET** /labels/{id} | Gets a label
[**RemoveLabel**](LabelsApi.md#removelabel) | **DELETE** /labels/{id} | Deletes a label
[**UpdateLabel**](LabelsApi.md#updatelabel) | **PUT** /labels/{id} | Updates a label


<a name="getlabel"></a>
# **GetLabel**
> LabelEntity GetLabel (string id)

Gets a label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLabelExample
    {
        public void main()
        {
            var apiInstance = new LabelsApi();
            var id = id_example;  // string | The label id.

            try
            {
                // Gets a label
                LabelEntity result = apiInstance.GetLabel(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.GetLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The label id. | 

### Return type

[**LabelEntity**](LabelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removelabel"></a>
# **RemoveLabel**
> LabelEntity RemoveLabel (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveLabelExample
    {
        public void main()
        {
            var apiInstance = new LabelsApi();
            var id = id_example;  // string | The label id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a label
                LabelEntity result = apiInstance.RemoveLabel(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.RemoveLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The label id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**LabelEntity**](LabelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelabel"></a>
# **UpdateLabel**
> LabelEntity UpdateLabel (string id, LabelEntity body)

Updates a label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLabelExample
    {
        public void main()
        {
            var apiInstance = new LabelsApi();
            var id = id_example;  // string | The label id.
            var body = new LabelEntity(); // LabelEntity | The label configuration details.

            try
            {
                // Updates a label
                LabelEntity result = apiInstance.UpdateLabel(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.UpdateLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The label id. | 
 **body** | [**LabelEntity**](LabelEntity.md)| The label configuration details. | 

### Return type

[**LabelEntity**](LabelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

