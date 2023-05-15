/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.32.0-beta
 * Contact: tech@getlago.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Update an existing Organization
        /// </summary>
        /// <remarks>
        /// Update an existing organization
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <returns>Organization</returns>
        Organization UpdateOrganization (OrganizationInput organizationInput);

        /// <summary>
        /// Update an existing Organization
        /// </summary>
        /// <remarks>
        /// Update an existing organization
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> UpdateOrganizationWithHttpInfo (OrganizationInput organizationInput);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Update an existing Organization
        /// </summary>
        /// <remarks>
        /// Update an existing organization
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> UpdateOrganizationAsync (OrganizationInput organizationInput, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update an existing Organization
        /// </summary>
        /// <remarks>
        /// Update an existing organization
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> UpdateOrganizationWithHttpInfoAsync (OrganizationInput organizationInput, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrganizationsApi : IOrganizationsApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganizationsApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsApi"/> class
        /// </summary>
        /// <returns></returns>
        public OrganizationsApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrganizationsApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
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
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

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
        /// Update an existing Organization Update an existing organization
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <returns>Organization</returns>
        public Organization UpdateOrganization (OrganizationInput organizationInput)
        {
             ApiResponse<Organization> localVarResponse = UpdateOrganizationWithHttpInfo(organizationInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing Organization Update an existing organization
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse<Organization> UpdateOrganizationWithHttpInfo (OrganizationInput organizationInput)
        {
            // verify the required parameter 'organizationInput' is set
            if (organizationInput == null)
                throw new ApiException(400, "Missing required parameter 'organizationInput' when calling OrganizationsApi->UpdateOrganization");

            var localVarPath = "/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationInput != null && organizationInput.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(organizationInput); // http body (model) parameter
            }
            else
            {
                localVarPostBody = organizationInput; // byte array
            }

            // authentication (bearerAuth) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateOrganization", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Organization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
        }

        /// <summary>
        /// Update an existing Organization Update an existing organization
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> UpdateOrganizationAsync (OrganizationInput organizationInput, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Organization> localVarResponse = await UpdateOrganizationWithHttpInfoAsync(organizationInput, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an existing Organization Update an existing organization
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationInput">Update an existing organization</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> UpdateOrganizationWithHttpInfoAsync (OrganizationInput organizationInput, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'organizationInput' is set
            if (organizationInput == null)
                throw new ApiException(400, "Missing required parameter 'organizationInput' when calling OrganizationsApi->UpdateOrganization");

            var localVarPath = "/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationInput != null && organizationInput.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(organizationInput); // http body (model) parameter
            }
            else
            {
                localVarPostBody = organizationInput; // byte array
            }

            // authentication (bearerAuth) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateOrganization", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Organization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
        }

    }
}
