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
    ///  Class for testing AccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountApiTests : IDisposable
    {
        private AccountApi instance;

        public AccountApiTests()
        {
            instance = new AccountApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AccountApi
            //Assert.IsType<AccountApi>(instance);
        }

        /// <summary>
        /// Test ApiAccountsAccountIdInvalidateTokenDelete
        /// </summary>
        [Fact]
        public void ApiAccountsAccountIdInvalidateTokenDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int accountId = null;
            //string? token = null;
            //instance.ApiAccountsAccountIdInvalidateTokenDelete(accountId, token);
        }

        /// <summary>
        /// Test ApiAccountsChargersGet
        /// </summary>
        [Fact]
        public void ApiAccountsChargersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAccountsChargersGet();
            //Assert.IsType<List<EaseeAccessControlDomainDTOSiteDTO>>(response);
        }

        /// <summary>
        /// Test ApiAccountsChargersPost
        /// </summary>
        [Fact]
        public void ApiAccountsChargersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EaseeAccessControlModelsProductPinDTO? easeeAccessControlModelsProductPinDTO = null;
            //instance.ApiAccountsChargersPost(easeeAccessControlModelsProductPinDTO);
        }

        /// <summary>
        /// Test ApiAccountsChargersSerialNoDelete
        /// </summary>
        [Fact]
        public void ApiAccountsChargersSerialNoDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serialNo = null;
            //instance.ApiAccountsChargersSerialNoDelete(serialNo);
        }

        /// <summary>
        /// Test ApiAccountsLoginPost
        /// </summary>
        [Fact]
        public void ApiAccountsLoginPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EaseeAccessControlModelsLoginDto? easeeAccessControlModelsLoginDto = null;
            //var response = instance.ApiAccountsLoginPost(easeeAccessControlModelsLoginDto);
            //Assert.IsType<EaseeUserAdministrationDTOUserToken>(response);
        }

        /// <summary>
        /// Test ApiAccountsProductsGet
        /// </summary>
        [Fact]
        public void ApiAccountsProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = instance.ApiAccountsProductsGet(userId);
            //Assert.IsType<List<EaseeAccessControlDomainDTOSiteDTO>>(response);
        }

        /// <summary>
        /// Test ApiAccountsProfileGet
        /// </summary>
        [Fact]
        public void ApiAccountsProfileGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAccountsProfileGet();
            //Assert.IsType<EaseeCoreDTOsAccountProfileDTO>(response);
        }

        /// <summary>
        /// Test ApiAccountsRefreshTokenPost
        /// </summary>
        [Fact]
        public void ApiAccountsRefreshTokenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EaseeAccessControlModelsRefreshTokenDTO? easeeAccessControlModelsRefreshTokenDTO = null;
            //var response = instance.ApiAccountsRefreshTokenPost(easeeAccessControlModelsRefreshTokenDTO);
            //Assert.IsType<EaseeUserAdministrationDTOUserToken>(response);
        }
    }
}