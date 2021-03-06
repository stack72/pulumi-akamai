// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * `akamai.TrafficManagement.GtmCidrmap` provides the resource for creating, configuring and importing a gtm Cidr Map to integrate easily with your existing GTM infrastructure to provide a secure, high performance, highly available and scalable solution for Global Traffic Management. Note: Import requires an ID of the format: `existingDomainName`:`existingMapName`
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as akamai from "@pulumi/akamai";
 * 
 * const demoCidrmap = new akamai.TrafficManagement.GtmCidrmap("demoCidrmap", {
 *     defaultDatacenter: {
 *         datacenterId: 5400,
 *         nickname: "All Other CIDR Blocks",
 *     },
 *     domain: "demo_domain.akadns.net",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-akamai/blob/master/website/docs/r/gtm_cidrmap.html.markdown.
 */
export class GtmCidrmap extends pulumi.CustomResource {
    /**
     * Get an existing GtmCidrmap resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GtmCidrmapState, opts?: pulumi.CustomResourceOptions): GtmCidrmap {
        return new GtmCidrmap(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'akamai:TrafficManagement/gtmCidrmap:GtmCidrmap';

    /**
     * Returns true if the given object is an instance of GtmCidrmap.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GtmCidrmap {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GtmCidrmap.__pulumiType;
    }

    /**
     * — (multiple allowed)
     * * `datacenterId`
     * * `nickname`
     */
    public readonly assignments!: pulumi.Output<outputs.TrafficManagement.GtmCidrmapAssignment[] | undefined>;
    public readonly defaultDatacenter!: pulumi.Output<outputs.TrafficManagement.GtmCidrmapDefaultDatacenter>;
    /**
     * — Domain name 
     */
    public readonly domain!: pulumi.Output<string>;
    /**
     * — Resource name
     * * `defaultDatacenter`
     * * `datacenterId`
     * * `nickname`
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * — (Boolean, Default: true) Wait for transaction to complete
     */
    public readonly waitOnComplete!: pulumi.Output<boolean | undefined>;

    /**
     * Create a GtmCidrmap resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GtmCidrmapArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GtmCidrmapArgs | GtmCidrmapState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as GtmCidrmapState | undefined;
            inputs["assignments"] = state ? state.assignments : undefined;
            inputs["defaultDatacenter"] = state ? state.defaultDatacenter : undefined;
            inputs["domain"] = state ? state.domain : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["waitOnComplete"] = state ? state.waitOnComplete : undefined;
        } else {
            const args = argsOrState as GtmCidrmapArgs | undefined;
            if (!args || args.defaultDatacenter === undefined) {
                throw new Error("Missing required property 'defaultDatacenter'");
            }
            if (!args || args.domain === undefined) {
                throw new Error("Missing required property 'domain'");
            }
            inputs["assignments"] = args ? args.assignments : undefined;
            inputs["defaultDatacenter"] = args ? args.defaultDatacenter : undefined;
            inputs["domain"] = args ? args.domain : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["waitOnComplete"] = args ? args.waitOnComplete : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(GtmCidrmap.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GtmCidrmap resources.
 */
export interface GtmCidrmapState {
    /**
     * — (multiple allowed)
     * * `datacenterId`
     * * `nickname`
     */
    readonly assignments?: pulumi.Input<pulumi.Input<inputs.TrafficManagement.GtmCidrmapAssignment>[]>;
    readonly defaultDatacenter?: pulumi.Input<inputs.TrafficManagement.GtmCidrmapDefaultDatacenter>;
    /**
     * — Domain name 
     */
    readonly domain?: pulumi.Input<string>;
    /**
     * — Resource name
     * * `defaultDatacenter`
     * * `datacenterId`
     * * `nickname`
     */
    readonly name?: pulumi.Input<string>;
    /**
     * — (Boolean, Default: true) Wait for transaction to complete
     */
    readonly waitOnComplete?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a GtmCidrmap resource.
 */
export interface GtmCidrmapArgs {
    /**
     * — (multiple allowed)
     * * `datacenterId`
     * * `nickname`
     */
    readonly assignments?: pulumi.Input<pulumi.Input<inputs.TrafficManagement.GtmCidrmapAssignment>[]>;
    readonly defaultDatacenter: pulumi.Input<inputs.TrafficManagement.GtmCidrmapDefaultDatacenter>;
    /**
     * — Domain name 
     */
    readonly domain: pulumi.Input<string>;
    /**
     * — Resource name
     * * `defaultDatacenter`
     * * `datacenterId`
     * * `nickname`
     */
    readonly name?: pulumi.Input<string>;
    /**
     * — (Boolean, Default: true) Wait for transaction to complete
     */
    readonly waitOnComplete?: pulumi.Input<boolean>;
}
