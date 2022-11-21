# kern.services.EaseeClient.Api.ChargerApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiChargersAcceptPost**](ChargerApi.md#apichargersacceptpost) | **POST** /api/chargers/accept | Accept Invitation |
| [**ApiChargersGet**](ChargerApi.md#apichargersget) | **GET** /api/chargers | Chargers |
| [**ApiChargersIdAccessDelete**](ChargerApi.md#apichargersidaccessdelete) | **DELETE** /api/chargers/{id}/access | Remove Charger Access |
| [**ApiChargersIdAccessPut**](ChargerApi.md#apichargersidaccessput) | **PUT** /api/chargers/{id}/access | Set Charger Access |
| [**ApiChargersIdBasicChargePlanDelete**](ChargerApi.md#apichargersidbasicchargeplandelete) | **DELETE** /api/chargers/{id}/basic_charge_plan | Delete Basic Charge Plan |
| [**ApiChargersIdBasicChargePlanGet**](ChargerApi.md#apichargersidbasicchargeplanget) | **GET** /api/chargers/{id}/basic_charge_plan | Basic Charge Plan |
| [**ApiChargersIdBasicChargePlanPost**](ChargerApi.md#apichargersidbasicchargeplanpost) | **POST** /api/chargers/{id}/basic_charge_plan | Set Basic Charge Plan |
| [**ApiChargersIdChargeScheduleFeaturesPost**](ChargerApi.md#apichargersidchargeschedulefeaturespost) | **POST** /api/chargers/{id}/charge_schedule/features | Turn on or off charge schedule features. |
| [**ApiChargersIdCommandsLockStatePost**](ChargerApi.md#apichargersidcommandslockstatepost) | **POST** /api/chargers/{id}/commands/lock_state | Set Cable Lock State |
| [**ApiChargersIdCommandsOverrideSchedulePost**](ChargerApi.md#apichargersidcommandsoverrideschedulepost) | **POST** /api/chargers/{id}/commands/override_schedule | Override Charging Schedule |
| [**ApiChargersIdCommandsPauseChargingPost**](ChargerApi.md#apichargersidcommandspausechargingpost) | **POST** /api/chargers/{id}/commands/pause_charging | Pause Charging |
| [**ApiChargersIdCommandsPollChargeropmodePost**](ChargerApi.md#apichargersidcommandspollchargeropmodepost) | **POST** /api/chargers/{id}/commands/poll_chargeropmode | Polls for a new Charger Op Mode |
| [**ApiChargersIdCommandsPollLifetimeenergyPost**](ChargerApi.md#apichargersidcommandspolllifetimeenergypost) | **POST** /api/chargers/{id}/commands/poll_lifetimeenergy | Polls for a new Energy Reading |
| [**ApiChargersIdCommandsRebootPost**](ChargerApi.md#apichargersidcommandsrebootpost) | **POST** /api/chargers/{id}/commands/reboot | Reboot |
| [**ApiChargersIdCommandsResumeChargingPost**](ChargerApi.md#apichargersidcommandsresumechargingpost) | **POST** /api/chargers/{id}/commands/resume_charging | Resume Charging |
| [**ApiChargersIdCommandsScanWifiPost**](ChargerApi.md#apichargersidcommandsscanwifipost) | **POST** /api/chargers/{id}/commands/scan_wifi | Scan Wi-Fi |
| [**ApiChargersIdCommandsSetRfidPairingModeAsyncPost**](ChargerApi.md#apichargersidcommandssetrfidpairingmodeasyncpost) | **POST** /api/chargers/{id}/commands/set_rfid_pairing_mode_async | Pair RFID Tag |
| [**ApiChargersIdCommandsSetWifiConfigPost**](ChargerApi.md#apichargersidcommandssetwificonfigpost) | **POST** /api/chargers/{id}/commands/set_wifi_config | Set Wi-Fi Configuration |
| [**ApiChargersIdCommandsSmartChargingPost**](ChargerApi.md#apichargersidcommandssmartchargingpost) | **POST** /api/chargers/{id}/commands/smart_charging | Enable Smart Charging |
| [**ApiChargersIdCommandsStartChargingPost**](ChargerApi.md#apichargersidcommandsstartchargingpost) | **POST** /api/chargers/{id}/commands/start_charging | Start Charging |
| [**ApiChargersIdCommandsStopChargingPost**](ChargerApi.md#apichargersidcommandsstopchargingpost) | **POST** /api/chargers/{id}/commands/stop_charging | Stop Charging |
| [**ApiChargersIdCommandsToggleChargingPost**](ChargerApi.md#apichargersidcommandstogglechargingpost) | **POST** /api/chargers/{id}/commands/toggle_charging | Toggle Charging |
| [**ApiChargersIdCommandsUpdateFirmwarePost**](ChargerApi.md#apichargersidcommandsupdatefirmwarepost) | **POST** /api/chargers/{id}/commands/update_firmware | Update Firmware |
| [**ApiChargersIdCommentsGet**](ChargerApi.md#apichargersidcommentsget) | **GET** /api/chargers/{id}/comments | Comments |
| [**ApiChargersIdConfigGet**](ChargerApi.md#apichargersidconfigget) | **GET** /api/chargers/{id}/config | Get Configuration |
| [**ApiChargersIdDetailsGet**](ChargerApi.md#apichargersiddetailsget) | **GET** /api/chargers/{id}/details | Charger Details |
| [**ApiChargersIdErrorsFromToGet**](ChargerApi.md#apichargersiderrorsfromtoget) | **GET** /api/chargers/{id}/errors/{from}/{to} | Errors |
| [**ApiChargersIdGet**](ChargerApi.md#apichargersidget) | **GET** /api/chargers/{id} | Charger |
| [**ApiChargersIdLogEventsLogTypeFromToGet**](ChargerApi.md#apichargersidlogeventslogtypefromtoget) | **GET** /api/chargers/{id}/log_events/{logType}/{from}/{to} | Log Events |
| [**ApiChargersIdObservationsObservationIdFromToGet**](ChargerApi.md#apichargersidobservationsobservationidfromtoget) | **GET** /api/chargers/{id}/observations/{observationId}/{from}/{to} | Observations |
| [**ApiChargersIdPairPost**](ChargerApi.md#apichargersidpairpost) | **POST** /api/chargers/{id}/pair | Pair |
| [**ApiChargersIdPartnersGet**](ChargerApi.md#apichargersidpartnersget) | **GET** /api/chargers/{id}/partners | Partner |
| [**ApiChargersIdPartnersPartnerIdDelete**](ChargerApi.md#apichargersidpartnerspartneriddelete) | **DELETE** /api/chargers/{id}/partners/{partnerId} | Remove Partner |
| [**ApiChargersIdPartnersPost**](ChargerApi.md#apichargersidpartnerspost) | **POST** /api/chargers/{id}/partners | Set Partner |
| [**ApiChargersIdPermissionDelete**](ChargerApi.md#apichargersidpermissiondelete) | **DELETE** /api/chargers/{id}/permission | Remove Charger Access |
| [**ApiChargersIdPermissionGet**](ChargerApi.md#apichargersidpermissionget) | **GET** /api/chargers/{id}/permission | Permissions |
| [**ApiChargersIdPermissionPost**](ChargerApi.md#apichargersidpermissionpost) | **POST** /api/chargers/{id}/permission | Grant Charger Access |
| [**ApiChargersIdSessionsLatestGet**](ChargerApi.md#apichargersidsessionslatestget) | **GET** /api/chargers/{id}/sessions/latest | Latest Charging Session |
| [**ApiChargersIdSessionsOngoingGet**](ChargerApi.md#apichargersidsessionsongoingget) | **GET** /api/chargers/{id}/sessions/ongoing | Ongoing Charging Session |
| [**ApiChargersIdSettingsPost**](ChargerApi.md#apichargersidsettingspost) | **POST** /api/chargers/{id}/settings | Change Charger Settings |
| [**ApiChargersIdSiteGet**](ChargerApi.md#apichargersidsiteget) | **GET** /api/chargers/{id}/site | Site |
| [**ApiChargersIdStateGet**](ChargerApi.md#apichargersidstateget) | **GET** /api/chargers/{id}/state | State |
| [**ApiChargersIdUnpairPost**](ChargerApi.md#apichargersidunpairpost) | **POST** /api/chargers/{id}/unpair | Unpair |
| [**ApiChargersIdUsageHourlyFromToGet**](ChargerApi.md#apichargersidusagehourlyfromtoget) | **GET** /api/chargers/{id}/usage/hourly/{from}/{to} | Power Usage |
| [**ApiChargersIdWeeklyChargePlanDelete**](ChargerApi.md#apichargersidweeklychargeplandelete) | **DELETE** /api/chargers/{id}/weekly_charge_plan | Remove Weekly Charge Plan |
| [**ApiChargersIdWeeklyChargePlanGet**](ChargerApi.md#apichargersidweeklychargeplanget) | **GET** /api/chargers/{id}/weekly_charge_plan | Weekly Charge Plan |
| [**ApiChargersIdWeeklyChargePlanPost**](ChargerApi.md#apichargersidweeklychargeplanpost) | **POST** /api/chargers/{id}/weekly_charge_plan | Set Weekly Charge Plan |

<a name="apichargersacceptpost"></a>
# **ApiChargersAcceptPost**
> void ApiChargersAcceptPost (string? email = null, string? invitationId = null)

Accept Invitation

Accept user invitation to access a charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersAcceptPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var email = "email_example";  // string? | Charger user permission invitation acceptance token (optional) 
            var invitationId = "invitationId_example";  // string? | Charger user permission invitation acceptance invitation_id (optional) 

            try
            {
                // Accept Invitation
                apiInstance.ApiChargersAcceptPost(email, invitationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersAcceptPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersAcceptPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept Invitation
    apiInstance.ApiChargersAcceptPostWithHttpInfo(email, invitationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersAcceptPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string?** | Charger user permission invitation acceptance token | [optional]  |
| **invitationId** | **string?** | Charger user permission invitation acceptance invitation_id | [optional]  |

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

<a name="apichargersget"></a>
# **ApiChargersGet**
> List&lt;EaseeCoreDTOsChargerBasicChargerDTO&gt; ApiChargersGet ()

Chargers

Get chargers.<br />If role is Partner, all partner chargers will be returned.<br />If role is User, the users  chargers will be returned.<br />Rate limited: Rate limited at max 2 requests per minute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);

            try
            {
                // Chargers
                List<EaseeCoreDTOsChargerBasicChargerDTO> result = apiInstance.ApiChargersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Chargers
    ApiResponse<List<EaseeCoreDTOsChargerBasicChargerDTO>> response = apiInstance.ApiChargersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EaseeCoreDTOsChargerBasicChargerDTO&gt;**](EaseeCoreDTOsChargerBasicChargerDTO.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidaccessdelete"></a>
# **ApiChargersIdAccessDelete**
> void ApiChargersIdAccessDelete (string id)

Remove Charger Access

Delete access level from the charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdAccessDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Remove Charger Access
                apiInstance.ApiChargersIdAccessDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdAccessDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdAccessDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Charger Access
    apiInstance.ApiChargersIdAccessDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdAccessDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidaccessput"></a>
# **ApiChargersIdAccessPut**
> void ApiChargersIdAccessPut (string id, int? body = null)

Set Charger Access

Set access level to the charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdAccessPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var body = 56;  // int? | Access level (optional) 

            try
            {
                // Set Charger Access
                apiInstance.ApiChargersIdAccessPut(id, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdAccessPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdAccessPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Charger Access
    apiInstance.ApiChargersIdAccessPutWithHttpInfo(id, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdAccessPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **body** | **int?** | Access level | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidbasicchargeplandelete"></a>
# **ApiChargersIdBasicChargePlanDelete**
> void ApiChargersIdBasicChargePlanDelete (string id)

Delete Basic Charge Plan

Delete basic charge plan of charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdBasicChargePlanDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Delete Basic Charge Plan
                apiInstance.ApiChargersIdBasicChargePlanDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdBasicChargePlanDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdBasicChargePlanDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Basic Charge Plan
    apiInstance.ApiChargersIdBasicChargePlanDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdBasicChargePlanDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidbasicchargeplanget"></a>
# **ApiChargersIdBasicChargePlanGet**
> List&lt;EaseeCoreDTOsChargerChargePlanDTO&gt; ApiChargersIdBasicChargePlanGet (string id)

Basic Charge Plan

Get basic charge plan of charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdBasicChargePlanGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Basic Charge Plan
                List<EaseeCoreDTOsChargerChargePlanDTO> result = apiInstance.ApiChargersIdBasicChargePlanGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdBasicChargePlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdBasicChargePlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Basic Charge Plan
    ApiResponse<List<EaseeCoreDTOsChargerChargePlanDTO>> response = apiInstance.ApiChargersIdBasicChargePlanGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdBasicChargePlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**List&lt;EaseeCoreDTOsChargerChargePlanDTO&gt;**](EaseeCoreDTOsChargerChargePlanDTO.md)

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

<a name="apichargersidbasicchargeplanpost"></a>
# **ApiChargersIdBasicChargePlanPost**
> void ApiChargersIdBasicChargePlanPost (string id, EaseeCoreDTOsChargerChargePlanDTO? easeeCoreDTOsChargerChargePlanDTO = null)

Set Basic Charge Plan

Set basic charge plan of charger. IsEnabled attribute allow to IsEnabled the charge plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdBasicChargePlanPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeCoreDTOsChargerChargePlanDTO = new EaseeCoreDTOsChargerChargePlanDTO?(); // EaseeCoreDTOsChargerChargePlanDTO? | Charge plan (optional) 

            try
            {
                // Set Basic Charge Plan
                apiInstance.ApiChargersIdBasicChargePlanPost(id, easeeCoreDTOsChargerChargePlanDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdBasicChargePlanPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdBasicChargePlanPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Basic Charge Plan
    apiInstance.ApiChargersIdBasicChargePlanPostWithHttpInfo(id, easeeCoreDTOsChargerChargePlanDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdBasicChargePlanPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeCoreDTOsChargerChargePlanDTO** | [**EaseeCoreDTOsChargerChargePlanDTO?**](EaseeCoreDTOsChargerChargePlanDTO?.md) | Charge plan | [optional]  |

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
| **202** | All commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot;  hub and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidchargeschedulefeaturespost"></a>
# **ApiChargersIdChargeScheduleFeaturesPost**
> void ApiChargersIdChargeScheduleFeaturesPost (string id, EaseeCoreDTOsScheduleScheduleFeatureRequestDto? easeeCoreDTOsScheduleScheduleFeatureRequestDto = null)

Turn on or off charge schedule features.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdChargeScheduleFeaturesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | charger id
            var easeeCoreDTOsScheduleScheduleFeatureRequestDto = new EaseeCoreDTOsScheduleScheduleFeatureRequestDto?(); // EaseeCoreDTOsScheduleScheduleFeatureRequestDto? | charge schedule feature request (optional) 

            try
            {
                // Turn on or off charge schedule features.
                apiInstance.ApiChargersIdChargeScheduleFeaturesPost(id, easeeCoreDTOsScheduleScheduleFeatureRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdChargeScheduleFeaturesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdChargeScheduleFeaturesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Turn on or off charge schedule features.
    apiInstance.ApiChargersIdChargeScheduleFeaturesPostWithHttpInfo(id, easeeCoreDTOsScheduleScheduleFeatureRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdChargeScheduleFeaturesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | charger id |  |
| **easeeCoreDTOsScheduleScheduleFeatureRequestDto** | [**EaseeCoreDTOsScheduleScheduleFeatureRequestDto?**](EaseeCoreDTOsScheduleScheduleFeatureRequestDto?.md) | charge schedule feature request | [optional]  |

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
| **202** | All commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot;  hub and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidcommandslockstatepost"></a>
# **ApiChargersIdCommandsLockStatePost**
> void ApiChargersIdCommandsLockStatePost (string id, EaseeCoreDTOsChargerLockStateDTO? easeeCoreDTOsChargerLockStateDTO = null)

Set Cable Lock State

If state = true, cable always locked in charger. state = false, cable is unlocked when car is disconnected

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsLockStatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeCoreDTOsChargerLockStateDTO = new EaseeCoreDTOsChargerLockStateDTO?(); // EaseeCoreDTOsChargerLockStateDTO? | Cable lock state (optional) 

            try
            {
                // Set Cable Lock State
                apiInstance.ApiChargersIdCommandsLockStatePost(id, easeeCoreDTOsChargerLockStateDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsLockStatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsLockStatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Cable Lock State
    apiInstance.ApiChargersIdCommandsLockStatePostWithHttpInfo(id, easeeCoreDTOsChargerLockStateDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsLockStatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeCoreDTOsChargerLockStateDTO** | [**EaseeCoreDTOsChargerLockStateDTO?**](EaseeCoreDTOsChargerLockStateDTO?.md) | Cable lock state | [optional]  |

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
| **202** | Commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot; hub  and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidcommandsoverrideschedulepost"></a>
# **ApiChargersIdCommandsOverrideSchedulePost**
> void ApiChargersIdCommandsOverrideSchedulePost (string id)

Override Charging Schedule

Allows current session to charge immediately provided that schedule is the only mechanism stopping charge  currently.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsOverrideSchedulePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Override Charging Schedule
                apiInstance.ApiChargersIdCommandsOverrideSchedulePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsOverrideSchedulePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsOverrideSchedulePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Override Charging Schedule
    apiInstance.ApiChargersIdCommandsOverrideSchedulePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsOverrideSchedulePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommandspausechargingpost"></a>
# **ApiChargersIdCommandsPauseChargingPost**
> void ApiChargersIdCommandsPauseChargingPost (string id)

Pause Charging

Pauses current charging session but keeps authorization. Limits dynamic charger current to 0. <br />Reset on  on new car connection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsPauseChargingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Pause Charging
                apiInstance.ApiChargersIdCommandsPauseChargingPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsPauseChargingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsPauseChargingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pause Charging
    apiInstance.ApiChargersIdCommandsPauseChargingPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsPauseChargingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommandspollchargeropmodepost"></a>
# **ApiChargersIdCommandsPollChargeropmodePost**
> void ApiChargersIdCommandsPollChargeropmodePost (string id)

Polls for a new Charger Op Mode

Rate limited to once every 3 minutes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsPollChargeropmodePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Polls for a new Charger Op Mode
                apiInstance.ApiChargersIdCommandsPollChargeropmodePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsPollChargeropmodePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsPollChargeropmodePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Polls for a new Charger Op Mode
    apiInstance.ApiChargersIdCommandsPollChargeropmodePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsPollChargeropmodePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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
| **202** | Commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot; hub  and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidcommandspolllifetimeenergypost"></a>
# **ApiChargersIdCommandsPollLifetimeenergyPost**
> void ApiChargersIdCommandsPollLifetimeenergyPost (string id)

Polls for a new Energy Reading

Rate limited to once every 3 minutes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsPollLifetimeenergyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Polls for a new Energy Reading
                apiInstance.ApiChargersIdCommandsPollLifetimeenergyPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsPollLifetimeenergyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsPollLifetimeenergyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Polls for a new Energy Reading
    apiInstance.ApiChargersIdCommandsPollLifetimeenergyPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsPollLifetimeenergyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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
| **202** | Commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot; hub  and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidcommandsrebootpost"></a>
# **ApiChargersIdCommandsRebootPost**
> void ApiChargersIdCommandsRebootPost (string id)

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
    public class ApiChargersIdCommandsRebootPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Reboot
                apiInstance.ApiChargersIdCommandsRebootPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsRebootPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsRebootPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reboot
    apiInstance.ApiChargersIdCommandsRebootPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsRebootPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommandsresumechargingpost"></a>
# **ApiChargersIdCommandsResumeChargingPost**
> void ApiChargersIdCommandsResumeChargingPost (string id)

Resume Charging

Resumes current charging session. Resets output current limit set in dynamic charger current

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsResumeChargingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Resume Charging
                apiInstance.ApiChargersIdCommandsResumeChargingPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsResumeChargingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsResumeChargingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resume Charging
    apiInstance.ApiChargersIdCommandsResumeChargingPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsResumeChargingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommandsscanwifipost"></a>
# **ApiChargersIdCommandsScanWifiPost**
> void ApiChargersIdCommandsScanWifiPost (string id, EaseeCoreDTOsChargerScanWifiSettingDTO? easeeCoreDTOsChargerScanWifiSettingDTO = null)

Scan Wi-Fi

Sends a Wi-Fi scan command to the charger. Result available in SignalR command responses and observations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsScanWifiPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeCoreDTOsChargerScanWifiSettingDTO = new EaseeCoreDTOsChargerScanWifiSettingDTO?(); // EaseeCoreDTOsChargerScanWifiSettingDTO? | Limits the time spent by firmware to scan (optional) 

            try
            {
                // Scan Wi-Fi
                apiInstance.ApiChargersIdCommandsScanWifiPost(id, easeeCoreDTOsChargerScanWifiSettingDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsScanWifiPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsScanWifiPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan Wi-Fi
    apiInstance.ApiChargersIdCommandsScanWifiPostWithHttpInfo(id, easeeCoreDTOsChargerScanWifiSettingDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsScanWifiPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeCoreDTOsChargerScanWifiSettingDTO** | [**EaseeCoreDTOsChargerScanWifiSettingDTO?**](EaseeCoreDTOsChargerScanWifiSettingDTO?.md) | Limits the time spent by firmware to scan | [optional]  |

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

<a name="apichargersidcommandssetrfidpairingmodeasyncpost"></a>
# **ApiChargersIdCommandsSetRfidPairingModeAsyncPost**
> void ApiChargersIdCommandsSetRfidPairingModeAsyncPost (string id, EaseeCoreDTOsChargerPairRFIDSettingsDTO? easeeCoreDTOsChargerPairRFIDSettingsDTO = null)

Pair RFID Tag

Pair new RFID tag with charger. Listen to the \"CommandResponse\" stream and observation '69:PairedUserIDToken'  to get the new token as read by the charger

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsSetRfidPairingModeAsyncPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeCoreDTOsChargerPairRFIDSettingsDTO = new EaseeCoreDTOsChargerPairRFIDSettingsDTO?(); // EaseeCoreDTOsChargerPairRFIDSettingsDTO? | Pair RFID settings (optional) 

            try
            {
                // Pair RFID Tag
                apiInstance.ApiChargersIdCommandsSetRfidPairingModeAsyncPost(id, easeeCoreDTOsChargerPairRFIDSettingsDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsSetRfidPairingModeAsyncPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsSetRfidPairingModeAsyncPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pair RFID Tag
    apiInstance.ApiChargersIdCommandsSetRfidPairingModeAsyncPostWithHttpInfo(id, easeeCoreDTOsChargerPairRFIDSettingsDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsSetRfidPairingModeAsyncPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeCoreDTOsChargerPairRFIDSettingsDTO** | [**EaseeCoreDTOsChargerPairRFIDSettingsDTO?**](EaseeCoreDTOsChargerPairRFIDSettingsDTO?.md) | Pair RFID settings | [optional]  |

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
| **202** | All commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot;  hub and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidcommandssetwificonfigpost"></a>
# **ApiChargersIdCommandsSetWifiConfigPost**
> void ApiChargersIdCommandsSetWifiConfigPost (string id, EaseeCoreDTOsChargerWifiConfigDTO? easeeCoreDTOsChargerWifiConfigDTO = null)

Set Wi-Fi Configuration

Sends Wi-Fi configuration to the charger. The charger may be unavailable up to 1 hour if incorrect values are  set in firmware

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsSetWifiConfigPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeCoreDTOsChargerWifiConfigDTO = new EaseeCoreDTOsChargerWifiConfigDTO?(); // EaseeCoreDTOsChargerWifiConfigDTO? | SSID and Password (optional) 

            try
            {
                // Set Wi-Fi Configuration
                apiInstance.ApiChargersIdCommandsSetWifiConfigPost(id, easeeCoreDTOsChargerWifiConfigDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsSetWifiConfigPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsSetWifiConfigPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Wi-Fi Configuration
    apiInstance.ApiChargersIdCommandsSetWifiConfigPostWithHttpInfo(id, easeeCoreDTOsChargerWifiConfigDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsSetWifiConfigPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeCoreDTOsChargerWifiConfigDTO** | [**EaseeCoreDTOsChargerWifiConfigDTO?**](EaseeCoreDTOsChargerWifiConfigDTO?.md) | SSID and Password | [optional]  |

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
| **202** | Configuration successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot;  hub and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidcommandssmartchargingpost"></a>
# **ApiChargersIdCommandsSmartChargingPost**
> void ApiChargersIdCommandsSmartChargingPost (string id)

Enable Smart Charging

Disable by using the 'settings' endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsSmartChargingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Enable Smart Charging
                apiInstance.ApiChargersIdCommandsSmartChargingPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsSmartChargingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsSmartChargingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Smart Charging
    apiInstance.ApiChargersIdCommandsSmartChargingPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsSmartChargingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommandsstartchargingpost"></a>
# **ApiChargersIdCommandsStartChargingPost**
> void ApiChargersIdCommandsStartChargingPost (string id)

Start Charging

Allows a charger with 'authorizationRequired' = true to deliver power. Otherwise it will have no effect

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsStartChargingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Start Charging
                apiInstance.ApiChargersIdCommandsStartChargingPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsStartChargingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsStartChargingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start Charging
    apiInstance.ApiChargersIdCommandsStartChargingPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsStartChargingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommandsstopchargingpost"></a>
# **ApiChargersIdCommandsStopChargingPost**
> void ApiChargersIdCommandsStopChargingPost (string id)

Stop Charging

Stops a charger with an active authorization from delivering power and revokes authorization. Will have no  effect if 'authorizationRequired' is false or charger is not authorized

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsStopChargingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Stop Charging
                apiInstance.ApiChargersIdCommandsStopChargingPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsStopChargingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsStopChargingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stop Charging
    apiInstance.ApiChargersIdCommandsStopChargingPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsStopChargingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommandstogglechargingpost"></a>
# **ApiChargersIdCommandsToggleChargingPost**
> void ApiChargersIdCommandsToggleChargingPost (string id)

Toggle Charging

Send charging command (Start/Stop or Pause/Resume). For chargers requiring online authorization, start/stop  commands are used. <br />For chargers without online authorization,  pause/resume commands are used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommandsToggleChargingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Toggle Charging
                apiInstance.ApiChargersIdCommandsToggleChargingPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsToggleChargingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsToggleChargingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Toggle Charging
    apiInstance.ApiChargersIdCommandsToggleChargingPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsToggleChargingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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
| **202** | Commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot; hub  and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidcommandsupdatefirmwarepost"></a>
# **ApiChargersIdCommandsUpdateFirmwarePost**
> void ApiChargersIdCommandsUpdateFirmwarePost (string id)

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
    public class ApiChargersIdCommandsUpdateFirmwarePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Update Firmware
                apiInstance.ApiChargersIdCommandsUpdateFirmwarePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsUpdateFirmwarePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommandsUpdateFirmwarePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Firmware
    apiInstance.ApiChargersIdCommandsUpdateFirmwarePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommandsUpdateFirmwarePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidcommentsget"></a>
# **ApiChargersIdCommentsGet**
> List&lt;EaseeCoreDTOsChargerCommentDTO&gt; ApiChargersIdCommentsGet (string id)

Comments

Get user comments for a charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdCommentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Comments
                List<EaseeCoreDTOsChargerCommentDTO> result = apiInstance.ApiChargersIdCommentsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdCommentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Comments
    ApiResponse<List<EaseeCoreDTOsChargerCommentDTO>> response = apiInstance.ApiChargersIdCommentsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdCommentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**List&lt;EaseeCoreDTOsChargerCommentDTO&gt;**](EaseeCoreDTOsChargerCommentDTO.md)

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

<a name="apichargersidconfigget"></a>
# **ApiChargersIdConfigGet**
> EaseeCoreDTOsChargerChargerConfigurationDTO ApiChargersIdConfigGet (string id)

Get Configuration

Get charger configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdConfigGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Get Configuration
                EaseeCoreDTOsChargerChargerConfigurationDTO result = apiInstance.ApiChargersIdConfigGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdConfigGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdConfigGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Configuration
    ApiResponse<EaseeCoreDTOsChargerChargerConfigurationDTO> response = apiInstance.ApiChargersIdConfigGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdConfigGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeCoreDTOsChargerChargerConfigurationDTO**](EaseeCoreDTOsChargerChargerConfigurationDTO.md)

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

<a name="apichargersiddetailsget"></a>
# **ApiChargersIdDetailsGet**
> EaseeCoreDTOsChargerChargerInfoDTO ApiChargersIdDetailsGet (string id)

Charger Details

Get charger details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Charger Details
                EaseeCoreDTOsChargerChargerInfoDTO result = apiInstance.ApiChargersIdDetailsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Details
    ApiResponse<EaseeCoreDTOsChargerChargerInfoDTO> response = apiInstance.ApiChargersIdDetailsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeCoreDTOsChargerChargerInfoDTO**](EaseeCoreDTOsChargerChargerInfoDTO.md)

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

<a name="apichargersiderrorsfromtoget"></a>
# **ApiChargersIdErrorsFromToGet**
> List&lt;MasterloopCoreTypesObservationsObservation&gt; ApiChargersIdErrorsFromToGet (string id, DateTime from, DateTime to)

Errors

Get errors for a given period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdErrorsFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // Errors
                List<MasterloopCoreTypesObservationsObservation> result = apiInstance.ApiChargersIdErrorsFromToGet(id, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdErrorsFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdErrorsFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Errors
    ApiResponse<List<MasterloopCoreTypesObservationsObservation>> response = apiInstance.ApiChargersIdErrorsFromToGetWithHttpInfo(id, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdErrorsFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |

### Return type

[**List&lt;MasterloopCoreTypesObservationsObservation&gt;**](MasterloopCoreTypesObservationsObservation.md)

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

<a name="apichargersidget"></a>
# **ApiChargersIdGet**
> EaseeCoreDTOsChargerChargerDTO ApiChargersIdGet (string id)

Charger

Get a specified charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Charger
                EaseeCoreDTOsChargerChargerDTO result = apiInstance.ApiChargersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger
    ApiResponse<EaseeCoreDTOsChargerChargerDTO> response = apiInstance.ApiChargersIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeCoreDTOsChargerChargerDTO**](EaseeCoreDTOsChargerChargerDTO.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidlogeventslogtypefromtoget"></a>
# **ApiChargersIdLogEventsLogTypeFromToGet**
> List&lt;EaseeCoreDTOsChargerChargerLogEventDTO&gt; ApiChargersIdLogEventsLogTypeFromToGet (string id, EaseeCoreEnumsLogType logType, DateTime from, DateTime to)

Log Events

Get log events in a given period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdLogEventsLogTypeFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var logType = (EaseeCoreEnumsLogType) "1";  // EaseeCoreEnumsLogType | Log type
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From timestamp (ISO8601 string)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To timestamp (ISO8601 string)

            try
            {
                // Log Events
                List<EaseeCoreDTOsChargerChargerLogEventDTO> result = apiInstance.ApiChargersIdLogEventsLogTypeFromToGet(id, logType, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdLogEventsLogTypeFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdLogEventsLogTypeFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log Events
    ApiResponse<List<EaseeCoreDTOsChargerChargerLogEventDTO>> response = apiInstance.ApiChargersIdLogEventsLogTypeFromToGetWithHttpInfo(id, logType, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdLogEventsLogTypeFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **logType** | **EaseeCoreEnumsLogType** | Log type |  |
| **from** | **DateTime** | From timestamp (ISO8601 string) |  |
| **to** | **DateTime** | To timestamp (ISO8601 string) |  |

### Return type

[**List&lt;EaseeCoreDTOsChargerChargerLogEventDTO&gt;**](EaseeCoreDTOsChargerChargerLogEventDTO.md)

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

<a name="apichargersidobservationsobservationidfromtoget"></a>
# **ApiChargersIdObservationsObservationIdFromToGet**
> List&lt;MasterloopCoreTypesObservationsObservation&gt; ApiChargersIdObservationsObservationIdFromToGet (string id, int observationId, DateTime from, DateTime to)

Observations

Get observations for a given period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdObservationsObservationIdFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var observationId = 56;  // int | Observation ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // Observations
                List<MasterloopCoreTypesObservationsObservation> result = apiInstance.ApiChargersIdObservationsObservationIdFromToGet(id, observationId, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdObservationsObservationIdFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdObservationsObservationIdFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Observations
    ApiResponse<List<MasterloopCoreTypesObservationsObservation>> response = apiInstance.ApiChargersIdObservationsObservationIdFromToGetWithHttpInfo(id, observationId, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdObservationsObservationIdFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **observationId** | **int** | Observation ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |

### Return type

[**List&lt;MasterloopCoreTypesObservationsObservation&gt;**](MasterloopCoreTypesObservationsObservation.md)

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

<a name="apichargersidpairpost"></a>
# **ApiChargersIdPairPost**
> void ApiChargersIdPairPost (string id, string? pinCode = null)

Pair

Pair a charger to an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdPairPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var pinCode = "pinCode_example";  // string? | Charger PIN (optional) 

            try
            {
                // Pair
                apiInstance.ApiChargersIdPairPost(id, pinCode);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdPairPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdPairPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pair
    apiInstance.ApiChargersIdPairPostWithHttpInfo(id, pinCode);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdPairPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **pinCode** | **string?** | Charger PIN | [optional]  |

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

<a name="apichargersidpartnersget"></a>
# **ApiChargersIdPartnersGet**
> EaseeAccessControlModelsPartnerDetailedDTO ApiChargersIdPartnersGet (string id)

Partner

Get partner of charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdPartnersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Partner
                EaseeAccessControlModelsPartnerDetailedDTO result = apiInstance.ApiChargersIdPartnersGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdPartnersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdPartnersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Partner
    ApiResponse<EaseeAccessControlModelsPartnerDetailedDTO> response = apiInstance.ApiChargersIdPartnersGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdPartnersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeAccessControlModelsPartnerDetailedDTO**](EaseeAccessControlModelsPartnerDetailedDTO.md)

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

<a name="apichargersidpartnerspartneriddelete"></a>
# **ApiChargersIdPartnersPartnerIdDelete**
> void ApiChargersIdPartnersPartnerIdDelete (string id, int partnerId)

Remove Partner

Remove partner from a charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdPartnersPartnerIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var partnerId = 56;  // int | Partner ID

            try
            {
                // Remove Partner
                apiInstance.ApiChargersIdPartnersPartnerIdDelete(id, partnerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdPartnersPartnerIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdPartnersPartnerIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Partner
    apiInstance.ApiChargersIdPartnersPartnerIdDeleteWithHttpInfo(id, partnerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdPartnersPartnerIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **partnerId** | **int** | Partner ID |  |

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

<a name="apichargersidpartnerspost"></a>
# **ApiChargersIdPartnersPost**
> void ApiChargersIdPartnersPost (string id, EaseeAccessControlModelsPairChargerPartnerDTO? easeeAccessControlModelsPairChargerPartnerDTO = null)

Set Partner

Set partner of a charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdPartnersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeAccessControlModelsPairChargerPartnerDTO = new EaseeAccessControlModelsPairChargerPartnerDTO?(); // EaseeAccessControlModelsPairChargerPartnerDTO? | Partner ID (optional) 

            try
            {
                // Set Partner
                apiInstance.ApiChargersIdPartnersPost(id, easeeAccessControlModelsPairChargerPartnerDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdPartnersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdPartnersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Partner
    apiInstance.ApiChargersIdPartnersPostWithHttpInfo(id, easeeAccessControlModelsPairChargerPartnerDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdPartnersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeAccessControlModelsPairChargerPartnerDTO** | [**EaseeAccessControlModelsPairChargerPartnerDTO?**](EaseeAccessControlModelsPairChargerPartnerDTO?.md) | Partner ID | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidpermissiondelete"></a>
# **ApiChargersIdPermissionDelete**
> void ApiChargersIdPermissionDelete (string id, string? phoneNo = null, string? email = null)

Remove Charger Access

Remove permission from the charger for a given phone number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdPermissionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var phoneNo = "phoneNo_example";  // string? | Phone number (optional) 
            var email = "email_example";  // string? | Email (optional) 

            try
            {
                // Remove Charger Access
                apiInstance.ApiChargersIdPermissionDelete(id, phoneNo, email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdPermissionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdPermissionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Charger Access
    apiInstance.ApiChargersIdPermissionDeleteWithHttpInfo(id, phoneNo, email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdPermissionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **phoneNo** | **string?** | Phone number | [optional]  |
| **email** | **string?** | Email | [optional]  |

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

<a name="apichargersidpermissionget"></a>
# **ApiChargersIdPermissionGet**
> List&lt;EaseeAccessControlDomainDTOUserChargerDTO&gt; ApiChargersIdPermissionGet (string id)

Permissions

Get permissions to the charger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdPermissionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Permissions
                List<EaseeAccessControlDomainDTOUserChargerDTO> result = apiInstance.ApiChargersIdPermissionGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdPermissionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdPermissionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Permissions
    ApiResponse<List<EaseeAccessControlDomainDTOUserChargerDTO>> response = apiInstance.ApiChargersIdPermissionGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdPermissionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**List&lt;EaseeAccessControlDomainDTOUserChargerDTO&gt;**](EaseeAccessControlDomainDTOUserChargerDTO.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidpermissionpost"></a>
# **ApiChargersIdPermissionPost**
> void ApiChargersIdPermissionPost (string id, EaseeAccessControlModelsChargerPermissionRequestDTO? easeeAccessControlModelsChargerPermissionRequestDTO = null)

Grant Charger Access

Grant permissions to the charger for a given phone number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdPermissionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeAccessControlModelsChargerPermissionRequestDTO = new EaseeAccessControlModelsChargerPermissionRequestDTO?(); // EaseeAccessControlModelsChargerPermissionRequestDTO? | User phone number (optional) 

            try
            {
                // Grant Charger Access
                apiInstance.ApiChargersIdPermissionPost(id, easeeAccessControlModelsChargerPermissionRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdPermissionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdPermissionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Grant Charger Access
    apiInstance.ApiChargersIdPermissionPostWithHttpInfo(id, easeeAccessControlModelsChargerPermissionRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdPermissionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeAccessControlModelsChargerPermissionRequestDTO** | [**EaseeAccessControlModelsChargerPermissionRequestDTO?**](EaseeAccessControlModelsChargerPermissionRequestDTO?.md) | User phone number | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidsessionslatestget"></a>
# **ApiChargersIdSessionsLatestGet**
> EaseeCoreDTOsChargerUsageStatisticsDTO ApiChargersIdSessionsLatestGet (string id)

Latest Charging Session

Get last updated charging session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdSessionsLatestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Latest Charging Session
                EaseeCoreDTOsChargerUsageStatisticsDTO result = apiInstance.ApiChargersIdSessionsLatestGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdSessionsLatestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdSessionsLatestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Latest Charging Session
    ApiResponse<EaseeCoreDTOsChargerUsageStatisticsDTO> response = apiInstance.ApiChargersIdSessionsLatestGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdSessionsLatestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeCoreDTOsChargerUsageStatisticsDTO**](EaseeCoreDTOsChargerUsageStatisticsDTO.md)

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

<a name="apichargersidsessionsongoingget"></a>
# **ApiChargersIdSessionsOngoingGet**
> EaseeCoreDTOsChargerUsageStatisticsDTO ApiChargersIdSessionsOngoingGet (string id)

Ongoing Charging Session

Get current state of ongoing charging session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdSessionsOngoingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Ongoing Charging Session
                EaseeCoreDTOsChargerUsageStatisticsDTO result = apiInstance.ApiChargersIdSessionsOngoingGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdSessionsOngoingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdSessionsOngoingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ongoing Charging Session
    ApiResponse<EaseeCoreDTOsChargerUsageStatisticsDTO> response = apiInstance.ApiChargersIdSessionsOngoingGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdSessionsOngoingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeCoreDTOsChargerUsageStatisticsDTO**](EaseeCoreDTOsChargerUsageStatisticsDTO.md)

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

<a name="apichargersidsettingspost"></a>
# **ApiChargersIdSettingsPost**
> void ApiChargersIdSettingsPost (string id, EaseeCoreDTOsChargerChargerSettingDTO easeeCoreDTOsChargerChargerSettingDTO)

Change Charger Settings

Charger settings to update. Please only specify keys you want to change. Endpoint handles partial JSON objects  and will give a 400 response if it does not understand the request.<br />Will only forward commands to device if  new value != old value <br /> Rate limited at max 20 requests per minute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdSettingsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeCoreDTOsChargerChargerSettingDTO = new EaseeCoreDTOsChargerChargerSettingDTO(); // EaseeCoreDTOsChargerChargerSettingDTO | Charger settings to set

            try
            {
                // Change Charger Settings
                apiInstance.ApiChargersIdSettingsPost(id, easeeCoreDTOsChargerChargerSettingDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdSettingsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdSettingsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Charger Settings
    apiInstance.ApiChargersIdSettingsPostWithHttpInfo(id, easeeCoreDTOsChargerChargerSettingDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdSettingsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeCoreDTOsChargerChargerSettingDTO** | [**EaseeCoreDTOsChargerChargerSettingDTO**](EaseeCoreDTOsChargerChargerSettingDTO.md) | Charger settings to set |  |

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
| **202** | All commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot;  hub and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apichargersidsiteget"></a>
# **ApiChargersIdSiteGet**
> EaseeSiteStructureDomainPortsSiteDTO ApiChargersIdSiteGet (string id)

Site

Get charger site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdSiteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Site
                EaseeSiteStructureDomainPortsSiteDTO result = apiInstance.ApiChargersIdSiteGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdSiteGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdSiteGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Site
    ApiResponse<EaseeSiteStructureDomainPortsSiteDTO> response = apiInstance.ApiChargersIdSiteGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdSiteGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeSiteStructureDomainPortsSiteDTO**](EaseeSiteStructureDomainPortsSiteDTO.md)

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

<a name="apichargersidstateget"></a>
# **ApiChargersIdStateGet**
> EaseeCoreDTOsChargerChargerStateDTO ApiChargersIdStateGet (string id)

State

Get charger state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdStateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // State
                EaseeCoreDTOsChargerChargerStateDTO result = apiInstance.ApiChargersIdStateGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdStateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdStateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // State
    ApiResponse<EaseeCoreDTOsChargerChargerStateDTO> response = apiInstance.ApiChargersIdStateGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdStateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeCoreDTOsChargerChargerStateDTO**](EaseeCoreDTOsChargerChargerStateDTO.md)

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

<a name="apichargersidunpairpost"></a>
# **ApiChargersIdUnpairPost**
> void ApiChargersIdUnpairPost (string id, string? pinCode = null)

Unpair

Unpair a charger from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdUnpairPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var pinCode = "pinCode_example";  // string? | Charger PIN (optional) 

            try
            {
                // Unpair
                apiInstance.ApiChargersIdUnpairPost(id, pinCode);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdUnpairPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdUnpairPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unpair
    apiInstance.ApiChargersIdUnpairPostWithHttpInfo(id, pinCode);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdUnpairPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **pinCode** | **string?** | Charger PIN | [optional]  |

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

<a name="apichargersidusagehourlyfromtoget"></a>
# **ApiChargersIdUsageHourlyFromToGet**
> List&lt;EaseeCoreDTOsSessionAggregatedUsageDTO&gt; ApiChargersIdUsageHourlyFromToGet (string id, DateTime from, DateTime to)

Power Usage

Get hourly power usage for a given period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdUsageHourlyFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // Power Usage
                List<EaseeCoreDTOsSessionAggregatedUsageDTO> result = apiInstance.ApiChargersIdUsageHourlyFromToGet(id, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdUsageHourlyFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdUsageHourlyFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Power Usage
    ApiResponse<List<EaseeCoreDTOsSessionAggregatedUsageDTO>> response = apiInstance.ApiChargersIdUsageHourlyFromToGetWithHttpInfo(id, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdUsageHourlyFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **from** | **DateTime** | From (ISO8601 datetime) |  |
| **to** | **DateTime** | To (ISO8601 datetime) |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionAggregatedUsageDTO&gt;**](EaseeCoreDTOsSessionAggregatedUsageDTO.md)

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

<a name="apichargersidweeklychargeplandelete"></a>
# **ApiChargersIdWeeklyChargePlanDelete**
> void ApiChargersIdWeeklyChargePlanDelete (string id)

Remove Weekly Charge Plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdWeeklyChargePlanDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Remove Weekly Charge Plan
                apiInstance.ApiChargersIdWeeklyChargePlanDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdWeeklyChargePlanDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdWeeklyChargePlanDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Weekly Charge Plan
    apiInstance.ApiChargersIdWeeklyChargePlanDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdWeeklyChargePlanDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

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

<a name="apichargersidweeklychargeplanget"></a>
# **ApiChargersIdWeeklyChargePlanGet**
> EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO ApiChargersIdWeeklyChargePlanGet (string id)

Weekly Charge Plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdWeeklyChargePlanGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID

            try
            {
                // Weekly Charge Plan
                EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO result = apiInstance.ApiChargersIdWeeklyChargePlanGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdWeeklyChargePlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdWeeklyChargePlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Weekly Charge Plan
    ApiResponse<EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO> response = apiInstance.ApiChargersIdWeeklyChargePlanGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdWeeklyChargePlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |

### Return type

[**EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO**](EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO.md)

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

<a name="apichargersidweeklychargeplanpost"></a>
# **ApiChargersIdWeeklyChargePlanPost**
> void ApiChargersIdWeeklyChargePlanPost (string id, EaseeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO? easeeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO = null)

Set Weekly Charge Plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiChargersIdWeeklyChargePlanPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargerApi(config);
            var id = "id_example";  // string | Charger ID
            var easeeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO = new EaseeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO?(); // EaseeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO? | Weekly charge plan details (optional) 

            try
            {
                // Set Weekly Charge Plan
                apiInstance.ApiChargersIdWeeklyChargePlanPost(id, easeeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargerApi.ApiChargersIdWeeklyChargePlanPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiChargersIdWeeklyChargePlanPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Weekly Charge Plan
    apiInstance.ApiChargersIdWeeklyChargePlanPostWithHttpInfo(id, easeeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargerApi.ApiChargersIdWeeklyChargePlanPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Charger ID |  |
| **easeeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO** | [**EaseeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO?**](EaseeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO?.md) | Weekly charge plan details | [optional]  |

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
| **202** | All commands successfully sent to charger. See \&quot;CommandResponse\&quot; SignalR method from \&quot;Products\&quot;  hub and match command responses to the details returned response body |  -  |
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

