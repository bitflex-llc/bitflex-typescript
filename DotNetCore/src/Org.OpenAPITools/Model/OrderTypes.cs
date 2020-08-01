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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines OrderTypes
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrderTypes
    {
        /// <summary>
        /// Enum Market for value: Market
        /// </summary>
        [EnumMember(Value = "Market")]
        Market = 1,

        /// <summary>
        /// Enum Limit for value: Limit
        /// </summary>
        [EnumMember(Value = "Limit")]
        Limit = 2,

        /// <summary>
        /// Enum StopLossLimit for value: StopLossLimit
        /// </summary>
        [EnumMember(Value = "StopLossLimit")]
        StopLossLimit = 3,

        /// <summary>
        /// Enum TakeProfitLimit for value: TakeProfitLimit
        /// </summary>
        [EnumMember(Value = "TakeProfitLimit")]
        TakeProfitLimit = 4,

        /// <summary>
        /// Enum StopLossMarket for value: StopLossMarket
        /// </summary>
        [EnumMember(Value = "StopLossMarket")]
        StopLossMarket = 5,

        /// <summary>
        /// Enum OCO for value: OCO
        /// </summary>
        [EnumMember(Value = "OCO")]
        OCO = 6

    }

}