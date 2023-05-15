# Org.OpenAPITools.Api.WalletsApi

All URIs are relative to *https://api.getlago.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWallet**](WalletsApi.md#createwallet) | **POST** /wallets | Create a new wallet
[**CreateWalletTransaction**](WalletsApi.md#createwallettransaction) | **POST** /wallet_transactions | Create a new wallet transaction
[**DestroyWallet**](WalletsApi.md#destroywallet) | **DELETE** /wallets/{id} | Delete a wallet
[**FindAllWalletTransactions**](WalletsApi.md#findallwallettransactions) | **GET** /wallets/{id}/wallet_transactions | Find wallet transactions
[**FindAllWallets**](WalletsApi.md#findallwallets) | **GET** /wallets | Find wallets
[**FindWallet**](WalletsApi.md#findwallet) | **GET** /wallets/{id} | Find wallet
[**UpdateWallet**](WalletsApi.md#updatewallet) | **PUT** /wallets/{id} | Update an existing wallet



## CreateWallet

> Wallet CreateWallet (WalletInput walletInput)

Create a new wallet

Create a new wallet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletsApi(Configuration.Default);
            var walletInput = new WalletInput(); // WalletInput | Wallet payload

            try
            {
                // Create a new wallet
                Wallet result = apiInstance.CreateWallet(walletInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.CreateWallet: " + e.Message );
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
 **walletInput** | [**WalletInput**](WalletInput.md)| Wallet payload | 

### Return type

[**Wallet**](Wallet.md)

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


## CreateWalletTransaction

> WalletTransactions CreateWalletTransaction (WalletTransactionInput walletTransactionInput)

Create a new wallet transaction

Create a new wallet transaction

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateWalletTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletsApi(Configuration.Default);
            var walletTransactionInput = new WalletTransactionInput(); // WalletTransactionInput | Wallet transaction payload

            try
            {
                // Create a new wallet transaction
                WalletTransactions result = apiInstance.CreateWalletTransaction(walletTransactionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.CreateWalletTransaction: " + e.Message );
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
 **walletTransactionInput** | [**WalletTransactionInput**](WalletTransactionInput.md)| Wallet transaction payload | 

### Return type

[**WalletTransactions**](WalletTransactions.md)

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


## DestroyWallet

> Wallet DestroyWallet (Guid id)

Delete a wallet

Delete a wallet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DestroyWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletsApi(Configuration.Default);
            var id = 1a901a90-1a90-1a90-1a90-1a901a901a90;  // Guid | Lago ID of the existing wallet

            try
            {
                // Delete a wallet
                Wallet result = apiInstance.DestroyWallet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.DestroyWallet: " + e.Message );
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
 **id** | **Guid**| Lago ID of the existing wallet | 

### Return type

[**Wallet**](Wallet.md)

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
| **405** | Not Allowed error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FindAllWalletTransactions

> WalletTransactionsPaginated FindAllWalletTransactions (Guid id, int? page = null, int? perPage = null, string status = null, string transactionType = null)

Find wallet transactions

Find all wallet transactions for certain wallet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllWalletTransactionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletsApi(Configuration.Default);
            var id = 1a901a90-1a90-1a90-1a90-1a901a901a90;  // Guid | Lago ID of the existing wallet
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 
            var status = pending;  // string | Status (pending or settled) (optional) 
            var transactionType = inbound;  // string | Transaction Type (inbound or outbound) (optional) 

            try
            {
                // Find wallet transactions
                WalletTransactionsPaginated result = apiInstance.FindAllWalletTransactions(id, page, perPage, status, transactionType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.FindAllWalletTransactions: " + e.Message );
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
 **id** | **Guid**| Lago ID of the existing wallet | 
 **page** | **int?**| Number of page | [optional] 
 **perPage** | **int?**| Number of records per page | [optional] 
 **status** | **string**| Status (pending or settled) | [optional] 
 **transactionType** | **string**| Transaction Type (inbound or outbound) | [optional] 

### Return type

[**WalletTransactionsPaginated**](WalletTransactionsPaginated.md)

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


## FindAllWallets

> WalletsPaginated FindAllWallets (string externalCustomerId, int? page = null, int? perPage = null)

Find wallets

Find all wallets for certain customer

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindAllWalletsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletsApi(Configuration.Default);
            var externalCustomerId = 12345;  // string | External customer ID
            var page = 2;  // int? | Number of page (optional) 
            var perPage = 20;  // int? | Number of records per page (optional) 

            try
            {
                // Find wallets
                WalletsPaginated result = apiInstance.FindAllWallets(externalCustomerId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.FindAllWallets: " + e.Message );
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
 **externalCustomerId** | **string**| External customer ID | 
 **page** | **int?**| Number of page | [optional] 
 **perPage** | **int?**| Number of records per page | [optional] 

### Return type

[**WalletsPaginated**](WalletsPaginated.md)

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


## FindWallet

> Wallet FindWallet (Guid id)

Find wallet

Return a wallet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletsApi(Configuration.Default);
            var id = 1a901a90-1a90-1a90-1a90-1a901a901a90;  // Guid | Lago ID of the existing wallet

            try
            {
                // Find wallet
                Wallet result = apiInstance.FindWallet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.FindWallet: " + e.Message );
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
 **id** | **Guid**| Lago ID of the existing wallet | 

### Return type

[**Wallet**](Wallet.md)

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


## UpdateWallet

> Wallet UpdateWallet (Guid id, WalletUpdateInput walletUpdateInput)

Update an existing wallet

Update an existing wallet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.getlago.com/api/v1";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletsApi(Configuration.Default);
            var id = 1a901a90-1a90-1a90-1a90-1a901a901a90;  // Guid | Lago ID of the existing wallet
            var walletUpdateInput = new WalletUpdateInput(); // WalletUpdateInput | Update an existing wallet

            try
            {
                // Update an existing wallet
                Wallet result = apiInstance.UpdateWallet(id, walletUpdateInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.UpdateWallet: " + e.Message );
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
 **id** | **Guid**| Lago ID of the existing wallet | 
 **walletUpdateInput** | [**WalletUpdateInput**](WalletUpdateInput.md)| Update an existing wallet | 

### Return type

[**Wallet**](Wallet.md)

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

