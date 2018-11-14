// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum EmailSyncDuration.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EmailSyncDuration
    {
    
        /// <summary>
        /// user Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// one Day
        /// </summary>
        OneDay = 1,
	
        /// <summary>
        /// three Days
        /// </summary>
        ThreeDays = 2,
	
        /// <summary>
        /// one Week
        /// </summary>
        OneWeek = 3,
	
        /// <summary>
        /// two Weeks
        /// </summary>
        TwoWeeks = 4,
	
        /// <summary>
        /// one Month
        /// </summary>
        OneMonth = 5,
	
        /// <summary>
        /// unlimited
        /// </summary>
        Unlimited = 6,
	
    }
}