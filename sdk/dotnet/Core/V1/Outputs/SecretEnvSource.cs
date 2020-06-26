// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    [OutputType]
    public sealed class SecretEnvSource
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specify whether the Secret must be defined
        /// </summary>
        public readonly bool Optional;

        [OutputConstructor]
        private SecretEnvSource(
            string name,

            bool optional)
        {
            Name = name;
            Optional = optional;
        }
    }
}