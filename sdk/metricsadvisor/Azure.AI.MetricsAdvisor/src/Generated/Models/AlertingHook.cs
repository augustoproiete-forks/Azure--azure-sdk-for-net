// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The HookInfo. </summary>
    public partial class AlertingHook
    {

        /// <summary> Initializes a new instance of AlertingHook. </summary>
        /// <param name="hookType"> hook type. </param>
        /// <param name="id"> Hook unique id. </param>
        /// <param name="name"> hook unique name. </param>
        /// <param name="description"> hook description. </param>
        /// <param name="externalLink"> hook external link. </param>
        /// <param name="administrators"> hook administrators. </param>
        internal AlertingHook(HookType hookType, string id, string name, string description, string externalLink, IReadOnlyList<string> administrators)
        {
            HookType = hookType;
            Id = id;
            Name = name;
            Description = description;
            ExternalLink = externalLink;
            Administrators = administrators;
        }
    }
}
