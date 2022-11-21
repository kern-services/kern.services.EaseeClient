# kern.services.EaseeClient.Api.ChargeSessionApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSessionsChargerChargerIdDailyGet**](ChargeSessionApi.md#apisessionschargerchargeriddailyget) | **GET** /api/sessions/charger/{chargerId}/daily | Charger Sessions - Daily |
| [**ApiSessionsChargerChargerIdHourlyGet**](ChargeSessionApi.md#apisessionschargerchargeridhourlyget) | **GET** /api/sessions/charger/{chargerId}/hourly | Charger Sessions - Hourly |
| [**ApiSessionsChargerChargerIdMonthlyGet**](ChargeSessionApi.md#apisessionschargerchargeridmonthlyget) | **GET** /api/sessions/charger/{chargerId}/monthly | Charger Sessions - Monthly |
| [**ApiSessionsChargerChargerIdSessionsFromToGet**](ChargeSessionApi.md#apisessionschargerchargeridsessionsfromtoget) | **GET** /api/sessions/charger/{chargerId}/sessions/{from}/{to} | Charger Sessions |
| [**ApiSessionsChargerChargerIdTotalFromToGet**](ChargeSessionApi.md#apisessionschargerchargeridtotalfromtoget) | **GET** /api/sessions/charger/{chargerId}/total/{from}/{to} | Charger Power Usage |
| [**ApiSessionsChargerChargerIdYearlyGet**](ChargeSessionApi.md#apisessionschargerchargeridyearlyget) | **GET** /api/sessions/charger/{chargerId}/yearly | Charger Sessions - Yearly |
| [**ApiSessionsExportSiteIdCategoryFromToGet**](ChargeSessionApi.md#apisessionsexportsiteidcategoryfromtoget) | **GET** /api/sessions/export/{siteId}/{category}/{from}/{to} | Site Consumption Report |
| [**ApiSessionsUserIdBreakdownFromToGet**](ChargeSessionApi.md#apisessionsuseridbreakdownfromtoget) | **GET** /api/sessions/user/{id}/breakdown/{from}/{to} | User Sessions - Grouped by Charger |
| [**ApiSessionsUserIdMonthlyGet**](ChargeSessionApi.md#apisessionsuseridmonthlyget) | **GET** /api/sessions/user/{id}/monthly | User Sessions - Monthly |
| [**ApiSessionsUserIdSessionsFromToGet**](ChargeSessionApi.md#apisessionsuseridsessionsfromtoget) | **GET** /api/sessions/user/{id}/sessions/{from}/{to} | User Sessions |
| [**ApiSessionsUserIdTotalFromToGet**](ChargeSessionApi.md#apisessionsuseridtotalfromtoget) | **GET** /api/sessions/user/{id}/total/{from}/{to} | User Power Usage |
| [**ApiSessionsUserIdWeeklyGet**](ChargeSessionApi.md#apisessionsuseridweeklyget) | **GET** /api/sessions/user/{id}/weekly | User Sessions - Weekly |
| [**ApiSessionsUserIdYearlyGet**](ChargeSessionApi.md#apisessionsuseridyearlyget) | **GET** /api/sessions/user/{id}/yearly | User Sessions - Yearly |

<a name="apisessionschargerchargeriddailyget"></a>
# **ApiSessionsChargerChargerIdDailyGet**
> List&lt;EaseeCoreDTOsSessionDailySummaryDTO&gt; ApiSessionsChargerChargerIdDailyGet (string chargerId, List<string>? rfidKeys = null)

Charger Sessions - Daily

Get Daily charging sessions for a charger. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsChargerChargerIdDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var chargerId = "chargerId_example";  // string | Charger Id
            var rfidKeys = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Charger Sessions - Daily
                List<EaseeCoreDTOsSessionDailySummaryDTO> result = apiInstance.ApiSessionsChargerChargerIdDailyGet(chargerId, rfidKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdDailyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsChargerChargerIdDailyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Sessions - Daily
    ApiResponse<List<EaseeCoreDTOsSessionDailySummaryDTO>> response = apiInstance.ApiSessionsChargerChargerIdDailyGetWithHttpInfo(chargerId, rfidKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdDailyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | Charger Id |  |
| **rfidKeys** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**List&lt;EaseeCoreDTOsSessionDailySummaryDTO&gt;**](EaseeCoreDTOsSessionDailySummaryDTO.md)

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

<a name="apisessionschargerchargeridhourlyget"></a>
# **ApiSessionsChargerChargerIdHourlyGet**
> List&lt;EaseeCoreDTOsSessionHourlySummaryDTO&gt; ApiSessionsChargerChargerIdHourlyGet (string chargerId, List<string>? rfidKeys = null)

Charger Sessions - Hourly

Get Hourly charging sessions for a charger. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsChargerChargerIdHourlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var chargerId = "chargerId_example";  // string | Charger Id
            var rfidKeys = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Charger Sessions - Hourly
                List<EaseeCoreDTOsSessionHourlySummaryDTO> result = apiInstance.ApiSessionsChargerChargerIdHourlyGet(chargerId, rfidKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdHourlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsChargerChargerIdHourlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Sessions - Hourly
    ApiResponse<List<EaseeCoreDTOsSessionHourlySummaryDTO>> response = apiInstance.ApiSessionsChargerChargerIdHourlyGetWithHttpInfo(chargerId, rfidKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdHourlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | Charger Id |  |
| **rfidKeys** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**List&lt;EaseeCoreDTOsSessionHourlySummaryDTO&gt;**](EaseeCoreDTOsSessionHourlySummaryDTO.md)

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

<a name="apisessionschargerchargeridmonthlyget"></a>
# **ApiSessionsChargerChargerIdMonthlyGet**
> List&lt;EaseeCoreDTOsSessionMonthlySummaryDTO&gt; ApiSessionsChargerChargerIdMonthlyGet (string chargerId, List<string>? rfidKeys = null)

Charger Sessions - Monthly

Get monthly charging sessions for a charger. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsChargerChargerIdMonthlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var chargerId = "chargerId_example";  // string | Charger ID
            var rfidKeys = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Charger Sessions - Monthly
                List<EaseeCoreDTOsSessionMonthlySummaryDTO> result = apiInstance.ApiSessionsChargerChargerIdMonthlyGet(chargerId, rfidKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdMonthlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsChargerChargerIdMonthlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Sessions - Monthly
    ApiResponse<List<EaseeCoreDTOsSessionMonthlySummaryDTO>> response = apiInstance.ApiSessionsChargerChargerIdMonthlyGetWithHttpInfo(chargerId, rfidKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdMonthlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | Charger ID |  |
| **rfidKeys** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**List&lt;EaseeCoreDTOsSessionMonthlySummaryDTO&gt;**](EaseeCoreDTOsSessionMonthlySummaryDTO.md)

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

<a name="apisessionschargerchargeridsessionsfromtoget"></a>
# **ApiSessionsChargerChargerIdSessionsFromToGet**
> List&lt;EaseeCoreDTOsSessionChargeSessionDTO&gt; ApiSessionsChargerChargerIdSessionsFromToGet (string chargerId, DateTime from, DateTime to, List<string>? rfidKeys = null)

Charger Sessions

Get charging sessions for a charger for a specific period. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsChargerChargerIdSessionsFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var chargerId = "chargerId_example";  // string | Charger ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)
            var rfidKeys = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Charger Sessions
                List<EaseeCoreDTOsSessionChargeSessionDTO> result = apiInstance.ApiSessionsChargerChargerIdSessionsFromToGet(chargerId, from, to, rfidKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdSessionsFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsChargerChargerIdSessionsFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Sessions
    ApiResponse<List<EaseeCoreDTOsSessionChargeSessionDTO>> response = apiInstance.ApiSessionsChargerChargerIdSessionsFromToGetWithHttpInfo(chargerId, from, to, rfidKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdSessionsFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | Charger ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |
| **rfidKeys** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**List&lt;EaseeCoreDTOsSessionChargeSessionDTO&gt;**](EaseeCoreDTOsSessionChargeSessionDTO.md)

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

<a name="apisessionschargerchargeridtotalfromtoget"></a>
# **ApiSessionsChargerChargerIdTotalFromToGet**
> double ApiSessionsChargerChargerIdTotalFromToGet (string chargerId, DateTime from, DateTime to)

Charger Power Usage

Get power usage (kWh/amount) for a charger for a specific period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsChargerChargerIdTotalFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var chargerId = "chargerId_example";  // string | Charger ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // Charger Power Usage
                double result = apiInstance.ApiSessionsChargerChargerIdTotalFromToGet(chargerId, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdTotalFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsChargerChargerIdTotalFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Power Usage
    ApiResponse<double> response = apiInstance.ApiSessionsChargerChargerIdTotalFromToGetWithHttpInfo(chargerId, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdTotalFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | Charger ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |

### Return type

**double**

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

<a name="apisessionschargerchargeridyearlyget"></a>
# **ApiSessionsChargerChargerIdYearlyGet**
> List&lt;EaseeCoreDTOsSessionYearlySummaryDTO&gt; ApiSessionsChargerChargerIdYearlyGet (string chargerId, List<string>? rfidKeys = null)

Charger Sessions - Yearly

Get Yearly charging sessions for a charger. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsChargerChargerIdYearlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var chargerId = "chargerId_example";  // string | Charger Id
            var rfidKeys = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Charger Sessions - Yearly
                List<EaseeCoreDTOsSessionYearlySummaryDTO> result = apiInstance.ApiSessionsChargerChargerIdYearlyGet(chargerId, rfidKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdYearlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsChargerChargerIdYearlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Sessions - Yearly
    ApiResponse<List<EaseeCoreDTOsSessionYearlySummaryDTO>> response = apiInstance.ApiSessionsChargerChargerIdYearlyGetWithHttpInfo(chargerId, rfidKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsChargerChargerIdYearlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerId** | **string** | Charger Id |  |
| **rfidKeys** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**List&lt;EaseeCoreDTOsSessionYearlySummaryDTO&gt;**](EaseeCoreDTOsSessionYearlySummaryDTO.md)

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

<a name="apisessionsexportsiteidcategoryfromtoget"></a>
# **ApiSessionsExportSiteIdCategoryFromToGet**
> System.IO.Stream ApiSessionsExportSiteIdCategoryFromToGet (int siteId, EaseeCoreEnumsReportCategory category, DateTime from, DateTime to, string? chargerId = null, List<string>? rfidKeys = null, string? tz = null)

Site Consumption Report

Get site consumption report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsExportSiteIdCategoryFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var siteId = 56;  // int | Site ID
            var category = (EaseeCoreEnumsReportCategory) "0";  // EaseeCoreEnumsReportCategory | Report Type
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)
            var chargerId = "chargerId_example";  // string? |  (optional) 
            var rfidKeys = new List<string>?(); // List<string>? |  (optional) 
            var tz = "tz_example";  // string? |  (optional) 

            try
            {
                // Site Consumption Report
                System.IO.Stream result = apiInstance.ApiSessionsExportSiteIdCategoryFromToGet(siteId, category, from, to, chargerId, rfidKeys, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsExportSiteIdCategoryFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsExportSiteIdCategoryFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Site Consumption Report
    ApiResponse<System.IO.Stream> response = apiInstance.ApiSessionsExportSiteIdCategoryFromToGetWithHttpInfo(siteId, category, from, to, chargerId, rfidKeys, tz);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsExportSiteIdCategoryFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **category** | **EaseeCoreEnumsReportCategory** | Report Type |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |
| **chargerId** | **string?** |  | [optional]  |
| **rfidKeys** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **tz** | **string?** |  | [optional]  |

### Return type

**System.IO.Stream**

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

<a name="apisessionsuseridbreakdownfromtoget"></a>
# **ApiSessionsUserIdBreakdownFromToGet**
> List&lt;EaseeCoreDTOsSessionChargingSessionDetailDTO&gt; ApiSessionsUserIdBreakdownFromToGet (int id, DateTime from, DateTime to)

User Sessions - Grouped by Charger

Get charging sessions grouped by chargers for a user. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsUserIdBreakdownFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var id = 56;  // int | User ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // User Sessions - Grouped by Charger
                List<EaseeCoreDTOsSessionChargingSessionDetailDTO> result = apiInstance.ApiSessionsUserIdBreakdownFromToGet(id, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdBreakdownFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsUserIdBreakdownFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User Sessions - Grouped by Charger
    ApiResponse<List<EaseeCoreDTOsSessionChargingSessionDetailDTO>> response = apiInstance.ApiSessionsUserIdBreakdownFromToGetWithHttpInfo(id, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdBreakdownFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | User ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionChargingSessionDetailDTO&gt;**](EaseeCoreDTOsSessionChargingSessionDetailDTO.md)

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

<a name="apisessionsuseridmonthlyget"></a>
# **ApiSessionsUserIdMonthlyGet**
> List&lt;EaseeCoreDTOsSessionMonthlySummaryDTO&gt; ApiSessionsUserIdMonthlyGet (int id)

User Sessions - Monthly

Get monthly charging sessions for a user. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsUserIdMonthlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var id = 56;  // int | User ID

            try
            {
                // User Sessions - Monthly
                List<EaseeCoreDTOsSessionMonthlySummaryDTO> result = apiInstance.ApiSessionsUserIdMonthlyGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdMonthlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsUserIdMonthlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User Sessions - Monthly
    ApiResponse<List<EaseeCoreDTOsSessionMonthlySummaryDTO>> response = apiInstance.ApiSessionsUserIdMonthlyGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdMonthlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | User ID |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionMonthlySummaryDTO&gt;**](EaseeCoreDTOsSessionMonthlySummaryDTO.md)

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

<a name="apisessionsuseridsessionsfromtoget"></a>
# **ApiSessionsUserIdSessionsFromToGet**
> List&lt;EaseeCoreDTOsSessionChargeSessionDTO&gt; ApiSessionsUserIdSessionsFromToGet (int id, DateTime from, DateTime to)

User Sessions

Get charging sessions for a user for a specific period. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsUserIdSessionsFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var id = 56;  // int | User ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // User Sessions
                List<EaseeCoreDTOsSessionChargeSessionDTO> result = apiInstance.ApiSessionsUserIdSessionsFromToGet(id, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdSessionsFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsUserIdSessionsFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User Sessions
    ApiResponse<List<EaseeCoreDTOsSessionChargeSessionDTO>> response = apiInstance.ApiSessionsUserIdSessionsFromToGetWithHttpInfo(id, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdSessionsFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | User ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionChargeSessionDTO&gt;**](EaseeCoreDTOsSessionChargeSessionDTO.md)

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

<a name="apisessionsuseridtotalfromtoget"></a>
# **ApiSessionsUserIdTotalFromToGet**
> double ApiSessionsUserIdTotalFromToGet (int id, DateTime from, DateTime to)

User Power Usage

Get power usage (kWh/amount) for a user for a specific period. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsUserIdTotalFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var id = 56;  // int | User ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // User Power Usage
                double result = apiInstance.ApiSessionsUserIdTotalFromToGet(id, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdTotalFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsUserIdTotalFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User Power Usage
    ApiResponse<double> response = apiInstance.ApiSessionsUserIdTotalFromToGetWithHttpInfo(id, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdTotalFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | User ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |

### Return type

**double**

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

<a name="apisessionsuseridweeklyget"></a>
# **ApiSessionsUserIdWeeklyGet**
> List&lt;EaseeCoreDTOsSessionWeeklySummaryDTO&gt; ApiSessionsUserIdWeeklyGet (int id)

User Sessions - Weekly

Get weekly charging sessions for a user. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsUserIdWeeklyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var id = 56;  // int | User Id

            try
            {
                // User Sessions - Weekly
                List<EaseeCoreDTOsSessionWeeklySummaryDTO> result = apiInstance.ApiSessionsUserIdWeeklyGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdWeeklyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsUserIdWeeklyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User Sessions - Weekly
    ApiResponse<List<EaseeCoreDTOsSessionWeeklySummaryDTO>> response = apiInstance.ApiSessionsUserIdWeeklyGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdWeeklyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | User Id |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionWeeklySummaryDTO&gt;**](EaseeCoreDTOsSessionWeeklySummaryDTO.md)

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

<a name="apisessionsuseridyearlyget"></a>
# **ApiSessionsUserIdYearlyGet**
> List&lt;EaseeCoreDTOsSessionYearlySummaryDTO&gt; ApiSessionsUserIdYearlyGet (int id)

User Sessions - Yearly

Get yearly charging sessions for a user. Rate limited at max 20 requests per 10 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSessionsUserIdYearlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargeSessionApi(config);
            var id = 56;  // int | User ID

            try
            {
                // User Sessions - Yearly
                List<EaseeCoreDTOsSessionYearlySummaryDTO> result = apiInstance.ApiSessionsUserIdYearlyGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdYearlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSessionsUserIdYearlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User Sessions - Yearly
    ApiResponse<List<EaseeCoreDTOsSessionYearlySummaryDTO>> response = apiInstance.ApiSessionsUserIdYearlyGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargeSessionApi.ApiSessionsUserIdYearlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | User ID |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionYearlySummaryDTO&gt;**](EaseeCoreDTOsSessionYearlySummaryDTO.md)

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

