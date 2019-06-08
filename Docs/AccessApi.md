# IO.Swagger.Api.AccessApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccessToken**](AccessApi.md#createaccesstoken) | **POST** /access/token | Creates a token for accessing the REST API via username/password
[**CreateAccessTokenFromTicket**](AccessApi.md#createaccesstokenfromticket) | **POST** /access/kerberos | Creates a token for accessing the REST API via Kerberos ticket exchange / SPNEGO negotiation
[**CreateDownloadToken**](AccessApi.md#createdownloadtoken) | **POST** /access/download-token | Creates a single use access token for downloading FlowFile content.
[**CreateUiExtensionToken**](AccessApi.md#createuiextensiontoken) | **POST** /access/ui-extension-token | Creates a single use access token for accessing a NiFi UI extension.
[**GetAccessStatus**](AccessApi.md#getaccessstatus) | **GET** /access | Gets the status the client&#39;s access
[**GetLoginConfig**](AccessApi.md#getloginconfig) | **GET** /access/config | Retrieves the access configuration for this NiFi
[**KnoxCallback**](AccessApi.md#knoxcallback) | **GET** /access/knox/callback | Redirect/callback URI for processing the result of the Apache Knox login sequence.
[**KnoxLogout**](AccessApi.md#knoxlogout) | **GET** /access/knox/logout | Performs a logout in the Apache Knox.
[**KnoxRequest**](AccessApi.md#knoxrequest) | **GET** /access/knox/request | Initiates a request to authenticate through Apache Knox.
[**OidcCallback**](AccessApi.md#oidccallback) | **GET** /access/oidc/callback | Redirect/callback URI for processing the result of the OpenId Connect login sequence.
[**OidcExchange**](AccessApi.md#oidcexchange) | **POST** /access/oidc/exchange | Retrieves a JWT following a successful login sequence using the configured OpenId Connect provider.
[**OidcLogout**](AccessApi.md#oidclogout) | **GET** /access/oidc/logout | Performs a logout in the OpenId Provider.
[**OidcRequest**](AccessApi.md#oidcrequest) | **GET** /access/oidc/request | Initiates a request to authenticate through the configured OpenId Connect provider.


<a name="createaccesstoken"></a>
# **CreateAccessToken**
> string CreateAccessToken (string username = null, string password = null)

Creates a token for accessing the REST API via username/password

The token returned is formatted as a JSON Web Token (JWT). The token is base64 encoded and comprised of three parts. The header, the body, and the signature. The expiration of the token is a contained within the body. The token can be used in the Authorization header in the format 'Authorization: Bearer <token>'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccessTokenExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();
            var username = username_example;  // string |  (optional) 
            var password = password_example;  // string |  (optional) 

            try
            {
                // Creates a token for accessing the REST API via username/password
                string result = apiInstance.CreateAccessToken(username, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.CreateAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | [optional] 
 **password** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaccesstokenfromticket"></a>
# **CreateAccessTokenFromTicket**
> string CreateAccessTokenFromTicket ()

Creates a token for accessing the REST API via Kerberos ticket exchange / SPNEGO negotiation

The token returned is formatted as a JSON Web Token (JWT). The token is base64 encoded and comprised of three parts. The header, the body, and the signature. The expiration of the token is a contained within the body. The token can be used in the Authorization header in the format 'Authorization: Bearer <token>'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccessTokenFromTicketExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Creates a token for accessing the REST API via Kerberos ticket exchange / SPNEGO negotiation
                string result = apiInstance.CreateAccessTokenFromTicket();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.CreateAccessTokenFromTicket: " + e.Message );
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

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdownloadtoken"></a>
# **CreateDownloadToken**
> string CreateDownloadToken ()

Creates a single use access token for downloading FlowFile content.

The token returned is a base64 encoded string. It is valid for a single request up to five minutes from being issued. It is used as a query parameter name 'access_token'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDownloadTokenExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Creates a single use access token for downloading FlowFile content.
                string result = apiInstance.CreateDownloadToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.CreateDownloadToken: " + e.Message );
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

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuiextensiontoken"></a>
# **CreateUiExtensionToken**
> string CreateUiExtensionToken ()

Creates a single use access token for accessing a NiFi UI extension.

The token returned is a base64 encoded string. It is valid for a single request up to five minutes from being issued. It is used as a query parameter name 'access_token'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUiExtensionTokenExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Creates a single use access token for accessing a NiFi UI extension.
                string result = apiInstance.CreateUiExtensionToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.CreateUiExtensionToken: " + e.Message );
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

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccessstatus"></a>
# **GetAccessStatus**
> AccessStatusEntity GetAccessStatus ()

Gets the status the client's access

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
    public class GetAccessStatusExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Gets the status the client's access
                AccessStatusEntity result = apiInstance.GetAccessStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.GetAccessStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccessStatusEntity**](AccessStatusEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloginconfig"></a>
# **GetLoginConfig**
> AccessConfigurationEntity GetLoginConfig ()

Retrieves the access configuration for this NiFi

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoginConfigExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Retrieves the access configuration for this NiFi
                AccessConfigurationEntity result = apiInstance.GetLoginConfig();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.GetLoginConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccessConfigurationEntity**](AccessConfigurationEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="knoxcallback"></a>
# **KnoxCallback**
> void KnoxCallback ()

Redirect/callback URI for processing the result of the Apache Knox login sequence.

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
    public class KnoxCallbackExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Redirect/callback URI for processing the result of the Apache Knox login sequence.
                apiInstance.KnoxCallback();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.KnoxCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="knoxlogout"></a>
# **KnoxLogout**
> void KnoxLogout ()

Performs a logout in the Apache Knox.

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
    public class KnoxLogoutExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Performs a logout in the Apache Knox.
                apiInstance.KnoxLogout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.KnoxLogout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="knoxrequest"></a>
# **KnoxRequest**
> void KnoxRequest ()

Initiates a request to authenticate through Apache Knox.

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
    public class KnoxRequestExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Initiates a request to authenticate through Apache Knox.
                apiInstance.KnoxRequest();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.KnoxRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidccallback"></a>
# **OidcCallback**
> void OidcCallback ()

Redirect/callback URI for processing the result of the OpenId Connect login sequence.

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
    public class OidcCallbackExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Redirect/callback URI for processing the result of the OpenId Connect login sequence.
                apiInstance.OidcCallback();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.OidcCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcexchange"></a>
# **OidcExchange**
> string OidcExchange ()

Retrieves a JWT following a successful login sequence using the configured OpenId Connect provider.

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
    public class OidcExchangeExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Retrieves a JWT following a successful login sequence using the configured OpenId Connect provider.
                string result = apiInstance.OidcExchange();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.OidcExchange: " + e.Message );
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

<a name="oidclogout"></a>
# **OidcLogout**
> void OidcLogout ()

Performs a logout in the OpenId Provider.

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
    public class OidcLogoutExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Performs a logout in the OpenId Provider.
                apiInstance.OidcLogout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.OidcLogout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcrequest"></a>
# **OidcRequest**
> void OidcRequest ()

Initiates a request to authenticate through the configured OpenId Connect provider.

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
    public class OidcRequestExample
    {
        public void main()
        {
            var apiInstance = new AccessApi();

            try
            {
                // Initiates a request to authenticate through the configured OpenId Connect provider.
                apiInstance.OidcRequest();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.OidcRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

