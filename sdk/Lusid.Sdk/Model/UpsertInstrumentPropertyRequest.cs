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
    /// UpsertInstrumentPropertyRequest
    /// </summary>
    [DataContract]
    public partial class UpsertInstrumentPropertyRequest :  IEquatable<UpsertInstrumentPropertyRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertInstrumentPropertyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertyRequest" /> class.
        /// </summary>
        /// <param name="identifierType">The instrument identifier type. (required).</param>
        /// <param name="identifier">The unique instrument identifier of the instrument to update or insert properties on. (required).</param>
        /// <param name="properties">Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain..</param>
        public UpsertInstrumentPropertyRequest(string identifierType = default(string), string identifier = default(string), List<Property> properties = default(List<Property>))
        {
            // to ensure "identifierType" is required (not null)
            if (identifierType == null)
            {
                throw new InvalidDataException("identifierType is a required property for UpsertInstrumentPropertyRequest and cannot be null");
            }
            else
            {
                this.IdentifierType = identifierType;
            }
            
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for UpsertInstrumentPropertyRequest and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            this.Properties = properties;
        }
        
        /// <summary>
        /// The instrument identifier type.
        /// </summary>
        /// <value>The instrument identifier type.</value>
        [DataMember(Name="identifierType", EmitDefaultValue=false)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// The unique instrument identifier of the instrument to update or insert properties on.
        /// </summary>
        /// <value>The unique instrument identifier of the instrument to update or insert properties on.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain.
        /// </summary>
        /// <value>Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertInstrumentPropertyRequest {\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as UpsertInstrumentPropertyRequest);
        }

        /// <summary>
        /// Returns true if UpsertInstrumentPropertyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertInstrumentPropertyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertInstrumentPropertyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.IdentifierType != null)
                    hashCode = hashCode * 59 + this.IdentifierType.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }
    }

}
