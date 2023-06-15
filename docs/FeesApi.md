# Org.OpenAPITools.Api.FeesApi

All URIs are relative to *https://api.getlago.com/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FindAllFees**](FeesApi.md#findallfees) | **GET** /fees | Find all fees |
| [**FindFee**](FeesApi.md#findfee) | **GET** /fees/{id} | Find fee by ID |
| [**UpdateFee**](FeesApi.md#updatefee) | **PUT** /fees/{id} | Update an existing fee |

<a id="findallfees"></a>
# **FindAllFees**
> FeesPaginated FindAllFees (int? page = null, int? perPage = null, string externalCustomerId = null, string externalSubscriptionId = null, string currency = null, string feeType = null, string billableMetricCode = null, string paymentStatus = null, DateTime? createdAtFrom = null, DateTime? createdAtTo = null, DateTime? succeededAtFrom = null, DateTime? succeededAtTo = null, DateTime? failedAtFrom = null, DateTime? failedAtTo = null, DateTime? refundedAtFrom = null, DateTime? refundedAtTo = null)

Find all fees

Find all fees of an organization and filter them

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllFeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FeesApi(config);
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 
            var externalCustomerId = 12345;  // string | External customer ID (optional) 
            var externalSubscriptionId = 12345;  // string | External subscription ID (optional) 
            var currency = EUR;  // string | Amount currency (optional) 
            var feeType = charge;  // string | Fee type (optional) 
            var billableMetricCode = bm_code;  // string | Code of the source billable metric (optional) 
            var paymentStatus = succeeded;  // string | Payment status (optional) 
            var createdAtFrom = 2023-03-28T12:21:51Z;  // DateTime? | Creation datetime from (optional) 
            var createdAtTo = 2023-03-28T12:21:51Z;  // DateTime? | Creation date to (optional) 
            var succeededAtFrom = 2023-03-28T12:21:51Z;  // DateTime? | Payment succees date from (optional) 
            var succeededAtTo = 2023-03-28T12:21:51Z;  // DateTime? | Payment succees date to (optional) 
            var failedAtFrom = 2023-03-28T12:21:51Z;  // DateTime? | Payment failed date from (optional) 
            var failedAtTo = 2023-03-28T12:21:51Z;  // DateTime? | Payment failed date to (optional) 
            var refundedAtFrom = 2023-03-28T12:21:51Z;  // DateTime? | Payment refund date from (optional) 
            var refundedAtTo = 2023-03-28T12:21:51Z;  // DateTime? | Payment refund date to (optional) 

            try
            {
                // Find all fees
                FeesPaginated result = apiInstance.FindAllFees(page, perPage, externalCustomerId, externalSubscriptionId, currency, feeType, billableMetricCode, paymentStatus, createdAtFrom, createdAtTo, succeededAtFrom, succeededAtTo, failedAtFrom, failedAtTo, refundedAtFrom, refundedAtTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeesApi.FindAllFees: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllFeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find all fees
    ApiResponse<FeesPaginated> response = apiInstance.FindAllFeesWithHttpInfo(page, perPage, externalCustomerId, externalSubscriptionId, currency, feeType, billableMetricCode, paymentStatus, createdAtFrom, createdAtTo, succeededAtFrom, succeededAtTo, failedAtFrom, failedAtTo, refundedAtFrom, refundedAtTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeesApi.FindAllFeesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Number of page | [optional]  |
| **perPage** | **int?** | Number of records per page | [optional]  |
| **externalCustomerId** | **string** | External customer ID | [optional]  |
| **externalSubscriptionId** | **string** | External subscription ID | [optional]  |
| **currency** | **string** | Amount currency | [optional]  |
| **feeType** | **string** | Fee type | [optional]  |
| **billableMetricCode** | **string** | Code of the source billable metric | [optional]  |
| **paymentStatus** | **string** | Payment status | [optional]  |
| **createdAtFrom** | **DateTime?** | Creation datetime from | [optional]  |
| **createdAtTo** | **DateTime?** | Creation date to | [optional]  |
| **succeededAtFrom** | **DateTime?** | Payment succees date from | [optional]  |
| **succeededAtTo** | **DateTime?** | Payment succees date to | [optional]  |
| **failedAtFrom** | **DateTime?** | Payment failed date from | [optional]  |
| **failedAtTo** | **DateTime?** | Payment failed date to | [optional]  |
| **refundedAtFrom** | **DateTime?** | Payment refund date from | [optional]  |
| **refundedAtTo** | **DateTime?** | Payment refund date to | [optional]  |

### Return type

[**FeesPaginated**](FeesPaginated.md)

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
| **422** | Unprocessable entity error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findfee"></a>
# **FindFee**
> FeeObject FindFee (Guid id)

Find fee by ID

Return a single fee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FeesApi(config);
            var id = 1a901a90-1a90-1a90-1a90-1a901a901a90;  // Guid | ID of the existing Lago Fee

            try
            {
                // Find fee by ID
                FeeObject result = apiInstance.FindFee(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeesApi.FindFee: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find fee by ID
    ApiResponse<FeeObject> response = apiInstance.FindFeeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeesApi.FindFeeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of the existing Lago Fee |  |

### Return type

[**FeeObject**](FeeObject.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefee"></a>
# **UpdateFee**
> FeeObject UpdateFee (Guid id, FeeUpdateInput feeUpdateInput = null)

Update an existing fee

Update an existing fee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FeesApi(config);
            var id = 1a901a90-1a90-1a90-1a90-1a901a901a90;  // Guid | ID of the existing Lago Fee
            var feeUpdateInput = new FeeUpdateInput(); // FeeUpdateInput | Payload to update a fee (optional) 

            try
            {
                // Update an existing fee
                FeeObject result = apiInstance.UpdateFee(id, feeUpdateInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeesApi.UpdateFee: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing fee
    ApiResponse<FeeObject> response = apiInstance.UpdateFeeWithHttpInfo(id, feeUpdateInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeesApi.UpdateFeeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of the existing Lago Fee |  |
| **feeUpdateInput** | [**FeeUpdateInput**](FeeUpdateInput.md) | Payload to update a fee | [optional]  |

### Return type

[**FeeObject**](FeeObject.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

