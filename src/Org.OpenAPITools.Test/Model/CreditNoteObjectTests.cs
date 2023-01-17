/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: tech@getlago.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing CreditNoteObject
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreditNoteObjectTests
    {
        // TODO uncomment below to declare an instance variable for CreditNoteObject
        //private CreditNoteObject instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreditNoteObject
            //instance = new CreditNoteObject();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreditNoteObject
        /// </summary>
        [Test]
        public void CreditNoteObjectInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" CreditNoteObject
            //Assert.IsInstanceOf(typeof(CreditNoteObject), instance);
        }


        /// <summary>
        /// Test the property 'LagoId'
        /// </summary>
        [Test]
        public void LagoIdTest()
        {
            // TODO unit test for the property 'LagoId'
        }
        /// <summary>
        /// Test the property 'SequentialId'
        /// </summary>
        [Test]
        public void SequentialIdTest()
        {
            // TODO unit test for the property 'SequentialId'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'LagoInvoiceId'
        /// </summary>
        [Test]
        public void LagoInvoiceIdTest()
        {
            // TODO unit test for the property 'LagoInvoiceId'
        }
        /// <summary>
        /// Test the property 'InvoiceNumber'
        /// </summary>
        [Test]
        public void InvoiceNumberTest()
        {
            // TODO unit test for the property 'InvoiceNumber'
        }
        /// <summary>
        /// Test the property 'IssuingDate'
        /// </summary>
        [Test]
        public void IssuingDateTest()
        {
            // TODO unit test for the property 'IssuingDate'
        }
        /// <summary>
        /// Test the property 'CreditStatus'
        /// </summary>
        [Test]
        public void CreditStatusTest()
        {
            // TODO unit test for the property 'CreditStatus'
        }
        /// <summary>
        /// Test the property 'RefundStatus'
        /// </summary>
        [Test]
        public void RefundStatusTest()
        {
            // TODO unit test for the property 'RefundStatus'
        }
        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Test]
        public void ReasonTest()
        {
            // TODO unit test for the property 'Reason'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'TotalAmountCents'
        /// </summary>
        [Test]
        public void TotalAmountCentsTest()
        {
            // TODO unit test for the property 'TotalAmountCents'
        }
        /// <summary>
        /// Test the property 'TotalAmountCurrency'
        /// </summary>
        [Test]
        public void TotalAmountCurrencyTest()
        {
            // TODO unit test for the property 'TotalAmountCurrency'
        }
        /// <summary>
        /// Test the property 'VatAmountCents'
        /// </summary>
        [Test]
        public void VatAmountCentsTest()
        {
            // TODO unit test for the property 'VatAmountCents'
        }
        /// <summary>
        /// Test the property 'VatAmountCurrency'
        /// </summary>
        [Test]
        public void VatAmountCurrencyTest()
        {
            // TODO unit test for the property 'VatAmountCurrency'
        }
        /// <summary>
        /// Test the property 'SubTotalVatExcludedAmountCents'
        /// </summary>
        [Test]
        public void SubTotalVatExcludedAmountCentsTest()
        {
            // TODO unit test for the property 'SubTotalVatExcludedAmountCents'
        }
        /// <summary>
        /// Test the property 'SubTotalVatExcludedAmountCurrency'
        /// </summary>
        [Test]
        public void SubTotalVatExcludedAmountCurrencyTest()
        {
            // TODO unit test for the property 'SubTotalVatExcludedAmountCurrency'
        }
        /// <summary>
        /// Test the property 'BalanceAmountCents'
        /// </summary>
        [Test]
        public void BalanceAmountCentsTest()
        {
            // TODO unit test for the property 'BalanceAmountCents'
        }
        /// <summary>
        /// Test the property 'BalanceAmountCurrency'
        /// </summary>
        [Test]
        public void BalanceAmountCurrencyTest()
        {
            // TODO unit test for the property 'BalanceAmountCurrency'
        }
        /// <summary>
        /// Test the property 'CreditAmountCents'
        /// </summary>
        [Test]
        public void CreditAmountCentsTest()
        {
            // TODO unit test for the property 'CreditAmountCents'
        }
        /// <summary>
        /// Test the property 'CreditAmountCurrency'
        /// </summary>
        [Test]
        public void CreditAmountCurrencyTest()
        {
            // TODO unit test for the property 'CreditAmountCurrency'
        }
        /// <summary>
        /// Test the property 'RefundAmountCents'
        /// </summary>
        [Test]
        public void RefundAmountCentsTest()
        {
            // TODO unit test for the property 'RefundAmountCents'
        }
        /// <summary>
        /// Test the property 'RefundAmountCurrency'
        /// </summary>
        [Test]
        public void RefundAmountCurrencyTest()
        {
            // TODO unit test for the property 'RefundAmountCurrency'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'FileUrl'
        /// </summary>
        [Test]
        public void FileUrlTest()
        {
            // TODO unit test for the property 'FileUrl'
        }
        /// <summary>
        /// Test the property 'Customer'
        /// </summary>
        [Test]
        public void CustomerTest()
        {
            // TODO unit test for the property 'Customer'
        }
        /// <summary>
        /// Test the property 'Items'
        /// </summary>
        [Test]
        public void ItemsTest()
        {
            // TODO unit test for the property 'Items'
        }

    }

}