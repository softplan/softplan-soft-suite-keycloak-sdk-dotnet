
#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UPConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.UPAttribute>? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.UPGroup>? Groups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unmanagedAttributePolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Keycloak.Sdk.JsonConverters.UnmanagedAttributePolicyJsonConverter))]
        public global::Softplan.Soft.Suite.Keycloak.Sdk.UnmanagedAttributePolicy? UnmanagedAttributePolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UPConfig" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="groups"></param>
        /// <param name="unmanagedAttributePolicy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UPConfig(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.UPAttribute>? attributes,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.UPGroup>? groups,
            global::Softplan.Soft.Suite.Keycloak.Sdk.UnmanagedAttributePolicy? unmanagedAttributePolicy)
        {
            this.Attributes = attributes;
            this.Groups = groups;
            this.UnmanagedAttributePolicy = unmanagedAttributePolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UPConfig" /> class.
        /// </summary>
        public UPConfig()
        {
        }

    }
}