/* 
 * NiFi Rest Api
 *
 * The Rest Api provides programmatic access to command and control a NiFi instance in real time. Start and                                              stop processors, monitor queues, query provenance data, and more. Each endpoint below includes a description,                                             definitions of the expected input and output, potential response codes, and the authorizations required                                             to invoke each service.
 *
 * OpenAPI spec version: 1.9.1
 * Contact: dev@nifi.apache.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace NiFi.Swagger.Core.Api
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using NiFi.Swagger.Core.Client;
    using NiFi.Swagger.Core.Model;

    using RestSharp;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISiteToSiteApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the available Peers and its status of this NiFi
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>PeersEntity</returns>
        PeersEntity GetPeers ();

        /// <summary>
        /// Returns the available Peers and its status of this NiFi
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PeersEntity</returns>
        ApiResponse<PeersEntity> GetPeersWithHttpInfo ();
        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ControllerEntity</returns>
        ControllerEntity GetSiteToSiteDetails ();

        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ControllerEntity</returns>
        ApiResponse<ControllerEntity> GetSiteToSiteDetailsWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the available Peers and its status of this NiFi
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeersEntity</returns>
        System.Threading.Tasks.Task<PeersEntity> GetPeersAsync ();

        /// <summary>
        /// Returns the available Peers and its status of this NiFi
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeersEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<PeersEntity>> GetPeersAsyncWithHttpInfo ();
        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ControllerEntity</returns>
        System.Threading.Tasks.Task<ControllerEntity> GetSiteToSiteDetailsAsync ();

        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ControllerEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControllerEntity>> GetSiteToSiteDetailsAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SiteToSiteApi : ISiteToSiteApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteToSiteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SiteToSiteApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteToSiteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SiteToSiteApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (this._exceptionFactory != null && this._exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return this._exceptionFactory;
            }
            set { this._exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns the available Peers and its status of this NiFi 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>PeersEntity</returns>
        public PeersEntity GetPeers ()
        {
             ApiResponse<PeersEntity> localVarResponse = this.GetPeersWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the available Peers and its status of this NiFi 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PeersEntity</returns>
        public ApiResponse< PeersEntity > GetPeersWithHttpInfo ()
        {

            var localVarPath = "/site-to-site/peers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetPeers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PeersEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PeersEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PeersEntity)));
        }

        /// <summary>
        /// Returns the available Peers and its status of this NiFi 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeersEntity</returns>
        public async System.Threading.Tasks.Task<PeersEntity> GetPeersAsync ()
        {
             ApiResponse<PeersEntity> localVarResponse = await this.GetPeersAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the available Peers and its status of this NiFi 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeersEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PeersEntity>> GetPeersAsyncWithHttpInfo ()
        {

            var localVarPath = "/site-to-site/peers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetPeers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PeersEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PeersEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PeersEntity)));
        }

        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ControllerEntity</returns>
        public ControllerEntity GetSiteToSiteDetails ()
        {
             ApiResponse<ControllerEntity> localVarResponse = this.GetSiteToSiteDetailsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ControllerEntity</returns>
        public ApiResponse< ControllerEntity > GetSiteToSiteDetailsWithHttpInfo ()
        {

            var localVarPath = "/site-to-site";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetSiteToSiteDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ControllerEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControllerEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControllerEntity)));
        }

        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ControllerEntity</returns>
        public async System.Threading.Tasks.Task<ControllerEntity> GetSiteToSiteDetailsAsync ()
        {
             ApiResponse<ControllerEntity> localVarResponse = await this.GetSiteToSiteDetailsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the details about this NiFi necessary to communicate via site to site 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ControllerEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControllerEntity>> GetSiteToSiteDetailsAsyncWithHttpInfo ()
        {

            var localVarPath = "/site-to-site";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetSiteToSiteDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ControllerEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControllerEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControllerEntity)));
        }

    }
}
