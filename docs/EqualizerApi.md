# kern.services.EaseeClient.Api.EqualizerApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPost**](EqualizerApi.md#apiequalizersidcommandsconfiguremaxallocatedcurrentpost) | **POST** /api/equalizers/{id}/commands/configure_max_allocated_current | Set max allocated current |
| [**ApiEqualizersIdCommandsConfigureMeterTypePost**](EqualizerApi.md#apiequalizersidcommandsconfiguremetertypepost) | **POST** /api/equalizers/{id}/commands/configure_meter_type | Configure Meter Type |
| [**ApiEqualizersIdCommandsRebootPost**](EqualizerApi.md#apiequalizersidcommandsrebootpost) | **POST** /api/equalizers/{id}/commands/reboot | Reboot |
| [**ApiEqualizersIdCommandsUpdateFirmwarePost**](EqualizerApi.md#apiequalizersidcommandsupdatefirmwarepost) | **POST** /api/equalizers/{id}/commands/update_firmware | Update Firmware |
| [**ApiEqualizersIdConfigGet**](EqualizerApi.md#apiequalizersidconfigget) | **GET** /api/equalizers/{id}/config | Configuration |
| [**ApiEqualizersIdDetailsGet**](EqualizerApi.md#apiequalizersiddetailsget) | **GET** /api/equalizers/{id}/details | Equalizer Details |
| [**ApiEqualizersIdGet**](EqualizerApi.md#apiequalizersidget) | **GET** /api/equalizers/{id} | Equalizer |
| [**ApiEqualizersIdSiteGet**](EqualizerApi.md#apiequalizersidsiteget) | **GET** /api/equalizers/{id}/site | Site |
| [**ApiEqualizersIdStateGet**](EqualizerApi.md#apiequalizersidstateget) | **GET** /api/equalizers/{id}/state | State |

<a name="apiequalizersidcommandsconfiguremaxallocatedcurrentpost"></a>
# **ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPost**
> void ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPost (string id, EaseeCoreDTOsEqualizerMaxAllocatedCurrentDTO? easeeCoreDTOsEqualizerMaxAllocatedCurrentDTO = null)

Set max allocated current

Configure max allocated current for the whole charge installation  Rate limited max 1 requests per minute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID
            var easeeCoreDTOsEqualizerMaxAllocatedCurrentDTO = new EaseeCoreDTOsEqualizerMaxAllocatedCurrentDTO?(); // EaseeCoreDTOsEqualizerMaxAllocatedCurrentDTO? | Max current allocated settings (optional) 

            try
            {
                // Set max allocated current
                apiInstance.ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPost(id, easeeCoreDTOsEqualizerMaxAllocatedCurrentDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set max allocated current
    apiInstance.ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPostWithHttpInfo(id, easeeCoreDTOsEqualizerMaxAllocatedCurrentDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsConfigureMaxAllocatedCurrentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |
| **easeeCoreDTOsEqualizerMaxAllocatedCurrentDTO** | [**EaseeCoreDTOsEqualizerMaxAllocatedCurrentDTO?**](EaseeCoreDTOsEqualizerMaxAllocatedCurrentDTO?.md) | Max current allocated settings | [optional]  |

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
| **200** | Success |  -  |
| **202** | Command successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot; hub and  match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiequalizersidcommandsconfiguremetertypepost"></a>
# **ApiEqualizersIdCommandsConfigureMeterTypePost**
> void ApiEqualizersIdCommandsConfigureMeterTypePost (string id, EaseeCoreDTOsEqualizerMeterSettingsDTO? easeeCoreDTOsEqualizerMeterSettingsDTO = null)

Configure Meter Type

Configure the meter type for an equalizer. To change the equalizer meter type from P1/HAN to Modbus, set <i>deviceMode</i> to 2 and set the <i>externalMeterType</i>(1-4)  To change the equalizer back to P1/HAN set only <i>deviceMode</i> to 1 since <i>externalMeterType</i> is only applicable to Modbus  Rate limited at max 1 request per minute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdCommandsConfigureMeterTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID
            var easeeCoreDTOsEqualizerMeterSettingsDTO = new EaseeCoreDTOsEqualizerMeterSettingsDTO?(); // EaseeCoreDTOsEqualizerMeterSettingsDTO? | Meter settings (optional) 

            try
            {
                // Configure Meter Type
                apiInstance.ApiEqualizersIdCommandsConfigureMeterTypePost(id, easeeCoreDTOsEqualizerMeterSettingsDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsConfigureMeterTypePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdCommandsConfigureMeterTypePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configure Meter Type
    apiInstance.ApiEqualizersIdCommandsConfigureMeterTypePostWithHttpInfo(id, easeeCoreDTOsEqualizerMeterSettingsDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsConfigureMeterTypePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |
| **easeeCoreDTOsEqualizerMeterSettingsDTO** | [**EaseeCoreDTOsEqualizerMeterSettingsDTO?**](EaseeCoreDTOsEqualizerMeterSettingsDTO?.md) | Meter settings | [optional]  |

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
| **200** | Success |  -  |
| **202** | Command successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot; hub and  match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiequalizersidcommandsrebootpost"></a>
# **ApiEqualizersIdCommandsRebootPost**
> void ApiEqualizersIdCommandsRebootPost (string id)

Reboot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdCommandsRebootPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID

            try
            {
                // Reboot
                apiInstance.ApiEqualizersIdCommandsRebootPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsRebootPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdCommandsRebootPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reboot
    apiInstance.ApiEqualizersIdCommandsRebootPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsRebootPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |

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
| **202** | Command successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot; hub and  match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiequalizersidcommandsupdatefirmwarepost"></a>
# **ApiEqualizersIdCommandsUpdateFirmwarePost**
> void ApiEqualizersIdCommandsUpdateFirmwarePost (string id)

Update Firmware

Updates firmware to latest public release

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdCommandsUpdateFirmwarePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID

            try
            {
                // Update Firmware
                apiInstance.ApiEqualizersIdCommandsUpdateFirmwarePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsUpdateFirmwarePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdCommandsUpdateFirmwarePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Firmware
    apiInstance.ApiEqualizersIdCommandsUpdateFirmwarePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdCommandsUpdateFirmwarePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |

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
| **202** | All commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot;  hub and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiequalizersidconfigget"></a>
# **ApiEqualizersIdConfigGet**
> EaseeCoreDTOsEqualizerEqualizerConfigurationDTO ApiEqualizersIdConfigGet (string id)

Configuration

Get equalizer configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdConfigGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID

            try
            {
                // Configuration
                EaseeCoreDTOsEqualizerEqualizerConfigurationDTO result = apiInstance.ApiEqualizersIdConfigGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdConfigGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdConfigGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configuration
    ApiResponse<EaseeCoreDTOsEqualizerEqualizerConfigurationDTO> response = apiInstance.ApiEqualizersIdConfigGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdConfigGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |

### Return type

[**EaseeCoreDTOsEqualizerEqualizerConfigurationDTO**](EaseeCoreDTOsEqualizerEqualizerConfigurationDTO.md)

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

<a name="apiequalizersiddetailsget"></a>
# **ApiEqualizersIdDetailsGet**
> EaseeCoreDTOsEqualizerDetailedEqualizerDTO ApiEqualizersIdDetailsGet (string id)

Equalizer Details

Get equalizer details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID

            try
            {
                // Equalizer Details
                EaseeCoreDTOsEqualizerDetailedEqualizerDTO result = apiInstance.ApiEqualizersIdDetailsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Equalizer Details
    ApiResponse<EaseeCoreDTOsEqualizerDetailedEqualizerDTO> response = apiInstance.ApiEqualizersIdDetailsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |

### Return type

[**EaseeCoreDTOsEqualizerDetailedEqualizerDTO**](EaseeCoreDTOsEqualizerDetailedEqualizerDTO.md)

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

<a name="apiequalizersidget"></a>
# **ApiEqualizersIdGet**
> EaseeCoreDTOsEqualizerEqualizerDTO ApiEqualizersIdGet (string id)

Equalizer

Get equalizer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID

            try
            {
                // Equalizer
                EaseeCoreDTOsEqualizerEqualizerDTO result = apiInstance.ApiEqualizersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Equalizer
    ApiResponse<EaseeCoreDTOsEqualizerEqualizerDTO> response = apiInstance.ApiEqualizersIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |

### Return type

[**EaseeCoreDTOsEqualizerEqualizerDTO**](EaseeCoreDTOsEqualizerEqualizerDTO.md)

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

<a name="apiequalizersidsiteget"></a>
# **ApiEqualizersIdSiteGet**
> EaseeCoreDTOsSiteSiteDTO ApiEqualizersIdSiteGet (string id)

Site

Get equalizer site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdSiteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID

            try
            {
                // Site
                EaseeCoreDTOsSiteSiteDTO result = apiInstance.ApiEqualizersIdSiteGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdSiteGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdSiteGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Site
    ApiResponse<EaseeCoreDTOsSiteSiteDTO> response = apiInstance.ApiEqualizersIdSiteGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdSiteGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |

### Return type

[**EaseeCoreDTOsSiteSiteDTO**](EaseeCoreDTOsSiteSiteDTO.md)

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

<a name="apiequalizersidstateget"></a>
# **ApiEqualizersIdStateGet**
> EaseeCoreDTOsEqualizerEqualizerStateDTO ApiEqualizersIdStateGet (string id)

State

Get current equalizer state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiEqualizersIdStateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EqualizerApi(config);
            var id = "id_example";  // string | Equalizer ID

            try
            {
                // State
                EaseeCoreDTOsEqualizerEqualizerStateDTO result = apiInstance.ApiEqualizersIdStateGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdStateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEqualizersIdStateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // State
    ApiResponse<EaseeCoreDTOsEqualizerEqualizerStateDTO> response = apiInstance.ApiEqualizersIdStateGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EqualizerApi.ApiEqualizersIdStateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Equalizer ID |  |

### Return type

[**EaseeCoreDTOsEqualizerEqualizerStateDTO**](EaseeCoreDTOsEqualizerEqualizerStateDTO.md)

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

