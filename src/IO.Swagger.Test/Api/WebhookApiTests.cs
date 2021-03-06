/* 
 * Reepay API
 *
 * REST API to manage Reepay resources
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing WebhookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WebhookApiTests
    {
        private WebhookApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WebhookApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebhookApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WebhookApi
            //Assert.IsInstanceOfType(typeof(WebhookApi), instance, "instance is a WebhookApi");
        }

        
        /// <summary>
        /// Test DisableWebhooks
        /// </summary>
        [Test]
        public void DisableWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhookDisableRequest body = null;
            //var response = instance.DisableWebhooks(body);
            //Assert.IsInstanceOf<List<Webhook>> (response, "response is List<Webhook>");
        }
        
        /// <summary>
        /// Test GetWebhook
        /// </summary>
        [Test]
        public void GetWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetWebhook(id);
            //Assert.IsInstanceOf<List<Webhook>> (response, "response is List<Webhook>");
        }
        
        /// <summary>
        /// Test GetWebhookRequests
        /// </summary>
        [Test]
        public void GetWebhookRequestsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetWebhookRequests(id);
            //Assert.IsInstanceOf<List<WebhookRequest>> (response, "response is List<WebhookRequest>");
        }
        
        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Test]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string createdBefore = null;
            //int? size = null;
            //string state = null;
            //var response = instance.GetWebhooks(createdBefore, size, state);
            //Assert.IsInstanceOf<List<Webhook>> (response, "response is List<Webhook>");
        }
        
        /// <summary>
        /// Test ResendJson
        /// </summary>
        [Test]
        public void ResendJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhookResendRequest body = null;
            //var response = instance.ResendJson(body);
            //Assert.IsInstanceOf<List<Webhook>> (response, "response is List<Webhook>");
        }
        
        /// <summary>
        /// Test UpdateWebhooks
        /// </summary>
        [Test]
        public void UpdateWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhookUpdateRequest body = null;
            //var response = instance.UpdateWebhooks(body);
            //Assert.IsInstanceOf<List<Webhook>> (response, "response is List<Webhook>");
        }
        
    }

}
