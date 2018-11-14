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
    /// The type SynchronizationStatus.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SynchronizationStatus
    {

        /// <summary>
        /// Gets or sets countSuccessiveCompleteFailures.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countSuccessiveCompleteFailures", Required = Newtonsoft.Json.Required.Default)]
        public Int64? CountSuccessiveCompleteFailures { get; set; }
    
        /// <summary>
        /// Gets or sets escrowsPruned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "escrowsPruned", Required = Newtonsoft.Json.Required.Default)]
        public bool? EscrowsPruned { get; set; }
    
        /// <summary>
        /// Gets or sets code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "code", Required = Newtonsoft.Json.Required.Default)]
        public SynchronizationStatusCode? Code { get; set; }
    
        /// <summary>
        /// Gets or sets lastExecution.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastExecution", Required = Newtonsoft.Json.Required.Default)]
        public SynchronizationTaskExecution LastExecution { get; set; }
    
        /// <summary>
        /// Gets or sets lastSuccessfulExecution.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSuccessfulExecution", Required = Newtonsoft.Json.Required.Default)]
        public SynchronizationTaskExecution LastSuccessfulExecution { get; set; }
    
        /// <summary>
        /// Gets or sets lastSuccessfulExecutionWithExports.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSuccessfulExecutionWithExports", Required = Newtonsoft.Json.Required.Default)]
        public SynchronizationTaskExecution LastSuccessfulExecutionWithExports { get; set; }
    
        /// <summary>
        /// Gets or sets progress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "progress", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SynchronizationProgress> Progress { get; set; }
    
        /// <summary>
        /// Gets or sets quarantine.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quarantine", Required = Newtonsoft.Json.Required.Default)]
        public SynchronizationQuarantine Quarantine { get; set; }
    
        /// <summary>
        /// Gets or sets steadyStateFirstAchievedTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "steadyStateFirstAchievedTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? SteadyStateFirstAchievedTime { get; set; }
    
        /// <summary>
        /// Gets or sets steadyStateLastAchievedTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "steadyStateLastAchievedTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? SteadyStateLastAchievedTime { get; set; }
    
        /// <summary>
        /// Gets or sets synchronizedEntryCountByType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "synchronizedEntryCountByType", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<StringKeyLongValuePair> SynchronizedEntryCountByType { get; set; }
    
        /// <summary>
        /// Gets or sets troubleshootingUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "troubleshootingUrl", Required = Newtonsoft.Json.Required.Default)]
        public string TroubleshootingUrl { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}