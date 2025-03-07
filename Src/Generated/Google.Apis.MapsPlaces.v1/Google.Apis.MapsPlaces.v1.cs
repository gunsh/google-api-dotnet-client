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

namespace Google.Apis.MapsPlaces.v1
{
    /// <summary>The MapsPlaces Service.</summary>
    public class MapsPlacesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MapsPlacesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MapsPlacesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Places = new PlacesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "places";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://places.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://places.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Places API (New).</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places</summary>
            public static string MapsPlatformPlaces = "https://www.googleapis.com/auth/maps-platform.places";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.details</summary>
            public static string MapsPlatformPlacesDetails = "https://www.googleapis.com/auth/maps-platform.places.details";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.nearbysearch</summary>
            public static string MapsPlatformPlacesNearbysearch = "https://www.googleapis.com/auth/maps-platform.places.nearbysearch";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.textsearch</summary>
            public static string MapsPlatformPlacesTextsearch = "https://www.googleapis.com/auth/maps-platform.places.textsearch";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Places API (New).</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places</summary>
            public const string MapsPlatformPlaces = "https://www.googleapis.com/auth/maps-platform.places";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.details</summary>
            public const string MapsPlatformPlacesDetails = "https://www.googleapis.com/auth/maps-platform.places.details";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.nearbysearch</summary>
            public const string MapsPlatformPlacesNearbysearch = "https://www.googleapis.com/auth/maps-platform.places.nearbysearch";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.textsearch</summary>
            public const string MapsPlatformPlacesTextsearch = "https://www.googleapis.com/auth/maps-platform.places.textsearch";
        }

        /// <summary>Gets the Places resource.</summary>
        public virtual PlacesResource Places { get; }
    }

    /// <summary>A base abstract class for MapsPlaces requests.</summary>
    public abstract class MapsPlacesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MapsPlacesBaseServiceRequest instance.</summary>
        protected MapsPlacesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MapsPlaces parameter list.</summary>
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

    /// <summary>The "places" collection of methods.</summary>
    public class PlacesResource
    {
        private const string Resource = "places";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PlacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Photos = new PhotosResource(service);
        }

        /// <summary>Gets the Photos resource.</summary>
        public virtual PhotosResource Photos { get; }

        /// <summary>The "photos" collection of methods.</summary>
        public class PhotosResource
        {
            private const string Resource = "photos";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PhotosResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get a photo media with a photo reference string.</summary>
            /// <param name="name">
            /// Required. The resource name of a photo media in the format:
            /// `places/{place_id}/photos/{photo_reference}/media`. The resource name of a photo as returned in a Place
            /// object's `photos.name` field comes with the format `places/{place_id}/photos/{photo_reference}`. You
            /// need to append `/media` at the end of the photo resource to get the photo media resource name.
            /// </param>
            public virtual GetMediaRequest GetMedia(string name)
            {
                return new GetMediaRequest(this.service, name);
            }

            /// <summary>Get a photo media with a photo reference string.</summary>
            public class GetMediaRequest : MapsPlacesBaseServiceRequest<Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1PhotoMedia>
            {
                /// <summary>Constructs a new GetMedia request.</summary>
                public GetMediaRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of a photo media in the format:
                /// `places/{place_id}/photos/{photo_reference}/media`. The resource name of a photo as returned in a
                /// Place object's `photos.name` field comes with the format
                /// `places/{place_id}/photos/{photo_reference}`. You need to append `/media` at the end of the photo
                /// resource to get the photo media resource name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. Specifies the maximum desired height, in pixels, of the image. If the image is smaller
                /// than the values specified, the original image will be returned. If the image is larger in either
                /// dimension, it will be scaled to match the smaller of the two dimensions, restricted to its original
                /// aspect ratio. Both the max_height_px and max_width_px properties accept an integer between 1 and
                /// 4800, inclusively. If the value is not within the allowed range, an INVALID_ARGUMENT error will be
                /// returned. At least one of max_height_px or max_width_px needs to be specified. If neither
                /// max_height_px nor max_width_px is specified, an INVALID_ARGUMENT error will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxHeightPx", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxHeightPx { get; set; }

                /// <summary>
                /// Optional. Specifies the maximum desired width, in pixels, of the image. If the image is smaller than
                /// the values specified, the original image will be returned. If the image is larger in either
                /// dimension, it will be scaled to match the smaller of the two dimensions, restricted to its original
                /// aspect ratio. Both the max_height_px and max_width_px properties accept an integer between 1 and
                /// 4800, inclusively. If the value is not within the allowed range, an INVALID_ARGUMENT error will be
                /// returned. At least one of max_height_px or max_width_px needs to be specified. If neither
                /// max_height_px nor max_width_px is specified, an INVALID_ARGUMENT error will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxWidthPx", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxWidthPx { get; set; }

                /// <summary>
                /// Optional. If set, skip the default HTTP redirect behavior and render a text format (for example, in
                /// JSON format for HTTP use case) response. If not set, an HTTP redirect will be issued to redirect the
                /// call to the image media. This option is ignored for non-HTTP requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("skipHttpRedirect", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> SkipHttpRedirect { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getMedia";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetMedia parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^places/[^/]+/photos/[^/]+/media$",
                    });
                    RequestParameters.Add("maxHeightPx", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxHeightPx",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("maxWidthPx", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxWidthPx",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("skipHttpRedirect", new Google.Apis.Discovery.Parameter
                    {
                        Name = "skipHttpRedirect",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string in the `places/{place_id}` format.
        /// </summary>
        /// <param name="name">Required. The resource name of a place, in the `places/{place_id}` format.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string in the `places/{place_id}` format.
        /// </summary>
        public class GetRequest : MapsPlacesBaseServiceRequest<Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1Place>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The resource name of a place, in the `places/{place_id}` format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. Place details will be displayed with the preferred language if available. Current list of
            /// supported languages: https://developers.google.com/maps/faq#languagesupport.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Optional. The Unicode country/region code (CLDR) of the location where the request is coming from. This
            /// parameter is used to display the place details, like region-specific place name, if available. The
            /// parameter can affect results based on applicable law. For more information, see
            /// https://www.unicode.org/cldr/charts/latest/supplemental/territory_language_information.html. Note that
            /// 3-digit region codes are not currently supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

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
                    Pattern = @"^places/[^/]+$",
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Search for places near locations.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchNearbyRequest SearchNearby(Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchNearbyRequest body)
        {
            return new SearchNearbyRequest(this.service, body);
        }

        /// <summary>Search for places near locations.</summary>
        public class SearchNearbyRequest : MapsPlacesBaseServiceRequest<Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchNearbyResponse>
        {
            /// <summary>Constructs a new SearchNearby request.</summary>
            public SearchNearbyRequest(Google.Apis.Services.IClientService service, Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchNearbyRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchNearbyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchNearby";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/places:searchNearby";

            /// <summary>Initializes SearchNearby parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Text query based place search.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchTextRequest SearchText(Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest body)
        {
            return new SearchTextRequest(this.service, body);
        }

        /// <summary>Text query based place search.</summary>
        public class SearchTextRequest : MapsPlacesBaseServiceRequest<Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextResponse>
        {
            /// <summary>Constructs a new SearchText request.</summary>
            public SearchTextRequest(Google.Apis.Services.IClientService service, Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/places:searchText";

            /// <summary>Initializes SearchText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.MapsPlaces.v1.Data
{
    /// <summary>
    /// A latitude-longitude viewport, represented as two diagonally opposite `low` and `high` points. A viewport is
    /// considered a closed region, i.e. it includes its boundary. The latitude bounds must range between -90 to 90
    /// degrees inclusive, and the longitude bounds must range between -180 to 180 degrees inclusive. Various cases
    /// include: - If `low` = `high`, the viewport consists of that single point. - If `low.longitude` &amp;gt;
    /// `high.longitude`, the longitude range is inverted (the viewport crosses the 180 degree longitude line). - If
    /// `low.longitude` = -180 degrees and `high.longitude` = 180 degrees, the viewport includes all longitudes. - If
    /// `low.longitude` = 180 degrees and `high.longitude` = -180 degrees, the longitude range is empty. - If
    /// `low.latitude` &amp;gt; `high.latitude`, the latitude range is empty. Both `low` and `high` must be populated,
    /// and the represented box cannot be empty (as specified by the definitions above). An empty viewport will result
    /// in an error. For example, this viewport fully encloses New York City: { "low": { "latitude": 40.477398,
    /// "longitude": -74.259087 }, "high": { "latitude": 40.91618, "longitude": -73.70018 } }
    /// </summary>
    public class GoogleGeoTypeViewport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The high point of the viewport.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("high")]
        public virtual GoogleTypeLatLng High { get; set; }

        /// <summary>Required. The low point of the viewport.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("low")]
        public virtual GoogleTypeLatLng Low { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the author of the UGC data. Used in Photo, and Review.</summary>
    public class GoogleMapsPlacesV1AuthorAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the author of the Photo or Review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Profile photo URI of the author of the Photo or Review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUri")]
        public virtual string PhotoUri { get; set; }

        /// <summary>URI of the author of the Photo or Review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Circle with a LatLng as center and radius.</summary>
    public class GoogleMapsPlacesV1Circle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Center latitude and longitude. The range of latitude must be within [-90.0, 90.0]. The range of
        /// the longitude must be within [-180.0, 180.0].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("center")]
        public virtual GoogleTypeLatLng Center { get; set; }

        /// <summary>Required. Radius measured in meters. The radius must be within [0.0, 50000.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radius")]
        public virtual System.Nullable<double> Radius { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the EV Charge Station hosted in Place. Terminology follows
    /// https://afdc.energy.gov/fuels/electricity_infrastructure.html One port could charge one car at a time. One port
    /// has one or more connectors. One station has one or more ports.
    /// </summary>
    public class GoogleMapsPlacesV1EVChargeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of EV charging connector aggregations that contain connectors of the same type and same charge rate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorAggregation")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1EVChargeOptionsConnectorAggregation> ConnectorAggregation { get; set; }

        /// <summary>
        /// Number of connectors at this station. However, because some ports can have multiple connectors but only be
        /// able to charge one car at a time (e.g.) the number of connectors may be greater than the total number of
        /// cars which can charge simultaneously.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorCount")]
        public virtual System.Nullable<int> ConnectorCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EV charging information grouped by [type, max_charge_rate_kw]. Shows EV charge aggregation of connectors that
    /// have the same type and max charge rate in kw.
    /// </summary>
    public class GoogleMapsPlacesV1EVChargeOptionsConnectorAggregation : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _availabilityLastUpdateTimeRaw;

        private object _availabilityLastUpdateTime;

        /// <summary>
        /// The timestamp when the connector availability information in this aggregation was last updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityLastUpdateTime")]
        public virtual string AvailabilityLastUpdateTimeRaw
        {
            get => _availabilityLastUpdateTimeRaw;
            set
            {
                _availabilityLastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _availabilityLastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AvailabilityLastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AvailabilityLastUpdateTimeDateTimeOffset instead.")]
        public virtual object AvailabilityLastUpdateTime
        {
            get => _availabilityLastUpdateTime;
            set
            {
                _availabilityLastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _availabilityLastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AvailabilityLastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AvailabilityLastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AvailabilityLastUpdateTimeRaw);
            set => AvailabilityLastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Number of connectors in this aggregation that are currently available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableCount")]
        public virtual System.Nullable<int> AvailableCount { get; set; }

        /// <summary>Number of connectors in this aggregation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>The static max charging rate in kw of each connector in the aggregation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChargeRateKw")]
        public virtual System.Nullable<double> MaxChargeRateKw { get; set; }

        /// <summary>Number of connectors in this aggregation that are currently out of service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfServiceCount")]
        public virtual System.Nullable<int> OutOfServiceCount { get; set; }

        /// <summary>The connector type of this aggregation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The most recent information about fuel options in a gas station. This information is updated regularly.
    /// </summary>
    public class GoogleMapsPlacesV1FuelOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The last known fuel price for each type of fuel this station has. There is one entry per fuel type this
        /// station has. Order is not important.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fuelPrices")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1FuelOptionsFuelPrice> FuelPrices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fuel price information for a given type.</summary>
    public class GoogleMapsPlacesV1FuelOptionsFuelPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The price of the fuel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual GoogleTypeMoney Price { get; set; }

        /// <summary>The type of fuel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time the fuel price was last updated.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a photo of a place.</summary>
    public class GoogleMapsPlacesV1Photo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This photo's authors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorAttributions")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1AuthorAttribution> AuthorAttributions { get; set; }

        /// <summary>The maximum available height, in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPx")]
        public virtual System.Nullable<int> HeightPx { get; set; }

        /// <summary>
        /// Identifier. A reference representing this place photo which may be used to look up this place photo again
        /// (also called the API "resource" name: `places/{place_id}/photos/{photo}`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The maximum available width, in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPx")]
        public virtual System.Nullable<int> WidthPx { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A photo media from Places API.</summary>
    public class GoogleMapsPlacesV1PhotoMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of a photo media in the format: `places/{place_id}/photos/{photo_reference}/media`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A short-lived uri that can be used to render the photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUri")]
        public virtual string PhotoUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All the information representing a Place.</summary>
    public class GoogleMapsPlacesV1Place : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the accessibility options a place offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibilityOptions")]
        public virtual GoogleMapsPlacesV1PlaceAccessibilityOptions AccessibilityOptions { get; set; }

        /// <summary>
        /// Repeated components for each locality level. Note the following facts about the address_components[] array:
        /// - The array of address components may contain more components than the formatted_address. - The array does
        /// not necessarily include all the political entities that contain an address, apart from those included in the
        /// formatted_address. To retrieve all the political entities that contain a specific address, you should use
        /// reverse geocoding, passing the latitude/longitude of the address as a parameter to the request. - The format
        /// of the response is not guaranteed to remain the same between requests. In particular, the number of
        /// address_components varies based on the address requested and can change over time for the same address. A
        /// component can change position in the array. The type of the component can change. A particular component may
        /// be missing in a later response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressComponents")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceAddressComponent> AddressComponents { get; set; }

        /// <summary>The place's address in adr microformat: http://microformats.org/wiki/adr.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adrFormatAddress")]
        public virtual string AdrFormatAddress { get; set; }

        /// <summary>Place allows dogs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowsDogs")]
        public virtual System.Nullable<bool> AllowsDogs { get; set; }

        /// <summary>A set of data provider that must be shown with this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributions")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceAttribution> Attributions { get; set; }

        /// <summary>The business status for the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessStatus")]
        public virtual string BusinessStatus { get; set; }

        /// <summary>Specifies if the business supports curbside pickup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curbsidePickup")]
        public virtual System.Nullable<bool> CurbsidePickup { get; set; }

        /// <summary>
        /// The hours of operation for the next seven days (including today). The time period starts at midnight on the
        /// date of the request and ends at 11:59 pm six days later. This field includes the special_days subfield of
        /// all hours, set for dates that have exceptional hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentOpeningHours")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHours CurrentOpeningHours { get; set; }

        /// <summary>
        /// Contains an array of entries for the next seven days including information about secondary hours of a
        /// business. Secondary hours are different from a business's main hours. For example, a restaurant can specify
        /// drive through hours or delivery hours as its secondary hours. This field populates the type subfield, which
        /// draws from a predefined list of opening hours types (such as DRIVE_THROUGH, PICKUP, or TAKEOUT) based on the
        /// types of the place. This field includes the special_days subfield of all hours, set for dates that have
        /// exceptional hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSecondaryOpeningHours")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHours> CurrentSecondaryOpeningHours { get; set; }

        /// <summary>Specifies if the business supports delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delivery")]
        public virtual System.Nullable<bool> Delivery { get; set; }

        /// <summary>Specifies if the business supports indoor or outdoor seating options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dineIn")]
        public virtual System.Nullable<bool> DineIn { get; set; }

        /// <summary>
        /// The localized name of the place, suitable as a short human-readable description. For example, "Google
        /// Sydney", "Starbucks", "Pyrmont", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual GoogleTypeLocalizedText DisplayName { get; set; }

        /// <summary>
        /// Contains a summary of the place. A summary is comprised of a textual overview, and also includes the
        /// language code for these if applicable. Summary text must be presented as-is and can not be modified or
        /// altered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editorialSummary")]
        public virtual GoogleTypeLocalizedText EditorialSummary { get; set; }

        /// <summary>Information of ev charging options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evChargeOptions")]
        public virtual GoogleMapsPlacesV1EVChargeOptions EvChargeOptions { get; set; }

        /// <summary>A full, human-readable address for this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedAddress")]
        public virtual string FormattedAddress { get; set; }

        /// <summary>
        /// The most recent information about fuel options in a gas station. This information is updated regularly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fuelOptions")]
        public virtual GoogleMapsPlacesV1FuelOptions FuelOptions { get; set; }

        /// <summary>Place is good for children.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goodForChildren")]
        public virtual System.Nullable<bool> GoodForChildren { get; set; }

        /// <summary>Place accommodates groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goodForGroups")]
        public virtual System.Nullable<bool> GoodForGroups { get; set; }

        /// <summary>Place is suitable for watching sports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goodForWatchingSports")]
        public virtual System.Nullable<bool> GoodForWatchingSports { get; set; }

        /// <summary>A URL providing more information about this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleMapsUri")]
        public virtual string GoogleMapsUri { get; set; }

        /// <summary>Background color for icon_mask in hex format, e.g. #909CE1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconBackgroundColor")]
        public virtual string IconBackgroundColor { get; set; }

        /// <summary>
        /// A truncated URL to an icon mask. User can access different icon type by appending type suffix to the end
        /// (eg, ".svg" or ".png").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconMaskBaseUri")]
        public virtual string IconMaskBaseUri { get; set; }

        /// <summary>The unique identifier of a place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A human-readable phone number for the place, in international format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internationalPhoneNumber")]
        public virtual string InternationalPhoneNumber { get; set; }

        /// <summary>Place provides live music.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveMusic")]
        public virtual System.Nullable<bool> LiveMusic { get; set; }

        /// <summary>The position of this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GoogleTypeLatLng Location { get; set; }

        /// <summary>Place has a children's menu.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("menuForChildren")]
        public virtual System.Nullable<bool> MenuForChildren { get; set; }

        /// <summary>
        /// This Place's resource name, in `places/{place_id}` format. Can be used to look up the Place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A human-readable phone number for the place, in national format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nationalPhoneNumber")]
        public virtual string NationalPhoneNumber { get; set; }

        /// <summary>Place provides outdoor seating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdoorSeating")]
        public virtual System.Nullable<bool> OutdoorSeating { get; set; }

        /// <summary>Options of parking provided by the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parkingOptions")]
        public virtual GoogleMapsPlacesV1PlaceParkingOptions ParkingOptions { get; set; }

        /// <summary>
        /// Payment options the place accepts. If a payment option data is not available, the payment option field will
        /// be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentOptions")]
        public virtual GoogleMapsPlacesV1PlacePaymentOptions PaymentOptions { get; set; }

        /// <summary>Information (including references) about photos of this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photos")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1Photo> Photos { get; set; }

        /// <summary>Plus code of the place location lat/long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plusCode")]
        public virtual GoogleMapsPlacesV1PlacePlusCode PlusCode { get; set; }

        /// <summary>Price level of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceLevel")]
        public virtual string PriceLevel { get; set; }

        /// <summary>
        /// The primary type of the given result. This type must one of the Places API supported types. For example,
        /// "restaurant", "cafe", "airport", etc. A place can only have a single primary type. For the complete list of
        /// possible values, see Table A and Table B at
        /// https://developers.google.com/maps/documentation/places/web-service/place-types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryType")]
        public virtual string PrimaryType { get; set; }

        /// <summary>
        /// The display name of the primary type, localized to the request language if applicable. For the complete list
        /// of possible values, see Table A and Table B at
        /// https://developers.google.com/maps/documentation/places/web-service/place-types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTypeDisplayName")]
        public virtual GoogleTypeLocalizedText PrimaryTypeDisplayName { get; set; }

        /// <summary>A rating between 1.0 and 5.0, based on user reviews of this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual System.Nullable<double> Rating { get; set; }

        /// <summary>The regular hours of operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regularOpeningHours")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHours RegularOpeningHours { get; set; }

        /// <summary>
        /// Contains an array of entries for information about regular secondary hours of a business. Secondary hours
        /// are different from a business's main hours. For example, a restaurant can specify drive through hours or
        /// delivery hours as its secondary hours. This field populates the type subfield, which draws from a predefined
        /// list of opening hours types (such as DRIVE_THROUGH, PICKUP, or TAKEOUT) based on the types of the place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regularSecondaryOpeningHours")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHours> RegularSecondaryOpeningHours { get; set; }

        /// <summary>Specifies if the place supports reservations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservable")]
        public virtual System.Nullable<bool> Reservable { get; set; }

        /// <summary>Place has restroom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restroom")]
        public virtual System.Nullable<bool> Restroom { get; set; }

        /// <summary>List of reviews about this place, sorted by relevance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviews")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1Review> Reviews { get; set; }

        /// <summary>Specifies if the place serves beer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesBeer")]
        public virtual System.Nullable<bool> ServesBeer { get; set; }

        /// <summary>Specifies if the place serves breakfast.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesBreakfast")]
        public virtual System.Nullable<bool> ServesBreakfast { get; set; }

        /// <summary>Specifies if the place serves brunch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesBrunch")]
        public virtual System.Nullable<bool> ServesBrunch { get; set; }

        /// <summary>Place serves cocktails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesCocktails")]
        public virtual System.Nullable<bool> ServesCocktails { get; set; }

        /// <summary>Place serves coffee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesCoffee")]
        public virtual System.Nullable<bool> ServesCoffee { get; set; }

        /// <summary>Place serves dessert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesDessert")]
        public virtual System.Nullable<bool> ServesDessert { get; set; }

        /// <summary>Specifies if the place serves dinner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesDinner")]
        public virtual System.Nullable<bool> ServesDinner { get; set; }

        /// <summary>Specifies if the place serves lunch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesLunch")]
        public virtual System.Nullable<bool> ServesLunch { get; set; }

        /// <summary>Specifies if the place serves vegetarian food.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesVegetarianFood")]
        public virtual System.Nullable<bool> ServesVegetarianFood { get; set; }

        /// <summary>Specifies if the place serves wine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesWine")]
        public virtual System.Nullable<bool> ServesWine { get; set; }

        /// <summary>A short, human-readable address for this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortFormattedAddress")]
        public virtual string ShortFormattedAddress { get; set; }

        /// <summary>A list of sub destinations related to the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subDestinations")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceSubDestination> SubDestinations { get; set; }

        /// <summary>Specifies if the business supports takeout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("takeout")]
        public virtual System.Nullable<bool> Takeout { get; set; }

        /// <summary>
        /// A set of type tags for this result. For example, "political" and "locality". For the complete list of
        /// possible values, see Table A and Table B at
        /// https://developers.google.com/maps/documentation/places/web-service/place-types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>The total number of reviews (with or without text) for this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRatingCount")]
        public virtual System.Nullable<int> UserRatingCount { get; set; }

        /// <summary>
        /// Number of minutes this place's timezone is currently offset from UTC. This is expressed in minutes to
        /// support timezones that are offset by fractions of an hour, e.g. X hours and 15 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffsetMinutes")]
        public virtual System.Nullable<int> UtcOffsetMinutes { get; set; }

        /// <summary>A viewport suitable for displaying the place on an average-sized map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewport")]
        public virtual GoogleGeoTypeViewport Viewport { get; set; }

        /// <summary>
        /// The authoritative website for this place, e.g. a business' homepage. Note that for places that are part of a
        /// chain (e.g. an IKEA store), this will usually be the website for the individual store, not the overall
        /// chain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUri")]
        public virtual string WebsiteUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the accessibility options a place offers.</summary>
    public class GoogleMapsPlacesV1PlaceAccessibilityOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Places has wheelchair accessible entrance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wheelchairAccessibleEntrance")]
        public virtual System.Nullable<bool> WheelchairAccessibleEntrance { get; set; }

        /// <summary>Place offers wheelchair accessible parking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wheelchairAccessibleParking")]
        public virtual System.Nullable<bool> WheelchairAccessibleParking { get; set; }

        /// <summary>Place has wheelchair accessible restroom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wheelchairAccessibleRestroom")]
        public virtual System.Nullable<bool> WheelchairAccessibleRestroom { get; set; }

        /// <summary>Place has wheelchair accessible seating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wheelchairAccessibleSeating")]
        public virtual System.Nullable<bool> WheelchairAccessibleSeating { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The structured components that form the formatted address, if this information is available.</summary>
    public class GoogleMapsPlacesV1PlaceAddressComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The language used to format this components, in CLDR notation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The full text description or name of the address component. For example, an address component for the
        /// country Australia may have a long_name of "Australia".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longText")]
        public virtual string LongText { get; set; }

        /// <summary>
        /// An abbreviated textual name for the address component, if available. For example, an address component for
        /// the country of Australia may have a short_name of "AU".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortText")]
        public virtual string ShortText { get; set; }

        /// <summary>An array indicating the type(s) of the address component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about data providers of this place.</summary>
    public class GoogleMapsPlacesV1PlaceAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the Place's data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>URI to the Place's data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerUri")]
        public virtual string ProviderUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about business hour of the place.</summary>
    public class GoogleMapsPlacesV1PlaceOpeningHours : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Is this place open right now? Always present unless we lack time-of-day or timezone data for these opening
        /// hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openNow")]
        public virtual System.Nullable<bool> OpenNow { get; set; }

        /// <summary>
        /// The periods that this place is open during the week. The periods are in chronological order, starting with
        /// Sunday in the place-local timezone. An empty (but not absent) value indicates a place that is never open,
        /// e.g. because it is closed temporarily for renovations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periods")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHoursPeriod> Periods { get; set; }

        /// <summary>A type string used to identify the type of secondary hours.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryHoursType")]
        public virtual string SecondaryHoursType { get; set; }

        /// <summary>
        /// Structured information for special days that fall within the period that the returned opening hours cover.
        /// Special days are days that could impact the business hours of a place, e.g. Christmas day. Set for
        /// current_opening_hours and current_secondary_opening_hours if there are exceptional hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specialDays")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHoursSpecialDay> SpecialDays { get; set; }

        /// <summary>
        /// Localized strings describing the opening hours of this place, one string for each day of the week. Will be
        /// empty if the hours are unknown or could not be converted to localized text. Example: "Sun: 18:00–06:00"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekdayDescriptions")]
        public virtual System.Collections.Generic.IList<string> WeekdayDescriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A period the place remains in open_now status.</summary>
    public class GoogleMapsPlacesV1PlaceOpeningHoursPeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time that the place starts to be closed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("close")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHoursPeriodPoint Close { get; set; }

        /// <summary>The time that the place starts to be open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("open")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHoursPeriodPoint Open { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status changing points.</summary>
    public class GoogleMapsPlacesV1PlaceOpeningHoursPeriodPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date in the local timezone for the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual GoogleTypeDate Date { get; set; }

        /// <summary>A day of the week, as an integer in the range 0-6. 0 is Sunday, 1 is Monday, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>The hour in 2 digits. Ranges from 00 to 23.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>The minute in 2 digits. Ranges from 00 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<int> Minute { get; set; }

        /// <summary>
        /// Whether or not this endpoint was truncated. Truncation occurs when the real hours are outside the times we
        /// are willing to return hours between, so we truncate the hours back to these boundaries. This ensures that at
        /// most 24 * 7 hours from midnight of the day of the request are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truncated")]
        public virtual System.Nullable<bool> Truncated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Structured information for special days that fall within the period that the returned opening hours cover.
    /// Special days are days that could impact the business hours of a place, e.g. Christmas day.
    /// </summary>
    public class GoogleMapsPlacesV1PlaceOpeningHoursSpecialDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date of this special day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual GoogleTypeDate Date { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about parking options for the place. A parking lot could support more than one option at the same
    /// time.
    /// </summary>
    public class GoogleMapsPlacesV1PlaceParkingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Place offers free garage parking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeGarageParking")]
        public virtual System.Nullable<bool> FreeGarageParking { get; set; }

        /// <summary>Place offers free parking lots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeParkingLot")]
        public virtual System.Nullable<bool> FreeParkingLot { get; set; }

        /// <summary>Place offers free street parking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeStreetParking")]
        public virtual System.Nullable<bool> FreeStreetParking { get; set; }

        /// <summary>Place offers paid garage parking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paidGarageParking")]
        public virtual System.Nullable<bool> PaidGarageParking { get; set; }

        /// <summary>Place offers paid parking lots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paidParkingLot")]
        public virtual System.Nullable<bool> PaidParkingLot { get; set; }

        /// <summary>Place offers paid street parking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paidStreetParking")]
        public virtual System.Nullable<bool> PaidStreetParking { get; set; }

        /// <summary>Place offers valet parking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valetParking")]
        public virtual System.Nullable<bool> ValetParking { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payment options the place accepts.</summary>
    public class GoogleMapsPlacesV1PlacePaymentOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Place accepts cash only as payment. Places with this attribute may still accept other payment methods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptsCashOnly")]
        public virtual System.Nullable<bool> AcceptsCashOnly { get; set; }

        /// <summary>Place accepts credit cards as payment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptsCreditCards")]
        public virtual System.Nullable<bool> AcceptsCreditCards { get; set; }

        /// <summary>Place accepts debit cards as payment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptsDebitCards")]
        public virtual System.Nullable<bool> AcceptsDebitCards { get; set; }

        /// <summary>Place accepts NFC payments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptsNfc")]
        public virtual System.Nullable<bool> AcceptsNfc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Plus code (http://plus.codes) is a location reference with two formats: global code defining a 14mx14m (1/8000th
    /// of a degree) or smaller rectangle, and compound code, replacing the prefix with a reference location.
    /// </summary>
    public class GoogleMapsPlacesV1PlacePlusCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Place's compound code, such as "33GV+HQ, Ramberg, Norway", containing the suffix of the global code and
        /// replacing the prefix with a formatted name of a reference entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compoundCode")]
        public virtual string CompoundCode { get; set; }

        /// <summary>
        /// Place's global (full) code, such as "9FWM33GV+HQ", representing an 1/8000 by 1/8000 degree area (~14 by 14
        /// meters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalCode")]
        public virtual string GlobalCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Place resource name and id of sub destinations that relate to the place. For example, different terminals are
    /// different destinations of an airport.
    /// </summary>
    public class GoogleMapsPlacesV1PlaceSubDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The place id of the sub destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The resource name of the sub destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a review of a place.</summary>
    public class GoogleMapsPlacesV1Review : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This review's author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorAttribution")]
        public virtual GoogleMapsPlacesV1AuthorAttribution AuthorAttribution { get; set; }

        /// <summary>
        /// A reference representing this place review which may be used to look up this place review again (also called
        /// the API "resource" name: `places/{place_id}/reviews/{review}`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The review text in its original language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalText")]
        public virtual GoogleTypeLocalizedText OriginalText { get; set; }

        private string _publishTimeRaw;

        private object _publishTime;

        /// <summary>Timestamp for the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual string PublishTimeRaw
        {
            get => _publishTimeRaw;
            set
            {
                _publishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishTimeDateTimeOffset instead.")]
        public virtual object PublishTime
        {
            get => _publishTime;
            set
            {
                _publishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishTimeRaw);
            set => PublishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A number between 1.0 and 5.0, also called the number of stars.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual System.Nullable<double> Rating { get; set; }

        /// <summary>
        /// A string of formatted recent time, expressing the review time relative to the current time in a form
        /// appropriate for the language and country.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativePublishTimeDescription")]
        public virtual string RelativePublishTimeDescription { get; set; }

        /// <summary>The localized text of the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleTypeLocalizedText Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request proto for Search Nearby. </summary>
    public class GoogleMapsPlacesV1SearchNearbyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Excluded primary Place type (e.g. "restaurant" or "gas_station") from
        /// https://developers.google.com/maps/documentation/places/web-service/place-types. Up to 50 types from [Table
        /// A](https://developers.google.com/maps/documentation/places/web-service/place-types#table-a) may be
        /// specified. If there are any conflicting primary types, i.e. a type appears in both included_primary_types
        /// and excluded_primary_types, an INVALID_ARGUMENT error is returned. If a Place type is specified with
        /// multiple type restrictions, only places that satisfy all of the restrictions are returned. For example, if
        /// we have {included_types = ["restaurant"], excluded_primary_types = ["restaurant"]}, the returned places
        /// provide "restaurant" related services but do not operate primarily as "restaurants".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPrimaryTypes")]
        public virtual System.Collections.Generic.IList<string> ExcludedPrimaryTypes { get; set; }

        /// <summary>
        /// Excluded Place type (eg, "restaurant" or "gas_station") from
        /// https://developers.google.com/maps/documentation/places/web-service/place-types. Up to 50 types from [Table
        /// A](https://developers.google.com/maps/documentation/places/web-service/place-types#table-a) may be
        /// specified. If the client provides both included_types (e.g. restaurant) and excluded_types (e.g. cafe), then
        /// the response should include places that are restaurant but not cafe. The response includes places that match
        /// at least one of the included_types and none of the excluded_types. If there are any conflicting types, i.e.
        /// a type appears in both included_types and excluded_types, an INVALID_ARGUMENT error is returned. If a Place
        /// type is specified with multiple type restrictions, only places that satisfy all of the restrictions are
        /// returned. For example, if we have {included_types = ["restaurant"], excluded_primary_types =
        /// ["restaurant"]}, the returned places provide "restaurant" related services but do not operate primarily as
        /// "restaurants".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedTypes")]
        public virtual System.Collections.Generic.IList<string> ExcludedTypes { get; set; }

        /// <summary>
        /// Included primary Place type (e.g. "restaurant" or "gas_station") from
        /// https://developers.google.com/maps/documentation/places/web-service/place-types. A place can only have a
        /// single primary type from the supported types table associated with it. Up to 50 types from [Table
        /// A](https://developers.google.com/maps/documentation/places/web-service/place-types#table-a) may be
        /// specified. If there are any conflicting primary types, i.e. a type appears in both included_primary_types
        /// and excluded_primary_types, an INVALID_ARGUMENT error is returned. If a Place type is specified with
        /// multiple type restrictions, only places that satisfy all of the restrictions are returned. For example, if
        /// we have {included_types = ["restaurant"], excluded_primary_types = ["restaurant"]}, the returned places
        /// provide "restaurant" related services but do not operate primarily as "restaurants".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedPrimaryTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedPrimaryTypes { get; set; }

        /// <summary>
        /// Included Place type (eg, "restaurant" or "gas_station") from
        /// https://developers.google.com/maps/documentation/places/web-service/place-types. Up to 50 types from [Table
        /// A](https://developers.google.com/maps/documentation/places/web-service/place-types#table-a) may be
        /// specified. If there are any conflicting types, i.e. a type appears in both included_types and
        /// excluded_types, an INVALID_ARGUMENT error is returned. If a Place type is specified with multiple type
        /// restrictions, only places that satisfy all of the restrictions are returned. For example, if we have
        /// {included_types = ["restaurant"], excluded_primary_types = ["restaurant"]}, the returned places provide
        /// "restaurant" related services but do not operate primarily as "restaurants".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedTypes { get; set; }

        /// <summary>
        /// Place details will be displayed with the preferred language if available. If the language code is
        /// unspecified or unrecognized, place details of any language may be returned, with a preference for English if
        /// such details exist. Current list of supported languages:
        /// https://developers.google.com/maps/faq#languagesupport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Required. The region to search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationRestriction")]
        public virtual GoogleMapsPlacesV1SearchNearbyRequestLocationRestriction LocationRestriction { get; set; }

        /// <summary>
        /// Maximum number of results to return. It must be between 1 and 20 (default), inclusively. If the number is
        /// unset, it falls back to the upper limit. If the number is set to negative or exceeds the upper limit, an
        /// INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxResultCount")]
        public virtual System.Nullable<int> MaxResultCount { get; set; }

        /// <summary>How results will be ranked in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankPreference")]
        public virtual string RankPreference { get; set; }

        /// <summary>
        /// The Unicode country/region code (CLDR) of the location where the request is coming from. This parameter is
        /// used to display the place details, like region-specific place name, if available. The parameter can affect
        /// results based on applicable law. For more information, see
        /// https://www.unicode.org/cldr/charts/latest/supplemental/territory_language_information.html. Note that
        /// 3-digit region codes are not currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The region to search.</summary>
    public class GoogleMapsPlacesV1SearchNearbyRequestLocationRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A circle defined by center point and radius.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("circle")]
        public virtual GoogleMapsPlacesV1Circle Circle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response proto for Search Nearby. </summary>
    public class GoogleMapsPlacesV1SearchNearbyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of places that meets user's requirements like places types, number of places and specific location
        /// restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("places")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1Place> Places { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request proto for SearchText. </summary>
    public class GoogleMapsPlacesV1SearchTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The requested place type. Full list of types supported:
        /// https://developers.google.com/maps/documentation/places/web-service/place-types. Only support one included
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedType")]
        public virtual string IncludedType { get; set; }

        /// <summary>
        /// Place details will be displayed with the preferred language if available. If the language code is
        /// unspecified or unrecognized, place details of any language may be returned, with a preference for English if
        /// such details exist. Current list of supported languages:
        /// https://developers.google.com/maps/faq#languagesupport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The region to search. This location serves as a bias which means results around given location might be
        /// returned. Cannot be set along with location_restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationBias")]
        public virtual GoogleMapsPlacesV1SearchTextRequestLocationBias LocationBias { get; set; }

        /// <summary>
        /// The region to search. This location serves as a restriction which means results outside given location will
        /// not be returned. Cannot be set along with location_bias.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationRestriction")]
        public virtual GoogleMapsPlacesV1SearchTextRequestLocationRestriction LocationRestriction { get; set; }

        /// <summary>
        /// Maximum number of results to return. It must be between 1 and 20, inclusively. The default is 20. If the
        /// number is unset, it falls back to the upper limit. If the number is set to negative or exceeds the upper
        /// limit, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxResultCount")]
        public virtual System.Nullable<int> MaxResultCount { get; set; }

        /// <summary>
        /// Filter out results whose average user rating is strictly less than this limit. A valid value must be a float
        /// between 0 and 5 (inclusively) at a 0.5 cadence i.e. [0, 0.5, 1.0, ... , 5.0] inclusively. The input rating
        /// will round up to the nearest 0.5(ceiling). For instance, a rating of 0.6 will eliminate all results with a
        /// less than 1.0 rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRating")]
        public virtual System.Nullable<double> MinRating { get; set; }

        /// <summary>Used to restrict the search to places that are currently open. The default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openNow")]
        public virtual System.Nullable<bool> OpenNow { get; set; }

        /// <summary>
        /// Used to restrict the search to places that are marked as certain price levels. Users can choose any
        /// combinations of price levels. Default to select all price levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceLevels")]
        public virtual System.Collections.Generic.IList<string> PriceLevels { get; set; }

        /// <summary>How results will be ranked in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankPreference")]
        public virtual string RankPreference { get; set; }

        /// <summary>
        /// The Unicode country/region code (CLDR) of the location where the request is coming from. This parameter is
        /// used to display the place details, like region-specific place name, if available. The parameter can affect
        /// results based on applicable law. For more information, see
        /// https://www.unicode.org/cldr/charts/latest/supplemental/territory_language_information.html. Note that
        /// 3-digit region codes are not currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Used to set strict type filtering for included_type. If set to true, only results of the same type will be
        /// returned. Default to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strictTypeFiltering")]
        public virtual System.Nullable<bool> StrictTypeFiltering { get; set; }

        /// <summary>Required. The text query for textual search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textQuery")]
        public virtual string TextQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The region to search. This location serves as a bias which means results around given location might be
    /// returned.
    /// </summary>
    public class GoogleMapsPlacesV1SearchTextRequestLocationBias : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A circle defined by center point and radius.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("circle")]
        public virtual GoogleMapsPlacesV1Circle Circle { get; set; }

        /// <summary>
        /// A rectangle box defined by northeast and southwest corner. `rectangle.high()` must be the northeast point of
        /// the rectangle viewport. `rectangle.low()` must be the southwest point of the rectangle viewport.
        /// `rectangle.low().latitude()` cannot be greater than `rectangle.high().latitude()`. This will result in an
        /// empty latitude range. A rectangle viewport cannot be wider than 180 degrees.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rectangle")]
        public virtual GoogleGeoTypeViewport Rectangle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The region to search. This location serves as a restriction which means results outside given location will not
    /// be returned.
    /// </summary>
    public class GoogleMapsPlacesV1SearchTextRequestLocationRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A rectangle box defined by northeast and southwest corner. `rectangle.high()` must be the northeast point of
        /// the rectangle viewport. `rectangle.low()` must be the southwest point of the rectangle viewport.
        /// `rectangle.low().latitude()` cannot be greater than `rectangle.high().latitude()`. This will result in an
        /// empty latitude range. A rectangle viewport cannot be wider than 180 degrees.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rectangle")]
        public virtual GoogleGeoTypeViewport Rectangle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response proto for SearchText. </summary>
    public class GoogleMapsPlacesV1SearchTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of places that meet the user's text search criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("places")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1Place> Places { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class GoogleTypeLatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Localized variant of a text in a particular language.</summary>
    public class GoogleTypeLocalizedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text's BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Localized string in the language corresponding to language_code below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class GoogleTypeMoney : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
