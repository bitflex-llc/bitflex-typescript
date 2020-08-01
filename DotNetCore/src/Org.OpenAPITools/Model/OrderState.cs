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
    /// Defines OrderState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrderState
    {
        /// <summary>
        /// Enum WaitingForActivation for value: WaitingForActivation
        /// </summary>
        [EnumMember(Value = "WaitingForActivation")]
        WaitingForActivation = 1,

        /// <summary>
        /// Enum OnMarket for value: OnMarket
        /// </summary>
        [EnumMember(Value = "OnMarket")]
        OnMarket = 2,

        /// <summary>
        /// Enum PartiallyFilled for value: PartiallyFilled
        /// </summary>
        [EnumMember(Value = "PartiallyFilled")]
        PartiallyFilled = 3,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 4,

        /// <summary>
        /// Enum Rejected for value: Rejected
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected = 5,

        /// <summary>
        /// Enum CloseFilled for value: Close_Filled
        /// </summary>
        [EnumMember(Value = "Close_Filled")]
        CloseFilled = 6,

        /// <summary>
        /// Enum CancelledByUser for value: Cancelled_ByUser
        /// </summary>
        [EnumMember(Value = "Cancelled_ByUser")]
        CancelledByUser = 7,

        /// <summary>
        /// Enum CloseMarginCall for value: Close_MarginCall
        /// </summary>
        [EnumMember(Value = "Close_MarginCall")]
        CloseMarginCall = 8

    }

}
