# Org.OpenAPITools.Api.PlansApi

All URIs are relative to *https://api.getlago.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePlan**](PlansApi.md#createplan) | **POST** /plans | Create a new plan
[**DestroyPlan**](PlansApi.md#destroyplan) | **DELETE** /plans/{code} | Delete a plan
[**FindAllPlans**](PlansApi.md#findallplans) | **GET** /plans | Find plans
[**FindPlan**](PlansApi.md#findplan) | **GET** /plans/{code} | Find plan by code
[**UpdatePlan**](PlansApi.md#updateplan) | **PUT** /plans/{code} | Update an existing plan



## CreatePlan

> Plan CreatePlan (PlanInput planInput)

Create a new plan

Create a new plan

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePlanExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlansApi(Configuration.Default);
            var planInput = new PlanInput(); // PlanInput | Plan payload

            try
            {
                // Create a new plan
                Plan result = apiInstance.CreatePlan(planInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlansApi.CreatePlan: " + e.Message );
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
 **planInput** | [**PlanInput**](PlanInput.md)| Plan payload | 

### Return type

[**Plan**](Plan.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request error |  -  |
| **401** | Unauthorized error |  -  |
| **404** | Not Found error |  -  |
| **422** | Unprocessable entity error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DestroyPlan

> Plan DestroyPlan (string code)

Delete a plan

Delete a plan

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DestroyPlanExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlansApi(Configuration.Default);
            var code = example_code;  // string | Code of the existing plan

            try
            {
                // Delete a plan
                Plan result = apiInstance.DestroyPlan(code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlansApi.DestroyPlan: " + e.Message );
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
 **code** | **string**| Code of the existing plan | 

### Return type

[**Plan**](Plan.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Unauthorized error |  -  |
| **404** | Not Found error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FindAllPlans

> PlansPaginated FindAllPlans (int? page = null, int? perPage = null)

Find plans

Find all plans in certain organisation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllPlansExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlansApi(Configuration.Default);
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 

            try
            {
                // Find plans
                PlansPaginated result = apiInstance.FindAllPlans(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlansApi.FindAllPlans: " + e.Message );
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
 **page** | **int?**| Number of page | [optional] 
 **perPage** | **int?**| Number of records per page | [optional] 

### Return type

[**PlansPaginated**](PlansPaginated.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Unauthorized error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FindPlan

> Plan FindPlan (string code)

Find plan by code

Return a single plan

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindPlanExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlansApi(Configuration.Default);
            var code = example_code;  // string | Code of the existing plan

            try
            {
                // Find plan by code
                Plan result = apiInstance.FindPlan(code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlansApi.FindPlan: " + e.Message );
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
 **code** | **string**| Code of the existing plan | 

### Return type

[**Plan**](Plan.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Unauthorized error |  -  |
| **404** | Not Found error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePlan

> Plan UpdatePlan (string code, PlanInput planInput)

Update an existing plan

Update an existing plan by code

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePlanExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlansApi(Configuration.Default);
            var code = example_code;  // string | Code of the existing plan
            var planInput = new PlanInput(); // PlanInput | Update an existing plan

            try
            {
                // Update an existing plan
                Plan result = apiInstance.UpdatePlan(code, planInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlansApi.UpdatePlan: " + e.Message );
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
 **code** | **string**| Code of the existing plan | 
 **planInput** | [**PlanInput**](PlanInput.md)| Update an existing plan | 

### Return type

[**Plan**](Plan.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request error |  -  |
| **401** | Unauthorized error |  -  |
| **404** | Not Found error |  -  |
| **422** | Unprocessable entity error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

