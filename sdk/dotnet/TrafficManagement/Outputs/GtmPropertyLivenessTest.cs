// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Akamai.TrafficManagement.Outputs
{

    [OutputType]
    public sealed class GtmPropertyLivenessTest
    {
        /// <summary>
        /// — (Boolean)
        /// </summary>
        public readonly bool? AnswersRequired;
        /// <summary>
        /// — (Boolean)
        /// * `error_penalty`
        /// </summary>
        public readonly bool? DisableNonstandardPortWarning;
        /// <summary>
        /// — (Boolean)
        /// </summary>
        public readonly bool? Disabled;
        public readonly double? ErrorPenalty;
        /// <summary>
        /// — (Boolean)
        /// </summary>
        public readonly bool? HttpError3xx;
        /// <summary>
        /// — (Boolean)
        /// </summary>
        public readonly bool? HttpError4xx;
        /// <summary>
        /// — (Boolean)
        /// </summary>
        public readonly bool? HttpError5xx;
        /// <summary>
        /// — (multiple allowed)
        /// `name`
        /// `value`
        /// </summary>
        public readonly ImmutableArray<Outputs.GtmPropertyLivenessTestHttpHeader> HttpHeaders;
        /// <summary>
        /// — Liveness test name
        /// * `test_interval`
        /// * `test_object_protocol`
        /// * `test_timeout`
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// — (Boolean)
        /// </summary>
        public readonly bool? PeerCertificateVerification;
        /// <summary>
        /// — (Boolean)
        /// * `request_string`
        /// * `resource_type`
        /// * `response_string`
        /// * `ssl_client_certificate`
        /// * `ssl_client_private_key`
        /// * `test_object`
        /// * `test_object_password`
        /// * `test_object_port`
        /// * `test_object_username`
        /// * `timeout_penalty`
        /// </summary>
        public readonly bool? RecursionRequested;
        public readonly string? RequestString;
        public readonly string? ResourceType;
        public readonly string? ResponseString;
        public readonly string? SslClientCertificate;
        public readonly string? SslClientPrivateKey;
        public readonly int TestInterval;
        public readonly string TestObject;
        public readonly string? TestObjectPassword;
        public readonly int? TestObjectPort;
        public readonly string TestObjectProtocol;
        public readonly string? TestObjectUsername;
        public readonly double TestTimeout;
        public readonly double? TimeoutPenalty;

        [OutputConstructor]
        private GtmPropertyLivenessTest(
            bool? answersRequired,

            bool? disableNonstandardPortWarning,

            bool? disabled,

            double? errorPenalty,

            bool? httpError3xx,

            bool? httpError4xx,

            bool? httpError5xx,

            ImmutableArray<Outputs.GtmPropertyLivenessTestHttpHeader> httpHeaders,

            string name,

            bool? peerCertificateVerification,

            bool? recursionRequested,

            string? requestString,

            string? resourceType,

            string? responseString,

            string? sslClientCertificate,

            string? sslClientPrivateKey,

            int testInterval,

            string testObject,

            string? testObjectPassword,

            int? testObjectPort,

            string testObjectProtocol,

            string? testObjectUsername,

            double testTimeout,

            double? timeoutPenalty)
        {
            AnswersRequired = answersRequired;
            DisableNonstandardPortWarning = disableNonstandardPortWarning;
            Disabled = disabled;
            ErrorPenalty = errorPenalty;
            HttpError3xx = httpError3xx;
            HttpError4xx = httpError4xx;
            HttpError5xx = httpError5xx;
            HttpHeaders = httpHeaders;
            Name = name;
            PeerCertificateVerification = peerCertificateVerification;
            RecursionRequested = recursionRequested;
            RequestString = requestString;
            ResourceType = resourceType;
            ResponseString = responseString;
            SslClientCertificate = sslClientCertificate;
            SslClientPrivateKey = sslClientPrivateKey;
            TestInterval = testInterval;
            TestObject = testObject;
            TestObjectPassword = testObjectPassword;
            TestObjectPort = testObjectPort;
            TestObjectProtocol = testObjectProtocol;
            TestObjectUsername = testObjectUsername;
            TestTimeout = testTimeout;
            TimeoutPenalty = timeoutPenalty;
        }
    }
}
