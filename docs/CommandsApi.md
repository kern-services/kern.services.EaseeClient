# kern.services.EaseeClient.Api.CommandsApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiCommandsDeviceCommandTicksGet**](CommandsApi.md#apicommandsdevicecommandticksget) | **GET** /api/commands/{device}/{command}/{ticks} | Get State |

<a name="apicommandsdevicecommandticksget"></a>
# **ApiCommandsDeviceCommandTicksGet**
> EaseeCoreDTOsCommandsCommandResponseDto ApiCommandsDeviceCommandTicksGet (string device, int command, long ticks)

Get State

Gets the state of a command. Status can be  1-Sent, 2-Expired, 3-Executed og 4-Rejected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiCommandsDeviceCommandTicksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CommandsApi(config);
            var device = "device_example";  // string | Serial number
            var command = 56;  // int | Command ID
            var ticks = 789L;  // long | Timestamp set by sender in ticks

            try
            {
                // Get State
                EaseeCoreDTOsCommandsCommandResponseDto result = apiInstance.ApiCommandsDeviceCommandTicksGet(device, command, ticks);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommandsApi.ApiCommandsDeviceCommandTicksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiCommandsDeviceCommandTicksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get State
    ApiResponse<EaseeCoreDTOsCommandsCommandResponseDto> response = apiInstance.ApiCommandsDeviceCommandTicksGetWithHttpInfo(device, command, ticks);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommandsApi.ApiCommandsDeviceCommandTicksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **device** | **string** | Serial number |  |
| **command** | **int** | Command ID |  |
| **ticks** | **long** | Timestamp set by sender in ticks |  |

### Return type

[**EaseeCoreDTOsCommandsCommandResponseDto**](EaseeCoreDTOsCommandsCommandResponseDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Detailed response about command state |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **404** | Unable to find a command matching the input parameters |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

