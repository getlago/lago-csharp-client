# Org.OpenAPITools.Api.InvoicesApi

All URIs are relative to *https://api.getlago.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadInvoice**](InvoicesApi.md#downloadinvoice) | **POST** /invoices/{id}/download | Download an existing invoice
[**FinalizeInvoice**](InvoicesApi.md#finalizeinvoice) | **PUT** /invoices/{id}/finalize | Finalize a draft invoice
[**FindAllInvoices**](InvoicesApi.md#findallinvoices) | **GET** /invoices/ | Find all invoices
[**FindInvoice**](InvoicesApi.md#findinvoice) | **GET** /invoices/{id} | Find invoice by ID
[**RefreshInvoice**](InvoicesApi.md#refreshinvoice) | **PUT** /invoices/{id}/refresh | Refresh a draft invoice
[**UpdateInvoice**](InvoicesApi.md#updateinvoice) | **PUT** /invoices/{id} | Update an existing invoice status



## DownloadInvoice

> Invoice DownloadInvoice (string id)

Download an existing invoice

Download an existing invoice

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DownloadInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var id = 183da83c-c007-4fbb-afcd-b00c07c41ffe;  // string | ID of the existing Lago Invoice

            try
            {
                // Download an existing invoice
                Invoice result = apiInstance.DownloadInvoice(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.DownloadInvoice: " + e.Message );
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
 **id** | **string**| ID of the existing Lago Invoice | 

### Return type

[**Invoice**](Invoice.md)

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


## FinalizeInvoice

> Invoice FinalizeInvoice (string id)

Finalize a draft invoice

Finalize a draft invoice

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FinalizeInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var id = 183da83c-c007-4fbb-afcd-b00c07c41ffe;  // string | ID of the draft Lago Invoice

            try
            {
                // Finalize a draft invoice
                Invoice result = apiInstance.FinalizeInvoice(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.FinalizeInvoice: " + e.Message );
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
 **id** | **string**| ID of the draft Lago Invoice | 

### Return type

[**Invoice**](Invoice.md)

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


## FindAllInvoices

> Invoices FindAllInvoices (int? page = null, int? perPage = null, string externalCustomerId = null, string issuingDateFrom = null, string issuingDateTo = null, string status = null)

Find all invoices

Find all invoices in certain organisation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllInvoicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 
            var externalCustomerId = 12345;  // string | External customer ID (optional) 
            var issuingDateFrom = 2022-07-08;  // string | Date from (optional) 
            var issuingDateTo = 2022-08-09;  // string | Date to (optional) 
            var status = draft;  // string | Status (draft or finalized) (optional) 

            try
            {
                // Find all invoices
                Invoices result = apiInstance.FindAllInvoices(page, perPage, externalCustomerId, issuingDateFrom, issuingDateTo, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.FindAllInvoices: " + e.Message );
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
 **externalCustomerId** | **string**| External customer ID | [optional] 
 **issuingDateFrom** | **string**| Date from | [optional] 
 **issuingDateTo** | **string**| Date to | [optional] 
 **status** | **string**| Status (draft or finalized) | [optional] 

### Return type

[**Invoices**](Invoices.md)

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


## FindInvoice

> Invoice FindInvoice (string id)

Find invoice by ID

Return a single invoice

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var id = 183da83c-c007-4fbb-afcd-b00c07c41ffe;  // string | ID of the existing Lago Invoice

            try
            {
                // Find invoice by ID
                Invoice result = apiInstance.FindInvoice(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.FindInvoice: " + e.Message );
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
 **id** | **string**| ID of the existing Lago Invoice | 

### Return type

[**Invoice**](Invoice.md)

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


## RefreshInvoice

> Invoice RefreshInvoice (string id)

Refresh a draft invoice

Refresh a draft invoice

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefreshInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var id = 183da83c-c007-4fbb-afcd-b00c07c41ffe;  // string | ID of the existing Lago Invoice

            try
            {
                // Refresh a draft invoice
                Invoice result = apiInstance.RefreshInvoice(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.RefreshInvoice: " + e.Message );
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
 **id** | **string**| ID of the existing Lago Invoice | 

### Return type

[**Invoice**](Invoice.md)

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


## UpdateInvoice

> Invoice UpdateInvoice (string id, InvoiceInput invoiceInput)

Update an existing invoice status

Update an existing invoice

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var id = 183da83c-c007-4fbb-afcd-b00c07c41ffe;  // string | ID of the existing Lago Invoice
            var invoiceInput = new InvoiceInput(); // InvoiceInput | Update an existing invoice

            try
            {
                // Update an existing invoice status
                Invoice result = apiInstance.UpdateInvoice(id, invoiceInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateInvoice: " + e.Message );
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
 **id** | **string**| ID of the existing Lago Invoice | 
 **invoiceInput** | [**InvoiceInput**](InvoiceInput.md)| Update an existing invoice | 

### Return type

[**Invoice**](Invoice.md)

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

