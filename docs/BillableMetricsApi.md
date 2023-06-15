# Org.OpenAPITools.Api.BillableMetricsApi

All URIs are relative to *https://api.getlago.com/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBillableMetric**](BillableMetricsApi.md#createbillablemetric) | **POST** /billable_metrics | Create a new billable metric |
| [**DestroyBillableMetric**](BillableMetricsApi.md#destroybillablemetric) | **DELETE** /billable_metrics/{code} | Delete a billable metric |
| [**FindAllBillableMetricGroups**](BillableMetricsApi.md#findallbillablemetricgroups) | **GET** /billable_metrics/{code}/groups | Find Billable metric groups |
| [**FindAllBillableMetrics**](BillableMetricsApi.md#findallbillablemetrics) | **GET** /billable_metrics | Find Billable metrics |
| [**FindBillableMetric**](BillableMetricsApi.md#findbillablemetric) | **GET** /billable_metrics/{code} | Find billable metric by code |
| [**UpdateBillableMetric**](BillableMetricsApi.md#updatebillablemetric) | **PUT** /billable_metrics/{code} | Update an existing billable metric |

<a id="createbillablemetric"></a>
# **CreateBillableMetric**
> BillableMetric CreateBillableMetric (BillableMetricInput billableMetricInput)

Create a new billable metric

Create a new billable metric

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBillableMetricExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillableMetricsApi(config);
            var billableMetricInput = new BillableMetricInput(); // BillableMetricInput | Billable metric payload

            try
            {
                // Create a new billable metric
                BillableMetric result = apiInstance.CreateBillableMetric(billableMetricInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillableMetricsApi.CreateBillableMetric: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBillableMetricWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new billable metric
    ApiResponse<BillableMetric> response = apiInstance.CreateBillableMetricWithHttpInfo(billableMetricInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BillableMetricsApi.CreateBillableMetricWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **billableMetricInput** | [**BillableMetricInput**](BillableMetricInput.md) | Billable metric payload |  |

### Return type

[**BillableMetric**](BillableMetric.md)

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
| **422** | Unprocessable entity error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destroybillablemetric"></a>
# **DestroyBillableMetric**
> BillableMetric DestroyBillableMetric (string code)

Delete a billable metric

Delete a billable metric

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DestroyBillableMetricExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillableMetricsApi(config);
            var code = example_code;  // string | Code of the existing billable metric

            try
            {
                // Delete a billable metric
                BillableMetric result = apiInstance.DestroyBillableMetric(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillableMetricsApi.DestroyBillableMetric: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DestroyBillableMetricWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a billable metric
    ApiResponse<BillableMetric> response = apiInstance.DestroyBillableMetricWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BillableMetricsApi.DestroyBillableMetricWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the existing billable metric |  |

### Return type

[**BillableMetric**](BillableMetric.md)

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

<a id="findallbillablemetricgroups"></a>
# **FindAllBillableMetricGroups**
> GroupsPaginated FindAllBillableMetricGroups (string code, int? page = null, int? perPage = null)

Find Billable metric groups

Find all billable metric groups in certain organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllBillableMetricGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillableMetricsApi(config);
            var code = example_code;  // string | Code of the existing billable metric
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 

            try
            {
                // Find Billable metric groups
                GroupsPaginated result = apiInstance.FindAllBillableMetricGroups(code, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillableMetricsApi.FindAllBillableMetricGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllBillableMetricGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find Billable metric groups
    ApiResponse<GroupsPaginated> response = apiInstance.FindAllBillableMetricGroupsWithHttpInfo(code, page, perPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BillableMetricsApi.FindAllBillableMetricGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the existing billable metric |  |
| **page** | **int?** | Number of page | [optional]  |
| **perPage** | **int?** | Number of records per page | [optional]  |

### Return type

[**GroupsPaginated**](GroupsPaginated.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findallbillablemetrics"></a>
# **FindAllBillableMetrics**
> BillableMetricsPaginated FindAllBillableMetrics (int? page = null, int? perPage = null)

Find Billable metrics

Find all billable metrics in certain organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllBillableMetricsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillableMetricsApi(config);
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 

            try
            {
                // Find Billable metrics
                BillableMetricsPaginated result = apiInstance.FindAllBillableMetrics(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillableMetricsApi.FindAllBillableMetrics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllBillableMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find Billable metrics
    ApiResponse<BillableMetricsPaginated> response = apiInstance.FindAllBillableMetricsWithHttpInfo(page, perPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BillableMetricsApi.FindAllBillableMetricsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Number of page | [optional]  |
| **perPage** | **int?** | Number of records per page | [optional]  |

### Return type

[**BillableMetricsPaginated**](BillableMetricsPaginated.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findbillablemetric"></a>
# **FindBillableMetric**
> BillableMetric FindBillableMetric (string code)

Find billable metric by code

Return a single billable metric

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindBillableMetricExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillableMetricsApi(config);
            var code = example_code;  // string | Code of the existing billable metric

            try
            {
                // Find billable metric by code
                BillableMetric result = apiInstance.FindBillableMetric(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillableMetricsApi.FindBillableMetric: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindBillableMetricWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find billable metric by code
    ApiResponse<BillableMetric> response = apiInstance.FindBillableMetricWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BillableMetricsApi.FindBillableMetricWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the existing billable metric |  |

### Return type

[**BillableMetric**](BillableMetric.md)

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

<a id="updatebillablemetric"></a>
# **UpdateBillableMetric**
> BillableMetric UpdateBillableMetric (string code, BillableMetricInput billableMetricInput)

Update an existing billable metric

Update an existing billable metric by code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateBillableMetricExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BillableMetricsApi(config);
            var code = example_code;  // string | Code of the existing billable metric
            var billableMetricInput = new BillableMetricInput(); // BillableMetricInput | Update an existing billable metric

            try
            {
                // Update an existing billable metric
                BillableMetric result = apiInstance.UpdateBillableMetric(code, billableMetricInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillableMetricsApi.UpdateBillableMetric: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBillableMetricWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing billable metric
    ApiResponse<BillableMetric> response = apiInstance.UpdateBillableMetricWithHttpInfo(code, billableMetricInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BillableMetricsApi.UpdateBillableMetricWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the existing billable metric |  |
| **billableMetricInput** | [**BillableMetricInput**](BillableMetricInput.md) | Update an existing billable metric |  |

### Return type

[**BillableMetric**](BillableMetric.md)

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

