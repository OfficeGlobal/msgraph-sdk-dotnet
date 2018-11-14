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
    /// The type WindowsKioskDesktopApp.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsKioskDesktopApp : WindowsKioskAppBase
    {

        /// <summary>
        /// Gets or sets path.
        /// Define the path of a desktop app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "path", Required = Newtonsoft.Json.Required.Default)]
        public string Path { get; set; }
    
        /// <summary>
        /// Gets or sets desktopApplicationId.
        /// Define the DesktopApplicationID of the app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "desktopApplicationId", Required = Newtonsoft.Json.Required.Default)]
        public string DesktopApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets desktopApplicationLinkPath.
        /// Define the DesktopApplicationLinkPath of the app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "desktopApplicationLinkPath", Required = Newtonsoft.Json.Required.Default)]
        public string DesktopApplicationLinkPath { get; set; }
    
    }
}