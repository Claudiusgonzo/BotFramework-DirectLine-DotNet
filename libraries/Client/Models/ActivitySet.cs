﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.

// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.DirectLine
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A collection of activities
    /// </summary>
    public partial class ActivitySet
    {
        /// <summary>
        /// Initializes a new instance of the ActivitySet class.
        /// </summary>
        public ActivitySet() { }

        /// <summary>
        /// Initializes a new instance of the ActivitySet class.
        /// </summary>
        public ActivitySet(IList<Activity> activities = default(IList<Activity>), string watermark = default(string))
        {
            Activities = activities;
            Watermark = watermark;
        }

        /// <summary>
        /// Activities
        /// </summary>
        [JsonProperty(PropertyName = "activities")]
        public IList<Activity> Activities { get; set; }

        /// <summary>
        /// Maximum watermark of activities within this set
        /// </summary>
        [JsonProperty(PropertyName = "watermark")]
        public string Watermark { get; set; }

    }
}
