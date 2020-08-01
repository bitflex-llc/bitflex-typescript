/* 
 * BITFLEX Public API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing TradingViewUdfApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TradingViewUdfApiTests : IDisposable
    {
        private TradingViewUdfApi instance;

        public TradingViewUdfApiTests()
        {
            instance = new TradingViewUdfApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TradingViewUdfApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TradingViewUdfApi
            //Assert.IsType(typeof(TradingViewUdfApi), instance, "instance is a TradingViewUdfApi");
        }

        
        /// <summary>
        /// Test ApiTradingViewUdfConfigGet
        /// </summary>
        [Fact]
        public void ApiTradingViewUdfConfigGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ApiTradingViewUdfConfigGet();
            
        }
        
        /// <summary>
        /// Test ApiTradingViewUdfHistoryGet
        /// </summary>
        [Fact]
        public void ApiTradingViewUdfHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? from = null;
            //long? to = null;
            //string symbol = null;
            //instance.ApiTradingViewUdfHistoryGet(from, to, symbol);
            
        }
        
        /// <summary>
        /// Test ApiTradingViewUdfSymbolsGet
        /// </summary>
        [Fact]
        public void ApiTradingViewUdfSymbolsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //instance.ApiTradingViewUdfSymbolsGet(symbol);
            
        }
        
        /// <summary>
        /// Test ApiTradingViewUdfTimeGet
        /// </summary>
        [Fact]
        public void ApiTradingViewUdfTimeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ApiTradingViewUdfTimeGet();
            
        }
        
    }

}