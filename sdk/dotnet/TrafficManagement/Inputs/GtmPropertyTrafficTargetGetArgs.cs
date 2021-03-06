// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Akamai.TrafficManagement.Inputs
{

    public sealed class GtmPropertyTrafficTargetGetArgs : Pulumi.ResourceArgs
    {
        [Input("datacenterId")]
        public Input<int>? DatacenterId { get; set; }

        /// <summary>
        /// — (Boolean)
        /// * `weight`
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("handoutCname")]
        public Input<string>? HandoutCname { get; set; }

        /// <summary>
        /// — Liveness test name
        /// * `test_interval`
        /// * `test_object_protocol`
        /// * `test_timeout`
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("servers")]
        private InputList<string>? _servers;

        /// <summary>
        /// — (List)
        /// </summary>
        public InputList<string> Servers
        {
            get => _servers ?? (_servers = new InputList<string>());
            set => _servers = value;
        }

        [Input("weight")]
        public Input<double>? Weight { get; set; }

        public GtmPropertyTrafficTargetGetArgs()
        {
        }
    }
}
