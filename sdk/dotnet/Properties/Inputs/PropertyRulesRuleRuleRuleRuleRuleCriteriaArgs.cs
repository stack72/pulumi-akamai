// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Akamai.Properties.Inputs
{

    public sealed class PropertyRulesRuleRuleRuleRuleRuleCriteriaArgs : Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("options")]
        private InputList<Inputs.PropertyRulesRuleRuleRuleRuleRuleCriteriaOptionArgs>? _options;
        public InputList<Inputs.PropertyRulesRuleRuleRuleRuleRuleCriteriaOptionArgs> Options
        {
            get => _options ?? (_options = new InputList<Inputs.PropertyRulesRuleRuleRuleRuleRuleCriteriaOptionArgs>());
            set => _options = value;
        }

        public PropertyRulesRuleRuleRuleRuleRuleCriteriaArgs()
        {
        }
    }
}