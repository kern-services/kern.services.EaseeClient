# kern.services.EaseeClient.Api.ResourcesApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiResourcesCountriesActiveGet**](ResourcesApi.md#apiresourcescountriesactiveget) | **GET** /api/resources/countries/active | Active Countries |
| [**ApiResourcesCountriesGet**](ResourcesApi.md#apiresourcescountriesget) | **GET** /api/resources/countries | Countries |
| [**ApiResourcesCurrenciesGet**](ResourcesApi.md#apiresourcescurrenciesget) | **GET** /api/resources/currencies | Currencies |
| [**ApiResourcesObservationPropertiesGet**](ResourcesApi.md#apiresourcesobservationpropertiesget) | **GET** /api/resources/observation_properties | Observations Properties |

<a name="apiresourcescountriesactiveget"></a>
# **ApiResourcesCountriesActiveGet**
> List&lt;EaseeCoreDTOsSiteCountryDTO&gt; ApiResourcesCountriesActiveGet ()

Active Countries

Get active countries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiResourcesCountriesActiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourcesApi(config);

            try
            {
                // Active Countries
                List<EaseeCoreDTOsSiteCountryDTO> result = apiInstance.ApiResourcesCountriesActiveGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourcesApi.ApiResourcesCountriesActiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiResourcesCountriesActiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Active Countries
    ApiResponse<List<EaseeCoreDTOsSiteCountryDTO>> response = apiInstance.ApiResourcesCountriesActiveGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourcesApi.ApiResourcesCountriesActiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EaseeCoreDTOsSiteCountryDTO&gt;**](EaseeCoreDTOsSiteCountryDTO.md)

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

<a name="apiresourcescountriesget"></a>
# **ApiResourcesCountriesGet**
> List&lt;EaseeCoreDTOsSiteCountryDTO&gt; ApiResourcesCountriesGet ()

Countries

Get countries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiResourcesCountriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourcesApi(config);

            try
            {
                // Countries
                List<EaseeCoreDTOsSiteCountryDTO> result = apiInstance.ApiResourcesCountriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourcesApi.ApiResourcesCountriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiResourcesCountriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Countries
    ApiResponse<List<EaseeCoreDTOsSiteCountryDTO>> response = apiInstance.ApiResourcesCountriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourcesApi.ApiResourcesCountriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EaseeCoreDTOsSiteCountryDTO&gt;**](EaseeCoreDTOsSiteCountryDTO.md)

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

<a name="apiresourcescurrenciesget"></a>
# **ApiResourcesCurrenciesGet**
> List&lt;EaseeCoreModelsSiteCurrency&gt; ApiResourcesCurrenciesGet ()

Currencies

Get currencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiResourcesCurrenciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourcesApi(config);

            try
            {
                // Currencies
                List<EaseeCoreModelsSiteCurrency> result = apiInstance.ApiResourcesCurrenciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourcesApi.ApiResourcesCurrenciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiResourcesCurrenciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Currencies
    ApiResponse<List<EaseeCoreModelsSiteCurrency>> response = apiInstance.ApiResourcesCurrenciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourcesApi.ApiResourcesCurrenciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EaseeCoreModelsSiteCurrency&gt;**](EaseeCoreModelsSiteCurrency.md)

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

<a name="apiresourcesobservationpropertiesget"></a>
# **ApiResourcesObservationPropertiesGet**
> List&lt;EaseeCoreDTOsChargerObservationPropertyDTO&gt; ApiResourcesObservationPropertiesGet ()

Observations Properties

Gets all Observation Properties (ID and name).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiResourcesObservationPropertiesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourcesApi(config);

            try
            {
                // Observations Properties
                List<EaseeCoreDTOsChargerObservationPropertyDTO> result = apiInstance.ApiResourcesObservationPropertiesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourcesApi.ApiResourcesObservationPropertiesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiResourcesObservationPropertiesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Observations Properties
    ApiResponse<List<EaseeCoreDTOsChargerObservationPropertyDTO>> response = apiInstance.ApiResourcesObservationPropertiesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourcesApi.ApiResourcesObservationPropertiesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EaseeCoreDTOsChargerObservationPropertyDTO&gt;**](EaseeCoreDTOsChargerObservationPropertyDTO.md)

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

