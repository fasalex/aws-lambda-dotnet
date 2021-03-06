﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Lambda.APIGatewayEvents
{
    /// <summary>
    /// For request using using API Gateway HTTP API version 2 payload proxy format
    /// https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-develop-integrations-lambda.html
    /// </summary>
    public class APIGatewayHttpApiV2ProxyRequest
    {
        /// <summary>
        /// The payload format version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The route key
        /// </summary>
        public string RouteKey { get; set; }

        /// <summary>
        /// The raw path
        /// </summary>
        public string RawPath { get; set; }

        /// <summary>
        /// The raw query string
        /// </summary>
        public string RawQueryString { get; set; }

        /// <summary>
        /// Cookies sent along with the request
        /// </summary>
        public string[] Cookies { get; set; }

        /// <summary>
        /// Headers sent with the request. Multiple values for the same header will be separated by a comma.
        /// </summary>
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Query string parameters sent with the request. Multiple values for the same parameter will be separated by a comma.
        /// </summary>
        public IDictionary<string, string> QueryStringParameters { get; set; }

        /// <summary>
        /// The request context for the request
        /// </summary>
        public ProxyRequestContext RequestContext { get; set; }

        /// <summary>
        /// The HTTP request body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// True if the body of the request is base 64 encoded.
        /// </summary>
        public bool IsBase64Encoded { get; set; }

        /// <summary>
        /// The stage variables defined for the stage in API Gateway
        /// </summary>
        public IDictionary<string, string> StageVariables { get; set; }

        /// <summary>
        /// The ProxyRequestContext contains the information to identify the AWS account and resources invoking the 
        /// Lambda function.
        /// </summary>
        public class ProxyRequestContext
        {
            /// <summary>
            /// The account id that owns the executing Lambda function
            /// </summary>
            public string AccountId { get; set; }

            /// <summary>
            /// The API Gateway rest API Id.
            /// </summary>
            public string ApiId { get; set; }

            /// <summary>
            /// Information about the current requesters authorization including claims and scopes.
            /// </summary>
            public AuthorizerDescription Authorizer { get; set; }

            /// <summary>
            /// The domin name.
            /// </summary>
            public string DomainName { get; set; }

            /// <summary>
            ///  The domain prefix
            /// </summary>
            public string DomainPrefix { get; set; }

            /// <summary>
            /// Information about the HTTP request like the method and path.
            /// </summary>
            public HttpDescription Http {get;set;}

            /// <summary>
            /// The unique request id
            /// </summary>
            public string RequestId { get; set; }

            /// <summary>
            ///  The route id
            /// </summary>
            public string RouteId { get; set; }

            /// <summary>
            /// The selected route key.
            /// </summary>
            public string RouteKey { get; set; }

            /// <summary>
            /// The API Gateway stage name
            /// </summary>
            public string Stage { get; set; }

            /// <summary>
            /// Gets and sets the request time.
            /// </summary>
            public string Time { get; set; }

            /// <summary>
            /// Gets and sets the request time as an epoch.
            /// </summary>
            public long TimeEpoch { get; set; }
        }

        /// <summary>
        /// Information about the HTTP elements for the request.
        /// </summary>
        public class HttpDescription
        {
            /// <summary>
            /// The HTTP method like POST or GET.
            /// </summary>
            public string Method { get; set; }

            /// <summary>
            /// The path of the request.
            /// </summary>
            public string Path { get; set; }

            /// <summary>
            /// The protocal used ot make the rquest
            /// </summary>
            public string Protocol { get; set; }

            /// <summary>
            /// The source ip for the request.
            /// </summary>
            public string SourceIp { get; set; }

            /// <summary>
            /// The user agent for the request.
            /// </summary>
            public string UserAgent { get; set; }
        }

        /// <summary>
        /// Information about the current requesters authorization.
        /// </summary>
        public class AuthorizerDescription
        {
            /// <summary>
            /// The JWT description including claims and scopes.
            /// </summary>
            public JwtDescription Jwt { get; set; }


            /// <summary>
            /// Describes the information in the JWT token
            /// </summary>
            public class JwtDescription
            {
                /// <summary>
                /// Map of the claims for the requester.
                /// </summary>
                public IDictionary<string, string> Claims { get; set; }
                /// <summary>
                /// List of the scopes for the requester.
                /// </summary>
                public string[] Scopes { get; set; }
            }
        }
    }
}
