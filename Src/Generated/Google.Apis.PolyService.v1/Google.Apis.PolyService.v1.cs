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

namespace Google.Apis.PolyService.v1
{
    /// <summary>The PolyService Service.</summary>
    public class PolyServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PolyServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PolyServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Assets = new AssetsResource(this);
            Users = new UsersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "poly";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://poly.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://poly.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for PolyService requests.</summary>
    public abstract class PolyServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PolyServiceBaseServiceRequest instance.</summary>
        protected PolyServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PolyService parameter list.</summary>
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

    /// <summary>The "assets" collection of methods.</summary>
    public class AssetsResource
    {
        private const string Resource = "assets";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AssetsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Returns detailed information about an asset given its name. PRIVATE assets are returned only if the
        /// currently authenticated user (via OAuth token) is the author of the asset.
        /// </summary>
        /// <param name="name">Required. An asset's name in the form `assets/{ASSET_ID}`.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Returns detailed information about an asset given its name. PRIVATE assets are returned only if the
        /// currently authenticated user (via OAuth token) is the author of the asset.
        /// </summary>
        public class GetRequest : PolyServiceBaseServiceRequest<Google.Apis.PolyService.v1.Data.Asset>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. An asset's name in the form `assets/{ASSET_ID}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^assets/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists all public, remixable assets. These are assets with an access level of PUBLIC and published under the
        /// CC-By license.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists all public, remixable assets. These are assets with an access level of PUBLIC and published under the
        /// CC-By license.
        /// </summary>
        public class ListRequest : PolyServiceBaseServiceRequest<Google.Apis.PolyService.v1.Data.ListAssetsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Filter assets based on the specified category. Supported values are: `animals`, `architecture`, `art`,
            /// `food`, `nature`, `objects`, `people`, `scenes`, `technology`, and `transport`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("category", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Category { get; set; }

