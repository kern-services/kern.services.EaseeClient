# kern.services.EaseeClient.Api.AccountApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiAccountsAccountIdInvalidateTokenDelete**](AccountApi.md#apiaccountsaccountidinvalidatetokendelete) | **DELETE** /api/accounts/{accountId}/invalidate_token | Invalidate refresh token |
| [**ApiAccountsChargersGet**](AccountApi.md#apiaccountschargersget) | **GET** /api/accounts/chargers | Chargers |
| [**ApiAccountsChargersPost**](AccountApi.md#apiaccountschargerspost) | **POST** /api/accounts/chargers | Add Charger |
| [**ApiAccountsChargersSerialNoDelete**](AccountApi.md#apiaccountschargersserialnodelete) | **DELETE** /api/accounts/chargers/{serial_no} | Remove Charger |
| [**ApiAccountsLoginPost**](AccountApi.md#apiaccountsloginpost) | **POST** /api/accounts/login | Authentication |
| [**ApiAccountsProductsGet**](AccountApi.md#apiaccountsproductsget) | **GET** /api/accounts/products | Products |
| [**ApiAccountsProfileGet**](AccountApi.md#apiaccountsprofileget) | **GET** /api/accounts/profile | Profile Info |
| [**ApiAccountsRefreshTokenPost**](AccountApi.md#apiaccountsrefreshtokenpost) | **POST** /api/accounts/refresh_token | Refresh Token |

<a name="apiaccountsaccountidinvalidatetokendelete"></a>
# **ApiAccountsAccountIdInvalidateTokenDelete**
> void ApiAccountsAccountIdInvalidateTokenDelete (int accountId, string? token = null)

Invalidate refresh token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsAccountIdInvalidateTokenDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountId = 56;  // int | The id for which the token belongs
            var token = "token_example";  // string? | Optional. Token to invalidate. If not present, all tokens for the accountId will be invalidated (optional) 

            try
            {
                // Invalidate refresh token
                apiInstance.ApiAccountsAccountIdInvalidateTokenDelete(accountId, token);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsAccountIdInvalidateTokenDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsAccountIdInvalidateTokenDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invalidate refresh token
    apiInstance.ApiAccountsAccountIdInvalidateTokenDeleteWithHttpInfo(accountId, token);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsAccountIdInvalidateTokenDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **int** | The id for which the token belongs |  |
| **token** | **string?** | Optional. Token to invalidate. If not present, all tokens for the accountId will be invalidated | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiaccountschargersget"></a>
# **ApiAccountsChargersGet**
> List&lt;EaseeAccessControlDomainDTOSiteDTO&gt; ApiAccountsChargersGet ()

Chargers

Replaced with products endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsChargersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);

            try
            {
                // Chargers
                List<EaseeAccessControlDomainDTOSiteDTO> result = apiInstance.ApiAccountsChargersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsChargersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsChargersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Chargers
    ApiResponse<List<EaseeAccessControlDomainDTOSiteDTO>> response = apiInstance.ApiAccountsChargersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsChargersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EaseeAccessControlDomainDTOSiteDTO&gt;**](EaseeAccessControlDomainDTOSiteDTO.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiaccountschargerspost"></a>
# **ApiAccountsChargersPost**
> void ApiAccountsChargersPost (EaseeAccessControlModelsProductPinDTO? easeeAccessControlModelsProductPinDTO = null)

Add Charger

Replaced with products endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsChargersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var easeeAccessControlModelsProductPinDTO = new EaseeAccessControlModelsProductPinDTO?(); // EaseeAccessControlModelsProductPinDTO? | Charger/equalizer PIN code details. (optional) 

            try
            {
                // Add Charger
                apiInstance.ApiAccountsChargersPost(easeeAccessControlModelsProductPinDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsChargersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsChargersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Charger
    apiInstance.ApiAccountsChargersPostWithHttpInfo(easeeAccessControlModelsProductPinDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsChargersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **easeeAccessControlModelsProductPinDTO** | [**EaseeAccessControlModelsProductPinDTO?**](EaseeAccessControlModelsProductPinDTO?.md) | Charger/equalizer PIN code details. | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiaccountschargersserialnodelete"></a>
# **ApiAccountsChargersSerialNoDelete**
> void ApiAccountsChargersSerialNoDelete (string serialNo)

Remove Charger

Replaced with products endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsChargersSerialNoDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var serialNo = "serialNo_example";  // string | Charger/equalizer identifier

            try
            {
                // Remove Charger
                apiInstance.ApiAccountsChargersSerialNoDelete(serialNo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsChargersSerialNoDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsChargersSerialNoDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Charger
    apiInstance.ApiAccountsChargersSerialNoDeleteWithHttpInfo(serialNo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsChargersSerialNoDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serialNo** | **string** | Charger/equalizer identifier |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiaccountsloginpost"></a>
# **ApiAccountsLoginPost**
> EaseeUserAdministrationDTOUserToken ApiAccountsLoginPost (EaseeAccessControlModelsLoginDto? easeeAccessControlModelsLoginDto = null)

Authentication

Authenticate and retrieve access Token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var easeeAccessControlModelsLoginDto = new EaseeAccessControlModelsLoginDto?(); // EaseeAccessControlModelsLoginDto? | Username and password (optional) 

            try
            {
                // Authentication
                EaseeUserAdministrationDTOUserToken result = apiInstance.ApiAccountsLoginPost(easeeAccessControlModelsLoginDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authentication
    ApiResponse<EaseeUserAdministrationDTOUserToken> response = apiInstance.ApiAccountsLoginPostWithHttpInfo(easeeAccessControlModelsLoginDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **easeeAccessControlModelsLoginDto** | [**EaseeAccessControlModelsLoginDto?**](EaseeAccessControlModelsLoginDto?.md) | Username and password | [optional]  |

### Return type

[**EaseeUserAdministrationDTOUserToken**](EaseeUserAdministrationDTOUserToken.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiaccountsproductsget"></a>
# **ApiAccountsProductsGet**
> List&lt;EaseeAccessControlDomainDTOSiteDTO&gt; ApiAccountsProductsGet (int? userId = null)

Products

Get products of logged in account. Product can be either charger or equalizer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsProductsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var userId = 56;  // int? |  (optional) 

            try
            {
                // Products
                List<EaseeAccessControlDomainDTOSiteDTO> result = apiInstance.ApiAccountsProductsGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsProductsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsProductsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Products
    ApiResponse<List<EaseeAccessControlDomainDTOSiteDTO>> response = apiInstance.ApiAccountsProductsGetWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsProductsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int?** |  | [optional]  |

### Return type

[**List&lt;EaseeAccessControlDomainDTOSiteDTO&gt;**](EaseeAccessControlDomainDTOSiteDTO.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiaccountsprofileget"></a>
# **ApiAccountsProfileGet**
> EaseeCoreDTOsAccountProfileDTO ApiAccountsProfileGet ()

Profile Info

Get profile info of logged in account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsProfileGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);

            try
            {
                // Profile Info
                EaseeCoreDTOsAccountProfileDTO result = apiInstance.ApiAccountsProfileGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsProfileGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsProfileGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Profile Info
    ApiResponse<EaseeCoreDTOsAccountProfileDTO> response = apiInstance.ApiAccountsProfileGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsProfileGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EaseeCoreDTOsAccountProfileDTO**](EaseeCoreDTOsAccountProfileDTO.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiaccountsrefreshtokenpost"></a>
# **ApiAccountsRefreshTokenPost**
> EaseeUserAdministrationDTOUserToken ApiAccountsRefreshTokenPost (EaseeAccessControlModelsRefreshTokenDTO? easeeAccessControlModelsRefreshTokenDTO = null)

Refresh Token

Refresh access token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiAccountsRefreshTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var easeeAccessControlModelsRefreshTokenDTO = new EaseeAccessControlModelsRefreshTokenDTO?(); // EaseeAccessControlModelsRefreshTokenDTO? | Access token and refresh token (optional) 

            try
            {
                // Refresh Token
                EaseeUserAdministrationDTOUserToken result = apiInstance.ApiAccountsRefreshTokenPost(easeeAccessControlModelsRefreshTokenDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ApiAccountsRefreshTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsRefreshTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refresh Token
    ApiResponse<EaseeUserAdministrationDTOUserToken> response = apiInstance.ApiAccountsRefreshTokenPostWithHttpInfo(easeeAccessControlModelsRefreshTokenDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ApiAccountsRefreshTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **easeeAccessControlModelsRefreshTokenDTO** | [**EaseeAccessControlModelsRefreshTokenDTO?**](EaseeAccessControlModelsRefreshTokenDTO?.md) | Access token and refresh token | [optional]  |

### Return type

[**EaseeUserAdministrationDTOUserToken**](EaseeUserAdministrationDTOUserToken.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

