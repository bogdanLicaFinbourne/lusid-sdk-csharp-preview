# Lusid.Sdk.Api.RelationshipsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRelationship**](RelationshipsApi.md#createrelationship) | **POST** /api/relationshipdefinitions/{scope}/{code}/relationships | [EXPERIMENTAL] Create Relationship
[**DeleteRelationship**](RelationshipsApi.md#deleterelationship) | **POST** /api/relationshipdefinitions/{scope}/{code}/relationships/$delete | [EXPERIMENTAL] Delete Relationship


<a name="createrelationship"></a>
# **CreateRelationship**
> CompleteRelationship CreateRelationship (string scope, string code, CreateRelationshipRequest createRelationshipRequest, DateTimeOrCutLabel effectiveAt = null)

[EXPERIMENTAL] Create Relationship

Create a relationship between two entity objects by their identifiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipsApi(config);
            var scope = scope_example;  // string | The scope of the relationship
            var code = code_example;  // string | The code of the relationship
            var createRelationshipRequest = new CreateRelationshipRequest(); // CreateRelationshipRequest | The details of the relationship to create.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the relationship should be effective from. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] Create Relationship
                CompleteRelationship result = apiInstance.CreateRelationship(scope, code, createRelationshipRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.CreateRelationship: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the relationship | 
 **code** | **string**| The code of the relationship | 
 **createRelationshipRequest** | [**CreateRelationshipRequest**](CreateRelationshipRequest.md)| The details of the relationship to create. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the relationship should be effective from. Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**CompleteRelationship**](CompleteRelationship.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly created relationship. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterelationship"></a>
# **DeleteRelationship**
> DeletedEntityResponse DeleteRelationship (string scope, string code, DeleteRelationshipRequest deleteRelationshipRequest, DateTimeOrCutLabel effectiveAt = null)

[EXPERIMENTAL] Delete Relationship

Delete a relationship between two entity objects represented by their identifiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipsApi(config);
            var scope = scope_example;  // string | The scope of the relationship
            var code = code_example;  // string | The code of the relationship
            var deleteRelationshipRequest = new DeleteRelationshipRequest(); // DeleteRelationshipRequest | The details of the relationship to delete.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the relationship should the deletion be effective from. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] Delete Relationship
                DeletedEntityResponse result = apiInstance.DeleteRelationship(scope, code, deleteRelationshipRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.DeleteRelationship: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the relationship | 
 **code** | **string**| The code of the relationship | 
 **deleteRelationshipRequest** | [**DeleteRelationshipRequest**](DeleteRelationshipRequest.md)| The details of the relationship to delete. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the relationship should the deletion be effective from. Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the relationship is deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

