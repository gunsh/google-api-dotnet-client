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

namespace Google.Apis.CloudNaturalLanguage.v1
{
    /// <summary>The CloudNaturalLanguage Service.</summary>
    public class CloudNaturalLanguageService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudNaturalLanguageService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudNaturalLanguageService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Documents = new DocumentsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "language";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://language.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://language.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Natural Language API.</summary>
        public class Scope
        {
            /// <summary>Apply machine learning models to reveal the structure and meaning of text</summary>
            public static string CloudLanguage = "https://www.googleapis.com/auth/cloud-language";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Natural Language API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Apply machine learning models to reveal the structure and meaning of text</summary>
            public const string CloudLanguage = "https://www.googleapis.com/auth/cloud-language";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Documents resource.</summary>
        public virtual DocumentsResource Documents { get; }
    }

    /// <summary>A base abstract class for CloudNaturalLanguage requests.</summary>
    public abstract class CloudNaturalLanguageBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudNaturalLanguageBaseServiceRequest instance.</summary>
        protected CloudNaturalLanguageBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudNaturalLanguage parameter list.</summary>
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

    /// <summary>The "documents" collection of methods.</summary>
    public class DocumentsResource
    {
        private const string Resource = "documents";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DocumentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text along with entity types,
        /// salience, mentions for each entity, and other properties.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeEntitiesRequest AnalyzeEntities(Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitiesRequest body)
        {
            return new AnalyzeEntitiesRequest(this.service, body);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text along with entity types,
        /// salience, mentions for each entity, and other properties.
        /// </summary>
        public class AnalyzeEntitiesRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitiesResponse>
        {
            /// <summary>Constructs a new AnalyzeEntities request.</summary>
            public AnalyzeEntitiesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitiesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitiesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeEntities";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents:analyzeEntities";

            /// <summary>Initializes AnalyzeEntities parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Finds entities, similar to AnalyzeEntities in the text and analyzes sentiment associated with each entity
        /// and its mentions.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeEntitySentimentRequest AnalyzeEntitySentiment(Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitySentimentRequest body)
        {
            return new AnalyzeEntitySentimentRequest(this.service, body);
        }

        /// <summary>
        /// Finds entities, similar to AnalyzeEntities in the text and analyzes sentiment associated with each entity
        /// and its mentions.
        /// </summary>
        public class AnalyzeEntitySentimentRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitySentimentResponse>
        {
            /// <summary>Constructs a new AnalyzeEntitySentiment request.</summary>
            public AnalyzeEntitySentimentRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitySentimentRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeEntitySentimentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeEntitySentiment";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents:analyzeEntitySentiment";

            /// <summary>Initializes AnalyzeEntitySentiment parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Analyzes the sentiment of the provided text.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeSentimentRequest AnalyzeSentiment(Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSentimentRequest body)
        {
            return new AnalyzeSentimentRequest(this.service, body);
        }

        /// <summary>Analyzes the sentiment of the provided text.</summary>
        public class AnalyzeSentimentRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSentimentResponse>
        {
            /// <summary>Constructs a new AnalyzeSentiment request.</summary>
            public AnalyzeSentimentRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSentimentRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSentimentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeSentiment";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents:analyzeSentiment";

            /// <summary>Initializes AnalyzeSentiment parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and tokenization along with part of speech
        /// tags, dependency trees, and other properties.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeSyntaxRequest AnalyzeSyntax(Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSyntaxRequest body)
        {
            return new AnalyzeSyntaxRequest(this.service, body);
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and tokenization along with part of speech
        /// tags, dependency trees, and other properties.
        /// </summary>
        public class AnalyzeSyntaxRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSyntaxResponse>
        {
            /// <summary>Constructs a new AnalyzeSyntax request.</summary>
            public AnalyzeSyntaxRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSyntaxRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v1.Data.AnalyzeSyntaxRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeSyntax";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents:analyzeSyntax";

            /// <summary>Initializes AnalyzeSyntax parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment, analyzeEntities, and
        /// analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnnotateTextRequest AnnotateText(Google.Apis.CloudNaturalLanguage.v1.Data.AnnotateTextRequest body)
        {
            return new AnnotateTextRequest(this.service, body);
        }

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment, analyzeEntities, and
        /// analyzeSyntax provide in one call.
        /// </summary>
        public class AnnotateTextRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v1.Data.AnnotateTextResponse>
        {
            /// <summary>Constructs a new AnnotateText request.</summary>
            public AnnotateTextRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v1.Data.AnnotateTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v1.Data.AnnotateTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "annotateText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents:annotateText";

            /// <summary>Initializes AnnotateText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Classifies a document into categories.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ClassifyTextRequest ClassifyText(Google.Apis.CloudNaturalLanguage.v1.Data.ClassifyTextRequest body)
        {
            return new ClassifyTextRequest(this.service, body);
        }

        /// <summary>Classifies a document into categories.</summary>
        public class ClassifyTextRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v1.Data.ClassifyTextResponse>
        {
            /// <summary>Constructs a new ClassifyText request.</summary>
            public ClassifyTextRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v1.Data.ClassifyTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v1.Data.ClassifyTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "classifyText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents:classifyText";

            /// <summary>Initializes ClassifyText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Moderates a document for harmful and sensitive categories.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ModerateTextRequest ModerateText(Google.Apis.CloudNaturalLanguage.v1.Data.ModerateTextRequest body)
        {
            return new ModerateTextRequest(this.service, body);
        }

        /// <summary>Moderates a document for harmful and sensitive categories.</summary>
        public class ModerateTextRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v1.Data.ModerateTextResponse>
        {
            /// <summary>Constructs a new ModerateText request.</summary>
            public ModerateTextRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v1.Data.ModerateTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v1.Data.ModerateTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "moderateText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents:moderateText";

            /// <summary>Initializes ModerateText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.CloudNaturalLanguage.v1.Data
{
    /// <summary>The entity analysis request message.</summary>
    public class AnalyzeEntitiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The entity analysis response message.</summary>
    public class AnalyzeEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recognized entities in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<Entity> Entities { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The entity-level sentiment analysis request message.</summary>
    public class AnalyzeEntitySentimentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The entity-level sentiment analysis response message.</summary>
    public class AnalyzeEntitySentimentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recognized entities in the input document with associated sentiments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<Entity> Entities { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The sentiment analysis request message.</summary>
    public class AnalyzeSentimentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate sentence offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The sentiment analysis response message.</summary>
    public class AnalyzeSentimentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The overall sentiment of the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSentiment")]
        public virtual Sentiment DocumentSentiment { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The sentiment for all the sentences in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentences")]
        public virtual System.Collections.Generic.IList<Sentence> Sentences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The syntax analysis request message.</summary>
    public class AnalyzeSyntaxRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The syntax analysis response message.</summary>
    public class AnalyzeSyntaxResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>Sentences in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentences")]
        public virtual System.Collections.Generic.IList<Sentence> Sentences { get; set; }

        /// <summary>Tokens, along with their syntactic information, in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokens")]
        public virtual System.Collections.Generic.IList<Token> Tokens { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request message for the text annotation API, which can perform multiple analysis types (sentiment, entities,
    /// and syntax) in one call.
    /// </summary>
    public class AnnotateTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>Required. The enabled features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual Features Features { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The text annotations response message.</summary>
    public class AnnotateTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Categories identified in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> Categories { get; set; }

        /// <summary>
        /// The overall sentiment for the document. Populated if the user enables
        /// AnnotateTextRequest.Features.extract_document_sentiment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSentiment")]
        public virtual Sentiment DocumentSentiment { get; set; }

        /// <summary>
        /// Entities, along with their semantic information, in the input document. Populated if the user enables
        /// AnnotateTextRequest.Features.extract_entities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<Entity> Entities { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>Harmful and sensitive categories identified in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderationCategories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> ModerationCategories { get; set; }

        /// <summary>
        /// Sentences in the input document. Populated if the user enables AnnotateTextRequest.Features.extract_syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentences")]
        public virtual System.Collections.Generic.IList<Sentence> Sentences { get; set; }

        /// <summary>
        /// Tokens, along with their syntactic information, in the input document. Populated if the user enables
        /// AnnotateTextRequest.Features.extract_syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokens")]
        public virtual System.Collections.Generic.IList<Token> Tokens { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a category returned from the text classifier.</summary>
    public class ClassificationCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The classifier's confidence of the category. Number represents how certain the classifier is that this
        /// category represents the given text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The name of the category representing the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model options available for classification requests.</summary>
    public class ClassificationModelOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Setting this field will use the V1 model and V1 content categories version. The V1 model is a legacy model;
        /// support for this will be discontinued in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v1Model")]
        public virtual V1Model V1Model { get; set; }

        /// <summary>
        /// Setting this field will use the V2 model with the appropriate content categories version. The V2 model is a
        /// better performing model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v2Model")]
        public virtual V2Model V2Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document classification request message.</summary>
    public class ClassifyTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Model options to use for classification. Defaults to v1 options if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classificationModelOptions")]
        public virtual ClassificationModelOptions ClassificationModelOptions { get; set; }

        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document classification response message.</summary>
    public class ClassifyTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Categories representing the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> Categories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents dependency parse tree information for a token. (For more information on dependency labels, see
    /// http://www.aclweb.org/anthology/P13-2017
    /// </summary>
    public class DependencyEdge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the head of this token in the dependency tree. This is the index of the token which has an arc
        /// going to this token. The index is the position of the token in the array of tokens returned by the API
        /// method. If this token is a root token, then the `head_token_index` is its own index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headTokenIndex")]
        public virtual System.Nullable<int> HeadTokenIndex { get; set; }

        /// <summary>The parse label for the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the input to API methods.</summary>
    public class Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content of the input in string format. Cloud audit logging exempt since it is based on user data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The Google Cloud Storage URI where the file content is located. This URI must be of the form:
        /// gs://bucket_name/object_name. For more details, see https://cloud.google.com/storage/docs/reference-uris.
        /// NOTE: Cloud Storage object versioning is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsContentUri")]
        public virtual string GcsContentUri { get; set; }

        /// <summary>
        /// The language of the document (if not specified, the language is automatically detected). Both ISO and BCP-47
        /// language codes are accepted. [Language Support](https://cloud.google.com/natural-language/docs/languages)
        /// lists currently supported languages for each API method. If the language (either specified by the caller or
        /// automatically detected) is not supported by the called API method, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>
        /// Required. If the type is not set or is `TYPE_UNSPECIFIED`, returns an `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a phrase in the text that is a known entity, such as a person, an organization, or location. The API
    /// associates information, such as salience and mentions, with entities.
    /// </summary>
    public class Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The mentions of this entity in the input document. The API currently supports proper noun mentions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentions")]
        public virtual System.Collections.Generic.IList<EntityMention> Mentions { get; set; }

        /// <summary>
        /// Metadata associated with the entity. For most entity types, the metadata is a Wikipedia URL
        /// (`wikipedia_url`) and Knowledge Graph MID (`mid`), if they are available. For the metadata associated with
        /// other entity types, see the Type table below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>The representative name for the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The salience score associated with the entity in the [0, 1.0] range. The salience score for an entity
        /// provides information about the importance or centrality of that entity to the entire document text. Scores
        /// closer to 0 are less salient, while scores closer to 1.0 are highly salient.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salience")]
        public virtual System.Nullable<float> Salience { get; set; }

        /// <summary>
        /// For calls to AnalyzeEntitySentiment or if AnnotateTextRequest.Features.extract_entity_sentiment is set to
        /// true, this field will contain the aggregate sentiment expressed for this entity in the provided document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual Sentiment Sentiment { get; set; }

        /// <summary>The entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a mention for an entity in the text. Currently, proper noun mentions are supported.
    /// </summary>
    public class EntityMention : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For calls to AnalyzeEntitySentiment or if AnnotateTextRequest.Features.extract_entity_sentiment is set to
        /// true, this field will contain the sentiment expressed for this mention of the entity in the provided
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual Sentiment Sentiment { get; set; }

        /// <summary>The mention text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextSpan Text { get; set; }

        /// <summary>The type of the entity mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// All available features for sentiment, syntax, and semantic analysis. Setting each one to true will enable that
    /// specific analysis for the input.
    /// </summary>
    public class Features : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The model options to use for classification. Defaults to v1 options if not specified. Only used if
        /// `classify_text` is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classificationModelOptions")]
        public virtual ClassificationModelOptions ClassificationModelOptions { get; set; }

        /// <summary>Classify the full document into categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classifyText")]
        public virtual System.Nullable<bool> ClassifyText { get; set; }

        /// <summary>Extract document-level sentiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractDocumentSentiment")]
        public virtual System.Nullable<bool> ExtractDocumentSentiment { get; set; }

        /// <summary>Extract entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractEntities")]
        public virtual System.Nullable<bool> ExtractEntities { get; set; }

        /// <summary>Extract entities and their associated sentiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractEntitySentiment")]
        public virtual System.Nullable<bool> ExtractEntitySentiment { get; set; }

        /// <summary>Extract syntax information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractSyntax")]
        public virtual System.Nullable<bool> ExtractSyntax { get; set; }

        /// <summary>Moderate the document for harmful and sensitive categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderateText")]
        public virtual System.Nullable<bool> ModerateText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document moderation request message.</summary>
    public class ModerateTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document moderation response message.</summary>
    public class ModerateTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Harmful and sensitive categories representing the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderationCategories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> ModerationCategories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents part of speech information for a token. Parts of speech are as defined in
    /// http://www.lrec-conf.org/proceedings/lrec2012/pdf/274_Paper.pdf
    /// </summary>
    public class PartOfSpeech : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The grammatical aspect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspect")]
        public virtual string Aspect { get; set; }

        /// <summary>The grammatical case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("case")]
        public virtual string Case__ { get; set; }

        /// <summary>The grammatical form.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual string Form { get; set; }

        /// <summary>The grammatical gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        /// <summary>The grammatical mood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mood")]
        public virtual string Mood { get; set; }

        /// <summary>The grammatical number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual string Number { get; set; }

        /// <summary>The grammatical person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual string Person { get; set; }

        /// <summary>The grammatical properness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proper")]
        public virtual string Proper { get; set; }

        /// <summary>The grammatical reciprocity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reciprocity")]
        public virtual string Reciprocity { get; set; }

        /// <summary>The part of speech tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The grammatical tense.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tense")]
        public virtual string Tense { get; set; }

        /// <summary>The grammatical voice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voice")]
        public virtual string Voice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a sentence in the input document.</summary>
    public class Sentence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For calls to AnalyzeSentiment or if AnnotateTextRequest.Features.extract_document_sentiment is set to true,
        /// this field will contain the sentiment for the sentence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual Sentiment Sentiment { get; set; }

        /// <summary>The sentence text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextSpan Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the feeling associated with the entire text or entities in the text.</summary>
    public class Sentiment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A non-negative number in the [0, +inf) range, which represents the absolute magnitude of sentiment
        /// regardless of score (positive or negative).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("magnitude")]
        public virtual System.Nullable<float> Magnitude { get; set; }

        /// <summary>Sentiment score between -1.0 (negative sentiment) and 1.0 (positive sentiment).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a text span in the input document.</summary>
    public class TextSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The API calculates the beginning offset of the content in the original document according to the
        /// EncodingType specified in the API request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beginOffset")]
        public virtual System.Nullable<int> BeginOffset { get; set; }

        /// <summary>The content of the text span, which is a substring of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the smallest syntactic building block of the text.</summary>
    public class Token : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dependency tree parse for this token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencyEdge")]
        public virtual DependencyEdge DependencyEdge { get; set; }

        /// <summary>[Lemma](https://en.wikipedia.org/wiki/Lemma_%28morphology%29) of the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lemma")]
        public virtual string Lemma { get; set; }

        /// <summary>Parts of speech tag for this token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partOfSpeech")]
        public virtual PartOfSpeech PartOfSpeech { get; set; }

        /// <summary>The token text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextSpan Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the V1 model.</summary>
    public class V1Model : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the V2 model.</summary>
    public class V2Model : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content categories used for classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentCategoriesVersion")]
        public virtual string ContentCategoriesVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
