/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: tech@getlago.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing WalletsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WalletsApiTests
    {
        private WalletsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WalletsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WalletsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' WalletsApi
            //Assert.IsInstanceOf(typeof(WalletsApi), instance);
        }

        
        /// <summary>
        /// Test CreateWallet
        /// </summary>
        [Test]
        public void CreateWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WalletInput walletInput = null;
            //var response = instance.CreateWallet(walletInput);
            //Assert.IsInstanceOf(typeof(Wallet), response, "response is Wallet");
        }
        
        /// <summary>
        /// Test CreateWalletTransaction
        /// </summary>
        [Test]
        public void CreateWalletTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WalletTransactionInput walletTransactionInput = null;
            //var response = instance.CreateWalletTransaction(walletTransactionInput);
            //Assert.IsInstanceOf(typeof(WalletTransaction), response, "response is WalletTransaction");
        }
        
        /// <summary>
        /// Test DestroyWallet
        /// </summary>
        [Test]
        public void DestroyWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DestroyWallet(id);
            //Assert.IsInstanceOf(typeof(Wallet), response, "response is Wallet");
        }
        
        /// <summary>
        /// Test FindAllWallets
        /// </summary>
        [Test]
        public void FindAllWalletsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalCustomerId = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.FindAllWallets(externalCustomerId, page, perPage);
            //Assert.IsInstanceOf(typeof(Wallets), response, "response is Wallets");
        }
        
        /// <summary>
        /// Test FindWallet
        /// </summary>
        [Test]
        public void FindWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.FindWallet(id);
            //Assert.IsInstanceOf(typeof(Wallet), response, "response is Wallet");
        }
        
        /// <summary>
        /// Test UpdateWallet
        /// </summary>
        [Test]
        public void UpdateWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //WalletUpdateInput walletUpdateInput = null;
            //var response = instance.UpdateWallet(id, walletUpdateInput);
            //Assert.IsInstanceOf(typeof(Wallet), response, "response is Wallet");
        }
        
    }

}