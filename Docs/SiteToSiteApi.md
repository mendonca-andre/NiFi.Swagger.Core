# IO.Swagger.Api.SiteToSiteApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPeers**](SiteToSiteApi.md#getpeers) | **GET** /site-to-site/peers | Returns the available Peers and its status of this NiFi
[**GetSiteToSiteDetails**](SiteToSiteApi.md#getsitetositedetails) | **GET** /site-to-site | Returns the details about this NiFi necessary to communicate via site to site


<a name="getpeers"></a>
# **GetPeers**
> PeersEntity GetPeers ()

Returns the available Peers and its status of this NiFi

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPeersExample
    {
        public void main()
        {
            var apiInstance = new SiteToSiteApi();

            try
            {
                // Returns the available Peers and its status of this NiFi
                PeersEntity result = apiInstance.GetPeers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SiteToSiteApi.GetPeers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PeersEntity**](PeersEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitetositedetails"></a>
# **GetSiteToSiteDetails**
> ControllerEntity GetSiteToSiteDetails ()

Returns the details about this NiFi necessary to communicate via site to site

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSiteToSiteDetailsExample
    {
        public void main()
        {
            var apiInstance = new SiteToSiteApi();

            try
            {
                // Returns the details about this NiFi necessary to communicate via site to site
                ControllerEntity result = apiInstance.GetSiteToSiteDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SiteToSiteApi.GetSiteToSiteDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ControllerEntity**](ControllerEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

