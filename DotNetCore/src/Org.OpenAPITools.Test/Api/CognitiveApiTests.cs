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
    ///  Class for testing CognitiveApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CognitiveApiTests : IDisposable
    {
        private CognitiveApi instance;

        public CognitiveApiTests()
        {
            instance = new CognitiveApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CognitiveApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CognitiveApi
            //Assert.IsType(typeof(CognitiveApi), instance, "instance is a CognitiveApi");
        }

        
        /// <summary>
        /// Test CognitiveSavefilePost
        /// </summary>
        [Fact]
        public void CognitiveSavefilePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string contentDisposition = null;
            //long? length = null;
            //string name = null;
            //string fileName = null;
            //var response = instance.CognitiveSavefilePost(contentType, contentDisposition, length, name, fileName);
            //Assert.IsType<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test CognitiveVerifyfacesPost
        /// </summary>
        [Fact]
        public void CognitiveVerifyfacesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object body = null;
            //var response = instance.CognitiveVerifyfacesPost(body);
            //Assert.IsType<string> (response, "response is string");
        }
        
    }

}