            /// <summary>Return only assets that have been curated by the Poly team.</summary>
            [Google.Apis.Util.RequestParameterAttribute("curated", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Curated { get; set; }

            /// <summary>
            /// Return only assets with the matching format. Acceptable values are: `BLOCKS`, `FBX`, `GLTF`, `GLTF2`,
            /// `OBJ`, `TILT`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Format { get; set; }

            /// <summary>
            /// One or more search terms to be matched against all text that Poly has indexed for assets, which includes
            /// display_name, description, and tags. Multiple keywords should be separated by spaces.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("keywords", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Keywords { get; set; }

            /// <summary>
            /// Returns assets that are of the specified complexity or less. Defaults to COMPLEX. For example, a request
            /// for MEDIUM assets also includes SIMPLE assets.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxComplexity", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MaxComplexityEnum> MaxComplexity { get; set; }

            /// <summary>
            /// Returns assets that are of the specified complexity or less. Defaults to COMPLEX. For example, a request
            /// for MEDIUM assets also includes SIMPLE assets.
            /// </summary>
            public enum MaxComplexityEnum
            {
                /// <summary>No complexity specified. This is equivalent to omitting the filter.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPLEXITY_UNSPECIFIED")]
                COMPLEXITYUNSPECIFIED = 0,

                /// <summary>Highly-complex.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPLEX")]
                COMPLEX = 1,

                /// <summary>Averagely-complex.</summary>
                [Google.Apis.Util.StringValueAttribute("MEDIUM")]
                MEDIUM = 2,

                /// <summary>Simple.</summary>
                [Google.Apis.Util.StringValueAttribute("SIMPLE")]
                SIMPLE = 3,
            }

            /// <summary>
            /// Specifies an ordering for assets. Acceptable values are: `BEST`, `NEWEST`, `OLDEST`. Defaults to `BEST`,
            /// which ranks assets based on a combination of popularity and other features.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// The maximum number of assets to be returned. This value must be between `1` and `100`. Defaults to `20`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Specifies a continuation token from a previous search whose results were split into multiple pages. To
            /// get the next page, submit the same request specifying the value from next_page_token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/assets";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("category", new Google.Apis.Discovery.Parameter
                {
                    Name = "category",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("curated", new Google.Apis.Discovery.Parameter
                {
                    Name = "curated",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("format", new Google.Apis.Discovery.Parameter
                {
                    Name = "format",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("keywords", new Google.Apis.Discovery.Parameter
                {
                    Name = "keywords",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxComplexity", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxComplexity",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Assets = new AssetsResource(service);
            Likedassets = new LikedassetsResource(service);
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists assets authored by the given user. Only the value 'me', representing the currently-authenticated
            /// user, is supported. May include assets with an access level of PRIVATE or UNLISTED and assets which are
            /// All Rights Reserved for the currently-authenticated user.
            /// </summary>
            /// <param name="name">
            /// A valid user id. Currently, only the special value 'me', representing the currently-authenticated user
            /// is supported. To use 'me', you must pass an OAuth token with the request.
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists assets authored by the given user. Only the value 'me', representing the currently-authenticated
            /// user, is supported. May include assets with an access level of PRIVATE or UNLISTED and assets which are
            /// All Rights Reserved for the currently-authenticated user.
            /// </summary>
            public class ListRequest : PolyServiceBaseServiceRequest<Google.Apis.PolyService.v1.Data.ListUserAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// A valid user id. Currently, only the special value 'me', representing the currently-authenticated
                /// user is supported. To use 'me', you must pass an OAuth token with the request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Return only assets with the matching format. Acceptable values are: `BLOCKS`, `FBX`, `GLTF`,
                /// `GLTF2`, `OBJ`, and `TILT`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Format { get; set; }

                /// <summary>
                /// Specifies an ordering for assets. Acceptable values are: `BEST`, `NEWEST`, `OLDEST`. Defaults to
                /// `BEST`, which ranks assets based on a combination of popularity and other features.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of assets to be returned. This value must be between `1` and `100`. Defaults to
                /// `20`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Specifies a continuation token from a previous search whose results were split into multiple pages.
                /// To get the next page, submit the same request specifying the value from next_page_token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The visibility of the assets to be returned. Defaults to VISIBILITY_UNSPECIFIED which returns all
                /// assets.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("visibility", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<VisibilityEnum> Visibility { get; set; }

                /// <summary>
                /// The visibility of the assets to be returned. Defaults to VISIBILITY_UNSPECIFIED which returns all
                /// assets.
                /// </summary>
                public enum VisibilityEnum
                {
                    /// <summary>No visibility specified. Returns all assets.</summary>
                    [Google.Apis.Util.StringValueAttribute("VISIBILITY_UNSPECIFIED")]
                    VISIBILITYUNSPECIFIED = 0,

                    /// <summary>Returns only published assets.</summary>
                    [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                    PUBLISHED = 1,

                    /// <summary>Returns only private assets.</summary>
                    [Google.Apis.Util.StringValueAttribute("PRIVATE")]
                    PRIVATE__ = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/assets";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^users/[^/]+$",
                    });
                    RequestParameters.Add("format", new Google.Apis.Discovery.Parameter
                    {
                        Name = "format",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
                    RequestParameters.Add("visibility", new Google.Apis.Discovery.Parameter
                    {
                        Name = "visibility",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Likedassets resource.</summary>
        public virtual LikedassetsResource Likedassets { get; }

        /// <summary>The "likedassets" collection of methods.</summary>
        public class LikedassetsResource
        {
            private const string Resource = "likedassets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LikedassetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists assets that the user has liked. Only the value 'me', representing the currently-authenticated
            /// user, is supported. May include assets with an access level of UNLISTED.
            /// </summary>
            /// <param name="name">
            /// A valid user id. Currently, only the special value 'me', representing the currently-authenticated user
            /// is supported. To use 'me', you must pass an OAuth token with the request.
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists assets that the user has liked. Only the value 'me', representing the currently-authenticated
            /// user, is supported. May include assets with an access level of UNLISTED.
            /// </summary>
            public class ListRequest : PolyServiceBaseServiceRequest<Google.Apis.PolyService.v1.Data.ListLikedAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// A valid user id. Currently, only the special value 'me', representing the currently-authenticated
                /// user is supported. To use 'me', you must pass an OAuth token with the request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Return only assets with the matching format. Acceptable values are: `BLOCKS`, `FBX`, `GLTF`,
                /// `GLTF2`, `OBJ`, `TILT`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Format { get; set; }

                /// <summary>
                /// Specifies an ordering for assets. Acceptable values are: `BEST`, `NEWEST`, `OLDEST`, 'LIKED_TIME'.
                /// Defaults to `LIKED_TIME`, which ranks assets based on how recently they were liked.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of assets to be returned. This value must be between `1` and `100`. Defaults to
                /// `20`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Specifies a continuation token from a previous search whose results were split into multiple pages.
                /// To get the next page, submit the same request specifying the value from next_page_token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/likedassets";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^users/[^/]+$",
                    });
                    RequestParameters.Add("format", new Google.Apis.Discovery.Parameter
                    {
                        Name = "format",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
}
namespace Google.Apis.PolyService.v1.Data
{
    /// <summary>
    /// Represents and describes an asset in the Poly library. An asset is a 3D model or scene created using [Tilt
    /// Brush](//www.tiltbrush.com), [Blocks](//vr.google.com/blocks/), or any 3D program that produces a file that can
    /// be upload to Poly.
    /// </summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The author's publicly visible name. Use this name when giving credit to the author. For more information,
        /// see [Licensing](/poly/discover/licensing).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorName")]
        public virtual string AuthorName { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// For published assets, the time when the asset was published. For unpublished assets, the time when the asset
        /// was created.
        /// </summary>
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

        /// <summary>The human-readable description, set by the asset's author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human-readable name, set by the asset's author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>A list of Formats where each format describes one representation of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formats")]
        public virtual System.Collections.Generic.IList<Format> Formats { get; set; }

        /// <summary>Whether this asset has been curated by the Poly team.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCurated")]
        public virtual System.Nullable<bool> IsCurated { get; set; }

        /// <summary>The license under which the author has made the asset available for use, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual string License { get; set; }

        /// <summary>
        /// Application-defined opaque metadata for this asset. This field is only returned when querying for the
        /// signed-in user's own assets, not for public assets. This string is limited to 1K chars. It is up to the
        /// creator of the asset to define the format for this string (for example, JSON).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual string Metadata { get; set; }

        /// <summary>The unique identifier for the asset in the form: `assets/{ASSET_ID}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Hints for displaying the asset. Note that these parameters are not immutable; the author of an asset may
        /// change them post-publication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentationParams")]
        public virtual PresentationParams PresentationParams { get; set; }

        /// <summary>The remix info for the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remixInfo")]
        public virtual RemixInfo RemixInfo { get; set; }

        /// <summary>The thumbnail image for the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual File Thumbnail { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// The time when the asset was last modified. For published assets, whose contents are immutable, the update
        /// time changes only when metadata properties, such as visibility, are updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The visibility of the asset and who can access it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message generated by the asset import process.</summary>
    public class AssetImportMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The code associated with this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>An optional file path. Only present for those error codes that specify it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>An optional image error. Only present for INVALID_IMAGE_FILE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageError")]
        public virtual ImageError ImageError { get; set; }

        /// <summary>An optional OBJ parse error. Only present for OBJ_PARSE_ERROR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objParseError")]
        public virtual ObjParseError ObjParseError { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a file in Poly, which can be a root, resource, or thumbnail file.</summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The MIME content-type, such as `image/png`. For more information, see [MIME
        /// types](//developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// The path of the resource file relative to the root file. For root or thumbnail files, this is just the
        /// filename.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativePath")]
        public virtual string RelativePath { get; set; }

        /// <summary>The URL where the file data can be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The same asset can be represented in different formats, for example, a [WaveFront
    /// .obj](//en.wikipedia.org/wiki/Wavefront_.obj_file) file with its corresponding .mtl file or a [Khronos
    /// glTF](//www.khronos.org/gltf) file with its corresponding .glb binary data. A format refers to a specific
    /// representation of an asset and contains all information needed to retrieve and describe this representation.
    /// </summary>
    public class Format : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Complexity stats about this representation of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatComplexity")]
        public virtual FormatComplexity FormatComplexity { get; set; }

        /// <summary>
        /// A short string that identifies the format type of this representation. Possible values are: `FBX`, `GLTF`,
        /// `GLTF2`, `OBJ`, and `TILT`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatType")]
        public virtual string FormatType { get; set; }

        /// <summary>
        /// A list of dependencies of the root element. May include, but is not limited to, materials, textures, and
        /// shader programs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<File> Resources { get; set; }

        /// <summary>
        /// The root of the file hierarchy. This will always be populated. For some format_types - such as `TILT`, which
        /// are self-contained - this is all of the data. Other types - such as `OBJ` - often reference other data
        /// elements. These are contained in the resources field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("root")]
        public virtual File Root { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information on the complexity of this Format.</summary>
    public class FormatComplexity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A non-negative integer that represents the level of detail (LOD) of this format relative to other formats of
        /// the same asset with the same format_type. This hint allows you to sort formats from the most-detailed (0) to
        /// least-detailed (integers greater than 0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lodHint")]
        public virtual System.Nullable<int> LodHint { get; set; }

        /// <summary>The estimated number of triangles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triangleCount")]
        public virtual System.Nullable<long> TriangleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message resulting from reading an image file.</summary>
    public class ImageError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of image error encountered. Optional for older image errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The file path in the import of the image that was rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message from a request to list.</summary>
    public class ListAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of assets that match the criteria specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<Asset> Assets { get; set; }

        /// <summary>
        /// The continuation token for retrieving the next page. If empty, indicates that there are no more pages. To
        /// get the next page, submit the same request specifying this value as the page_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total number of assets in the list, without pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message from a request to list.</summary>
    public class ListLikedAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of assets that match the criteria specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<Asset> Assets { get; set; }

        /// <summary>
        /// The continuation token for retrieving the next page. If empty, indicates that there are no more pages. To
        /// get the next page, submit the same request specifying this value as the page_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total number of assets in the list, without pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message from a request to list.</summary>
    public class ListUserAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The continuation token for retrieving the next page. If empty, indicates that there are no more pages. To
        /// get the next page, submit the same request specifying this value as the page_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total number of assets in the list, without pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>A list of UserAssets matching the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAssets")]
        public virtual System.Collections.Generic.IList<UserAsset> UserAssets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of an error resulting from parsing an OBJ file</summary>
    public class ObjParseError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of problem found (required).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ending character index at which the problem was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>The file path in which the problem was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>
        /// The text of the line. Note that this may be truncated if the line was very long. This may not include the
        /// error if it occurs after line truncation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual string Line { get; set; }

        /// <summary>Line number at which the problem was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual System.Nullable<int> LineNumber { get; set; }

        /// <summary>The starting character index at which the problem was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Hints for displaying the asset, based on information available when the asset was uploaded.</summary>
    public class PresentationParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A background color which could be used for displaying the 3D asset in a 'thumbnail' or 'palette' style view.
        /// Authors have the option to set this background color when publishing or editing their asset. This is
        /// represented as a six-digit hexademical triplet specifying the RGB components of the background color, e.g.
        /// #FF0000 for Red.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual string BackgroundColor { get; set; }

        /// <summary>
        /// The materials' diffuse/albedo color. This does not apply to vertex colors or texture maps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorSpace")]
        public virtual string ColorSpace { get; set; }

        /// <summary>
        /// A rotation that should be applied to the object root to make it upright. More precisely, this quaternion
        /// transforms from "object space" (the space in which the object is defined) to "presentation space", a
        /// coordinate system where +Y is up, +X is right, -Z is forward. For example, if the object is the Eiffel
        /// Tower, in its local coordinate system the object might be laid out such that the base of the tower is on the
        /// YZ plane and the tip of the tower is towards positive X. In this case this quaternion would specify a
        /// rotation (of 90 degrees about the Z axis) such that in the presentation space the base of the tower is
        /// aligned with the XZ plane, and the tip of the tower lies towards +Y. This rotation is unrelated to the
        /// object's pose in the web preview, which is just a camera position setting and is *not* reflected in this
        /// rotation. Please note: this is applicable only to the gLTF.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientingRotation")]
        public virtual Quaternion OrientingRotation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A [Quaternion](//en.wikipedia.org/wiki/Quaternion). Please note: if in the response you see "w: 1" and nothing
    /// else this is the default value of [0, 0, 0, 1] where x,y, and z are 0.
    /// </summary>
    public class Quaternion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The scalar component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("w")]
        public virtual System.Nullable<double> W { get; set; }

        /// <summary>The x component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<double> X { get; set; }

        /// <summary>The y component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<double> Y { get; set; }

        /// <summary>The z component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        public virtual System.Nullable<double> Z { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Info about the sources of this asset (i.e. assets that were remixed to create this asset).</summary>
    public class RemixInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource ids for the sources of this remix, of the form: `assets/{ASSET_ID}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceAsset")]
        public virtual System.Collections.Generic.IList<string> SourceAsset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response message from a request to startImport. This is returned in the response field of the Operation.
    /// </summary>
    public class StartAssetImportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id of newly created asset. If this is empty when the operation is complete it means the import failed.
        /// Please refer to the assetImportMessages field to understand what went wrong.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetId")]
        public virtual string AssetId { get; set; }

        /// <summary>The id of the asset import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetImportId")]
        public virtual string AssetImportId { get; set; }

        /// <summary>
        /// The message from the asset import. This will contain any warnings (or - in the case of failure - errors)
        /// that occurred during import.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetImportMessages")]
        public virtual System.Collections.Generic.IList<AssetImportMessage> AssetImportMessages { get; set; }

        /// <summary>The publish URL for the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishUrl")]
        public virtual string PublishUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data about the user's asset.</summary>
    public class UserAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An Asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
