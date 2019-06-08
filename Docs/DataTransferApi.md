# IO.Swagger.Api.DataTransferApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommitInputPortTransaction**](DataTransferApi.md#commitinputporttransaction) | **DELETE** /data-transfer/input-ports/{portId}/transactions/{transactionId} | Commit or cancel the specified transaction
[**CommitOutputPortTransaction**](DataTransferApi.md#commitoutputporttransaction) | **DELETE** /data-transfer/output-ports/{portId}/transactions/{transactionId} | Commit or cancel the specified transaction
[**CreatePortTransaction**](DataTransferApi.md#createporttransaction) | **POST** /data-transfer/{portType}/{portId}/transactions | Create a transaction to the specified output port or input port
[**ExtendInputPortTransactionTTL**](DataTransferApi.md#extendinputporttransactionttl) | **PUT** /data-transfer/input-ports/{portId}/transactions/{transactionId} | Extend transaction TTL
[**ExtendOutputPortTransactionTTL**](DataTransferApi.md#extendoutputporttransactionttl) | **PUT** /data-transfer/output-ports/{portId}/transactions/{transactionId} | Extend transaction TTL
[**ReceiveFlowFiles**](DataTransferApi.md#receiveflowfiles) | **POST** /data-transfer/input-ports/{portId}/transactions/{transactionId}/flow-files | Transfer flow files to the input port
[**TransferFlowFiles**](DataTransferApi.md#transferflowfiles) | **GET** /data-transfer/output-ports/{portId}/transactions/{transactionId}/flow-files | Transfer flow files from the output port


<a name="commitinputporttransaction"></a>
# **CommitInputPortTransaction**
> TransactionResultEntity CommitInputPortTransaction (int? responseCode, string portId, string transactionId)

Commit or cancel the specified transaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommitInputPortTransactionExample
    {
        public void main()
        {
            var apiInstance = new DataTransferApi();
            var responseCode = 56;  // int? | The response code. Available values are BAD_CHECKSUM(19), CONFIRM_TRANSACTION(12) or CANCEL_TRANSACTION(15).
            var portId = portId_example;  // string | The input port id.
            var transactionId = transactionId_example;  // string | The transaction id.

            try
            {
                // Commit or cancel the specified transaction
                TransactionResultEntity result = apiInstance.CommitInputPortTransaction(responseCode, portId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTransferApi.CommitInputPortTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **responseCode** | **int?**| The response code. Available values are BAD_CHECKSUM(19), CONFIRM_TRANSACTION(12) or CANCEL_TRANSACTION(15). | 
 **portId** | **string**| The input port id. | 
 **transactionId** | **string**| The transaction id. | 

### Return type

[**TransactionResultEntity**](TransactionResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="commitoutputporttransaction"></a>
# **CommitOutputPortTransaction**
> TransactionResultEntity CommitOutputPortTransaction (int? responseCode, string checksum, string portId, string transactionId)

Commit or cancel the specified transaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommitOutputPortTransactionExample
    {
        public void main()
        {
            var apiInstance = new DataTransferApi();
            var responseCode = 56;  // int? | The response code. Available values are CONFIRM_TRANSACTION(12) or CANCEL_TRANSACTION(15).
            var checksum = checksum_example;  // string | A checksum calculated at client side using CRC32 to check flow file content integrity. It must match with the value calculated at server side.
            var portId = portId_example;  // string | The output port id.
            var transactionId = transactionId_example;  // string | The transaction id.

            try
            {
                // Commit or cancel the specified transaction
                TransactionResultEntity result = apiInstance.CommitOutputPortTransaction(responseCode, checksum, portId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTransferApi.CommitOutputPortTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **responseCode** | **int?**| The response code. Available values are CONFIRM_TRANSACTION(12) or CANCEL_TRANSACTION(15). | 
 **checksum** | **string**| A checksum calculated at client side using CRC32 to check flow file content integrity. It must match with the value calculated at server side. | 
 **portId** | **string**| The output port id. | 
 **transactionId** | **string**| The transaction id. | 

### Return type

[**TransactionResultEntity**](TransactionResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createporttransaction"></a>
# **CreatePortTransaction**
> TransactionResultEntity CreatePortTransaction (string portType, string portId)

Create a transaction to the specified output port or input port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePortTransactionExample
    {
        public void main()
        {
            var apiInstance = new DataTransferApi();
            var portType = portType_example;  // string | The port type.
            var portId = portId_example;  // string | 

            try
            {
                // Create a transaction to the specified output port or input port
                TransactionResultEntity result = apiInstance.CreatePortTransaction(portType, portId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTransferApi.CreatePortTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portType** | **string**| The port type. | 
 **portId** | **string**|  | 

### Return type

[**TransactionResultEntity**](TransactionResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extendinputporttransactionttl"></a>
# **ExtendInputPortTransactionTTL**
> TransactionResultEntity ExtendInputPortTransactionTTL (string portId, string transactionId)

Extend transaction TTL

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExtendInputPortTransactionTTLExample
    {
        public void main()
        {
            var apiInstance = new DataTransferApi();
            var portId = portId_example;  // string | 
            var transactionId = transactionId_example;  // string | 

            try
            {
                // Extend transaction TTL
                TransactionResultEntity result = apiInstance.ExtendInputPortTransactionTTL(portId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTransferApi.ExtendInputPortTransactionTTL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portId** | **string**|  | 
 **transactionId** | **string**|  | 

### Return type

[**TransactionResultEntity**](TransactionResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extendoutputporttransactionttl"></a>
# **ExtendOutputPortTransactionTTL**
> TransactionResultEntity ExtendOutputPortTransactionTTL (string portId, string transactionId)

Extend transaction TTL

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExtendOutputPortTransactionTTLExample
    {
        public void main()
        {
            var apiInstance = new DataTransferApi();
            var portId = portId_example;  // string | 
            var transactionId = transactionId_example;  // string | 

            try
            {
                // Extend transaction TTL
                TransactionResultEntity result = apiInstance.ExtendOutputPortTransactionTTL(portId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTransferApi.ExtendOutputPortTransactionTTL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portId** | **string**|  | 
 **transactionId** | **string**|  | 

### Return type

[**TransactionResultEntity**](TransactionResultEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="receiveflowfiles"></a>
# **ReceiveFlowFiles**
> string ReceiveFlowFiles (string portId, string transactionId)

Transfer flow files to the input port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReceiveFlowFilesExample
    {
        public void main()
        {
            var apiInstance = new DataTransferApi();
            var portId = portId_example;  // string | The input port id.
            var transactionId = transactionId_example;  // string | 

            try
            {
                // Transfer flow files to the input port
                string result = apiInstance.ReceiveFlowFiles(portId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTransferApi.ReceiveFlowFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portId** | **string**| The input port id. | 
 **transactionId** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferflowfiles"></a>
# **TransferFlowFiles**
> StreamingOutput TransferFlowFiles (string portId, string transactionId)

Transfer flow files from the output port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransferFlowFilesExample
    {
        public void main()
        {
            var apiInstance = new DataTransferApi();
            var portId = portId_example;  // string | The output port id.
            var transactionId = transactionId_example;  // string | 

            try
            {
                // Transfer flow files from the output port
                StreamingOutput result = apiInstance.TransferFlowFiles(portId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTransferApi.TransferFlowFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portId** | **string**| The output port id. | 
 **transactionId** | **string**|  | 

### Return type

[**StreamingOutput**](StreamingOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

