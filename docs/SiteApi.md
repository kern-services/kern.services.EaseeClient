# kern.services.EaseeClient.Api.SiteApi

All URIs are relative to *https://api.easee.cloud*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSitesAcceptPost**](SiteApi.md#apisitesacceptpost) | **POST** /api/sites/accept | Accept Site Invitation |
| [**ApiSitesCircuitsConfirmPost**](SiteApi.md#apisitescircuitsconfirmpost) | **POST** /api/sites/circuits/confirm | Confirm Circuit Move |
| [**ApiSitesGet**](SiteApi.md#apisitesget) | **GET** /api/sites | Get Sites |
| [**ApiSitesSiteIdAccessPut**](SiteApi.md#apisitessiteidaccessput) | **PUT** /api/sites/{siteId}/access | Access Level - All Chargers |
| [**ApiSitesSiteIdBreakdownFromToGet**](SiteApi.md#apisitessiteidbreakdownfromtoget) | **GET** /api/sites/{siteId}/breakdown/{from}/{to} | Usage/Cost |
| [**ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGet**](SiteApi.md#apisitessiteidchargerschargeridusersuseridmonthlyget) | **GET** /api/sites/{siteId}/chargers/{chargerId}/users/{userId}/monthly | Charger Usage - Monthly |
| [**ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGet**](SiteApi.md#apisitessiteidchargerschargeridusersuseridyearlyget) | **GET** /api/sites/{siteId}/chargers/{chargerId}/users/{userId}/yearly | Charger Usage - Yearly |
| [**ApiSitesSiteIdChargersGet**](SiteApi.md#apisitessiteidchargersget) | **GET** /api/sites/{siteId}/chargers | Chargers |
| [**ApiSitesSiteIdChargersLevelOfAccessPut**](SiteApi.md#apisitessiteidchargerslevelofaccessput) | **PUT** /api/sites/{siteId}/chargers/level_of_access | Access Level - Chargers |
| [**ApiSitesSiteIdCircuitCollectionPost**](SiteApi.md#apisitessiteidcircuitcollectionpost) | **POST** /api/sites/{siteId}/circuit_collection | Set Circuits |
| [**ApiSitesSiteIdCircuitsCircuitIdChargersPut**](SiteApi.md#apisitessiteidcircuitscircuitidchargersput) | **PUT** /api/sites/{siteId}/circuits/{circuitId}/chargers | Update Chargers |
| [**ApiSitesSiteIdCircuitsCircuitIdDelete**](SiteApi.md#apisitessiteidcircuitscircuitiddelete) | **DELETE** /api/sites/{siteId}/circuits/{circuitId} | Delete Circuit |
| [**ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGet**](SiteApi.md#apisitessiteidcircuitscircuitiddynamiccurrentget) | **GET** /api/sites/{siteId}/circuits/{circuitId}/dynamicCurrent | Dynamic Circuit Current |
| [**ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPost**](SiteApi.md#apisitessiteidcircuitscircuitiddynamiccurrentpost) | **POST** /api/sites/{siteId}/circuits/{circuitId}/dynamicCurrent | Set Dynamic Circuit Current |
| [**ApiSitesSiteIdCircuitsCircuitIdSettingsGet**](SiteApi.md#apisitessiteidcircuitscircuitidsettingsget) | **GET** /api/sites/{siteId}/circuits/{circuitId}/settings | Circuit Settings |
| [**ApiSitesSiteIdCircuitsCircuitIdSettingsPost**](SiteApi.md#apisitessiteidcircuitscircuitidsettingspost) | **POST** /api/sites/{siteId}/circuits/{circuitId}/settings | Set Circuit Settings |
| [**ApiSitesSiteIdCircuitsPost**](SiteApi.md#apisitessiteidcircuitspost) | **POST** /api/sites/{siteId}/circuits | Set Circuit |
| [**ApiSitesSiteIdCircuitsPut**](SiteApi.md#apisitessiteidcircuitsput) | **PUT** /api/sites/{siteId}/circuits | Update Circuits |
| [**ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePut**](SiteApi.md#apisitessiteidcircuitsserialnumberpincodecircuitnameput) | **PUT** /api/sites/{siteId}/circuits/{serialNumber}/{pinCode}/{circuitName} | Start Circuit Move |
| [**ApiSitesSiteIdCircuitsSerialNumberPinCodeGet**](SiteApi.md#apisitessiteidcircuitsserialnumberpincodeget) | **GET** /api/sites/{siteId}/circuits/{serialNumber}/{pinCode} | Circuit Attached |
| [**ApiSitesSiteIdDelete**](SiteApi.md#apisitessiteiddelete) | **DELETE** /api/sites/{siteId} | Delete Site |
| [**ApiSitesSiteIdEnergyGet**](SiteApi.md#apisitessiteidenergyget) | **GET** /api/sites/{siteId}/energy | Lifetime Energy |
| [**ApiSitesSiteIdEqualizersEqualizerIdDelete**](SiteApi.md#apisitessiteidequalizersequalizeriddelete) | **DELETE** /api/sites/{siteId}/equalizers/{equalizerId} | Remove Equalizer |
| [**ApiSitesSiteIdInvitePost**](SiteApi.md#apisitessiteidinvitepost) | **POST** /api/sites/{siteId}/invite | Send Site Invitation |
| [**ApiSitesSiteIdLookupAdminGet**](SiteApi.md#apisitessiteidlookupadminget) | **GET** /api/sites/{siteId}/lookup_admin | Get User to Invite as Admin |
| [**ApiSitesSiteIdLookupUserGet**](SiteApi.md#apisitessiteidlookupuserget) | **GET** /api/sites/{siteId}/lookup_user | User to Invite |
| [**ApiSitesSiteIdMonthlyGet**](SiteApi.md#apisitessiteidmonthlyget) | **GET** /api/sites/{siteId}/monthly | Usage/Cost - Monthly |
| [**ApiSitesSiteIdOwnerPost**](SiteApi.md#apisitessiteidownerpost) | **POST** /api/sites/{siteId}/owner | Change Site Owner |
| [**ApiSitesSiteIdPatch**](SiteApi.md#apisitessiteidpatch) | **PATCH** /api/sites/{siteId} | Update Site (Partial) |
| [**ApiSitesSiteIdPermissionDelete**](SiteApi.md#apisitessiteidpermissiondelete) | **DELETE** /api/sites/{siteId}/permission | Delete Site Permission |
| [**ApiSitesSiteIdPermissionPut**](SiteApi.md#apisitessiteidpermissionput) | **PUT** /api/sites/{siteId}/permission | Updates a site user&#39;s permissions |
| [**ApiSitesSiteIdPricePost**](SiteApi.md#apisitessiteidpricepost) | **POST** /api/sites/{siteId}/price | Set Charging Price |
| [**ApiSitesSiteIdReinvitePost**](SiteApi.md#apisitessiteidreinvitepost) | **POST** /api/sites/{siteId}/reinvite | Resend Site Invitation |
| [**ApiSitesSiteIdRequestAccessPost**](SiteApi.md#apisitessiteidrequestaccesspost) | **POST** /api/sites/{siteId}/request_access | Request site access by logged in user(installer) |
| [**ApiSitesSiteIdSiteGroupsGet**](SiteApi.md#apisitessiteidsitegroupsget) | **GET** /api/sites/{siteId}/siteGroups | Site Groups |
| [**ApiSitesSiteIdUsersGet**](SiteApi.md#apisitessiteidusersget) | **GET** /api/sites/{siteId}/users | Users |
| [**ApiSitesSiteIdUsersUserIdMonthlyGet**](SiteApi.md#apisitessiteidusersuseridmonthlyget) | **GET** /api/sites/{siteId}/users/{userId}/monthly | Charger Usage, All Chargers - Monthly |
| [**ApiSitesSiteIdUsersUserIdYearlyGet**](SiteApi.md#apisitessiteidusersuseridyearlyget) | **GET** /api/sites/{siteId}/users/{userId}/yearly | Charger Usage, All Chargers - Yearly |
| [**ApiSitesSiteIdWeeklyGet**](SiteApi.md#apisitessiteidweeklyget) | **GET** /api/sites/{siteId}/weekly | Power Usage/Cost - Weekly |
| [**ApiSitesSiteIdYearlyGet**](SiteApi.md#apisitessiteidyearlyget) | **GET** /api/sites/{siteId}/yearly | Usage/Cost - Yearly |
| [**GetSiteById**](SiteApi.md#getsitebyid) | **GET** /api/sites/{siteId} | Get Site |
| [**GetSiteState**](SiteApi.md#getsitestate) | **GET** /api/sites/{siteId}/state | Dashboard Circuit States |

<a name="apisitesacceptpost"></a>
# **ApiSitesAcceptPost**
> void ApiSitesAcceptPost (string? email = null, string? body = null)

Accept Site Invitation

Accept site invitation for access to the site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesAcceptPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var email = "email_example";  // string? | Site user permission invitation acceptance token (optional) 
            var body = "body_example";  // string? | Site user permission invitation acceptance token (optional) 

            try
            {
                // Accept Site Invitation
                apiInstance.ApiSitesAcceptPost(email, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesAcceptPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesAcceptPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept Site Invitation
    apiInstance.ApiSitesAcceptPostWithHttpInfo(email, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesAcceptPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string?** | Site user permission invitation acceptance token | [optional]  |
| **body** | **string?** | Site user permission invitation acceptance token | [optional]  |

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

<a name="apisitescircuitsconfirmpost"></a>
# **ApiSitesCircuitsConfirmPost**
> void ApiSitesCircuitsConfirmPost (string? body = null)

Confirm Circuit Move

Confirm a request made to move a circuit to a new site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesCircuitsConfirmPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var body = "body_example";  // string? | Confirmation token (optional) 

            try
            {
                // Confirm Circuit Move
                apiInstance.ApiSitesCircuitsConfirmPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesCircuitsConfirmPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesCircuitsConfirmPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Confirm Circuit Move
    apiInstance.ApiSitesCircuitsConfirmPostWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesCircuitsConfirmPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string?** | Confirmation token | [optional]  |

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

<a name="apisitesget"></a>
# **ApiSitesGet**
> List&lt;EaseeCoreDTOsSiteBasicSiteDTO&gt; ApiSitesGet (string? search = null, int? offset = null, int? limit = null)

Get Sites

Get sites for logged in user. Offset and limits are used if \"search\" is specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var search = "search_example";  // string? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get Sites
                List<EaseeCoreDTOsSiteBasicSiteDTO> result = apiInstance.ApiSitesGet(search, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Sites
    ApiResponse<List<EaseeCoreDTOsSiteBasicSiteDTO>> response = apiInstance.ApiSitesGetWithHttpInfo(search, offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **search** | **string?** |  | [optional]  |
| **offset** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**List&lt;EaseeCoreDTOsSiteBasicSiteDTO&gt;**](EaseeCoreDTOsSiteBasicSiteDTO.md)

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

<a name="apisitessiteidaccessput"></a>
# **ApiSitesSiteIdAccessPut**
> void ApiSitesSiteIdAccessPut (int siteId, int? body = null)

Access Level - All Chargers

Set access level for all chargers on a site.<br /> Access Level can be Everyone, Registered Users og White  Listed Users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdAccessPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var body = 56;  // int? | Access level (optional) 

            try
            {
                // Access Level - All Chargers
                apiInstance.ApiSitesSiteIdAccessPut(siteId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdAccessPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdAccessPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Access Level - All Chargers
    apiInstance.ApiSitesSiteIdAccessPutWithHttpInfo(siteId, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdAccessPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
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

<a name="apisitessiteidbreakdownfromtoget"></a>
# **ApiSitesSiteIdBreakdownFromToGet**
> List&lt;EaseeCoreDTOsSessionChargingSessionDetailDTO&gt; ApiSitesSiteIdBreakdownFromToGet (int siteId, DateTime from, DateTime to)

Usage/Cost

Get power usage and cost for all chargers on a site in a time period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdBreakdownFromToGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | From (ISO8601 datetime)
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | To (ISO8601 datetime)

            try
            {
                // Usage/Cost
                List<EaseeCoreDTOsSessionChargingSessionDetailDTO> result = apiInstance.ApiSitesSiteIdBreakdownFromToGet(siteId, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdBreakdownFromToGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdBreakdownFromToGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Usage/Cost
    ApiResponse<List<EaseeCoreDTOsSessionChargingSessionDetailDTO>> response = apiInstance.ApiSitesSiteIdBreakdownFromToGetWithHttpInfo(siteId, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdBreakdownFromToGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisitessiteidchargerschargeridusersuseridmonthlyget"></a>
# **ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGet**
> List&lt;EaseeCoreDTOsSessionMonthlySessionSummaryDTO&gt; ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGet (int siteId, string chargerId, int userId)

Charger Usage - Monthly

Get monthly charger power usage for a user and a charger on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var chargerId = "chargerId_example";  // string | Charger ID
            var userId = 56;  // int | User ID

            try
            {
                // Charger Usage - Monthly
                List<EaseeCoreDTOsSessionMonthlySessionSummaryDTO> result = apiInstance.ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGet(siteId, chargerId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Usage - Monthly
    ApiResponse<List<EaseeCoreDTOsSessionMonthlySessionSummaryDTO>> response = apiInstance.ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGetWithHttpInfo(siteId, chargerId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersChargerIdUsersUserIdMonthlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **chargerId** | **string** | Charger ID |  |
| **userId** | **int** | User ID |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionMonthlySessionSummaryDTO&gt;**](EaseeCoreDTOsSessionMonthlySessionSummaryDTO.md)

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

<a name="apisitessiteidchargerschargeridusersuseridyearlyget"></a>
# **ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGet**
> List&lt;EaseeCoreDTOsSessionYearlySessionSummaryDTO&gt; ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGet (int siteId, string chargerId, int userId)

Charger Usage - Yearly

Get yearly charger power usage for a user and a charger on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var chargerId = "chargerId_example";  // string | Charger ID
            var userId = 56;  // int | User ID

            try
            {
                // Charger Usage - Yearly
                List<EaseeCoreDTOsSessionYearlySessionSummaryDTO> result = apiInstance.ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGet(siteId, chargerId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Usage - Yearly
    ApiResponse<List<EaseeCoreDTOsSessionYearlySessionSummaryDTO>> response = apiInstance.ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGetWithHttpInfo(siteId, chargerId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersChargerIdUsersUserIdYearlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **chargerId** | **string** | Charger ID |  |
| **userId** | **int** | User ID |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionYearlySessionSummaryDTO&gt;**](EaseeCoreDTOsSessionYearlySessionSummaryDTO.md)

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

<a name="apisitessiteidchargersget"></a>
# **ApiSitesSiteIdChargersGet**
> List&lt;EaseeSiteStructureDomainPortsChargerDTO&gt; ApiSitesSiteIdChargersGet (int siteId)

Chargers

Get all chargers on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdChargersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID

            try
            {
                // Chargers
                List<EaseeSiteStructureDomainPortsChargerDTO> result = apiInstance.ApiSitesSiteIdChargersGet(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdChargersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Chargers
    ApiResponse<List<EaseeSiteStructureDomainPortsChargerDTO>> response = apiInstance.ApiSitesSiteIdChargersGetWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |

### Return type

[**List&lt;EaseeSiteStructureDomainPortsChargerDTO&gt;**](EaseeSiteStructureDomainPortsChargerDTO.md)

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

<a name="apisitessiteidchargerslevelofaccessput"></a>
# **ApiSitesSiteIdChargersLevelOfAccessPut**
> void ApiSitesSiteIdChargersLevelOfAccessPut (int siteId, List<EaseeCoreDTOsSiteChargerAccessDTO>? easeeCoreDTOsSiteChargerAccessDTO = null)

Access Level - Chargers

Set or delete access level for specified chargers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdChargersLevelOfAccessPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var easeeCoreDTOsSiteChargerAccessDTO = new List<EaseeCoreDTOsSiteChargerAccessDTO>?(); // List<EaseeCoreDTOsSiteChargerAccessDTO>? | Chargers with Access Level (optional) 

            try
            {
                // Access Level - Chargers
                apiInstance.ApiSitesSiteIdChargersLevelOfAccessPut(siteId, easeeCoreDTOsSiteChargerAccessDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersLevelOfAccessPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdChargersLevelOfAccessPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Access Level - Chargers
    apiInstance.ApiSitesSiteIdChargersLevelOfAccessPutWithHttpInfo(siteId, easeeCoreDTOsSiteChargerAccessDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdChargersLevelOfAccessPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **easeeCoreDTOsSiteChargerAccessDTO** | [**List&lt;EaseeCoreDTOsSiteChargerAccessDTO&gt;?**](EaseeCoreDTOsSiteChargerAccessDTO.md) | Chargers with Access Level | [optional]  |

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

<a name="apisitessiteidcircuitcollectionpost"></a>
# **ApiSitesSiteIdCircuitCollectionPost**
> void ApiSitesSiteIdCircuitCollectionPost (int siteId, List<EaseeCoreDTOsSiteUpdateCircuitDTO>? easeeCoreDTOsSiteUpdateCircuitDTO = null)

Set Circuits

Create or update circuits with backplates on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitCollectionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var easeeCoreDTOsSiteUpdateCircuitDTO = new List<EaseeCoreDTOsSiteUpdateCircuitDTO>?(); // List<EaseeCoreDTOsSiteUpdateCircuitDTO>? | Circuit with Backplates (optional) 

            try
            {
                // Set Circuits
                apiInstance.ApiSitesSiteIdCircuitCollectionPost(siteId, easeeCoreDTOsSiteUpdateCircuitDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitCollectionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitCollectionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Circuits
    apiInstance.ApiSitesSiteIdCircuitCollectionPostWithHttpInfo(siteId, easeeCoreDTOsSiteUpdateCircuitDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitCollectionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **easeeCoreDTOsSiteUpdateCircuitDTO** | [**List&lt;EaseeCoreDTOsSiteUpdateCircuitDTO&gt;?**](EaseeCoreDTOsSiteUpdateCircuitDTO.md) | Circuit with Backplates | [optional]  |

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

<a name="apisitessiteidcircuitscircuitidchargersput"></a>
# **ApiSitesSiteIdCircuitsCircuitIdChargersPut**
> void ApiSitesSiteIdCircuitsCircuitIdChargersPut (int siteId, int circuitId, List<EaseeCoreDTOsChargerChargerDTO>? easeeCoreDTOsChargerChargerDTO = null)

Update Chargers

Update a set of chargers on a circuit. Rate limited at max 15 request per minute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsCircuitIdChargersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var circuitId = 56;  // int | Circuit ID
            var easeeCoreDTOsChargerChargerDTO = new List<EaseeCoreDTOsChargerChargerDTO>?(); // List<EaseeCoreDTOsChargerChargerDTO>? | Charger details array (optional) 

            try
            {
                // Update Chargers
                apiInstance.ApiSitesSiteIdCircuitsCircuitIdChargersPut(siteId, circuitId, easeeCoreDTOsChargerChargerDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdChargersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsCircuitIdChargersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Chargers
    apiInstance.ApiSitesSiteIdCircuitsCircuitIdChargersPutWithHttpInfo(siteId, circuitId, easeeCoreDTOsChargerChargerDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdChargersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **circuitId** | **int** | Circuit ID |  |
| **easeeCoreDTOsChargerChargerDTO** | [**List&lt;EaseeCoreDTOsChargerChargerDTO&gt;?**](EaseeCoreDTOsChargerChargerDTO.md) | Charger details array | [optional]  |

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

<a name="apisitessiteidcircuitscircuitiddelete"></a>
# **ApiSitesSiteIdCircuitsCircuitIdDelete**
> void ApiSitesSiteIdCircuitsCircuitIdDelete (int siteId, int circuitId)

Delete Circuit

Delete an empty circuit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsCircuitIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var circuitId = 56;  // int | Circuit ID

            try
            {
                // Delete Circuit
                apiInstance.ApiSitesSiteIdCircuitsCircuitIdDelete(siteId, circuitId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsCircuitIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Circuit
    apiInstance.ApiSitesSiteIdCircuitsCircuitIdDeleteWithHttpInfo(siteId, circuitId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **circuitId** | **int** | Circuit ID |  |

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

<a name="apisitessiteidcircuitscircuitiddynamiccurrentget"></a>
# **ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGet**
> EaseeCoreDTOsSiteDynamicCircuitCurrentDto ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGet (int siteId, int circuitId)

Dynamic Circuit Current

Get dynamic circuit current of the primary charger

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var circuitId = 56;  // int | Circuit ID

            try
            {
                // Dynamic Circuit Current
                EaseeCoreDTOsSiteDynamicCircuitCurrentDto result = apiInstance.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGet(siteId, circuitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dynamic Circuit Current
    ApiResponse<EaseeCoreDTOsSiteDynamicCircuitCurrentDto> response = apiInstance.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGetWithHttpInfo(siteId, circuitId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **circuitId** | **int** | Circuit ID |  |

### Return type

[**EaseeCoreDTOsSiteDynamicCircuitCurrentDto**](EaseeCoreDTOsSiteDynamicCircuitCurrentDto.md)

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

<a name="apisitessiteidcircuitscircuitiddynamiccurrentpost"></a>
# **ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPost**
> void ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPost (int siteId, int circuitId, EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto? easeeCoreDTOsSiteDynamicCircuitCurrentTtlDto = null)

Set Dynamic Circuit Current

Set dynamic circuit current. <br />Time to Live should be specified in minutes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var circuitId = 56;  // int | Circuit ID
            var easeeCoreDTOsSiteDynamicCircuitCurrentTtlDto = new EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto?(); // EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto? | Dynamic Current Settings (optional) 

            try
            {
                // Set Dynamic Circuit Current
                apiInstance.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPost(siteId, circuitId, easeeCoreDTOsSiteDynamicCircuitCurrentTtlDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Dynamic Circuit Current
    apiInstance.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPostWithHttpInfo(siteId, circuitId, easeeCoreDTOsSiteDynamicCircuitCurrentTtlDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdDynamicCurrentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **circuitId** | **int** | Circuit ID |  |
| **easeeCoreDTOsSiteDynamicCircuitCurrentTtlDto** | [**EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto?**](EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto?.md) | Dynamic Current Settings | [optional]  |

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

<a name="apisitessiteidcircuitscircuitidsettingsget"></a>
# **ApiSitesSiteIdCircuitsCircuitIdSettingsGet**
> EaseeCoreDTOsSiteExtendedCircuitSettingsDTO ApiSitesSiteIdCircuitsCircuitIdSettingsGet (int siteId, int circuitId)

Circuit Settings

Get extended circuit settings for a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsCircuitIdSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var circuitId = 56;  // int | Circuit ID

            try
            {
                // Circuit Settings
                EaseeCoreDTOsSiteExtendedCircuitSettingsDTO result = apiInstance.ApiSitesSiteIdCircuitsCircuitIdSettingsGet(siteId, circuitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsCircuitIdSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Circuit Settings
    ApiResponse<EaseeCoreDTOsSiteExtendedCircuitSettingsDTO> response = apiInstance.ApiSitesSiteIdCircuitsCircuitIdSettingsGetWithHttpInfo(siteId, circuitId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **circuitId** | **int** | Circuit ID |  |

### Return type

[**EaseeCoreDTOsSiteExtendedCircuitSettingsDTO**](EaseeCoreDTOsSiteExtendedCircuitSettingsDTO.md)

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

<a name="apisitessiteidcircuitscircuitidsettingspost"></a>
# **ApiSitesSiteIdCircuitsCircuitIdSettingsPost**
> void ApiSitesSiteIdCircuitsCircuitIdSettingsPost (int siteId, int circuitId, EaseeCoreDTOsSiteCircuitSettingsDTO? easeeCoreDTOsSiteCircuitSettingsDTO = null)

Set Circuit Settings

Set circuit settings of a site. Rate limited at max 20 request per minute. <br /> Please only specify keys you  want to change. Endpoint handles partial JSON objects and will give a 400 response if it does not understand the  request.<br />Will only forward values for dynamicCircuitCurrentP1, P2, P3 to device if new value != old value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsCircuitIdSettingsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var circuitId = 56;  // int | Circuit ID
            var easeeCoreDTOsSiteCircuitSettingsDTO = new EaseeCoreDTOsSiteCircuitSettingsDTO?(); // EaseeCoreDTOsSiteCircuitSettingsDTO? | Settings (optional) 

            try
            {
                // Set Circuit Settings
                apiInstance.ApiSitesSiteIdCircuitsCircuitIdSettingsPost(siteId, circuitId, easeeCoreDTOsSiteCircuitSettingsDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdSettingsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsCircuitIdSettingsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Circuit Settings
    apiInstance.ApiSitesSiteIdCircuitsCircuitIdSettingsPostWithHttpInfo(siteId, circuitId, easeeCoreDTOsSiteCircuitSettingsDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsCircuitIdSettingsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **circuitId** | **int** | Circuit ID |  |
| **easeeCoreDTOsSiteCircuitSettingsDTO** | [**EaseeCoreDTOsSiteCircuitSettingsDTO?**](EaseeCoreDTOsSiteCircuitSettingsDTO?.md) | Settings | [optional]  |

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
| **400** | Request has missing/invalid values |  -  |
| **401** | Missing authorization data. Check \&quot;Authorization\&quot; header |  -  |
| **403** | Forbidden. Authorization set, but access to resource is denied |  -  |
| **500** | Oops! Unexpected internal error. Request has been logged and code monkeys warned |  -  |
| **503** | Server gateway cannot reach API. Try again in about a minute... |  -  |
| **504** | Unable to deliver commands upstream. End device is not reachable, or a problem with queueing the  device command |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisitessiteidcircuitspost"></a>
# **ApiSitesSiteIdCircuitsPost**
> void ApiSitesSiteIdCircuitsPost (int siteId, EaseeCoreDTOsSiteUpdateCircuitDTO? easeeCoreDTOsSiteUpdateCircuitDTO = null)

Set Circuit

Set circuit with backplates on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site identifier
            var easeeCoreDTOsSiteUpdateCircuitDTO = new EaseeCoreDTOsSiteUpdateCircuitDTO?(); // EaseeCoreDTOsSiteUpdateCircuitDTO? | Circuit details (optional) 

            try
            {
                // Set Circuit
                apiInstance.ApiSitesSiteIdCircuitsPost(siteId, easeeCoreDTOsSiteUpdateCircuitDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Circuit
    apiInstance.ApiSitesSiteIdCircuitsPostWithHttpInfo(siteId, easeeCoreDTOsSiteUpdateCircuitDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site identifier |  |
| **easeeCoreDTOsSiteUpdateCircuitDTO** | [**EaseeCoreDTOsSiteUpdateCircuitDTO?**](EaseeCoreDTOsSiteUpdateCircuitDTO?.md) | Circuit details | [optional]  |

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

<a name="apisitessiteidcircuitsput"></a>
# **ApiSitesSiteIdCircuitsPut**
> void ApiSitesSiteIdCircuitsPut (int siteId, List<EaseeCoreDTOsSiteCircuitDTO>? easeeCoreDTOsSiteCircuitDTO = null)

Update Circuits

Update circuits on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var easeeCoreDTOsSiteCircuitDTO = new List<EaseeCoreDTOsSiteCircuitDTO>?(); // List<EaseeCoreDTOsSiteCircuitDTO>? | Circuit array (optional) 

            try
            {
                // Update Circuits
                apiInstance.ApiSitesSiteIdCircuitsPut(siteId, easeeCoreDTOsSiteCircuitDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Circuits
    apiInstance.ApiSitesSiteIdCircuitsPutWithHttpInfo(siteId, easeeCoreDTOsSiteCircuitDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **easeeCoreDTOsSiteCircuitDTO** | [**List&lt;EaseeCoreDTOsSiteCircuitDTO&gt;?**](EaseeCoreDTOsSiteCircuitDTO.md) | Circuit array | [optional]  |

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

<a name="apisitessiteidcircuitsserialnumberpincodecircuitnameput"></a>
# **ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePut**
> void ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePut (int siteId, string serialNumber, string pinCode, string circuitName)

Start Circuit Move

Initiate a request to move a circuit to a new site. If the source site has an owner then a confirmation email is sent.  If the source site has no owner then the circuit will be immediately transferred to the new site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var serialNumber = "serialNumber_example";  // string | Main Charger Serial Number
            var pinCode = "pinCode_example";  // string | Main Charger PIN Code
            var circuitName = "circuitName_example";  // string | Circuit Panel Name

            try
            {
                // Start Circuit Move
                apiInstance.ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePut(siteId, serialNumber, pinCode, circuitName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start Circuit Move
    apiInstance.ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePutWithHttpInfo(siteId, serialNumber, pinCode, circuitName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsSerialNumberPinCodeCircuitNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **serialNumber** | **string** | Main Charger Serial Number |  |
| **pinCode** | **string** | Main Charger PIN Code |  |
| **circuitName** | **string** | Circuit Panel Name |  |

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

<a name="apisitessiteidcircuitsserialnumberpincodeget"></a>
# **ApiSitesSiteIdCircuitsSerialNumberPinCodeGet**
> EaseeSiteStructureDomainPortsSiteCircuitDTO ApiSitesSiteIdCircuitsSerialNumberPinCodeGet (int siteId, string serialNumber, string pinCode)

Circuit Attached

Check if Circuit is attached to a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdCircuitsSerialNumberPinCodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var serialNumber = "serialNumber_example";  // string | Main charger serial number
            var pinCode = "pinCode_example";  // string | Main charger PIN code

            try
            {
                // Circuit Attached
                EaseeSiteStructureDomainPortsSiteCircuitDTO result = apiInstance.ApiSitesSiteIdCircuitsSerialNumberPinCodeGet(siteId, serialNumber, pinCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsSerialNumberPinCodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdCircuitsSerialNumberPinCodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Circuit Attached
    ApiResponse<EaseeSiteStructureDomainPortsSiteCircuitDTO> response = apiInstance.ApiSitesSiteIdCircuitsSerialNumberPinCodeGetWithHttpInfo(siteId, serialNumber, pinCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdCircuitsSerialNumberPinCodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **serialNumber** | **string** | Main charger serial number |  |
| **pinCode** | **string** | Main charger PIN code |  |

### Return type

[**EaseeSiteStructureDomainPortsSiteCircuitDTO**](EaseeSiteStructureDomainPortsSiteCircuitDTO.md)

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

<a name="apisitessiteiddelete"></a>
# **ApiSitesSiteIdDelete**
> void ApiSitesSiteIdDelete (int siteId)

Delete Site

Delete site (Global Admin or Partner Admin).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | 

            try
            {
                // Delete Site
                apiInstance.ApiSitesSiteIdDelete(siteId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Site
    apiInstance.ApiSitesSiteIdDeleteWithHttpInfo(siteId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** |  |  |

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

<a name="apisitessiteidenergyget"></a>
# **ApiSitesSiteIdEnergyGet**
> List&lt;EaseeCoreDTOsChargerChargerEnergyDTO&gt; ApiSitesSiteIdEnergyGet (int siteId)

Lifetime Energy

Get current lifetime energy for all chargers on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdEnergyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID

            try
            {
                // Lifetime Energy
                List<EaseeCoreDTOsChargerChargerEnergyDTO> result = apiInstance.ApiSitesSiteIdEnergyGet(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdEnergyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdEnergyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lifetime Energy
    ApiResponse<List<EaseeCoreDTOsChargerChargerEnergyDTO>> response = apiInstance.ApiSitesSiteIdEnergyGetWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdEnergyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |

### Return type

[**List&lt;EaseeCoreDTOsChargerChargerEnergyDTO&gt;**](EaseeCoreDTOsChargerChargerEnergyDTO.md)

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

<a name="apisitessiteidequalizersequalizeriddelete"></a>
# **ApiSitesSiteIdEqualizersEqualizerIdDelete**
> void ApiSitesSiteIdEqualizersEqualizerIdDelete (int siteId, string equalizerId)

Remove Equalizer

Remove equalizer from a site. The api will only remove the site and master backpalte id references from databse

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdEqualizersEqualizerIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var equalizerId = "equalizerId_example";  // string | Equalizer ID

            try
            {
                // Remove Equalizer
                apiInstance.ApiSitesSiteIdEqualizersEqualizerIdDelete(siteId, equalizerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdEqualizersEqualizerIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdEqualizersEqualizerIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Equalizer
    apiInstance.ApiSitesSiteIdEqualizersEqualizerIdDeleteWithHttpInfo(siteId, equalizerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdEqualizersEqualizerIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **equalizerId** | **string** | Equalizer ID |  |

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

<a name="apisitessiteidinvitepost"></a>
# **ApiSitesSiteIdInvitePost**
> void ApiSitesSiteIdInvitePost (int siteId, EaseeAccessControlModelsSitePermissionRequestDTO? easeeAccessControlModelsSitePermissionRequestDTO = null)

Send Site Invitation

Send site invitation to user for access to the site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdInvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var easeeAccessControlModelsSitePermissionRequestDTO = new EaseeAccessControlModelsSitePermissionRequestDTO?(); // EaseeAccessControlModelsSitePermissionRequestDTO? | Invitation Request with user phone number and role (optional) 

            try
            {
                // Send Site Invitation
                apiInstance.ApiSitesSiteIdInvitePost(siteId, easeeAccessControlModelsSitePermissionRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdInvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdInvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Site Invitation
    apiInstance.ApiSitesSiteIdInvitePostWithHttpInfo(siteId, easeeAccessControlModelsSitePermissionRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdInvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **easeeAccessControlModelsSitePermissionRequestDTO** | [**EaseeAccessControlModelsSitePermissionRequestDTO?**](EaseeAccessControlModelsSitePermissionRequestDTO?.md) | Invitation Request with user phone number and role | [optional]  |

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

<a name="apisitessiteidlookupadminget"></a>
# **ApiSitesSiteIdLookupAdminGet**
> EaseeUserAdministrationDomainDTOBasicProfile ApiSitesSiteIdLookupAdminGet (int siteId, string? phoneNo = null)

Get User to Invite as Admin

Get user by phone number to invite to the site as administrator. (Site Admin)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdLookupAdminGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var phoneNo = "phoneNo_example";  // string? | Send invite to phone no (optional) 

            try
            {
                // Get User to Invite as Admin
                EaseeUserAdministrationDomainDTOBasicProfile result = apiInstance.ApiSitesSiteIdLookupAdminGet(siteId, phoneNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdLookupAdminGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdLookupAdminGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User to Invite as Admin
    ApiResponse<EaseeUserAdministrationDomainDTOBasicProfile> response = apiInstance.ApiSitesSiteIdLookupAdminGetWithHttpInfo(siteId, phoneNo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdLookupAdminGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **phoneNo** | **string?** | Send invite to phone no | [optional]  |

### Return type

[**EaseeUserAdministrationDomainDTOBasicProfile**](EaseeUserAdministrationDomainDTOBasicProfile.md)

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

<a name="apisitessiteidlookupuserget"></a>
# **ApiSitesSiteIdLookupUserGet**
> EaseeUserAdministrationDomainDTOBasicProfile ApiSitesSiteIdLookupUserGet (int siteId, string? phoneNo = null)

User to Invite

Get user by phone number to invite to site. (Site Admin)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdLookupUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var phoneNo = "phoneNo_example";  // string? | Send invite to phone no (optional) 

            try
            {
                // User to Invite
                EaseeUserAdministrationDomainDTOBasicProfile result = apiInstance.ApiSitesSiteIdLookupUserGet(siteId, phoneNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdLookupUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdLookupUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User to Invite
    ApiResponse<EaseeUserAdministrationDomainDTOBasicProfile> response = apiInstance.ApiSitesSiteIdLookupUserGetWithHttpInfo(siteId, phoneNo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdLookupUserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **phoneNo** | **string?** | Send invite to phone no | [optional]  |

### Return type

[**EaseeUserAdministrationDomainDTOBasicProfile**](EaseeUserAdministrationDomainDTOBasicProfile.md)

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

<a name="apisitessiteidmonthlyget"></a>
# **ApiSitesSiteIdMonthlyGet**
> List&lt;EaseeCoreDTOsSessionMonthlySummaryDTO&gt; ApiSitesSiteIdMonthlyGet (int siteId)

Usage/Cost - Monthly

Get monthly power usage and cost for charging sessions on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdMonthlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site Id

            try
            {
                // Usage/Cost - Monthly
                List<EaseeCoreDTOsSessionMonthlySummaryDTO> result = apiInstance.ApiSitesSiteIdMonthlyGet(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdMonthlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdMonthlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Usage/Cost - Monthly
    ApiResponse<List<EaseeCoreDTOsSessionMonthlySummaryDTO>> response = apiInstance.ApiSitesSiteIdMonthlyGetWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdMonthlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site Id |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisitessiteidownerpost"></a>
# **ApiSitesSiteIdOwnerPost**
> void ApiSitesSiteIdOwnerPost (int siteId, EaseeAccessControlModelsSiteOwnerDTO? easeeAccessControlModelsSiteOwnerDTO = null)

Change Site Owner

Change site owner (Global Admin, Partner Admin or Site Owner).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdOwnerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var easeeAccessControlModelsSiteOwnerDTO = new EaseeAccessControlModelsSiteOwnerDTO?(); // EaseeAccessControlModelsSiteOwnerDTO? | New Owner (optional) 

            try
            {
                // Change Site Owner
                apiInstance.ApiSitesSiteIdOwnerPost(siteId, easeeAccessControlModelsSiteOwnerDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdOwnerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdOwnerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Site Owner
    apiInstance.ApiSitesSiteIdOwnerPostWithHttpInfo(siteId, easeeAccessControlModelsSiteOwnerDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdOwnerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **easeeAccessControlModelsSiteOwnerDTO** | [**EaseeAccessControlModelsSiteOwnerDTO?**](EaseeAccessControlModelsSiteOwnerDTO?.md) | New Owner | [optional]  |

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

<a name="apisitessiteidpatch"></a>
# **ApiSitesSiteIdPatch**
> void ApiSitesSiteIdPatch (int siteId, List<MicrosoftAspNetCoreJsonPatchOperationsOperation>? microsoftAspNetCoreJsonPatchOperationsOperation = null)

Update Site (Partial)

More info: <a>http://jsonpatch.com</a><br />  For example to change only <b>Name</b> and <b>Site Type</b> of site: <br />  [  { \"op\": \"replace\", \"path\": \"/name\", \"value\": \"test site\" },  { \"op\": \"replace\", \"path\": \"/siteType\", \"value\": 2 }  ]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var microsoftAspNetCoreJsonPatchOperationsOperation = new List<MicrosoftAspNetCoreJsonPatchOperationsOperation>?(); // List<MicrosoftAspNetCoreJsonPatchOperationsOperation>? | Site properties to update (optional) 

            try
            {
                // Update Site (Partial)
                apiInstance.ApiSitesSiteIdPatch(siteId, microsoftAspNetCoreJsonPatchOperationsOperation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Site (Partial)
    apiInstance.ApiSitesSiteIdPatchWithHttpInfo(siteId, microsoftAspNetCoreJsonPatchOperationsOperation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **microsoftAspNetCoreJsonPatchOperationsOperation** | [**List&lt;MicrosoftAspNetCoreJsonPatchOperationsOperation&gt;?**](MicrosoftAspNetCoreJsonPatchOperationsOperation.md) | Site properties to update | [optional]  |

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

<a name="apisitessiteidpermissiondelete"></a>
# **ApiSitesSiteIdPermissionDelete**
> void ApiSitesSiteIdPermissionDelete (int siteId, string? phoneNo = null, string? email = null)

Delete Site Permission

Delete user permission for a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdPermissionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var phoneNo = "phoneNo_example";  // string? | User Phone Number (optional) 
            var email = "email_example";  // string? | user email (optional) 

            try
            {
                // Delete Site Permission
                apiInstance.ApiSitesSiteIdPermissionDelete(siteId, phoneNo, email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPermissionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdPermissionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Site Permission
    apiInstance.ApiSitesSiteIdPermissionDeleteWithHttpInfo(siteId, phoneNo, email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPermissionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **phoneNo** | **string?** | User Phone Number | [optional]  |
| **email** | **string?** | user email | [optional]  |

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

<a name="apisitessiteidpermissionput"></a>
# **ApiSitesSiteIdPermissionPut**
> void ApiSitesSiteIdPermissionPut (int siteId, EaseeCoreDTOsSiteUpdateSitePermissionRequestDTO? easeeCoreDTOsSiteUpdateSitePermissionRequestDTO = null)

Updates a site user's permissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdPermissionPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | 
            var easeeCoreDTOsSiteUpdateSitePermissionRequestDTO = new EaseeCoreDTOsSiteUpdateSitePermissionRequestDTO?(); // EaseeCoreDTOsSiteUpdateSitePermissionRequestDTO? |  (optional) 

            try
            {
                // Updates a site user's permissions
                apiInstance.ApiSitesSiteIdPermissionPut(siteId, easeeCoreDTOsSiteUpdateSitePermissionRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPermissionPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdPermissionPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a site user's permissions
    apiInstance.ApiSitesSiteIdPermissionPutWithHttpInfo(siteId, easeeCoreDTOsSiteUpdateSitePermissionRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPermissionPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** |  |  |
| **easeeCoreDTOsSiteUpdateSitePermissionRequestDTO** | [**EaseeCoreDTOsSiteUpdateSitePermissionRequestDTO?**](EaseeCoreDTOsSiteUpdateSitePermissionRequestDTO?.md) |  | [optional]  |

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

<a name="apisitessiteidpricepost"></a>
# **ApiSitesSiteIdPricePost**
> void ApiSitesSiteIdPricePost (int siteId, EaseeCoreDTOsSiteSiteCostDTO? easeeCoreDTOsSiteSiteCostDTO = null)

Set Charging Price

Set fixed cost per kWh for a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdPricePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var easeeCoreDTOsSiteSiteCostDTO = new EaseeCoreDTOsSiteSiteCostDTO?(); // EaseeCoreDTOsSiteSiteCostDTO? | Fixed cost per kilowatt hour and currency id (optional) 

            try
            {
                // Set Charging Price
                apiInstance.ApiSitesSiteIdPricePost(siteId, easeeCoreDTOsSiteSiteCostDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPricePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdPricePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Charging Price
    apiInstance.ApiSitesSiteIdPricePostWithHttpInfo(siteId, easeeCoreDTOsSiteSiteCostDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdPricePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **easeeCoreDTOsSiteSiteCostDTO** | [**EaseeCoreDTOsSiteSiteCostDTO?**](EaseeCoreDTOsSiteSiteCostDTO?.md) | Fixed cost per kilowatt hour and currency id | [optional]  |

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

<a name="apisitessiteidreinvitepost"></a>
# **ApiSitesSiteIdReinvitePost**
> void ApiSitesSiteIdReinvitePost (int siteId, EaseeAccessControlModelsSitePermissionRequestDTO? easeeAccessControlModelsSitePermissionRequestDTO = null)

Resend Site Invitation

Resend site invitation to user for access to the site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdReinvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var easeeAccessControlModelsSitePermissionRequestDTO = new EaseeAccessControlModelsSitePermissionRequestDTO?(); // EaseeAccessControlModelsSitePermissionRequestDTO? | site permisssion reinvite request (optional) 

            try
            {
                // Resend Site Invitation
                apiInstance.ApiSitesSiteIdReinvitePost(siteId, easeeAccessControlModelsSitePermissionRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdReinvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdReinvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend Site Invitation
    apiInstance.ApiSitesSiteIdReinvitePostWithHttpInfo(siteId, easeeAccessControlModelsSitePermissionRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdReinvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **easeeAccessControlModelsSitePermissionRequestDTO** | [**EaseeAccessControlModelsSitePermissionRequestDTO?**](EaseeAccessControlModelsSitePermissionRequestDTO?.md) | site permisssion reinvite request | [optional]  |

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

<a name="apisitessiteidrequestaccesspost"></a>
# **ApiSitesSiteIdRequestAccessPost**
> void ApiSitesSiteIdRequestAccessPost (int siteId, int? body = null)

Request site access by logged in user(installer)

Request site access by logged in user(installer) and send email to the site owner.  Rate limited at max 5 request per 30 minutes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdRequestAccessPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var body = 56;  // int? | Site permission (allowed only admin or user) (optional) 

            try
            {
                // Request site access by logged in user(installer)
                apiInstance.ApiSitesSiteIdRequestAccessPost(siteId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdRequestAccessPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdRequestAccessPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request site access by logged in user(installer)
    apiInstance.ApiSitesSiteIdRequestAccessPostWithHttpInfo(siteId, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdRequestAccessPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **body** | **int?** | Site permission (allowed only admin or user) | [optional]  |

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

<a name="apisitessiteidsitegroupsget"></a>
# **ApiSitesSiteIdSiteGroupsGet**
> List&lt;EaseePartnersDomainEntitiesPartnerSiteGroup&gt; ApiSitesSiteIdSiteGroupsGet (int siteId)

Site Groups

Get site groups for a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdSiteGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | 

            try
            {
                // Site Groups
                List<EaseePartnersDomainEntitiesPartnerSiteGroup> result = apiInstance.ApiSitesSiteIdSiteGroupsGet(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdSiteGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdSiteGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Site Groups
    ApiResponse<List<EaseePartnersDomainEntitiesPartnerSiteGroup>> response = apiInstance.ApiSitesSiteIdSiteGroupsGetWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdSiteGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** |  |  |

### Return type

[**List&lt;EaseePartnersDomainEntitiesPartnerSiteGroup&gt;**](EaseePartnersDomainEntitiesPartnerSiteGroup.md)

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

<a name="apisitessiteidusersget"></a>
# **ApiSitesSiteIdUsersGet**
> EaseeUserAdministrationDomainDTOSitePermissionDTO ApiSitesSiteIdUsersGet (int siteId)

Users

Get all users for a site with permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdUsersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID

            try
            {
                // Users
                EaseeUserAdministrationDomainDTOSitePermissionDTO result = apiInstance.ApiSitesSiteIdUsersGet(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdUsersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdUsersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Users
    ApiResponse<EaseeUserAdministrationDomainDTOSitePermissionDTO> response = apiInstance.ApiSitesSiteIdUsersGetWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdUsersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |

### Return type

[**EaseeUserAdministrationDomainDTOSitePermissionDTO**](EaseeUserAdministrationDomainDTOSitePermissionDTO.md)

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

<a name="apisitessiteidusersuseridmonthlyget"></a>
# **ApiSitesSiteIdUsersUserIdMonthlyGet**
> List&lt;EaseeCoreDTOsSessionMonthlySessionSummaryDTO&gt; ApiSitesSiteIdUsersUserIdMonthlyGet (int siteId, int userId)

Charger Usage, All Chargers - Monthly

Get monthly charger power usage for a user on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdUsersUserIdMonthlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var userId = 56;  // int | User ID

            try
            {
                // Charger Usage, All Chargers - Monthly
                List<EaseeCoreDTOsSessionMonthlySessionSummaryDTO> result = apiInstance.ApiSitesSiteIdUsersUserIdMonthlyGet(siteId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdUsersUserIdMonthlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdUsersUserIdMonthlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Usage, All Chargers - Monthly
    ApiResponse<List<EaseeCoreDTOsSessionMonthlySessionSummaryDTO>> response = apiInstance.ApiSitesSiteIdUsersUserIdMonthlyGetWithHttpInfo(siteId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdUsersUserIdMonthlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **userId** | **int** | User ID |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionMonthlySessionSummaryDTO&gt;**](EaseeCoreDTOsSessionMonthlySessionSummaryDTO.md)

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

<a name="apisitessiteidusersuseridyearlyget"></a>
# **ApiSitesSiteIdUsersUserIdYearlyGet**
> List&lt;EaseeCoreDTOsSessionYearlySessionSummaryDTO&gt; ApiSitesSiteIdUsersUserIdYearlyGet (int siteId, int userId)

Charger Usage, All Chargers - Yearly

Get yearly charger power usage for a user on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdUsersUserIdYearlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var userId = 56;  // int | User ID

            try
            {
                // Charger Usage, All Chargers - Yearly
                List<EaseeCoreDTOsSessionYearlySessionSummaryDTO> result = apiInstance.ApiSitesSiteIdUsersUserIdYearlyGet(siteId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdUsersUserIdYearlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdUsersUserIdYearlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Charger Usage, All Chargers - Yearly
    ApiResponse<List<EaseeCoreDTOsSessionYearlySessionSummaryDTO>> response = apiInstance.ApiSitesSiteIdUsersUserIdYearlyGetWithHttpInfo(siteId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdUsersUserIdYearlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **userId** | **int** | User ID |  |

### Return type

[**List&lt;EaseeCoreDTOsSessionYearlySessionSummaryDTO&gt;**](EaseeCoreDTOsSessionYearlySessionSummaryDTO.md)

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

<a name="apisitessiteidweeklyget"></a>
# **ApiSitesSiteIdWeeklyGet**
> List&lt;EaseeCoreDTOsSessionWeeklySummaryDTO&gt; ApiSitesSiteIdWeeklyGet (int siteId)

Power Usage/Cost - Weekly

Get weekly power usage and cost for charging sessions on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdWeeklyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site Id

            try
            {
                // Power Usage/Cost - Weekly
                List<EaseeCoreDTOsSessionWeeklySummaryDTO> result = apiInstance.ApiSitesSiteIdWeeklyGet(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdWeeklyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdWeeklyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Power Usage/Cost - Weekly
    ApiResponse<List<EaseeCoreDTOsSessionWeeklySummaryDTO>> response = apiInstance.ApiSitesSiteIdWeeklyGetWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdWeeklyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site Id |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisitessiteidyearlyget"></a>
# **ApiSitesSiteIdYearlyGet**
> List&lt;EaseeCoreDTOsSessionYearlySummaryDTO&gt; ApiSitesSiteIdYearlyGet (int siteId)

Usage/Cost - Yearly

Get yearly power usage and cost for charging sessions on a site.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class ApiSitesSiteIdYearlyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID

            try
            {
                // Usage/Cost - Yearly
                List<EaseeCoreDTOsSessionYearlySummaryDTO> result = apiInstance.ApiSitesSiteIdYearlyGet(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdYearlyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSitesSiteIdYearlyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Usage/Cost - Yearly
    ApiResponse<List<EaseeCoreDTOsSessionYearlySummaryDTO>> response = apiInstance.ApiSitesSiteIdYearlyGetWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.ApiSitesSiteIdYearlyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsitebyid"></a>
# **GetSiteById**
> EaseeCoreDTOsSiteDetailSiteDTO GetSiteById (int siteId, bool? detailed = null)

Get Site

Get a site by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class GetSiteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site ID
            var detailed = true;  // bool? | Whether to include site details (optional)  (default to true)

            try
            {
                // Get Site
                EaseeCoreDTOsSiteDetailSiteDTO result = apiInstance.GetSiteById(siteId, detailed);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.GetSiteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSiteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Site
    ApiResponse<EaseeCoreDTOsSiteDetailSiteDTO> response = apiInstance.GetSiteByIdWithHttpInfo(siteId, detailed);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.GetSiteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site ID |  |
| **detailed** | **bool?** | Whether to include site details | [optional] [default to true] |

### Return type

[**EaseeCoreDTOsSiteDetailSiteDTO**](EaseeCoreDTOsSiteDetailSiteDTO.md)

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

<a name="getsitestate"></a>
# **GetSiteState**
> EaseeCoreDTOsDashboardDashboardStateDTO GetSiteState (int siteId)

Dashboard Circuit States

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.EaseeClient.Api;
using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Model;

namespace Example
{
    public class GetSiteStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.easee.cloud";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SiteApi(config);
            var siteId = 56;  // int | Site identifier.

            try
            {
                // Dashboard Circuit States
                EaseeCoreDTOsDashboardDashboardStateDTO result = apiInstance.GetSiteState(siteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteApi.GetSiteState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSiteStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dashboard Circuit States
    ApiResponse<EaseeCoreDTOsDashboardDashboardStateDTO> response = apiInstance.GetSiteStateWithHttpInfo(siteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteApi.GetSiteStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **int** | Site identifier. |  |

### Return type

[**EaseeCoreDTOsDashboardDashboardStateDTO**](EaseeCoreDTOsDashboardDashboardStateDTO.md)

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

