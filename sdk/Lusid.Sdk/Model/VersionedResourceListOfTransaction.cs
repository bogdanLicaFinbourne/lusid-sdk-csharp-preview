/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1386
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// VersionedResourceListOfTransaction
    /// </summary>
    [DataContract]
    public partial class VersionedResourceListOfTransaction :  IEquatable<VersionedResourceListOfTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionedResourceListOfTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VersionedResourceListOfTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionedResourceListOfTransaction" /> class.
        /// </summary>
        /// <param name="version">version (required).</param>
        /// <param name="values">values (required).</param>
        /// <param name="href">href.</param>
        /// <param name="links">links.</param>
        public VersionedResourceListOfTransaction(Version version = default(Version), List<Transaction> values = default(List<Transaction>), string href = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for VersionedResourceListOfTransaction and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for VersionedResourceListOfTransaction and cannot be null");
            }
            else
            {
                this.Values = values;
            }
            
            this.Href = href;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<Transaction> Values { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionedResourceListOfTransaction {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionedResourceListOfTransaction);
        }

        /// <summary>
        /// Returns true if VersionedResourceListOfTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionedResourceListOfTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionedResourceListOfTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
