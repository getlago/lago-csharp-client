# Org.OpenAPITools.Api.EventsApi

All URIs are relative to *https://api.getlago.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBatchEvents**](EventsApi.md#createbatchevents) | **POST** /events/batch | Create batch events
[**CreateEvent**](EventsApi.md#createevent) | **POST** /events | Create a new event
[**EventEstimateFees**](EventsApi.md#eventestimatefees) | **POST** /events/estimate_fees | Estimate fees for an instant charge
[**FindEvent**](EventsApi.md#findevent) | **GET** /events/{id} | Find event by transaction ID



## CreateBatchEvents

> void CreateBatchEvents (BatchEventInput batchEventInput)

Create batch events

Create batch events

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBatchEventsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(Configuration.Default);
            var batchEventInput = new BatchEventInput(); // BatchEventInput | Batch events payload

            try
            {
                // Create batch events
                apiInstance.CreateBatchEvents(batchEventInput);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EventsApi.CreateBatchEvents: " + e.Message );
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
 **batchEventInput** | [**BatchEventInput**](BatchEventInput.md)| Batch events payload | 

### Return type

void (empty response body)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateEvent

> void CreateEvent (EventInput eventInput)

Create a new event

Create a new event

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateEventExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(Configuration.Default);
            var eventInput = new EventInput(); // EventInput | Event payload

            try
            {
                // Create a new event
                apiInstance.CreateEvent(eventInput);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EventsApi.CreateEvent: " + e.Message );
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
 **eventInput** | [**EventInput**](EventInput.md)| Event payload | 

### Return type

void (empty response body)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EventEstimateFees

> Fees EventEstimateFees (EventEstimateFeesInput eventEstimateFeesInput)

Estimate fees for an instant charge

Estimate the fees that would be created after reception of an event for a billable metric attached to one or multiple instant charges

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventEstimateFeesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(Configuration.Default);
            var eventEstimateFeesInput = new EventEstimateFeesInput(); // EventEstimateFeesInput | Event payload for instant fee estimate

            try
            {
                // Estimate fees for an instant charge
                Fees result = apiInstance.EventEstimateFees(eventEstimateFeesInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EventsApi.EventEstimateFees: " + e.Message );
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
 **eventEstimateFeesInput** | [**EventEstimateFeesInput**](EventEstimateFeesInput.md)| Event payload for instant fee estimate | 

### Return type

[**Fees**](Fees.md)

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


## FindEvent

> Event FindEvent (string id)

Find event by transaction ID

Return a single event

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindEventExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(Configuration.Default);
            var id = 12345;  // string | Id of the existing transaction

            try
            {
                // Find event by transaction ID
                Event result = apiInstance.FindEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EventsApi.FindEvent: " + e.Message );
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
 **id** | **string**| Id of the existing transaction | 

### Return type

[**Event**](Event.md)

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

