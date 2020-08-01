/* 
 * BITFLEX Public API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICognitiveApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>string</returns>
        string CognitiveSavefilePost (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CognitiveSavefilePostWithHttpInfo (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>string</returns>
        string CognitiveVerifyfacesPost (Object body = default(Object));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CognitiveVerifyfacesPostWithHttpInfo (Object body = default(Object));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICognitiveApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CognitiveSavefilePostAsync (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CognitiveSavefilePostAsyncWithHttpInfo (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CognitiveVerifyfacesPostAsync (Object body = default(Object));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CognitiveVerifyfacesPostAsyncWithHttpInfo (Object body = default(Object));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICognitiveApi : ICognitiveApiSync, ICognitiveApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CognitiveApi : ICognitiveApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CognitiveApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CognitiveApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CognitiveApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CognitiveApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CognitiveApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CognitiveApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CognitiveApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CognitiveApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>string</returns>
        public string CognitiveSavefilePost (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string))
        {
             Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = CognitiveSavefilePostWithHttpInfo(contentType, contentDisposition, length, name, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public Org.OpenAPITools.Client.ApiResponse< string > CognitiveSavefilePostWithHttpInfo (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string))
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (contentType != null)
            {
                localVarRequestOptions.FormParameters.Add("ContentType", Org.OpenAPITools.Client.ClientUtils.ParameterToString(contentType)); // form parameter
            }
            if (contentDisposition != null)
            {
                localVarRequestOptions.FormParameters.Add("ContentDisposition", Org.OpenAPITools.Client.ClientUtils.ParameterToString(contentDisposition)); // form parameter
            }
            if (length != null)
            {
                localVarRequestOptions.FormParameters.Add("Length", Org.OpenAPITools.Client.ClientUtils.ParameterToString(length)); // form parameter
            }
            if (name != null)
            {
                localVarRequestOptions.FormParameters.Add("Name", Org.OpenAPITools.Client.ClientUtils.ParameterToString(name)); // form parameter
            }
            if (fileName != null)
            {
                localVarRequestOptions.FormParameters.Add("FileName", Org.OpenAPITools.Client.ClientUtils.ParameterToString(fileName)); // form parameter
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< string >("/Cognitive/savefile", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CognitiveSavefilePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CognitiveSavefilePostAsync (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string))
        {
             Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = await CognitiveSavefilePostAsyncWithHttpInfo(contentType, contentDisposition, length, name, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"> (optional)</param>
        /// <param name="contentDisposition"> (optional)</param>
        /// <param name="length"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="fileName"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<string>> CognitiveSavefilePostAsyncWithHttpInfo (string contentType = default(string), string contentDisposition = default(string), long? length = default(long?), string name = default(string), string fileName = default(string))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (contentType != null)
            {
                localVarRequestOptions.FormParameters.Add("ContentType", Org.OpenAPITools.Client.ClientUtils.ParameterToString(contentType)); // form parameter
            }
            if (contentDisposition != null)
            {
                localVarRequestOptions.FormParameters.Add("ContentDisposition", Org.OpenAPITools.Client.ClientUtils.ParameterToString(contentDisposition)); // form parameter
            }
            if (length != null)
            {
                localVarRequestOptions.FormParameters.Add("Length", Org.OpenAPITools.Client.ClientUtils.ParameterToString(length)); // form parameter
            }
            if (name != null)
            {
                localVarRequestOptions.FormParameters.Add("Name", Org.OpenAPITools.Client.ClientUtils.ParameterToString(name)); // form parameter
            }
            if (fileName != null)
            {
                localVarRequestOptions.FormParameters.Add("FileName", Org.OpenAPITools.Client.ClientUtils.ParameterToString(fileName)); // form parameter
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<string>("/Cognitive/savefile", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CognitiveSavefilePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>string</returns>
        public string CognitiveVerifyfacesPost (Object body = default(Object))
        {
             Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = CognitiveVerifyfacesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public Org.OpenAPITools.Client.ApiResponse< string > CognitiveVerifyfacesPostWithHttpInfo (Object body = default(Object))
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< string >("/Cognitive/verifyfaces", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CognitiveVerifyfacesPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CognitiveVerifyfacesPostAsync (Object body = default(Object))
        {
             Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = await CognitiveVerifyfacesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<string>> CognitiveVerifyfacesPostAsyncWithHttpInfo (Object body = default(Object))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = body;

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<string>("/Cognitive/verifyfaces", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CognitiveVerifyfacesPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
