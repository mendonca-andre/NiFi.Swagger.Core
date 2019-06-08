# IO.Swagger.Api.SnippetsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSnippet**](SnippetsApi.md#createsnippet) | **POST** /snippets | Creates a snippet. The snippet will be automatically discarded if not used in a subsequent request after 1 minute.
[**DeleteSnippet**](SnippetsApi.md#deletesnippet) | **DELETE** /snippets/{id} | Deletes the components in a snippet and discards the snippet
[**UpdateSnippet**](SnippetsApi.md#updatesnippet) | **PUT** /snippets/{id} | Move&#39;s the components in this Snippet into a new Process Group and discards the snippet


<a name="createsnippet"></a>
# **CreateSnippet**
> SnippetEntity CreateSnippet (SnippetEntity body)

Creates a snippet. The snippet will be automatically discarded if not used in a subsequent request after 1 minute.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSnippetExample
    {
        public void main()
        {
            var apiInstance = new SnippetsApi();
            var body = new SnippetEntity(); // SnippetEntity | The snippet configuration details.

            try
            {
                // Creates a snippet. The snippet will be automatically discarded if not used in a subsequent request after 1 minute.
                SnippetEntity result = apiInstance.CreateSnippet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SnippetsApi.CreateSnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SnippetEntity**](SnippetEntity.md)| The snippet configuration details. | 

### Return type

[**SnippetEntity**](SnippetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesnippet"></a>
# **DeleteSnippet**
> SnippetEntity DeleteSnippet (string id, bool? disconnectedNodeAcknowledged = null)

Deletes the components in a snippet and discards the snippet

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSnippetExample
    {
        public void main()
        {
            var apiInstance = new SnippetsApi();
            var id = id_example;  // string | The snippet id.
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes the components in a snippet and discards the snippet
                SnippetEntity result = apiInstance.DeleteSnippet(id, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SnippetsApi.DeleteSnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The snippet id. | 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**SnippetEntity**](SnippetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesnippet"></a>
# **UpdateSnippet**
> SnippetEntity UpdateSnippet (string id, SnippetEntity body)

Move's the components in this Snippet into a new Process Group and discards the snippet

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSnippetExample
    {
        public void main()
        {
            var apiInstance = new SnippetsApi();
            var id = id_example;  // string | The snippet id.
            var body = new SnippetEntity(); // SnippetEntity | The snippet configuration details.

            try
            {
                // Move's the components in this Snippet into a new Process Group and discards the snippet
                SnippetEntity result = apiInstance.UpdateSnippet(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SnippetsApi.UpdateSnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The snippet id. | 
 **body** | [**SnippetEntity**](SnippetEntity.md)| The snippet configuration details. | 

### Return type

[**SnippetEntity**](SnippetEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

