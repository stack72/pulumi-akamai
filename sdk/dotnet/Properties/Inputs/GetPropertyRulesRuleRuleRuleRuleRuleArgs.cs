// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Akamai.Properties.Inputs
{

    public sealed class GetPropertyRulesRuleRuleRuleRuleRuleArgs : Pulumi.InvokeArgs
    {
        [Input("behaviors")]
        private List<Inputs.GetPropertyRulesRuleRuleRuleRuleRuleBehaviorArgs>? _behaviors;

        /// <summary>
        /// — (Optional) One or more behaviors to apply to requests that match.
        /// </summary>
        public List<Inputs.GetPropertyRulesRuleRuleRuleRuleRuleBehaviorArgs> Behaviors
        {
            get => _behaviors ?? (_behaviors = new List<Inputs.GetPropertyRulesRuleRuleRuleRuleRuleBehaviorArgs>());
            set => _behaviors = value;
        }

        [Input("comment")]
        public string? Comment { get; set; }

        [Input("criteriaMatch")]
        public string? CriteriaMatch { get; set; }

        [Input("criterias")]
        private List<Inputs.GetPropertyRulesRuleRuleRuleRuleRuleCriteriaArgs>? _criterias;

        /// <summary>
        /// — (Optional) One or more criteria to match requests on.
        /// </summary>
        public List<Inputs.GetPropertyRulesRuleRuleRuleRuleRuleCriteriaArgs> Criterias
        {
            get => _criterias ?? (_criterias = new List<Inputs.GetPropertyRulesRuleRuleRuleRuleRuleCriteriaArgs>());
            set => _criterias = value;
        }

        /// <summary>
        /// — (Required) The name of the behavior.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetPropertyRulesRuleRuleRuleRuleRuleArgs()
        {
        }
    }
}
