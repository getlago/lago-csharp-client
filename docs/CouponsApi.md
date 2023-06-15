# Org.OpenAPITools.Api.CouponsApi

All URIs are relative to *https://api.getlago.com/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplyCoupon**](CouponsApi.md#applycoupon) | **POST** /applied_coupons | Apply a coupon to a customer |
| [**CreateCoupon**](CouponsApi.md#createcoupon) | **POST** /coupons | Create a new coupon |
| [**DestroyCoupon**](CouponsApi.md#destroycoupon) | **DELETE** /coupons/{code} | Delete a coupon |
| [**FindAllAppliedCoupons**](CouponsApi.md#findallappliedcoupons) | **GET** /applied_coupons | Find Applied Coupons |
| [**FindAllCoupons**](CouponsApi.md#findallcoupons) | **GET** /coupons | Find Coupons |
| [**FindCoupon**](CouponsApi.md#findcoupon) | **GET** /coupons/{code} | Find coupon by code |
| [**UpdateCoupon**](CouponsApi.md#updatecoupon) | **PUT** /coupons/{code} | Update an existing coupon |

<a id="applycoupon"></a>
# **ApplyCoupon**
> AppliedCoupon ApplyCoupon (AppliedCouponInput appliedCouponInput)

Apply a coupon to a customer

Apply a coupon to a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApplyCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CouponsApi(config);
            var appliedCouponInput = new AppliedCouponInput(); // AppliedCouponInput | Apply coupon payload

            try
            {
                // Apply a coupon to a customer
                AppliedCoupon result = apiInstance.ApplyCoupon(appliedCouponInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.ApplyCoupon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplyCouponWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply a coupon to a customer
    ApiResponse<AppliedCoupon> response = apiInstance.ApplyCouponWithHttpInfo(appliedCouponInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CouponsApi.ApplyCouponWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appliedCouponInput** | [**AppliedCouponInput**](AppliedCouponInput.md) | Apply coupon payload |  |

### Return type

[**AppliedCoupon**](AppliedCoupon.md)

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

<a id="createcoupon"></a>
# **CreateCoupon**
> Coupon CreateCoupon (CouponInput couponInput)

Create a new coupon

Create a new coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CouponsApi(config);
            var couponInput = new CouponInput(); // CouponInput | Coupon payload

            try
            {
                // Create a new coupon
                Coupon result = apiInstance.CreateCoupon(couponInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.CreateCoupon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCouponWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new coupon
    ApiResponse<Coupon> response = apiInstance.CreateCouponWithHttpInfo(couponInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CouponsApi.CreateCouponWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **couponInput** | [**CouponInput**](CouponInput.md) | Coupon payload |  |

### Return type

[**Coupon**](Coupon.md)

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

<a id="destroycoupon"></a>
# **DestroyCoupon**
> Coupon DestroyCoupon (string code)

Delete a coupon

Delete a coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DestroyCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CouponsApi(config);
            var code = example_code;  // string | Code of the existing coupon

            try
            {
                // Delete a coupon
                Coupon result = apiInstance.DestroyCoupon(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.DestroyCoupon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DestroyCouponWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a coupon
    ApiResponse<Coupon> response = apiInstance.DestroyCouponWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CouponsApi.DestroyCouponWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the existing coupon |  |

### Return type

[**Coupon**](Coupon.md)

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

<a id="findallappliedcoupons"></a>
# **FindAllAppliedCoupons**
> AppliedCouponsPaginated FindAllAppliedCoupons (int? page = null, int? perPage = null, string status = null, string externalCustomerId = null)

Find Applied Coupons

Find all applied coupons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllAppliedCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CouponsApi(config);
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 
            var status = "active";  // string | Applied coupon status (optional) 
            var externalCustomerId = 12345;  // string | External customer ID (optional) 

            try
            {
                // Find Applied Coupons
                AppliedCouponsPaginated result = apiInstance.FindAllAppliedCoupons(page, perPage, status, externalCustomerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.FindAllAppliedCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllAppliedCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find Applied Coupons
    ApiResponse<AppliedCouponsPaginated> response = apiInstance.FindAllAppliedCouponsWithHttpInfo(page, perPage, status, externalCustomerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CouponsApi.FindAllAppliedCouponsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Number of page | [optional]  |
| **perPage** | **int?** | Number of records per page | [optional]  |
| **status** | **string** | Applied coupon status | [optional]  |
| **externalCustomerId** | **string** | External customer ID | [optional]  |

### Return type

[**AppliedCouponsPaginated**](AppliedCouponsPaginated.md)

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

<a id="findallcoupons"></a>
# **FindAllCoupons**
> CouponsPaginated FindAllCoupons (int? page = null, int? perPage = null)

Find Coupons

Find all coupons in certain organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CouponsApi(config);
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 

            try
            {
                // Find Coupons
                CouponsPaginated result = apiInstance.FindAllCoupons(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.FindAllCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find Coupons
    ApiResponse<CouponsPaginated> response = apiInstance.FindAllCouponsWithHttpInfo(page, perPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CouponsApi.FindAllCouponsWithHttpInfo: " + e.Message);
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

[**CouponsPaginated**](CouponsPaginated.md)

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

<a id="findcoupon"></a>
# **FindCoupon**
> Coupon FindCoupon (string code)

Find coupon by code

Return a single coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CouponsApi(config);
            var code = example_code;  // string | Code of the existing coupon

            try
            {
                // Find coupon by code
                Coupon result = apiInstance.FindCoupon(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.FindCoupon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindCouponWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find coupon by code
    ApiResponse<Coupon> response = apiInstance.FindCouponWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CouponsApi.FindCouponWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the existing coupon |  |

### Return type

[**Coupon**](Coupon.md)

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

<a id="updatecoupon"></a>
# **UpdateCoupon**
> Coupon UpdateCoupon (string code, CouponInput couponInput)

Update an existing coupon

Update an existing coupon by code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.getlago.com/api/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CouponsApi(config);
            var code = example_code;  // string | Code of the existing coupon
            var couponInput = new CouponInput(); // CouponInput | Update an existing coupon

            try
            {
                // Update an existing coupon
                Coupon result = apiInstance.UpdateCoupon(code, couponInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CouponsApi.UpdateCoupon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCouponWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing coupon
    ApiResponse<Coupon> response = apiInstance.UpdateCouponWithHttpInfo(code, couponInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CouponsApi.UpdateCouponWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the existing coupon |  |
| **couponInput** | [**CouponInput**](CouponInput.md) | Update an existing coupon |  |

### Return type

[**Coupon**](Coupon.md)

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

