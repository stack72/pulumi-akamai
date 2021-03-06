// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Akamai.TrafficManagement
{
    public static class GetGtmDefaultDatacenter
    {
        /// <summary>
        /// Use `akamai.TrafficManagement.getGtmDefaultDatacenter` data source to retrieve default datacenter id and nickname.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetGtmDefaultDatacenterResult> InvokeAsync(GetGtmDefaultDatacenterArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetGtmDefaultDatacenterResult>("akamai:TrafficManagement/getGtmDefaultDatacenter:getGtmDefaultDatacenter", args ?? new GetGtmDefaultDatacenterArgs(), options.WithVersion());
    }


    public sealed class GetGtmDefaultDatacenterArgs : Pulumi.InvokeArgs
    {
        [Input("datacenter")]
        public int? Datacenter { get; set; }

        /// <summary>
        /// — (Optional. Default 5400)
        /// </summary>
        [Input("domain", required: true)]
        public string Domain { get; set; } = null!;

        public GetGtmDefaultDatacenterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetGtmDefaultDatacenterResult
    {
        public readonly int? Datacenter;
        public readonly int DatacenterId;
        public readonly string Domain;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Nickname;

        [OutputConstructor]
        private GetGtmDefaultDatacenterResult(
            int? datacenter,

            int datacenterId,

            string domain,

            string id,

            string nickname)
        {
            Datacenter = datacenter;
            DatacenterId = datacenterId;
            Domain = domain;
            Id = id;
            Nickname = nickname;
        }
    }
}
