// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * `akamai.TrafficManagement.GtmDatacenter` provides the resource for creating, configuring and importing a gtm datacenter to integrate easily with your existing GTM infrastructure to provide a secure, high performance, highly available and scalable solution for Global Traffic Management. Note: Import requires an ID of the format: `existingDomainName`:`existingDatacenterId`
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as akamai from "@pulumi/akamai";
 * 
 * const demoDatacenter = new akamai.TrafficManagement.GtmDatacenter("demoDatacenter", {
 *     domain: "demo_domain.akadns.net",
 *     nickname: "demoDatacenter",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-akamai/blob/master/website/docs/r/gtm_datacenter.html.markdown.
 */
export class GtmDatacenter extends pulumi.CustomResource {
    /**
     * Get an existing GtmDatacenter resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GtmDatacenterState, opts?: pulumi.CustomResourceOptions): GtmDatacenter {
        return new GtmDatacenter(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'akamai:TrafficManagement/gtmDatacenter:GtmDatacenter';

    /**
     * Returns true if the given object is an instance of GtmDatacenter.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GtmDatacenter {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GtmDatacenter.__pulumiType;
    }

    public readonly city!: pulumi.Output<string | undefined>;
    public readonly cloneOf!: pulumi.Output<number | undefined>;
    /**
     * — (Boolean)
     * * `continent`
     * * `country`
     * * `latitude`
     * * `longitude`
     * * `stateOrProvince`
     */
    public readonly cloudServerHostHeaderOverride!: pulumi.Output<boolean | undefined>;
    /**
     * — (Boolean)
     */
    public readonly cloudServerTargeting!: pulumi.Output<boolean | undefined>;
    public readonly continent!: pulumi.Output<string | undefined>;
    public readonly country!: pulumi.Output<string | undefined>;
    public /*out*/ readonly datacenterId!: pulumi.Output<number>;
    public readonly defaultLoadObject!: pulumi.Output<outputs.TrafficManagement.GtmDatacenterDefaultLoadObject | undefined>;
    /**
     * — Domain name 
     */
    public readonly domain!: pulumi.Output<string>;
    public readonly latitude!: pulumi.Output<number | undefined>;
    public readonly longitude!: pulumi.Output<number | undefined>;
    /**
     * — datacenter nickname
     * * `defaultLoadObject`
     * * `loadObject`
     * * `loadObjectPort`
     */
    public readonly nickname!: pulumi.Output<string | undefined>;
    public /*out*/ readonly pingInterval!: pulumi.Output<number>;
    public /*out*/ readonly pingPacketSize!: pulumi.Output<number>;
    public /*out*/ readonly scorePenalty!: pulumi.Output<number>;
    public /*out*/ readonly servermonitorLivenessCount!: pulumi.Output<number>;
    public /*out*/ readonly servermonitorLoadCount!: pulumi.Output<number>;
    public /*out*/ readonly servermonitorPool!: pulumi.Output<string>;
    public readonly stateOrProvince!: pulumi.Output<string | undefined>;
    /**
     * — (Boolean)
     */
    public /*out*/ readonly virtual!: pulumi.Output<boolean>;
    /**
     * — (Boolean, Default: true) Wait for transaction to complete
     */
    public readonly waitOnComplete!: pulumi.Output<boolean | undefined>;

    /**
     * Create a GtmDatacenter resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GtmDatacenterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GtmDatacenterArgs | GtmDatacenterState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as GtmDatacenterState | undefined;
            inputs["city"] = state ? state.city : undefined;
            inputs["cloneOf"] = state ? state.cloneOf : undefined;
            inputs["cloudServerHostHeaderOverride"] = state ? state.cloudServerHostHeaderOverride : undefined;
            inputs["cloudServerTargeting"] = state ? state.cloudServerTargeting : undefined;
            inputs["continent"] = state ? state.continent : undefined;
            inputs["country"] = state ? state.country : undefined;
            inputs["datacenterId"] = state ? state.datacenterId : undefined;
            inputs["defaultLoadObject"] = state ? state.defaultLoadObject : undefined;
            inputs["domain"] = state ? state.domain : undefined;
            inputs["latitude"] = state ? state.latitude : undefined;
            inputs["longitude"] = state ? state.longitude : undefined;
            inputs["nickname"] = state ? state.nickname : undefined;
            inputs["pingInterval"] = state ? state.pingInterval : undefined;
            inputs["pingPacketSize"] = state ? state.pingPacketSize : undefined;
            inputs["scorePenalty"] = state ? state.scorePenalty : undefined;
            inputs["servermonitorLivenessCount"] = state ? state.servermonitorLivenessCount : undefined;
            inputs["servermonitorLoadCount"] = state ? state.servermonitorLoadCount : undefined;
            inputs["servermonitorPool"] = state ? state.servermonitorPool : undefined;
            inputs["stateOrProvince"] = state ? state.stateOrProvince : undefined;
            inputs["virtual"] = state ? state.virtual : undefined;
            inputs["waitOnComplete"] = state ? state.waitOnComplete : undefined;
        } else {
            const args = argsOrState as GtmDatacenterArgs | undefined;
            if (!args || args.domain === undefined) {
                throw new Error("Missing required property 'domain'");
            }
            inputs["city"] = args ? args.city : undefined;
            inputs["cloneOf"] = args ? args.cloneOf : undefined;
            inputs["cloudServerHostHeaderOverride"] = args ? args.cloudServerHostHeaderOverride : undefined;
            inputs["cloudServerTargeting"] = args ? args.cloudServerTargeting : undefined;
            inputs["continent"] = args ? args.continent : undefined;
            inputs["country"] = args ? args.country : undefined;
            inputs["defaultLoadObject"] = args ? args.defaultLoadObject : undefined;
            inputs["domain"] = args ? args.domain : undefined;
            inputs["latitude"] = args ? args.latitude : undefined;
            inputs["longitude"] = args ? args.longitude : undefined;
            inputs["nickname"] = args ? args.nickname : undefined;
            inputs["stateOrProvince"] = args ? args.stateOrProvince : undefined;
            inputs["waitOnComplete"] = args ? args.waitOnComplete : undefined;
            inputs["datacenterId"] = undefined /*out*/;
            inputs["pingInterval"] = undefined /*out*/;
            inputs["pingPacketSize"] = undefined /*out*/;
            inputs["scorePenalty"] = undefined /*out*/;
            inputs["servermonitorLivenessCount"] = undefined /*out*/;
            inputs["servermonitorLoadCount"] = undefined /*out*/;
            inputs["servermonitorPool"] = undefined /*out*/;
            inputs["virtual"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(GtmDatacenter.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GtmDatacenter resources.
 */
export interface GtmDatacenterState {
    readonly city?: pulumi.Input<string>;
    readonly cloneOf?: pulumi.Input<number>;
    /**
     * — (Boolean)
     * * `continent`
     * * `country`
     * * `latitude`
     * * `longitude`
     * * `stateOrProvince`
     */
    readonly cloudServerHostHeaderOverride?: pulumi.Input<boolean>;
    /**
     * — (Boolean)
     */
    readonly cloudServerTargeting?: pulumi.Input<boolean>;
    readonly continent?: pulumi.Input<string>;
    readonly country?: pulumi.Input<string>;
    readonly datacenterId?: pulumi.Input<number>;
    readonly defaultLoadObject?: pulumi.Input<inputs.TrafficManagement.GtmDatacenterDefaultLoadObject>;
    /**
     * — Domain name 
     */
    readonly domain?: pulumi.Input<string>;
    readonly latitude?: pulumi.Input<number>;
    readonly longitude?: pulumi.Input<number>;
    /**
     * — datacenter nickname
     * * `defaultLoadObject`
     * * `loadObject`
     * * `loadObjectPort`
     */
    readonly nickname?: pulumi.Input<string>;
    readonly pingInterval?: pulumi.Input<number>;
    readonly pingPacketSize?: pulumi.Input<number>;
    readonly scorePenalty?: pulumi.Input<number>;
    readonly servermonitorLivenessCount?: pulumi.Input<number>;
    readonly servermonitorLoadCount?: pulumi.Input<number>;
    readonly servermonitorPool?: pulumi.Input<string>;
    readonly stateOrProvince?: pulumi.Input<string>;
    /**
     * — (Boolean)
     */
    readonly virtual?: pulumi.Input<boolean>;
    /**
     * — (Boolean, Default: true) Wait for transaction to complete
     */
    readonly waitOnComplete?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a GtmDatacenter resource.
 */
export interface GtmDatacenterArgs {
    readonly city?: pulumi.Input<string>;
    readonly cloneOf?: pulumi.Input<number>;
    /**
     * — (Boolean)
     * * `continent`
     * * `country`
     * * `latitude`
     * * `longitude`
     * * `stateOrProvince`
     */
    readonly cloudServerHostHeaderOverride?: pulumi.Input<boolean>;
    /**
     * — (Boolean)
     */
    readonly cloudServerTargeting?: pulumi.Input<boolean>;
    readonly continent?: pulumi.Input<string>;
    readonly country?: pulumi.Input<string>;
    readonly defaultLoadObject?: pulumi.Input<inputs.TrafficManagement.GtmDatacenterDefaultLoadObject>;
    /**
     * — Domain name 
     */
    readonly domain: pulumi.Input<string>;
    readonly latitude?: pulumi.Input<number>;
    readonly longitude?: pulumi.Input<number>;
    /**
     * — datacenter nickname
     * * `defaultLoadObject`
     * * `loadObject`
     * * `loadObjectPort`
     */
    readonly nickname?: pulumi.Input<string>;
    readonly stateOrProvince?: pulumi.Input<string>;
    /**
     * — (Boolean, Default: true) Wait for transaction to complete
     */
    readonly waitOnComplete?: pulumi.Input<boolean>;
}
