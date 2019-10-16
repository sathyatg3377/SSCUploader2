using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserSessionInfoControllerApi
    {
        /// <summary>
        /// Retrieve the current user&#39;s session info. (The &#39;username&#39; parameter is not yet supported) 
        /// </summary>
        /// <param name="username">username</param>
        /// <returns>ApiResultUserSessionInformation</returns>
        ApiResultUserSessionInformation PostUserSessionInfo (string username);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserSessionInfoControllerApi : IUserSessionInfoControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionInfoControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserSessionInfoControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionInfoControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserSessionInfoControllerApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Retrieve the current user&#39;s session info. (The &#39;username&#39; parameter is not yet supported) 
        /// </summary>
        /// <param name="username">username</param> 
        /// <returns>ApiResultUserSessionInformation</returns>            
        public ApiResultUserSessionInformation PostUserSessionInfo (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PostUserSessionInfo");
            
    
            var path = "/userSession/info";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(username); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserSessionInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserSessionInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultUserSessionInformation) ApiClient.Deserialize(response.Content, typeof(ApiResultUserSessionInformation), response.Headers);
        }
    
    }
}
