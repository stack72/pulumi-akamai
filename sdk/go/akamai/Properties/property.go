// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package Properties

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The `Properties.Property` resource represents an Akamai property configuration, allowing you to create,
// update, and activate properties on the Akamai platform.
type Property struct {
	pulumi.CustomResourceState

	// — the Account ID under which the property is created.
	Account pulumi.StringOutput `pulumi:"account"`
	// — (Required) One or more email addresses to inform about activation changes.
	Contacts pulumi.StringArrayOutput `pulumi:"contacts"`
	// — (Optional) The contract ID.
	Contract pulumi.StringPtrOutput `pulumi:"contract"`
	// — (Optional) The CP Code id or name to use (or create). Required unless a [cpCode behavior](https://developer.akamai.com/api/core_features/property_manager/vlatest.html#cpcode) is present in the default rule.
	CpCode pulumi.StringPtrOutput `pulumi:"cpCode"`
	// — the final public hostname to edge hostname map
	EdgeHostnames pulumi.StringMapOutput `pulumi:"edgeHostnames"`
	// — (Optional) The group ID.
	Group pulumi.StringPtrOutput `pulumi:"group"`
	// — (Required) A map of public hostnames to edge hostnames (e.g. `{"example.org" = "example.org.edgesuite.net"}`)
	Hostnames pulumi.StringMapOutput `pulumi:"hostnames"`
	// — (Optional) Whether the property is a secure (Enhanced TLS) property or not.
	IsSecure pulumi.BoolPtrOutput `pulumi:"isSecure"`
	// — (Required) The property name.
	Name pulumi.StringOutput `pulumi:"name"`
	// — (Optional) The property origin (an origin must be specified to activate a property, but may be defined in your rules block).
	Origins PropertyOriginArrayOutput `pulumi:"origins"`
	// — (Optional) The product ID. (Default: `prd_SPM` for Ion)
	Product pulumi.StringPtrOutput `pulumi:"product"`
	// — the current version of the property active on the production network.
	ProductionVersion pulumi.IntOutput `pulumi:"productionVersion"`
	// — (Optional) The rule format to use ([more](https://developer.akamai.com/api/core_features/property_manager/v1.html#getruleformats)).
	RuleFormat pulumi.StringPtrOutput `pulumi:"ruleFormat"`
	// — (Required) A JSON encoded string of property rules (see: [`Properties.PropertyRules`](https://www.terraform.io/docs/providers/akamai/d/property_rules.html))
	Rules    pulumi.StringPtrOutput `pulumi:"rules"`
	Rulessha pulumi.StringOutput    `pulumi:"rulessha"`
	// — the current version of the property active on the staging network.
	StagingVersion pulumi.IntOutput `pulumi:"stagingVersion"`
	// — (Optional) A JSON encoded string of property manager variable definitions (see: [`Properties.PropertyVariables`](https://www.terraform.io/docs/providers/akamai/r/property_variables.html))
	Variables pulumi.StringPtrOutput `pulumi:"variables"`
	// — the current version of the property config.
	Version pulumi.IntOutput `pulumi:"version"`
}

