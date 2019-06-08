# IO.Swagger.Api.TemplatesApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportTemplate**](TemplatesApi.md#exporttemplate) | **GET** /templates/{id}/download | Exports a template
[**RemoveTemplate**](TemplatesApi.md#removetemplate) | **DELETE** /templates/{id} | Deletes a template


<a name="exporttemplate"></a>
# **ExportTemplate**
> string ExportTemplate (string id)

Exports a template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportTemplateExample
    {
        public void main()
        {
            var apiInstance = new TemplatesApi();
            var id = id_example;  // string | The template id.

            try
            {
                // Exports a template
                string result = apiInstance.ExportTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ExportTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The template id. | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetemplate"></a>
# **RemoveTemplate**
> TemplateEntity RemoveTemplate (string id, bool? disconnectedNodeAcknowledged = null)

Deletes a template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveTemplateExample
    {
        public void main()
        {
            var apiInstance = new TemplatesApi();
            var id = id_example;  // string | The template id.
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a template
                TemplateEntity result = apiInstance.RemoveTemplate(id, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.RemoveTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The template id. | 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**TemplateEntity**](TemplateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

