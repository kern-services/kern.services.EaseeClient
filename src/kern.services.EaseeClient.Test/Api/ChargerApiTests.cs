/*
 * Easee Cloud API
 *
 * Find more information and documentation at <br/> <a href='https://developer.easee.cloud'>https://developer.easee.cloud</a>
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using kern.services.EaseeClient.Client;
using kern.services.EaseeClient.Api;
// uncomment below to import models
//using kern.services.EaseeClient.Model;

namespace kern.services.EaseeClient.Test.Api
{
    /// <summary>
    ///  Class for testing ChargerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChargerApiTests : IDisposable
    {
        private ChargerApi instance;

        public ChargerApiTests()
        {
            instance = new ChargerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChargerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ChargerApi
            //Assert.IsType<ChargerApi>(instance);
        }

        /// <summary>
        /// Test ApiChargersAcceptPost
        /// </summary>
        [Fact]
        public void ApiChargersAcceptPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? email = null;
            //string? invitationId = null;
            //instance.ApiChargersAcceptPost(email, invitationId);
        }

        /// <summary>
        /// Test ApiChargersGet
        /// </summary>
        [Fact]
        public void ApiChargersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiChargersGet();
            //Assert.IsType<List<EaseeCoreDTOsChargerBasicChargerDTO>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdAccessDelete
        /// </summary>
        [Fact]
        public void ApiChargersIdAccessDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdAccessDelete(id);
        }

        /// <summary>
        /// Test ApiChargersIdAccessPut
        /// </summary>
        [Fact]
        public void ApiChargersIdAccessPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? body = null;
            //instance.ApiChargersIdAccessPut(id, body);
        }

        /// <summary>
        /// Test ApiChargersIdBasicChargePlanDelete
        /// </summary>
        [Fact]
        public void ApiChargersIdBasicChargePlanDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdBasicChargePlanDelete(id);
        }

        /// <summary>
        /// Test ApiChargersIdBasicChargePlanGet
        /// </summary>
        [Fact]
        public void ApiChargersIdBasicChargePlanGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdBasicChargePlanGet(id);
            //Assert.IsType<List<EaseeCoreDTOsChargerChargePlanDTO>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdBasicChargePlanPost
        /// </summary>
        [Fact]
        public void ApiChargersIdBasicChargePlanPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsChargerChargePlanDTO? easeeCoreDTOsChargerChargePlanDTO = null;
            //instance.ApiChargersIdBasicChargePlanPost(id, easeeCoreDTOsChargerChargePlanDTO);
        }

        /// <summary>
        /// Test ApiChargersIdChargeScheduleFeaturesPost
        /// </summary>
        [Fact]
        public void ApiChargersIdChargeScheduleFeaturesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsScheduleScheduleFeatureRequestDto? easeeCoreDTOsScheduleScheduleFeatureRequestDto = null;
            //instance.ApiChargersIdChargeScheduleFeaturesPost(id, easeeCoreDTOsScheduleScheduleFeatureRequestDto);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsLockStatePost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsLockStatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsChargerLockStateDTO? easeeCoreDTOsChargerLockStateDTO = null;
            //instance.ApiChargersIdCommandsLockStatePost(id, easeeCoreDTOsChargerLockStateDTO);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsOverrideSchedulePost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsOverrideSchedulePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsOverrideSchedulePost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsPauseChargingPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsPauseChargingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsPauseChargingPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsPollChargeropmodePost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsPollChargeropmodePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsPollChargeropmodePost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsPollLifetimeenergyPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsPollLifetimeenergyPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsPollLifetimeenergyPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsRebootPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsRebootPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsRebootPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsResumeChargingPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsResumeChargingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsResumeChargingPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsScanWifiPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsScanWifiPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsChargerScanWifiSettingDTO? easeeCoreDTOsChargerScanWifiSettingDTO = null;
            //instance.ApiChargersIdCommandsScanWifiPost(id, easeeCoreDTOsChargerScanWifiSettingDTO);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsSetRfidPairingModeAsyncPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsSetRfidPairingModeAsyncPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsChargerPairRFIDSettingsDTO? easeeCoreDTOsChargerPairRFIDSettingsDTO = null;
            //instance.ApiChargersIdCommandsSetRfidPairingModeAsyncPost(id, easeeCoreDTOsChargerPairRFIDSettingsDTO);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsSetWifiConfigPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsSetWifiConfigPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsChargerWifiConfigDTO? easeeCoreDTOsChargerWifiConfigDTO = null;
            //instance.ApiChargersIdCommandsSetWifiConfigPost(id, easeeCoreDTOsChargerWifiConfigDTO);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsSmartChargingPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsSmartChargingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsSmartChargingPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsStartChargingPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsStartChargingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsStartChargingPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsStopChargingPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsStopChargingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsStopChargingPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsToggleChargingPost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsToggleChargingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsToggleChargingPost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommandsUpdateFirmwarePost
        /// </summary>
        [Fact]
        public void ApiChargersIdCommandsUpdateFirmwarePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdCommandsUpdateFirmwarePost(id);
        }

        /// <summary>
        /// Test ApiChargersIdCommentsGet
        /// </summary>
        [Fact]
        public void ApiChargersIdCommentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdCommentsGet(id);
            //Assert.IsType<List<EaseeCoreDTOsChargerCommentDTO>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdConfigGet
        /// </summary>
        [Fact]
        public void ApiChargersIdConfigGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdConfigGet(id);
            //Assert.IsType<EaseeCoreDTOsChargerChargerConfigurationDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdDetailsGet
        /// </summary>
        [Fact]
        public void ApiChargersIdDetailsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdDetailsGet(id);
            //Assert.IsType<EaseeCoreDTOsChargerChargerInfoDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdErrorsFromToGet
        /// </summary>
        [Fact]
        public void ApiChargersIdErrorsFromToGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DateTime from = null;
            //DateTime to = null;
            //var response = instance.ApiChargersIdErrorsFromToGet(id, from, to);
            //Assert.IsType<List<MasterloopCoreTypesObservationsObservation>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdGet
        /// </summary>
        [Fact]
        public void ApiChargersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdGet(id);
            //Assert.IsType<EaseeCoreDTOsChargerChargerDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdLogEventsLogTypeFromToGet
        /// </summary>
        [Fact]
        public void ApiChargersIdLogEventsLogTypeFromToGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreEnumsLogType logType = null;
            //DateTime from = null;
            //DateTime to = null;
            //var response = instance.ApiChargersIdLogEventsLogTypeFromToGet(id, logType, from, to);
            //Assert.IsType<List<EaseeCoreDTOsChargerChargerLogEventDTO>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdObservationsObservationIdFromToGet
        /// </summary>
        [Fact]
        public void ApiChargersIdObservationsObservationIdFromToGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int observationId = null;
            //DateTime from = null;
            //DateTime to = null;
            //var response = instance.ApiChargersIdObservationsObservationIdFromToGet(id, observationId, from, to);
            //Assert.IsType<List<MasterloopCoreTypesObservationsObservation>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdPairPost
        /// </summary>
        [Fact]
        public void ApiChargersIdPairPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? pinCode = null;
            //instance.ApiChargersIdPairPost(id, pinCode);
        }

        /// <summary>
        /// Test ApiChargersIdPartnersGet
        /// </summary>
        [Fact]
        public void ApiChargersIdPartnersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdPartnersGet(id);
            //Assert.IsType<EaseeAccessControlModelsPartnerDetailedDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdPartnersPartnerIdDelete
        /// </summary>
        [Fact]
        public void ApiChargersIdPartnersPartnerIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int partnerId = null;
            //instance.ApiChargersIdPartnersPartnerIdDelete(id, partnerId);
        }

        /// <summary>
        /// Test ApiChargersIdPartnersPost
        /// </summary>
        [Fact]
        public void ApiChargersIdPartnersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeAccessControlModelsPairChargerPartnerDTO? easeeAccessControlModelsPairChargerPartnerDTO = null;
            //instance.ApiChargersIdPartnersPost(id, easeeAccessControlModelsPairChargerPartnerDTO);
        }

        /// <summary>
        /// Test ApiChargersIdPermissionDelete
        /// </summary>
        [Fact]
        public void ApiChargersIdPermissionDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? phoneNo = null;
            //string? email = null;
            //instance.ApiChargersIdPermissionDelete(id, phoneNo, email);
        }

        /// <summary>
        /// Test ApiChargersIdPermissionGet
        /// </summary>
        [Fact]
        public void ApiChargersIdPermissionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdPermissionGet(id);
            //Assert.IsType<List<EaseeAccessControlDomainDTOUserChargerDTO>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdPermissionPost
        /// </summary>
        [Fact]
        public void ApiChargersIdPermissionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeAccessControlModelsChargerPermissionRequestDTO? easeeAccessControlModelsChargerPermissionRequestDTO = null;
            //instance.ApiChargersIdPermissionPost(id, easeeAccessControlModelsChargerPermissionRequestDTO);
        }

        /// <summary>
        /// Test ApiChargersIdSessionsLatestGet
        /// </summary>
        [Fact]
        public void ApiChargersIdSessionsLatestGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdSessionsLatestGet(id);
            //Assert.IsType<EaseeCoreDTOsChargerUsageStatisticsDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdSessionsOngoingGet
        /// </summary>
        [Fact]
        public void ApiChargersIdSessionsOngoingGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdSessionsOngoingGet(id);
            //Assert.IsType<EaseeCoreDTOsChargerUsageStatisticsDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdSettingsPost
        /// </summary>
        [Fact]
        public void ApiChargersIdSettingsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsChargerChargerSettingDTO easeeCoreDTOsChargerChargerSettingDTO = null;
            //instance.ApiChargersIdSettingsPost(id, easeeCoreDTOsChargerChargerSettingDTO);
        }

        /// <summary>
        /// Test ApiChargersIdSiteGet
        /// </summary>
        [Fact]
        public void ApiChargersIdSiteGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdSiteGet(id);
            //Assert.IsType<EaseeSiteStructureDomainPortsSiteDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdStateGet
        /// </summary>
        [Fact]
        public void ApiChargersIdStateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdStateGet(id);
            //Assert.IsType<EaseeCoreDTOsChargerChargerStateDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdUnpairPost
        /// </summary>
        [Fact]
        public void ApiChargersIdUnpairPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? pinCode = null;
            //instance.ApiChargersIdUnpairPost(id, pinCode);
        }

        /// <summary>
        /// Test ApiChargersIdUsageHourlyFromToGet
        /// </summary>
        [Fact]
        public void ApiChargersIdUsageHourlyFromToGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DateTime from = null;
            //DateTime to = null;
            //var response = instance.ApiChargersIdUsageHourlyFromToGet(id, from, to);
            //Assert.IsType<List<EaseeCoreDTOsSessionAggregatedUsageDTO>>(response);
        }

        /// <summary>
        /// Test ApiChargersIdWeeklyChargePlanDelete
        /// </summary>
        [Fact]
        public void ApiChargersIdWeeklyChargePlanDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiChargersIdWeeklyChargePlanDelete(id);
        }

        /// <summary>
        /// Test ApiChargersIdWeeklyChargePlanGet
        /// </summary>
        [Fact]
        public void ApiChargersIdWeeklyChargePlanGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiChargersIdWeeklyChargePlanGet(id);
            //Assert.IsType<EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO>(response);
        }

        /// <summary>
        /// Test ApiChargersIdWeeklyChargePlanPost
        /// </summary>
        [Fact]
        public void ApiChargersIdWeeklyChargePlanPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EaseeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO? easeeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO = null;
            //instance.ApiChargersIdWeeklyChargePlanPost(id, easeeCoreDTOsScheduleWeeklyChargeScheduleRequestDTO);
        }
    }
}
