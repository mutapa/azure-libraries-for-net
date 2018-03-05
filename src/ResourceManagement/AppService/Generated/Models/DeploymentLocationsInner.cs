// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of available locations (regions or App Service Environments) for
    /// deployment of App Service resources.
    /// </summary>
    public partial class DeploymentLocationsInner
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentLocationsInner class.
        /// </summary>
        public DeploymentLocationsInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentLocationsInner class.
        /// </summary>
        /// <param name="locations">Available regions.</param>
        /// <param name="hostingEnvironments">Available App Service
        /// Environments with full descriptions of the environments.</param>
        /// <param name="hostingEnvironmentDeploymentInfos">Available App
        /// Service Environments with basic information.</param>
        public DeploymentLocationsInner(IList<GeoRegion> locations = default(IList<GeoRegion>), IList<AppServiceEnvironment> hostingEnvironments = default(IList<AppServiceEnvironment>), IList<HostingEnvironmentDeploymentInfo> hostingEnvironmentDeploymentInfos = default(IList<HostingEnvironmentDeploymentInfo>))
        {
            Locations = locations;
            HostingEnvironments = hostingEnvironments;
            HostingEnvironmentDeploymentInfos = hostingEnvironmentDeploymentInfos;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets available regions.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<GeoRegion> Locations { get; set; }

        /// <summary>
        /// Gets or sets available App Service Environments with full
        /// descriptions of the environments.
        /// </summary>
        [JsonProperty(PropertyName = "hostingEnvironments")]
        public IList<AppServiceEnvironment> HostingEnvironments { get; set; }

        /// <summary>
        /// Gets or sets available App Service Environments with basic
        /// information.
        /// </summary>
        [JsonProperty(PropertyName = "hostingEnvironmentDeploymentInfos")]
        public IList<HostingEnvironmentDeploymentInfo> HostingEnvironmentDeploymentInfos { get; set; }

    }
}