// NewProperty registers a new resource with the given unique name, arguments, and options.
func NewProperty(ctx *pulumi.Context,
	name string, args *PropertyArgs, opts ...pulumi.ResourceOption) (*Property, error) {
	if args == nil || args.Contacts == nil {
		return nil, errors.New("missing required argument 'Contacts'")
	}
	if args == nil || args.Hostnames == nil {
		return nil, errors.New("missing required argument 'Hostnames'")
	}
	if args == nil {
		args = &PropertyArgs{}
	}
	var resource Property
	err := ctx.RegisterResource("akamai:Properties/property:Property", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProperty gets an existing Property resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProperty(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PropertyState, opts ...pulumi.ResourceOption) (*Property, error) {
	var resource Property
	err := ctx.ReadResource("akamai:Properties/property:Property", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Property resources.
type propertyState struct {
	// — the Account ID under which the property is created.
	Account *string `pulumi:"account"`
	// — (Required) One or more email addresses to inform about activation changes.
	Contacts []string `pulumi:"contacts"`
	// — (Optional) The contract ID.
	Contract *string `pulumi:"contract"`
	// — (Optional) The CP Code id or name to use (or create). Required unless a [cpCode behavior](https://developer.akamai.com/api/core_features/property_manager/vlatest.html#cpcode) is present in the default rule.
	CpCode *string `pulumi:"cpCode"`
	// — the final public hostname to edge hostname map
	EdgeHostnames map[string]string `pulumi:"edgeHostnames"`
	// — (Optional) The group ID.
	Group *string `pulumi:"group"`
	// — (Required) A map of public hostnames to edge hostnames (e.g. `{"example.org" = "example.org.edgesuite.net"}`)
	Hostnames map[string]string `pulumi:"hostnames"`
	// — (Optional) Whether the property is a secure (Enhanced TLS) property or not.
	IsSecure *bool `pulumi:"isSecure"`
	// — (Required) The property name.
	Name *string `pulumi:"name"`
	// — (Optional) The property origin (an origin must be specified to activate a property, but may be defined in your rules block).
	Origins []PropertyOrigin `pulumi:"origins"`
	// — (Optional) The product ID. (Default: `prd_SPM` for Ion)
	Product *string `pulumi:"product"`
	// — the current version of the property active on the production network.
	ProductionVersion *int `pulumi:"productionVersion"`
	// — (Optional) The rule format to use ([more](https://developer.akamai.com/api/core_features/property_manager/v1.html#getruleformats)).
	RuleFormat *string `pulumi:"ruleFormat"`
	// — (Required) A JSON encoded string of property rules (see: [`Properties.PropertyRules`](https://www.terraform.io/docs/providers/akamai/d/property_rules.html))
	Rules    *string `pulumi:"rules"`
	Rulessha *string `pulumi:"rulessha"`
	// — the current version of the property active on the staging network.
	StagingVersion *int `pulumi:"stagingVersion"`
	// — (Optional) A JSON encoded string of property manager variable definitions (see: [`Properties.PropertyVariables`](https://www.terraform.io/docs/providers/akamai/r/property_variables.html))
	Variables *string `pulumi:"variables"`
	// — the current version of the property config.
	Version *int `pulumi:"version"`
}

type PropertyState struct {
	// — the Account ID under which the property is created.
	Account pulumi.StringPtrInput
	// — (Required) One or more email addresses to inform about activation changes.
	Contacts pulumi.StringArrayInput
	// — (Optional) The contract ID.
	Contract pulumi.StringPtrInput
	// — (Optional) The CP Code id or name to use (or create). Required unless a [cpCode behavior](https://developer.akamai.com/api/core_features/property_manager/vlatest.html#cpcode) is present in the default rule.
	CpCode pulumi.StringPtrInput
	// — the final public hostname to edge hostname map
	EdgeHostnames pulumi.StringMapInput
	// — (Optional) The group ID.
	Group pulumi.StringPtrInput
	// — (Required) A map of public hostnames to edge hostnames (e.g. `{"example.org" = "example.org.edgesuite.net"}`)
	Hostnames pulumi.StringMapInput
	// — (Optional) Whether the property is a secure (Enhanced TLS) property or not.
	IsSecure pulumi.BoolPtrInput
	// — (Required) The property name.
	Name pulumi.StringPtrInput
	// — (Optional) The property origin (an origin must be specified to activate a property, but may be defined in your rules block).
	Origins PropertyOriginArrayInput
	// — (Optional) The product ID. (Default: `prd_SPM` for Ion)
	Product pulumi.StringPtrInput
	// — the current version of the property active on the production network.
	ProductionVersion pulumi.IntPtrInput
	// — (Optional) The rule format to use ([more](https://developer.akamai.com/api/core_features/property_manager/v1.html#getruleformats)).
	RuleFormat pulumi.StringPtrInput
	// — (Required) A JSON encoded string of property rules (see: [`Properties.PropertyRules`](https://www.terraform.io/docs/providers/akamai/d/property_rules.html))
	Rules    pulumi.StringPtrInput
	Rulessha pulumi.StringPtrInput
	// — the current version of the property active on the staging network.
	StagingVersion pulumi.IntPtrInput
	// — (Optional) A JSON encoded string of property manager variable definitions (see: [`Properties.PropertyVariables`](https://www.terraform.io/docs/providers/akamai/r/property_variables.html))
	Variables pulumi.StringPtrInput
	// — the current version of the property config.
	Version pulumi.IntPtrInput
}

func (PropertyState) ElementType() reflect.Type {
	return reflect.TypeOf((*propertyState)(nil)).Elem()
}

type propertyArgs struct {
	// — (Required) One or more email addresses to inform about activation changes.
	Contacts []string `pulumi:"contacts"`
	// — (Optional) The contract ID.
	Contract *string `pulumi:"contract"`
	// — (Optional) The CP Code id or name to use (or create). Required unless a [cpCode behavior](https://developer.akamai.com/api/core_features/property_manager/vlatest.html#cpcode) is present in the default rule.
	CpCode *string `pulumi:"cpCode"`
	// — (Optional) The group ID.
	Group *string `pulumi:"group"`
	// — (Required) A map of public hostnames to edge hostnames (e.g. `{"example.org" = "example.org.edgesuite.net"}`)
	Hostnames map[string]string `pulumi:"hostnames"`
	// — (Optional) Whether the property is a secure (Enhanced TLS) property or not.
	IsSecure *bool `pulumi:"isSecure"`
	// — (Required) The property name.
	Name *string `pulumi:"name"`
	// — (Optional) The property origin (an origin must be specified to activate a property, but may be defined in your rules block).
	Origins []PropertyOrigin `pulumi:"origins"`
	// — (Optional) The product ID. (Default: `prd_SPM` for Ion)
	Product *string `pulumi:"product"`
	// — (Optional) The rule format to use ([more](https://developer.akamai.com/api/core_features/property_manager/v1.html#getruleformats)).
	RuleFormat *string `pulumi:"ruleFormat"`
	// — (Required) A JSON encoded string of property rules (see: [`Properties.PropertyRules`](https://www.terraform.io/docs/providers/akamai/d/property_rules.html))
	Rules *string `pulumi:"rules"`
	// — (Optional) A JSON encoded string of property manager variable definitions (see: [`Properties.PropertyVariables`](https://www.terraform.io/docs/providers/akamai/r/property_variables.html))
	Variables *string `pulumi:"variables"`
}

// The set of arguments for constructing a Property resource.
type PropertyArgs struct {
	// — (Required) One or more email addresses to inform about activation changes.
	Contacts pulumi.StringArrayInput
	// — (Optional) The contract ID.
	Contract pulumi.StringPtrInput
	// — (Optional) The CP Code id or name to use (or create). Required unless a [cpCode behavior](https://developer.akamai.com/api/core_features/property_manager/vlatest.html#cpcode) is present in the default rule.
	CpCode pulumi.StringPtrInput
	// — (Optional) The group ID.
	Group pulumi.StringPtrInput
	// — (Required) A map of public hostnames to edge hostnames (e.g. `{"example.org" = "example.org.edgesuite.net"}`)
	Hostnames pulumi.StringMapInput
	// — (Optional) Whether the property is a secure (Enhanced TLS) property or not.
	IsSecure pulumi.BoolPtrInput
	// — (Required) The property name.
	Name pulumi.StringPtrInput
	// — (Optional) The property origin (an origin must be specified to activate a property, but may be defined in your rules block).
	Origins PropertyOriginArrayInput
	// — (Optional) The product ID. (Default: `prd_SPM` for Ion)
	Product pulumi.StringPtrInput
	// — (Optional) The rule format to use ([more](https://developer.akamai.com/api/core_features/property_manager/v1.html#getruleformats)).
	RuleFormat pulumi.StringPtrInput
	// — (Required) A JSON encoded string of property rules (see: [`Properties.PropertyRules`](https://www.terraform.io/docs/providers/akamai/d/property_rules.html))
	Rules pulumi.StringPtrInput
	// — (Optional) A JSON encoded string of property manager variable definitions (see: [`Properties.PropertyVariables`](https://www.terraform.io/docs/providers/akamai/r/property_variables.html))
	Variables pulumi.StringPtrInput
}

func (PropertyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*propertyArgs)(nil)).Elem()
}
