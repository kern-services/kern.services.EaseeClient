# kern.services.EaseeClient.Api.ConsumptionApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiConsumptionTotalGet**](ConsumptionApi.md#apiconsumptiontotalget) | **GET** /api/consumption/total | Get total consumption endpoint |

<a name="apiconsumptiontotalget"></a>
# **ApiConsumptionTotalGet**
> List&lt;EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionPeriod&gt; ApiConsumptionTotalGet (List<string>? chargerIds = null, DateTime? fromDateTimeUtc = null, DateTime? toDateTimeUtc = null, EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionAggregationType? grouping = null, string? tz = null)

Get total consumption endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiConsumptionTotalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConsumptionApi(config);
            var chargerIds = new List<string>?(); // List<string>? |  (optional) 
            var fromDateTimeUtc = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTimeUtc = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var grouping = new EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionAggregationType?(); // EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionAggregationType? |  (optional) 
            var tz = "\"GMT\"";  // string? |  (optional)  (default to "GMT")

            try
            {
                // Get total consumption endpoint
                List<EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionPeriod> result = apiInstance.ApiConsumptionTotalGet(chargerIds, fromDateTimeUtc, toDateTimeUtc, grouping, tz);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsumptionApi.ApiConsumptionTotalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConsumptionTotalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get total consumption endpoint
    ApiResponse<List<EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionPeriod>> response = apiInstance.ApiConsumptionTotalGetWithHttpInfo(chargerIds, fromDateTimeUtc, toDateTimeUtc, grouping, tz);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsumptionApi.ApiConsumptionTotalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargerIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fromDateTimeUtc** | **DateTime?** |  | [optional]  |
| **toDateTimeUtc** | **DateTime?** |  | [optional]  |
| **grouping** | [**EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionAggregationType?**](EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionAggregationType?.md) |  | [optional]  |
| **tz** | **string?** |  | [optional] [default to &quot;GMT&quot;] |

### Return type

[**List&lt;EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionPeriod&gt;**](EaseeBusinessLayerManagersTotalConsumptionTotalConsumptionPeriod.md)

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

