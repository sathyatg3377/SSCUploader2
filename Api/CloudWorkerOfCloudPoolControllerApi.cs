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
    public interface ICloudWorkerOfCloudPoolControllerApi
    {
        /// <summary>
        /// Assign workers to the cloud pool 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultCloudPoolWorkerActionResponse</returns>
        ApiResultCloudPoolWorkerActionResponse AssignCloudWorkerOfCloudPool (string parentId, CloudPoolWorkerAssignRequest resource);
        /// <summary>
        /// Disable workers in the cloud pool 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultCloudPoolWorkerActionResponse</returns>
        ApiResultCloudPoolWorkerActionResponse DisableCloudWorkerOfCloudPool (string parentId, CloudPoolWorkerDisableRequest resource);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListCloudWorker</returns>
        ApiResultListCloudWorker ListCloudWorkerOfCloudPool (string parentId, string fields, int? start, int? limit, string orderby);
        /// <summary>
        /// Replace workers in the cloud pool 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultCloudPoolWorkerActionResponse</returns>
        ApiResultCloudPoolWorkerActionResponse ReplaceCloudWorkerOfCloudPool (string parentId, CloudPoolWorkerReplaceRequest resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CloudWorkerOfCloudPoolControllerApi : ICloudWorkerOfCloudPoolControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudWorkerOfCloudPoolControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CloudWorkerOfCloudPoolControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudWorkerOfCloudPoolControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CloudWorkerOfCloudPoolControllerApi(String basePath)
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
        /// Assign workers to the cloud pool 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultCloudPoolWorkerActionResponse</returns>            
        public ApiResultCloudPoolWorkerActionResponse AssignCloudWorkerOfCloudPool (string parentId, CloudPoolWorkerAssignRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling AssignCloudWorkerOfCloudPool");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling AssignCloudWorkerOfCloudPool");
            
    
            var path = "/cloudpools/{parentId}/workers/action/assign";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssignCloudWorkerOfCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssignCloudWorkerOfCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPoolWorkerActionResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPoolWorkerActionResponse), response.Headers);
        }
    
        /// <summary>
        /// Disable workers in the cloud pool 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultCloudPoolWorkerActionResponse</returns>            
        public ApiResultCloudPoolWorkerActionResponse DisableCloudWorkerOfCloudPool (string parentId, CloudPoolWorkerDisableRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling DisableCloudWorkerOfCloudPool");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling DisableCloudWorkerOfCloudPool");
            
    
            var path = "/cloudpools/{parentId}/workers/action/disable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DisableCloudWorkerOfCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DisableCloudWorkerOfCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPoolWorkerActionResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPoolWorkerActionResponse), response.Headers);
        }
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <returns>ApiResultListCloudWorker</returns>            
        public ApiResultListCloudWorker ListCloudWorkerOfCloudPool (string parentId, string fields, int? start, int? limit, string orderby)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListCloudWorkerOfCloudPool");
            
    
            var path = "/cloudpools/{parentId}/workers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCloudWorkerOfCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCloudWorkerOfCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListCloudWorker) ApiClient.Deserialize(response.Content, typeof(ApiResultListCloudWorker), response.Headers);
        }
    
        /// <summary>
        /// Replace workers in the cloud pool 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultCloudPoolWorkerActionResponse</returns>            
        public ApiResultCloudPoolWorkerActionResponse ReplaceCloudWorkerOfCloudPool (string parentId, CloudPoolWorkerReplaceRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ReplaceCloudWorkerOfCloudPool");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling ReplaceCloudWorkerOfCloudPool");
            
    
            var path = "/cloudpools/{parentId}/workers/action/replace";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceCloudWorkerOfCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceCloudWorkerOfCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPoolWorkerActionResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPoolWorkerActionResponse), response.Headers);
        }
    
    }
}
