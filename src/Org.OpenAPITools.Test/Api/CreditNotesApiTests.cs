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
    ///  Class for testing CreditNotesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CreditNotesApiTests
    {
        private CreditNotesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreditNotesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreditNotesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CreditNotesApi
            //Assert.IsInstanceOf(typeof(CreditNotesApi), instance);
        }

        
        /// <summary>
        /// Test CreateCreditNote
        /// </summary>
        [Test]
        public void CreateCreditNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreditNoteInput creditNoteInput = null;
            //var response = instance.CreateCreditNote(creditNoteInput);
            //Assert.IsInstanceOf(typeof(CreditNote), response, "response is CreditNote");
        }
        
        /// <summary>
        /// Test DownloadCreditNote
        /// </summary>
        [Test]
        public void DownloadCreditNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DownloadCreditNote(id);
            //Assert.IsInstanceOf(typeof(CreditNote), response, "response is CreditNote");
        }
        
        /// <summary>
        /// Test FindAllCreditNotes
        /// </summary>
        [Test]
        public void FindAllCreditNotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string externalCustomerId = null;
            //var response = instance.FindAllCreditNotes(page, perPage, externalCustomerId);
            //Assert.IsInstanceOf(typeof(CreditNotes), response, "response is CreditNotes");
        }
        
        /// <summary>
        /// Test FindCreditNote
        /// </summary>
        [Test]
        public void FindCreditNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.FindCreditNote(id);
            //Assert.IsInstanceOf(typeof(CreditNote), response, "response is CreditNote");
        }
        
        /// <summary>
        /// Test UpdateCreditNote
        /// </summary>
        [Test]
        public void UpdateCreditNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CreditNoteUpdateInput creditNoteUpdateInput = null;
            //var response = instance.UpdateCreditNote(id, creditNoteUpdateInput);
            //Assert.IsInstanceOf(typeof(CreditNote), response, "response is CreditNote");
        }
        
        /// <summary>
        /// Test VoidCreditNote
        /// </summary>
        [Test]
        public void VoidCreditNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.VoidCreditNote(id);
            //Assert.IsInstanceOf(typeof(CreditNote), response, "response is CreditNote");
        }
        
    }

}
