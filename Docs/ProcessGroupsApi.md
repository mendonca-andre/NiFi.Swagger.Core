# IO.Swagger.Api.ProcessGroupsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CopySnippet**](ProcessGroupsApi.md#copysnippet) | **POST** /process-groups/{id}/snippet-instance | Copies a snippet and discards it.
[**CreateConnection**](ProcessGroupsApi.md#createconnection) | **POST** /process-groups/{id}/connections | Creates a connection
[**CreateControllerService**](ProcessGroupsApi.md#createcontrollerservice) | **POST** /process-groups/{id}/controller-services | Creates a new controller service
[**CreateFunnel**](ProcessGroupsApi.md#createfunnel) | **POST** /process-groups/{id}/funnels | Creates a funnel
[**CreateInputPort**](ProcessGroupsApi.md#createinputport) | **POST** /process-groups/{id}/input-ports | Creates an input port
[**CreateLabel**](ProcessGroupsApi.md#createlabel) | **POST** /process-groups/{id}/labels | Creates a label
[**CreateOutputPort**](ProcessGroupsApi.md#createoutputport) | **POST** /process-groups/{id}/output-ports | Creates an output port
[**CreateProcessGroup**](ProcessGroupsApi.md#createprocessgroup) | **POST** /process-groups/{id}/process-groups | Creates a process group
[**CreateProcessor**](ProcessGroupsApi.md#createprocessor) | **POST** /process-groups/{id}/processors | Creates a new processor
[**CreateRemoteProcessGroup**](ProcessGroupsApi.md#createremoteprocessgroup) | **POST** /process-groups/{id}/remote-process-groups | Creates a new process group
[**CreateTemplate**](ProcessGroupsApi.md#createtemplate) | **POST** /process-groups/{id}/templates | Creates a template and discards the specified snippet.
[**DeleteVariableRegistryUpdateRequest**](ProcessGroupsApi.md#deletevariableregistryupdaterequest) | **DELETE** /process-groups/{groupId}/variable-registry/update-requests/{updateId} | Deletes an update request for a process group&#39;s variable registry. If the request is not yet complete, it will automatically be cancelled.
[**GetConnections**](ProcessGroupsApi.md#getconnections) | **GET** /process-groups/{id}/connections | Gets all connections
[**GetFunnels**](ProcessGroupsApi.md#getfunnels) | **GET** /process-groups/{id}/funnels | Gets all funnels
[**GetInputPorts**](ProcessGroupsApi.md#getinputports) | **GET** /process-groups/{id}/input-ports | Gets all input ports
[**GetLabels**](ProcessGroupsApi.md#getlabels) | **GET** /process-groups/{id}/labels | Gets all labels
[**GetLocalModifications**](ProcessGroupsApi.md#getlocalmodifications) | **GET** /process-groups/{id}/local-modifications | Gets a list of local modifications to the Process Group since it was last synchronized with the Flow Registry
[**GetOutputPorts**](ProcessGroupsApi.md#getoutputports) | **GET** /process-groups/{id}/output-ports | Gets all output ports
[**GetProcessGroup**](ProcessGroupsApi.md#getprocessgroup) | **GET** /process-groups/{id} | Gets a process group
[**GetProcessGroups**](ProcessGroupsApi.md#getprocessgroups) | **GET** /process-groups/{id}/process-groups | Gets all process groups
[**GetProcessors**](ProcessGroupsApi.md#getprocessors) | **GET** /process-groups/{id}/processors | Gets all processors
[**GetRemoteProcessGroups**](ProcessGroupsApi.md#getremoteprocessgroups) | **GET** /process-groups/{id}/remote-process-groups | Gets all remote process groups
[**GetVariableRegistry**](ProcessGroupsApi.md#getvariableregistry) | **GET** /process-groups/{id}/variable-registry | Gets a process group&#39;s variable registry
[**GetVariableRegistryUpdateRequest**](ProcessGroupsApi.md#getvariableregistryupdaterequest) | **GET** /process-groups/{groupId}/variable-registry/update-requests/{updateId} | Gets a process group&#39;s variable registry
[**ImportTemplate**](ProcessGroupsApi.md#importtemplate) | **POST** /process-groups/{id}/templates/import | Imports a template
[**InstantiateTemplate**](ProcessGroupsApi.md#instantiatetemplate) | **POST** /process-groups/{id}/template-instance | Instantiates a template
[**RemoveProcessGroup**](ProcessGroupsApi.md#removeprocessgroup) | **DELETE** /process-groups/{id} | Deletes a process group
[**SubmitUpdateVariableRegistryRequest**](ProcessGroupsApi.md#submitupdatevariableregistryrequest) | **POST** /process-groups/{id}/variable-registry/update-requests | Submits a request to update a process group&#39;s variable registry
[**UpdateProcessGroup**](ProcessGroupsApi.md#updateprocessgroup) | **PUT** /process-groups/{id} | Updates a process group
[**UpdateVariableRegistry**](ProcessGroupsApi.md#updatevariableregistry) | **PUT** /process-groups/{id}/variable-registry | Updates the contents of a Process Group&#39;s variable Registry
[**UploadTemplate**](ProcessGroupsApi.md#uploadtemplate) | **POST** /process-groups/{id}/templates/upload | Uploads a template


<a name="copysnippet"></a>
# **CopySnippet**
> FlowEntity CopySnippet (string id, CopySnippetRequestEntity body)

Copies a snippet and discards it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CopySnippetExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new CopySnippetRequestEntity(); // CopySnippetRequestEntity | The copy snippet request.

            try
            {
                // Copies a snippet and discards it.
                FlowEntity result = apiInstance.CopySnippet(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CopySnippet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**CopySnippetRequestEntity**](CopySnippetRequestEntity.md)| The copy snippet request. | 

### Return type

[**FlowEntity**](FlowEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconnection"></a>
# **CreateConnection**
> ConnectionEntity CreateConnection (string id, ConnectionEntity body)

Creates a connection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateConnectionExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new ConnectionEntity(); // ConnectionEntity | The connection configuration details.

            try
            {
                // Creates a connection
                ConnectionEntity result = apiInstance.CreateConnection(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**ConnectionEntity**](ConnectionEntity.md)| The connection configuration details. | 

### Return type

[**ConnectionEntity**](ConnectionEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontrollerservice"></a>
# **CreateControllerService**
> ControllerServiceEntity CreateControllerService (string id, ControllerServiceEntity body)

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
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new ControllerServiceEntity(); // ControllerServiceEntity | The controller service configuration details.

            try
            {
                // Creates a new controller service
                ControllerServiceEntity result = apiInstance.CreateControllerService(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateControllerService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**ControllerServiceEntity**](ControllerServiceEntity.md)| The controller service configuration details. | 

### Return type

[**ControllerServiceEntity**](ControllerServiceEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfunnel"></a>
# **CreateFunnel**
> FunnelEntity CreateFunnel (string id, FunnelEntity body)

Creates a funnel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFunnelExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new FunnelEntity(); // FunnelEntity | The funnel configuration details.

            try
            {
                // Creates a funnel
                FunnelEntity result = apiInstance.CreateFunnel(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateFunnel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**FunnelEntity**](FunnelEntity.md)| The funnel configuration details. | 

### Return type

[**FunnelEntity**](FunnelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinputport"></a>
# **CreateInputPort**
> PortEntity CreateInputPort (string id, PortEntity body)

Creates an input port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateInputPortExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new PortEntity(); // PortEntity | The input port configuration details.

            try
            {
                // Creates an input port
                PortEntity result = apiInstance.CreateInputPort(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateInputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**PortEntity**](PortEntity.md)| The input port configuration details. | 

### Return type

[**PortEntity**](PortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlabel"></a>
# **CreateLabel**
> LabelEntity CreateLabel (string id, LabelEntity body)

Creates a label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLabelExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new LabelEntity(); // LabelEntity | The label configuration details.

            try
            {
                // Creates a label
                LabelEntity result = apiInstance.CreateLabel(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**LabelEntity**](LabelEntity.md)| The label configuration details. | 

### Return type

[**LabelEntity**](LabelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createoutputport"></a>
# **CreateOutputPort**
> PortEntity CreateOutputPort (string id, PortEntity body)

Creates an output port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOutputPortExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new PortEntity(); // PortEntity | The output port configuration.

            try
            {
                // Creates an output port
                PortEntity result = apiInstance.CreateOutputPort(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateOutputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**PortEntity**](PortEntity.md)| The output port configuration. | 

### Return type

[**PortEntity**](PortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprocessgroup"></a>
# **CreateProcessGroup**
> ProcessGroupEntity CreateProcessGroup (string id, ProcessGroupEntity body)

Creates a process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new ProcessGroupEntity(); // ProcessGroupEntity | The process group configuration details.

            try
            {
                // Creates a process group
                ProcessGroupEntity result = apiInstance.CreateProcessGroup(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateProcessGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**ProcessGroupEntity**](ProcessGroupEntity.md)| The process group configuration details. | 

### Return type

[**ProcessGroupEntity**](ProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprocessor"></a>
# **CreateProcessor**
> ProcessorEntity CreateProcessor (string id, ProcessorEntity body)

Creates a new processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProcessorExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new ProcessorEntity(); // ProcessorEntity | The processor configuration details.

            try
            {
                // Creates a new processor
                ProcessorEntity result = apiInstance.CreateProcessor(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateProcessor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**ProcessorEntity**](ProcessorEntity.md)| The processor configuration details. | 

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createremoteprocessgroup"></a>
# **CreateRemoteProcessGroup**
> RemoteProcessGroupEntity CreateRemoteProcessGroup (string id, RemoteProcessGroupEntity body)

Creates a new process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRemoteProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new RemoteProcessGroupEntity(); // RemoteProcessGroupEntity | The remote process group configuration details.

            try
            {
                // Creates a new process group
                RemoteProcessGroupEntity result = apiInstance.CreateRemoteProcessGroup(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateRemoteProcessGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**RemoteProcessGroupEntity**](RemoteProcessGroupEntity.md)| The remote process group configuration details. | 

### Return type

[**RemoteProcessGroupEntity**](RemoteProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplate"></a>
# **CreateTemplate**
> TemplateEntity CreateTemplate (string id, CreateTemplateRequestEntity body)

Creates a template and discards the specified snippet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new CreateTemplateRequestEntity(); // CreateTemplateRequestEntity | The create template request.

            try
            {
                // Creates a template and discards the specified snippet.
                TemplateEntity result = apiInstance.CreateTemplate(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.CreateTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**CreateTemplateRequestEntity**](CreateTemplateRequestEntity.md)| The create template request. | 

### Return type

[**TemplateEntity**](TemplateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevariableregistryupdaterequest"></a>
# **DeleteVariableRegistryUpdateRequest**
> VariableRegistryUpdateRequestEntity DeleteVariableRegistryUpdateRequest (string groupId, string updateId, bool? disconnectedNodeAcknowledged = null)

Deletes an update request for a process group's variable registry. If the request is not yet complete, it will automatically be cancelled.

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
    public class DeleteVariableRegistryUpdateRequestExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var groupId = groupId_example;  // string | The process group id.
            var updateId = updateId_example;  // string | The ID of the Variable Registry Update Request
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes an update request for a process group's variable registry. If the request is not yet complete, it will automatically be cancelled.
                VariableRegistryUpdateRequestEntity result = apiInstance.DeleteVariableRegistryUpdateRequest(groupId, updateId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.DeleteVariableRegistryUpdateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The process group id. | 
 **updateId** | **string**| The ID of the Variable Registry Update Request | 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**VariableRegistryUpdateRequestEntity**](VariableRegistryUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnections"></a>
# **GetConnections**
> ConnectionsEntity GetConnections (string id)

Gets all connections

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectionsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets all connections
                ConnectionsEntity result = apiInstance.GetConnections(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetConnections: " + e.Message );
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

[**ConnectionsEntity**](ConnectionsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfunnels"></a>
# **GetFunnels**
> FunnelsEntity GetFunnels (string id)

Gets all funnels

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFunnelsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets all funnels
                FunnelsEntity result = apiInstance.GetFunnels(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetFunnels: " + e.Message );
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

[**FunnelsEntity**](FunnelsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinputports"></a>
# **GetInputPorts**
> InputPortsEntity GetInputPorts (string id)

Gets all input ports

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInputPortsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets all input ports
                InputPortsEntity result = apiInstance.GetInputPorts(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetInputPorts: " + e.Message );
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

[**InputPortsEntity**](InputPortsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlabels"></a>
# **GetLabels**
> LabelsEntity GetLabels (string id)

Gets all labels

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLabelsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets all labels
                LabelsEntity result = apiInstance.GetLabels(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetLabels: " + e.Message );
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

[**LabelsEntity**](LabelsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalmodifications"></a>
# **GetLocalModifications**
> FlowComparisonEntity GetLocalModifications (string id)

Gets a list of local modifications to the Process Group since it was last synchronized with the Flow Registry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocalModificationsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets a list of local modifications to the Process Group since it was last synchronized with the Flow Registry
                FlowComparisonEntity result = apiInstance.GetLocalModifications(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetLocalModifications: " + e.Message );
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

[**FlowComparisonEntity**](FlowComparisonEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoutputports"></a>
# **GetOutputPorts**
> OutputPortsEntity GetOutputPorts (string id)

Gets all output ports

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOutputPortsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets all output ports
                OutputPortsEntity result = apiInstance.GetOutputPorts(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetOutputPorts: " + e.Message );
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

[**OutputPortsEntity**](OutputPortsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessgroup"></a>
# **GetProcessGroup**
> ProcessGroupEntity GetProcessGroup (string id)

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
    public class GetProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets a process group
                ProcessGroupEntity result = apiInstance.GetProcessGroup(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetProcessGroup: " + e.Message );
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

[**ProcessGroupEntity**](ProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessgroups"></a>
# **GetProcessGroups**
> ProcessGroupsEntity GetProcessGroups (string id)

Gets all process groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessGroupsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets all process groups
                ProcessGroupsEntity result = apiInstance.GetProcessGroups(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetProcessGroups: " + e.Message );
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

[**ProcessGroupsEntity**](ProcessGroupsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessors"></a>
# **GetProcessors**
> ProcessorsEntity GetProcessors (string id, bool? includeDescendantGroups = null)

Gets all processors

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessorsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var includeDescendantGroups = true;  // bool? | Whether or not to include processors from descendant process groups (optional)  (default to false)

            try
            {
                // Gets all processors
                ProcessorsEntity result = apiInstance.GetProcessors(id, includeDescendantGroups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetProcessors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **includeDescendantGroups** | **bool?**| Whether or not to include processors from descendant process groups | [optional] [default to false]

### Return type

[**ProcessorsEntity**](ProcessorsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremoteprocessgroups"></a>
# **GetRemoteProcessGroups**
> RemoteProcessGroupsEntity GetRemoteProcessGroups (string id)

Gets all remote process groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemoteProcessGroupsExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Gets all remote process groups
                RemoteProcessGroupsEntity result = apiInstance.GetRemoteProcessGroups(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetRemoteProcessGroups: " + e.Message );
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

[**RemoteProcessGroupsEntity**](RemoteProcessGroupsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvariableregistry"></a>
# **GetVariableRegistry**
> VariableRegistryEntity GetVariableRegistry (string id, bool? includeAncestorGroups = null)

Gets a process group's variable registry

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
    public class GetVariableRegistryExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var includeAncestorGroups = true;  // bool? | Whether or not to include ancestor groups (optional)  (default to true)

            try
            {
                // Gets a process group's variable registry
                VariableRegistryEntity result = apiInstance.GetVariableRegistry(id, includeAncestorGroups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetVariableRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **includeAncestorGroups** | **bool?**| Whether or not to include ancestor groups | [optional] [default to true]

### Return type

[**VariableRegistryEntity**](VariableRegistryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvariableregistryupdaterequest"></a>
# **GetVariableRegistryUpdateRequest**
> VariableRegistryUpdateRequestEntity GetVariableRegistryUpdateRequest (string groupId, string updateId)

Gets a process group's variable registry

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
    public class GetVariableRegistryUpdateRequestExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var groupId = groupId_example;  // string | The process group id.
            var updateId = updateId_example;  // string | The ID of the Variable Registry Update Request

            try
            {
                // Gets a process group's variable registry
                VariableRegistryUpdateRequestEntity result = apiInstance.GetVariableRegistryUpdateRequest(groupId, updateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.GetVariableRegistryUpdateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The process group id. | 
 **updateId** | **string**| The ID of the Variable Registry Update Request | 

### Return type

[**VariableRegistryUpdateRequestEntity**](VariableRegistryUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importtemplate"></a>
# **ImportTemplate**
> TemplateEntity ImportTemplate (string id)

Imports a template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.

            try
            {
                // Imports a template
                TemplateEntity result = apiInstance.ImportTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.ImportTemplate: " + e.Message );
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

[**TemplateEntity**](TemplateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="instantiatetemplate"></a>
# **InstantiateTemplate**
> FlowEntity InstantiateTemplate (string id, InstantiateTemplateRequestEntity body)

Instantiates a template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InstantiateTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new InstantiateTemplateRequestEntity(); // InstantiateTemplateRequestEntity | The instantiate template request.

            try
            {
                // Instantiates a template
                FlowEntity result = apiInstance.InstantiateTemplate(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.InstantiateTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**InstantiateTemplateRequestEntity**](InstantiateTemplateRequestEntity.md)| The instantiate template request. | 

### Return type

[**FlowEntity**](FlowEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeprocessgroup"></a>
# **RemoveProcessGroup**
> ProcessGroupEntity RemoveProcessGroup (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a process group
                ProcessGroupEntity result = apiInstance.RemoveProcessGroup(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.RemoveProcessGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**ProcessGroupEntity**](ProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitupdatevariableregistryrequest"></a>
# **SubmitUpdateVariableRegistryRequest**
> VariableRegistryUpdateRequestEntity SubmitUpdateVariableRegistryRequest (string id, VariableRegistryEntity body)

Submits a request to update a process group's variable registry

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
    public class SubmitUpdateVariableRegistryRequestExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new VariableRegistryEntity(); // VariableRegistryEntity | The variable registry configuration details.

            try
            {
                // Submits a request to update a process group's variable registry
                VariableRegistryUpdateRequestEntity result = apiInstance.SubmitUpdateVariableRegistryRequest(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.SubmitUpdateVariableRegistryRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**VariableRegistryEntity**](VariableRegistryEntity.md)| The variable registry configuration details. | 

### Return type

[**VariableRegistryUpdateRequestEntity**](VariableRegistryUpdateRequestEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocessgroup"></a>
# **UpdateProcessGroup**
> ProcessGroupEntity UpdateProcessGroup (string id, ProcessGroupEntity body)

Updates a process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new ProcessGroupEntity(); // ProcessGroupEntity | The process group configuration details.

            try
            {
                // Updates a process group
                ProcessGroupEntity result = apiInstance.UpdateProcessGroup(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.UpdateProcessGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**ProcessGroupEntity**](ProcessGroupEntity.md)| The process group configuration details. | 

### Return type

[**ProcessGroupEntity**](ProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevariableregistry"></a>
# **UpdateVariableRegistry**
> VariableRegistryEntity UpdateVariableRegistry (string id, VariableRegistryEntity body)

Updates the contents of a Process Group's variable Registry

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
    public class UpdateVariableRegistryExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var body = new VariableRegistryEntity(); // VariableRegistryEntity | The variable registry configuration details.

            try
            {
                // Updates the contents of a Process Group's variable Registry
                VariableRegistryEntity result = apiInstance.UpdateVariableRegistry(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.UpdateVariableRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **body** | [**VariableRegistryEntity**](VariableRegistryEntity.md)| The variable registry configuration details. | 

### Return type

[**VariableRegistryEntity**](VariableRegistryEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadtemplate"></a>
# **UploadTemplate**
> TemplateEntity UploadTemplate (string id, System.IO.Stream template, bool? body = null)

Uploads a template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProcessGroupsApi();
            var id = id_example;  // string | The process group id.
            var template = new System.IO.Stream(); // System.IO.Stream | The binary content of the template file being uploaded.
            var body = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional) 

            try
            {
                // Uploads a template
                TemplateEntity result = apiInstance.UploadTemplate(id, template, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessGroupsApi.UploadTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The process group id. | 
 **template** | **System.IO.Stream**| The binary content of the template file being uploaded. | 
 **body** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] 

### Return type

[**TemplateEntity**](TemplateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

