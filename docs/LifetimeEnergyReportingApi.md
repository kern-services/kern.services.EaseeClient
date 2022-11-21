# kern.services.EaseeClient.Api.LifetimeEnergyReportingApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiChargersLifetimeEnergyIdAllGet**](LifetimeEnergyReportingApi.md#apichargerslifetimeenergyidallget) | **GET** /api/chargers/lifetime-energy/{id}/all |  |
| [**ApiChargersLifetimeEnergyIdConfigurePut**](LifetimeEnergyReportingApi.md#apichargerslifetimeenergyidconfigureput) | **PUT** /api/chargers/lifetime-energy/{id}/configure |  |
| [**ApiChargersLifetimeEnergyIdDailyGet**](LifetimeEnergyReportingApi.md#apichargerslifetimeenergyiddailyget) | **GET** /api/chargers/lifetime-energy/{id}/daily |  |
| [**ApiChargersLifetimeEnergyIdHourlyGet**](LifetimeEnergyReportingApi.md#apichargerslifetimeenergyidhourlyget) | **GET** /api/chargers/lifetime-energy/{id}/hourly |  |
| [**ApiChargersLifetimeEnergyIdMonthlyGet**](LifetimeEnergyReportingApi.md#apichargerslifetimeenergyidmonthlyget) | **GET** /api/chargers/lifetime-energy/{id}/monthly |  |
| [**ApiChargersLifetimeEnergyIdYearlyGet**](LifetimeEnergyReportingApi.md#apichargerslifetimeenergyidyearlyget) | **GET** /api/chargers/lifetime-energy/{id}/yearly |  |

<a name="apichargerslifetimeenergyidallget"></a>
# **ApiChargersLifetimeEnergyIdAllGet**
> EaseeServicesLifetimeEnergyReportingGetAllMeasurementsResponse ApiChargersLifetimeEnergyIdAllGet (string id, DateTime? from = null, DateTime? to = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersLifetimeEnergyIdAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LifetimeEnergyReportingApi(config);
            var id = "id_example";  // string | 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                EaseeServicesLifetimeEnergyReportingGetAllMeasurementsResponse result = apiInstance.ApiChargersLifetimeEnergyIdAllGet(id, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersLifetimeEnergyIdAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EaseeServicesLifetimeEnergyReportingGetAllMeasurementsResponse> response = apiInstance.ApiChargersLifetimeEnergyIdAllGetWithHttpInfo(id, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |

### Return type

[**EaseeServicesLifetimeEnergyReportingGetAllMeasurementsResponse**](EaseeServicesLifetimeEnergyReportingGetAllMeasurementsResponse.md)

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

<a name="apichargerslifetimeenergyidconfigureput"></a>
# **ApiChargersLifetimeEnergyIdConfigurePut**
> void ApiChargersLifetimeEnergyIdConfigurePut (string id, EaseeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest? easeeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersLifetimeEnergyIdConfigurePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LifetimeEnergyReportingApi(config);
            var id = "id_example";  // string | 
            var easeeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest = new EaseeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest?(); // EaseeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest? |  (optional) 

            try
            {
                apiInstance.ApiChargersLifetimeEnergyIdConfigurePut(id, easeeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdConfigurePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersLifetimeEnergyIdConfigurePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiChargersLifetimeEnergyIdConfigurePutWithHttpInfo(id, easeeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdConfigurePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **easeeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest** | [**EaseeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest?**](EaseeServicesLifetimeEnergyReportingLifetimeEnergyMeasurementSettingsRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargerslifetimeenergyiddailyget"></a>
# **ApiChargersLifetimeEnergyIdDailyGet**
> List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt; ApiChargersLifetimeEnergyIdDailyGet (string id, DateTime? from = null, DateTime? to = null, string? tz = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersLifetimeEnergyIdDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LifetimeEnergyReportingApi(config);
            var id = "id_example";  // string | 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var tz = "tz_example";  // string? |  (optional) 

            try
            {
                List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy> result = apiInstance.ApiChargersLifetimeEnergyIdDailyGet(id, from, to, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdDailyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersLifetimeEnergyIdDailyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy>> response = apiInstance.ApiChargersLifetimeEnergyIdDailyGetWithHttpInfo(id, from, to, tz);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdDailyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |
| **tz** | **string?** |  | [optional]  |

### Return type

[**List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt;**](EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy.md)

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

<a name="apichargerslifetimeenergyidhourlyget"></a>
# **ApiChargersLifetimeEnergyIdHourlyGet**
> List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt; ApiChargersLifetimeEnergyIdHourlyGet (string id, DateTime? from = null, DateTime? to = null, string? tz = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersLifetimeEnergyIdHourlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LifetimeEnergyReportingApi(config);
            var id = "id_example";  // string | 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var tz = "tz_example";  // string? |  (optional) 

            try
            {
                List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy> result = apiInstance.ApiChargersLifetimeEnergyIdHourlyGet(id, from, to, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdHourlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersLifetimeEnergyIdHourlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy>> response = apiInstance.ApiChargersLifetimeEnergyIdHourlyGetWithHttpInfo(id, from, to, tz);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdHourlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |
| **tz** | **string?** |  | [optional]  |

### Return type

[**List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt;**](EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy.md)

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

<a name="apichargerslifetimeenergyidmonthlyget"></a>
# **ApiChargersLifetimeEnergyIdMonthlyGet**
> List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt; ApiChargersLifetimeEnergyIdMonthlyGet (string id, DateTime? from = null, DateTime? to = null, string? tz = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersLifetimeEnergyIdMonthlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LifetimeEnergyReportingApi(config);
            var id = "id_example";  // string | 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var tz = "tz_example";  // string? |  (optional) 

            try
            {
                List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy> result = apiInstance.ApiChargersLifetimeEnergyIdMonthlyGet(id, from, to, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdMonthlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersLifetimeEnergyIdMonthlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy>> response = apiInstance.ApiChargersLifetimeEnergyIdMonthlyGetWithHttpInfo(id, from, to, tz);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdMonthlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |
| **tz** | **string?** |  | [optional]  |

### Return type

[**List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt;**](EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy.md)

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

<a name="apichargerslifetimeenergyidyearlyget"></a>
# **ApiChargersLifetimeEnergyIdYearlyGet**
> List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt; ApiChargersLifetimeEnergyIdYearlyGet (string id, DateTime? from = null, DateTime? to = null, string? tz = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersLifetimeEnergyIdYearlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LifetimeEnergyReportingApi(config);
            var id = "id_example";  // string | 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var tz = "tz_example";  // string? |  (optional) 

            try
            {
                List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy> result = apiInstance.ApiChargersLifetimeEnergyIdYearlyGet(id, from, to, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdYearlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersLifetimeEnergyIdYearlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy>> response = apiInstance.ApiChargersLifetimeEnergyIdYearlyGetWithHttpInfo(id, from, to, tz);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LifetimeEnergyReportingApi.ApiChargersLifetimeEnergyIdYearlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |
| **tz** | **string?** |  | [optional]  |

### Return type

[**List&lt;EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy&gt;**](EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy.md)

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

