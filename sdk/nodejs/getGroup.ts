// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Use `akamai..getGroup` data source to retrieve a group id.
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-akamai/blob/master/website/docs/d/group.html.markdown.
 */
export function getGroup(args?: GetGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("akamai:index/getGroup:getGroup", {
        "contract": args.contract,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getGroup.
 */
export interface GetGroupArgs {
    /**
     * — (Optional) The contract ID
     */
    readonly contract?: string;
    /**
     * — (Required) The group name.
     */
    readonly name?: string;
}

/**
 * A collection of values returned by getGroup.
 */
export interface GetGroupResult {
    readonly contract?: string;
    readonly name?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
