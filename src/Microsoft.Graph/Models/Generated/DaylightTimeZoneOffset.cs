// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DaylightTimeZoneOffset.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DaylightTimeZoneOffset : StandardTimeZoneOffset
    {
    
        /// <summary>
        /// Gets or sets daylightBias.
        /// The time offset from Coordinated Universal Time (UTC) for daylight saving time. This value is in minutes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "daylightBias", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DaylightBias { get; set; }
    
    }
}
