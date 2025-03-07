// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.FirebaseAppDistribution.v1alpha
{
    /// <summary>The FirebaseAppDistribution Service.</summary>
    public class FirebaseAppDistributionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseAppDistributionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseAppDistributionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Apps = new AppsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebaseappdistribution";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://firebaseappdistribution.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://firebaseappdistribution.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase App Distribution API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase App Distribution API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseAppDistribution requests.</summary>
    public abstract class FirebaseAppDistributionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseAppDistributionBaseServiceRequest instance.</summary>
        protected FirebaseAppDistributionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes FirebaseAppDistribution parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "apps" collection of methods.</summary>
    public class AppsResource
    {
        private const string Resource = "apps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AppsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ReleaseByHash = new ReleaseByHashResource(service);
            Releases = new ReleasesResource(service);
            Testers = new TestersResource(service);
            UploadStatus = new UploadStatusResource(service);
        }

        /// <summary>Gets the ReleaseByHash resource.</summary>
        public virtual ReleaseByHashResource ReleaseByHash { get; }

        /// <summary>The "release_by_hash" collection of methods.</summary>
        public class ReleaseByHashResource
        {
            private const string Resource = "releaseByHash";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReleaseByHashResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>GET Release by binary upload hash</summary>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            /// <param name="uploadHash">The hash for the upload</param>
            public virtual GetRequest Get(string mobilesdkAppId, string uploadHash)
            {
                return new GetRequest(this.service, mobilesdkAppId, uploadHash);
            }

            /// <summary>GET Release by binary upload hash</summary>
            public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetReleaseByUploadHashResponse>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId, string uploadHash) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    UploadHash = uploadHash;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>The hash for the upload</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadHash", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UploadHash { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/release_by_hash/{uploadHash}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("uploadHash", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uploadHash",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Releases resource.</summary>
        public virtual ReleasesResource Releases { get; }

        /// <summary>The "releases" collection of methods.</summary>
        public class ReleasesResource
        {
            private const string Resource = "releases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReleasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Notes = new NotesResource(service);
            }

            /// <summary>Gets the Notes resource.</summary>
            public virtual NotesResource Notes { get; }

            /// <summary>The "notes" collection of methods.</summary>
            public class NotesResource
            {
                private const string Resource = "notes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NotesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create release notes on a release.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="mobilesdkAppId">
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </param>
                /// <param name="releaseId">Release identifier</param>
                public virtual CreateRequest Create(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest body, string mobilesdkAppId, string releaseId)
                {
                    return new CreateRequest(this.service, body, mobilesdkAppId, releaseId);
                }

                /// <summary>Create release notes on a release.</summary>
                public class CreateRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesResponse>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest body, string mobilesdkAppId, string releaseId) : base(service)
                    {
                        MobilesdkAppId = mobilesdkAppId;
                        ReleaseId = releaseId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Unique id for a Firebase app of the format:
                    /// {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
                    /// 1:581234567376:android:aa0a3c7b135e90289
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MobilesdkAppId { get; private set; }

                    /// <summary>Release identifier</summary>
                    [Google.Apis.Util.RequestParameterAttribute("releaseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ReleaseId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/releases/{releaseId}/notes";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mobilesdkAppId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("releaseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "releaseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Enable access on a release for testers.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            /// <param name="releaseId">Release identifier</param>
            public virtual EnableAccessRequest EnableAccess(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest body, string mobilesdkAppId, string releaseId)
            {
                return new EnableAccessRequest(this.service, body, mobilesdkAppId, releaseId);
            }

            /// <summary>Enable access on a release for testers.</summary>
            public class EnableAccessRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseResponse>
            {
                /// <summary>Constructs a new EnableAccess request.</summary>
                public EnableAccessRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest body, string mobilesdkAppId, string releaseId) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    ReleaseId = releaseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>Release identifier</summary>
                [Google.Apis.Util.RequestParameterAttribute("releaseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ReleaseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enable_access";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/releases/{releaseId}/enable_access";

                /// <summary>Initializes EnableAccess parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("releaseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "releaseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Testers resource.</summary>
        public virtual TestersResource Testers { get; }

        /// <summary>The "testers" collection of methods.</summary>
        public class TestersResource
        {
            private const string Resource = "testers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TestersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            public virtual GetTesterUdidsRequest GetTesterUdids(string mobilesdkAppId)
            {
                return new GetTesterUdidsRequest(this.service, mobilesdkAppId);
            }

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            public class GetTesterUdidsRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetTesterUdidsResponse>
            {
                /// <summary>Constructs a new GetTesterUdids request.</summary>
                public GetTesterUdidsRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>
                /// The name of the project, which is the parent of testers Format: `projects/{project_number}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Project { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getTesterUdids";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/testers:getTesterUdids";

                /// <summary>Initializes GetTesterUdids parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the UploadStatus resource.</summary>
        public virtual UploadStatusResource UploadStatus { get; }

        /// <summary>The "upload_status" collection of methods.</summary>
        public class UploadStatusResource
        {
            private const string Resource = "uploadStatus";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UploadStatusResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>GET Binary upload status by token</summary>
            /// <param name="mobilesdkAppId">
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </param>
            /// <param name="uploadToken">The token for the upload</param>
            public virtual GetRequest Get(string mobilesdkAppId, string uploadToken)
            {
                return new GetRequest(this.service, mobilesdkAppId, uploadToken);
            }

            /// <summary>GET Binary upload status by token</summary>
            public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetUploadStatusResponse>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId, string uploadToken) : base(service)
                {
                    MobilesdkAppId = mobilesdkAppId;
                    UploadToken = uploadToken;
                    InitParameters();
                }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MobilesdkAppId { get; private set; }

                /// <summary>The token for the upload</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadToken", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UploadToken { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/upload_status/{uploadToken}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("uploadToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uploadToken",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Get the app, if it exists</summary>
        /// <param name="mobilesdkAppId">
        /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
        /// 1:581234567376:android:aa0a3c7b135e90289
        /// </param>
        public virtual GetRequest Get(string mobilesdkAppId)
        {
            return new GetRequest(this.service, mobilesdkAppId);
        }

        /// <summary>Get the app, if it exists</summary>
        public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaApp>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
            {
                MobilesdkAppId = mobilesdkAppId;
                InitParameters();
            }

            /// <summary>
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MobilesdkAppId { get; private set; }

            /// <summary>
            /// App view. When unset or set to BASIC, returns an App with everything set except for aab_state. When set
            /// to FULL, returns an App with aab_state set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("appView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<AppViewEnum> AppView { get; set; }

            /// <summary>
            /// App view. When unset or set to BASIC, returns an App with everything set except for aab_state. When set
            /// to FULL, returns an App with aab_state set.
            /// </summary>
            public enum AppViewEnum
            {
                /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                [Google.Apis.Util.StringValueAttribute("APP_VIEW_UNSPECIFIED")]
                APPVIEWUNSPECIFIED = 0,

                /// <summary>Include everything except aab_state.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 1,

                /// <summary>Include everything.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/apps/{mobilesdkAppId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "mobilesdkAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("appView", new Google.Apis.Discovery.Parameter
                {
                    Name = "appView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get a JWT token</summary>
        /// <param name="mobilesdkAppId">
        /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
        /// 1:581234567376:android:aa0a3c7b135e90289
        /// </param>
        public virtual GetJwtRequest GetJwt(string mobilesdkAppId)
        {
            return new GetJwtRequest(this.service, mobilesdkAppId);
        }

        /// <summary>Get a JWT token</summary>
        public class GetJwtRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaJwt>
        {
            /// <summary>Constructs a new GetJwt request.</summary>
            public GetJwtRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
            {
                MobilesdkAppId = mobilesdkAppId;
                InitParameters();
            }

            /// <summary>
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MobilesdkAppId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getJwt";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/apps/{mobilesdkAppId}/jwt";

            /// <summary>Initializes GetJwt parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "mobilesdkAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provision app distribution for an existing Firebase app, enabling it to subsequently be used by appdistro.
        /// </summary>
        /// <param name="mobilesdkAppId">
        /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)} Example:
        /// 1:581234567376:android:aa0a3c7b135e90289
        /// </param>
        public virtual ProvisionAppRequest ProvisionApp(string mobilesdkAppId)
        {
            return new ProvisionAppRequest(this.service, mobilesdkAppId);
        }

        /// <summary>
        /// Provision app distribution for an existing Firebase app, enabling it to subsequently be used by appdistro.
        /// </summary>
        public class ProvisionAppRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaProvisionAppResponse>
        {
            /// <summary>Constructs a new ProvisionApp request.</summary>
            public ProvisionAppRequest(Google.Apis.Services.IClientService service, string mobilesdkAppId) : base(service)
            {
                MobilesdkAppId = mobilesdkAppId;
                InitParameters();
            }

            /// <summary>
            /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
            /// Example: 1:581234567376:android:aa0a3c7b135e90289
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MobilesdkAppId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "provisionApp";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/apps/{mobilesdkAppId}";

            /// <summary>Initializes ProvisionApp parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "mobilesdkAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Apps = new AppsResource(service);
            Testers = new TestersResource(service);
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Releases = new ReleasesResource(service);
            }

            /// <summary>Gets the Releases resource.</summary>
            public virtual ReleasesResource Releases { get; }

            /// <summary>The "releases" collection of methods.</summary>
            public class ReleasesResource
            {
                private const string Resource = "releases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReleasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Tests = new TestsResource(service);
                }

                /// <summary>Gets the Tests resource.</summary>
                public virtual TestsResource Tests { get; }

                /// <summary>The "tests" collection of methods.</summary>
                public class TestsResource
                {
                    private const string Resource = "tests";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TestsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Run automated test(s) on release.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the release resource, which is the parent of the test Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Run automated test(s) on release.</summary>
                    public class CreateRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release resource, which is the parent of the test Format:
                        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the test, which will become the final component of the tests's
                        /// resource name. This value should be 4-63 characters, and valid characters are /a-z-/. If it
                        /// is not provided one will be automatically generated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("releaseTestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ReleaseTestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/tests";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
                            });
                            RequestParameters.Add("releaseTestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "releaseTestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Get results for automated test run on release.</summary>
                    /// <param name="name">
                    /// Required. The name of the release test resource. Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Get results for automated test run on release.</summary>
                    public class GetRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaReleaseTest>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release test resource. Format:
                        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+/tests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List results for automated tests run on release.</summary>
                    /// <param name="parent">
                    /// Required. The name of the release resource, which is the parent of the tests Format:
                    /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List results for automated tests run on release.</summary>
                    public class ListRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaListReleaseTestsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the release resource, which is the parent of the tests Format:
                        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of tests to return. The service may return fewer than this
                        /// value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListReleaseTests` call. Provide this to
                        /// retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/tests";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/apps/[^/]+/releases/[^/]+$",
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }
            }

            /// <summary>Gets configuration for automated tests.</summary>
            /// <param name="name">
            /// Required. The name of the `TestConfig` resource to retrieve. Format:
            /// `projects/{project_number}/apps/{app_id}/testConfig`
            /// </param>
            public virtual GetTestConfigRequest GetTestConfig(string name)
            {
                return new GetTestConfigRequest(this.service, name);
            }

            /// <summary>Gets configuration for automated tests.</summary>
            public class GetTestConfigRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig>
            {
                /// <summary>Constructs a new GetTestConfig request.</summary>
                public GetTestConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the `TestConfig` resource to retrieve. Format:
                /// `projects/{project_number}/apps/{app_id}/testConfig`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getTestConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes GetTestConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+/testConfig$",
                    });
                }
            }

            /// <summary>Updates a release.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The name of the test configuration resource. Format:
            /// `projects/{project_number}/apps/{app_id}/testConfig`
            /// </param>
            public virtual UpdateTestConfigRequest UpdateTestConfig(Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig body, string name)
            {
                return new UpdateTestConfigRequest(this.service, body, name);
            }

            /// <summary>Updates a release.</summary>
            public class UpdateTestConfigRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig>
            {
                /// <summary>Constructs a new UpdateTestConfig request.</summary>
                public UpdateTestConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The name of the test configuration resource. Format:
                /// `projects/{project_number}/apps/{app_id}/testConfig`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaTestConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateTestConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes UpdateTestConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+/testConfig$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Testers resource.</summary>
        public virtual TestersResource Testers { get; }

        /// <summary>The "testers" collection of methods.</summary>
        public class TestersResource
        {
            private const string Resource = "testers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TestersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            /// <param name="project">
            /// The name of the project, which is the parent of testers Format: `projects/{project_number}`
            /// </param>
            public virtual GetUdidsRequest GetUdids(string project)
            {
                return new GetUdidsRequest(this.service, project);
            }

            /// <summary>Get UDIDs of tester iOS devices in a project</summary>
            public class GetUdidsRequest : FirebaseAppDistributionBaseServiceRequest<Google.Apis.FirebaseAppDistribution.v1alpha.Data.GoogleFirebaseAppdistroV1alphaGetTesterUdidsResponse>
            {
                /// <summary>Constructs a new GetUdids request.</summary>
                public GetUdidsRequest(Google.Apis.Services.IClientService service, string project) : base(service)
                {
                    Project = project;
                    InitParameters();
                }

                /// <summary>
                /// The name of the project, which is the parent of testers Format: `projects/{project_number}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>
                /// Unique id for a Firebase app of the format: {version}:{project_number}:{platform}:{hash(bundle_id)}
                /// Example: 1:581234567376:android:aa0a3c7b135e90289
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mobilesdkAppId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MobilesdkAppId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getUdids";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+project}/testers:udids";

                /// <summary>Initializes GetUdids parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("mobilesdkAppId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mobilesdkAppId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.FirebaseAppDistribution.v1alpha.Data
{
    /// <summary>A release of a Firebase app.</summary>
    public class GoogleFirebaseAppdistroV1Release : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A signed link (which expires in one hour) to directly download the app binary (IPA/APK/AAB)
        /// file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryDownloadUri")]
        public virtual string BinaryDownloadUri { get; set; }

        /// <summary>
        /// Output only. Build version of the release. For an Android release, the build version is the `versionCode`.
        /// For an iOS release, the build version is the `CFBundleVersion`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the release was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Display version of the release. For an Android release, the display version is the
        /// `versionName`. For an iOS release, the display version is the `CFBundleShortVersionString`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>Output only. A link to the Firebase console displaying a single release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseConsoleUri")]
        public virtual string FirebaseConsoleUri { get; set; }

        /// <summary>
        /// The name of the release resource. Format: `projects/{project_number}/apps/{app_id}/releases/{release_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Notes of the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual GoogleFirebaseAppdistroV1ReleaseNotes ReleaseNotes { get; set; }

        /// <summary>
        /// Output only. A link to the release in the tester web clip or Android app that lets testers (which were
        /// granted access to the app) view release notes and install the app onto their devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingUri")]
        public virtual string TestingUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Notes that belong to a release.</summary>
    public class GoogleFirebaseAppdistroV1ReleaseNotes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text of the release notes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata for `UploadRelease`.</summary>
    public class GoogleFirebaseAppdistroV1UploadReleaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `UploadRelease`.</summary>
    public class GoogleFirebaseAppdistroV1UploadReleaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Release associated with the uploaded binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual GoogleFirebaseAppdistroV1Release Release { get; set; }

        /// <summary>Result of upload release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>App bundle test certificate</summary>
    public class GoogleFirebaseAppdistroV1alphaAabCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>MD5 hash of the certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashMd5")]
        public virtual string CertificateHashMd5 { get; set; }

        /// <summary>SHA1 hash of the certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashSha1")]
        public virtual string CertificateHashSha1 { get; set; }

        /// <summary>SHA256 hash of the certificate used to resign the AAB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashSha256")]
        public virtual string CertificateHashSha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App bundle test certificate generated for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aabCertificate")]
        public virtual GoogleFirebaseAppdistroV1alphaAabCertificate AabCertificate { get; set; }

        /// <summary>
        /// App bundle state. Only valid for android apps. The app_view field in the request must be set to FULL in
        /// order for this to be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aabState")]
        public virtual string AabState { get; set; }

        /// <summary>Firebase gmp app id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Bundle identifier</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>Developer contact email for testers to reach out to about privacy or support issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; }

        /// <summary>iOS or Android</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>Project number of the Firebase project, for example 300830567303.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual string ProjectNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An app crash that occurred during an automated test.</summary>
    public class GoogleFirebaseAppdistroV1alphaAppCrash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The message associated with the crash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Output only. The raw stack trace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual string StackTrace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaCreateReleaseNotesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual release notes body from the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual GoogleFirebaseAppdistroV1alphaReleaseNotes ReleaseNotes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaCreateReleaseNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The results of running an automated test on a particular device.</summary>
    public class GoogleFirebaseAppdistroV1alphaDeviceExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An app crash, if any occurred during the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appCrash")]
        public virtual GoogleFirebaseAppdistroV1alphaAppCrash AppCrash { get; set; }

        /// <summary>Output only. A URI to an image of the Robo crawl graph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawlGraphUri")]
        public virtual string CrawlGraphUri { get; set; }

        /// <summary>Required. The device that the test was run on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual GoogleFirebaseAppdistroV1alphaTestDevice Device { get; set; }

        /// <summary>Output only. The reason why the test failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedReason")]
        public virtual string FailedReason { get; set; }

        /// <summary>Output only. The reason why the test was inconclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inconclusiveReason")]
        public virtual string InconclusiveReason { get; set; }

        /// <summary>
        /// Output only. The path to a directory in Cloud Storage that will eventually contain the results for this
        /// execution. For example, gs://bucket/Nexus5-18-en-portrait.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsStoragePath")]
        public virtual string ResultsStoragePath { get; set; }

        /// <summary>Output only. The statistics collected during the Robo test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roboStats")]
        public virtual GoogleFirebaseAppdistroV1alphaRoboStats RoboStats { get; set; }

        /// <summary>
        /// Output only. A list of screenshot image URIs taken from the Robo crawl. The file names are numbered by the
        /// order in which they were taken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshotUris")]
        public virtual System.Collections.Generic.IList<string> ScreenshotUris { get; set; }

        /// <summary>Output only. The state of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. A URI to a video of the test run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoUri")]
        public virtual string VideoUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Ignored. Used to be build version of the app release if an instance identifier was provided for
        /// the release_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        /// <summary>
        /// Optional. Ignored. Used to be display version of the app release if an instance identifier was provided for
        /// the release_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>
        /// Optional. An email address which should get access to this release, for example rebeccahe@google.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Optional. A repeated list of group aliases to enable access to a release for Note: This field is misnamed,
        /// but can't be changed because we need to maintain compatibility with old build tools
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupIds")]
        public virtual System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaEnableAccessOnReleaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object to get the release given a upload hash</summary>
    public class GoogleFirebaseAppdistroV1alphaGetReleaseByUploadHashResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Release object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual GoogleFirebaseAppdistroV1alphaRelease Release { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the UDIDs of tester iOS devices in a project</summary>
    public class GoogleFirebaseAppdistroV1alphaGetTesterUdidsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The UDIDs of tester iOS devices in a project</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerUdids")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaTesterUdid> TesterUdids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaGetUploadStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error code associated with (only set on "FAILURE")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>
        /// Any additional context for the given upload status (e.g. error message) Meant to be displayed to the client
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The release that was created from the upload (only set on "SUCCESS")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual GoogleFirebaseAppdistroV1alphaRelease Release { get; set; }

        /// <summary>The status of the upload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaJwt : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for `ListReleaseTests`.</summary>
    public class GoogleFirebaseAppdistroV1alphaListReleaseTestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A short-lived token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The tests listed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseTests")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaReleaseTest> ReleaseTests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Login credential for automated tests</summary>
    public class GoogleFirebaseAppdistroV1alphaLoginCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Hints to the crawler for identifying input fields</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldHints")]
        public virtual GoogleFirebaseAppdistroV1alphaLoginCredentialFieldHints FieldHints { get; set; }

        /// <summary>Optional. Are these credentials for Google?</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("google")]
        public virtual System.Nullable<bool> Google { get; set; }

        /// <summary>Optional. Password for automated tests</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Optional. Username for automated tests</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Hints to the crawler for identifying input fields</summary>
    public class GoogleFirebaseAppdistroV1alphaLoginCredentialFieldHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Android resource name of the password UI element. For example, in Java: R.string.foo in xml:
        /// @string/foo Only the "foo" part is needed. Reference doc:
        /// https://developer.android.com/guide/topics/resources/accessing-resources.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordResourceName")]
        public virtual string PasswordResourceName { get; set; }

        /// <summary>
        /// Required. The Android resource name of the username UI element. For example, in Java: R.string.foo in xml:
        /// @string/foo Only the "foo" part is needed. Reference doc:
        /// https://developer.android.com/guide/topics/resources/accessing-resources.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usernameResourceName")]
        public virtual string UsernameResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaProvisionAppResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto defining a release object</summary>
    public class GoogleFirebaseAppdistroV1alphaRelease : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Release build version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        /// <summary>Release version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        private string _distributedAtRaw;

        private object _distributedAt;

        /// <summary>Timestamp when the release was created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributedAt")]
        public virtual string DistributedAtRaw
        {
            get => _distributedAtRaw;
            set
            {
                _distributedAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _distributedAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DistributedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DistributedAtDateTimeOffset instead.")]
        public virtual object DistributedAt
        {
            get => _distributedAt;
            set
            {
                _distributedAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _distributedAt = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DistributedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DistributedAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DistributedAtRaw);
            set => DistributedAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Release Id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Instance id of the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        private string _lastActivityAtRaw;

        private object _lastActivityAt;

        /// <summary>Last activity timestamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastActivityAt")]
        public virtual string LastActivityAtRaw
        {
            get => _lastActivityAtRaw;
            set
            {
                _lastActivityAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastActivityAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastActivityAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastActivityAtDateTimeOffset instead.")]
        public virtual object LastActivityAt
        {
            get => _lastActivityAt;
            set
            {
                _lastActivityAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastActivityAt = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastActivityAtRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastActivityAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastActivityAtRaw);
            set => LastActivityAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Number of testers who have open invitations for the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openInvitationCount")]
        public virtual System.Nullable<int> OpenInvitationCount { get; set; }

        private string _receivedAtRaw;

        private object _receivedAt;

        /// <summary>unused. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receivedAt")]
        public virtual string ReceivedAtRaw
        {
            get => _receivedAtRaw;
            set
            {
                _receivedAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _receivedAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReceivedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReceivedAtDateTimeOffset instead.")]
        public virtual object ReceivedAt
        {
            get => _receivedAt;
            set
            {
                _receivedAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _receivedAt = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReceivedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReceivedAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReceivedAtRaw);
            set => ReceivedAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Release notes summary</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotesSummary")]
        public virtual string ReleaseNotesSummary { get; set; }

        /// <summary>Count of testers added to the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerCount")]
        public virtual System.Nullable<int> TesterCount { get; set; }

        /// <summary>Number of testers who have installed the release</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testerWithInstallCount")]
        public virtual System.Nullable<int> TesterWithInstallCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleFirebaseAppdistroV1alphaReleaseNotes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual string ReleaseNotes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The results of running an automated test on a release.</summary>
    public class GoogleFirebaseAppdistroV1alphaReleaseTest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the test was run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. The results of the test on each device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceExecutions")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaDeviceExecution> DeviceExecutions { get; set; }

        /// <summary>Optional. Input only. Login credentials for the test. Input only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginCredential")]
        public virtual GoogleFirebaseAppdistroV1alphaLoginCredential LoginCredential { get; set; }

        /// <summary>
        /// The name of the release test resource. Format:
        /// `projects/{project_number}/apps/{app_id}/releases/{release_id}/tests/{test_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Robo crawler</summary>
    public class GoogleFirebaseAppdistroV1alphaRoboCrawler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Login credential for automated tests</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginCredential")]
        public virtual GoogleFirebaseAppdistroV1alphaLoginCredential LoginCredential { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics collected during a Robo test.</summary>
    public class GoogleFirebaseAppdistroV1alphaRoboStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of actions that crawler performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionsPerformed")]
        public virtual System.Nullable<int> ActionsPerformed { get; set; }

        /// <summary>Output only. Duration of crawl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawlDuration")]
        public virtual object CrawlDuration { get; set; }

        /// <summary>Output only. Number of distinct screens visited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctVisitedScreens")]
        public virtual System.Nullable<int> DistinctVisitedScreens { get; set; }

        /// <summary>Output only. Whether the main activity crawl timed out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainActivityCrawlTimedOut")]
        public virtual System.Nullable<bool> MainActivityCrawlTimedOut { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for automated tests</summary>
    public class GoogleFirebaseAppdistroV1alphaTestConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The name of the test configuration resource. Format:
        /// `projects/{project_number}/apps/{app_id}/testConfig`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Configuration for Robo crawler</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roboCrawler")]
        public virtual GoogleFirebaseAppdistroV1alphaRoboCrawler RoboCrawler { get; set; }

        /// <summary>Optional. Tests will be run on this list of devices</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDevices")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppdistroV1alphaTestDevice> TestDevices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A device on which automated tests can be run.</summary>
    public class GoogleFirebaseAppdistroV1alphaTestDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The locale of the device (e.g. "en_US" for US English) during the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>Required. The device model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>Optional. The orientation of the device during the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>Required. The version of the device (API level on Android).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The UDIDs of a tester's iOS device</summary>
    public class GoogleFirebaseAppdistroV1alphaTesterUdid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the tester's device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The platform of the tester's device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The UDID of the tester's device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("udid")]
        public virtual string Udid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
