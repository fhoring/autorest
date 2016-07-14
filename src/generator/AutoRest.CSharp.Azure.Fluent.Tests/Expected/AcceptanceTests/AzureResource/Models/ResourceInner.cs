// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureResource.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Some resource
    /// <see href="http://tempuri.org" />
    /// </summary>
    public partial class ResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourceInner class.
        /// </summary>
        public ResourceInner() { }

        /// <summary>
        /// Initializes a new instance of the ResourceInner class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="name">Resource Name</param>
        public ResourceInner(string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string name = default(string))
        {
            Id = id;
            Type = type;
            Tags = tags;
            Location = location;
            Name = name;
        }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets resource Location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

    }
}
