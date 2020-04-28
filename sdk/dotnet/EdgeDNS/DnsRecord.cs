// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Akamai.EdgeDNS
{
    /// <summary>
    /// The `akamai.EdgeDNS.DnsRecord` provides the resource for configuring a dns record to integrate easily with your existing DNS infrastructure to provide a secure, high performance, highly available and scalable solution for DNS hosting.
    /// </summary>
    public partial class DnsRecord : Pulumi.CustomResource
    {
        /// <summary>
        /// — (Required,Boolean) Whether the record is active.  
        /// </summary>
        [Output("active")]
        public Output<bool> Active { get; private set; } = null!;

        [Output("algorithm")]
        public Output<int?> Algorithm { get; private set; } = null!;

        [Output("digest")]
        public Output<string?> Digest { get; private set; } = null!;

        [Output("digestType")]
        public Output<int?> DigestType { get; private set; } = null!;

        [Output("expiration")]
        public Output<string?> Expiration { get; private set; } = null!;

        [Output("fingerprint")]
        public Output<string?> Fingerprint { get; private set; } = null!;

        [Output("fingerprintType")]
        public Output<int?> FingerprintType { get; private set; } = null!;

        [Output("flags")]
        public Output<int?> Flags { get; private set; } = null!;

        [Output("flagsnaptr")]
        public Output<string?> Flagsnaptr { get; private set; } = null!;

        [Output("hardware")]
        public Output<string?> Hardware { get; private set; } = null!;

        [Output("inception")]
        public Output<string?> Inception { get; private set; } = null!;

        [Output("iterations")]
        public Output<int?> Iterations { get; private set; } = null!;

        [Output("key")]
        public Output<string?> Key { get; private set; } = null!;

        [Output("keytag")]
        public Output<int?> Keytag { get; private set; } = null!;

        [Output("labels")]
        public Output<int?> Labels { get; private set; } = null!;

        [Output("mailbox")]
        public Output<string?> Mailbox { get; private set; } = null!;

        /// <summary>
        /// — (Required) The name of the record. The name is an owner name, that is, the name of the node to which this resource record pertains.  
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("nextHashedOwnerName")]
        public Output<string?> NextHashedOwnerName { get; private set; } = null!;

        [Output("order")]
        public Output<int?> Order { get; private set; } = null!;

        [Output("originalTtl")]
        public Output<int?> OriginalTtl { get; private set; } = null!;

        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        [Output("preference")]
        public Output<int?> Preference { get; private set; } = null!;

        [Output("priority")]
        public Output<int?> Priority { get; private set; } = null!;

        [Output("priorityIncrement")]
        public Output<int?> PriorityIncrement { get; private set; } = null!;

        [Output("protocol")]
        public Output<int?> Protocol { get; private set; } = null!;

        [Output("recordtype")]
        public Output<string> Recordtype { get; private set; } = null!;

        [Output("regexp")]
        public Output<string?> Regexp { get; private set; } = null!;

        [Output("replacement")]
        public Output<string?> Replacement { get; private set; } = null!;

        [Output("salt")]
        public Output<string?> Salt { get; private set; } = null!;

        [Output("service")]
        public Output<string?> Service { get; private set; } = null!;

        [Output("signature")]
        public Output<string?> Signature { get; private set; } = null!;

        [Output("signer")]
        public Output<string?> Signer { get; private set; } = null!;

        [Output("software")]
        public Output<string?> Software { get; private set; } = null!;

        [Output("subtype")]
        public Output<int?> Subtype { get; private set; } = null!;

        /// <summary>
        /// — (Required) A domain name that specifies the canonical or primary name for the owner. The owner name is an alias.  
        /// </summary>
        [Output("targets")]
        public Output<ImmutableArray<string>> Targets { get; private set; } = null!;

        /// <summary>
        /// — (Required,Boolean) The TTL is a 32-bit signed integer that specifies the time interval that the resource record may be cached before the source of the information should be consulted again. Zero values are interpreted to mean that the RR can only be used for the transaction in progress, and should not be cached. Zero values can also be used for extremely volatile data.  
        /// </summary>
        [Output("ttl")]
        public Output<int> Ttl { get; private set; } = null!;

        [Output("txt")]
        public Output<string?> Txt { get; private set; } = null!;

        [Output("typeBitmaps")]
        public Output<string?> TypeBitmaps { get; private set; } = null!;

        [Output("typeCovered")]
        public Output<string?> TypeCovered { get; private set; } = null!;

        [Output("weight")]
        public Output<int?> Weight { get; private set; } = null!;

        /// <summary>
        /// — (Required) Domain zone, encapsulating any nested subdomains.  
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a DnsRecord resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DnsRecord(string name, DnsRecordArgs args, CustomResourceOptions? options = null)
            : base("akamai:EdgeDNS/dnsRecord:DnsRecord", name, args ?? new DnsRecordArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DnsRecord(string name, Input<string> id, DnsRecordState? state = null, CustomResourceOptions? options = null)
            : base("akamai:EdgeDNS/dnsRecord:DnsRecord", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DnsRecord resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DnsRecord Get(string name, Input<string> id, DnsRecordState? state = null, CustomResourceOptions? options = null)
        {
            return new DnsRecord(name, id, state, options);
        }
    }

    public sealed class DnsRecordArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// — (Required,Boolean) Whether the record is active.  
        /// </summary>
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        [Input("algorithm")]
        public Input<int>? Algorithm { get; set; }

        [Input("digest")]
        public Input<string>? Digest { get; set; }

        [Input("digestType")]
        public Input<int>? DigestType { get; set; }

        [Input("expiration")]
        public Input<string>? Expiration { get; set; }

        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        [Input("fingerprintType")]
        public Input<int>? FingerprintType { get; set; }

        [Input("flags")]
        public Input<int>? Flags { get; set; }

        [Input("flagsnaptr")]
        public Input<string>? Flagsnaptr { get; set; }

        [Input("hardware")]
        public Input<string>? Hardware { get; set; }

        [Input("inception")]
        public Input<string>? Inception { get; set; }

        [Input("iterations")]
        public Input<int>? Iterations { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("keytag")]
        public Input<int>? Keytag { get; set; }

        [Input("labels")]
        public Input<int>? Labels { get; set; }

        [Input("mailbox")]
        public Input<string>? Mailbox { get; set; }

        /// <summary>
        /// — (Required) The name of the record. The name is an owner name, that is, the name of the node to which this resource record pertains.  
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nextHashedOwnerName")]
        public Input<string>? NextHashedOwnerName { get; set; }

        [Input("order")]
        public Input<int>? Order { get; set; }

        [Input("originalTtl")]
        public Input<int>? OriginalTtl { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("preference")]
        public Input<int>? Preference { get; set; }

        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("priorityIncrement")]
        public Input<int>? PriorityIncrement { get; set; }

        [Input("protocol")]
        public Input<int>? Protocol { get; set; }

        [Input("recordtype", required: true)]
        public Input<string> Recordtype { get; set; } = null!;

        [Input("regexp")]
        public Input<string>? Regexp { get; set; }

        [Input("replacement")]
        public Input<string>? Replacement { get; set; }

        [Input("salt")]
        public Input<string>? Salt { get; set; }

        [Input("service")]
        public Input<string>? Service { get; set; }

        [Input("signature")]
        public Input<string>? Signature { get; set; }

        [Input("signer")]
        public Input<string>? Signer { get; set; }

        [Input("software")]
        public Input<string>? Software { get; set; }

        [Input("subtype")]
        public Input<int>? Subtype { get; set; }

        [Input("targets")]
        private InputList<string>? _targets;

        /// <summary>
        /// — (Required) A domain name that specifies the canonical or primary name for the owner. The owner name is an alias.  
        /// </summary>
        public InputList<string> Targets
        {
            get => _targets ?? (_targets = new InputList<string>());
            set => _targets = value;
        }

        /// <summary>
        /// — (Required,Boolean) The TTL is a 32-bit signed integer that specifies the time interval that the resource record may be cached before the source of the information should be consulted again. Zero values are interpreted to mean that the RR can only be used for the transaction in progress, and should not be cached. Zero values can also be used for extremely volatile data.  
        /// </summary>
        [Input("ttl", required: true)]
        public Input<int> Ttl { get; set; } = null!;

        [Input("txt")]
        public Input<string>? Txt { get; set; }

        [Input("typeBitmaps")]
        public Input<string>? TypeBitmaps { get; set; }

        [Input("typeCovered")]
        public Input<string>? TypeCovered { get; set; }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        /// <summary>
        /// — (Required) Domain zone, encapsulating any nested subdomains.  
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public DnsRecordArgs()
        {
        }
    }

    public sealed class DnsRecordState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// — (Required,Boolean) Whether the record is active.  
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        [Input("algorithm")]
        public Input<int>? Algorithm { get; set; }

        [Input("digest")]
        public Input<string>? Digest { get; set; }

        [Input("digestType")]
        public Input<int>? DigestType { get; set; }

        [Input("expiration")]
        public Input<string>? Expiration { get; set; }

        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        [Input("fingerprintType")]
        public Input<int>? FingerprintType { get; set; }

        [Input("flags")]
        public Input<int>? Flags { get; set; }

        [Input("flagsnaptr")]
        public Input<string>? Flagsnaptr { get; set; }

        [Input("hardware")]
        public Input<string>? Hardware { get; set; }

        [Input("inception")]
        public Input<string>? Inception { get; set; }

        [Input("iterations")]
        public Input<int>? Iterations { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("keytag")]
        public Input<int>? Keytag { get; set; }

        [Input("labels")]
        public Input<int>? Labels { get; set; }

        [Input("mailbox")]
        public Input<string>? Mailbox { get; set; }

        /// <summary>
        /// — (Required) The name of the record. The name is an owner name, that is, the name of the node to which this resource record pertains.  
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nextHashedOwnerName")]
        public Input<string>? NextHashedOwnerName { get; set; }

        [Input("order")]
        public Input<int>? Order { get; set; }

        [Input("originalTtl")]
        public Input<int>? OriginalTtl { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("preference")]
        public Input<int>? Preference { get; set; }

        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("priorityIncrement")]
        public Input<int>? PriorityIncrement { get; set; }

        [Input("protocol")]
        public Input<int>? Protocol { get; set; }

        [Input("recordtype")]
        public Input<string>? Recordtype { get; set; }

        [Input("regexp")]
        public Input<string>? Regexp { get; set; }

        [Input("replacement")]
        public Input<string>? Replacement { get; set; }

        [Input("salt")]
        public Input<string>? Salt { get; set; }

        [Input("service")]
        public Input<string>? Service { get; set; }

        [Input("signature")]
        public Input<string>? Signature { get; set; }

        [Input("signer")]
        public Input<string>? Signer { get; set; }

        [Input("software")]
        public Input<string>? Software { get; set; }

        [Input("subtype")]
        public Input<int>? Subtype { get; set; }

        [Input("targets")]
        private InputList<string>? _targets;

        /// <summary>
        /// — (Required) A domain name that specifies the canonical or primary name for the owner. The owner name is an alias.  
        /// </summary>
        public InputList<string> Targets
        {
            get => _targets ?? (_targets = new InputList<string>());
            set => _targets = value;
        }

        /// <summary>
        /// — (Required,Boolean) The TTL is a 32-bit signed integer that specifies the time interval that the resource record may be cached before the source of the information should be consulted again. Zero values are interpreted to mean that the RR can only be used for the transaction in progress, and should not be cached. Zero values can also be used for extremely volatile data.  
        /// </summary>
        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        [Input("txt")]
        public Input<string>? Txt { get; set; }

        [Input("typeBitmaps")]
        public Input<string>? TypeBitmaps { get; set; }

        [Input("typeCovered")]
        public Input<string>? TypeCovered { get; set; }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        /// <summary>
        /// — (Required) Domain zone, encapsulating any nested subdomains.  
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public DnsRecordState()
        {
        }
    }
}