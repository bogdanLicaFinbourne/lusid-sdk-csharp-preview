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
    /// AggregationResponseNodeOfDictionaryOfStringToObject
    /// </summary>
    [DataContract]
    public partial class AggregationResponseNodeOfDictionaryOfStringToObject :  IEquatable<AggregationResponseNodeOfDictionaryOfStringToObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationResponseNodeOfDictionaryOfStringToObject" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        /// <param name="depth">depth.</param>
        /// <param name="properties">properties.</param>
        /// <param name="children">children.</param>
        public AggregationResponseNodeOfDictionaryOfStringToObject(AggregateSpec key = default(AggregateSpec), string value = default(string), int? depth = default(int?), Dictionary<string, Object> properties = default(Dictionary<string, Object>), List<AggregationResponseNodeOfDictionaryOfStringToObject> children = default(List<AggregationResponseNodeOfDictionaryOfStringToObject>))
        {
            this.Key = key;
            this.Value = value;
            this.Depth = depth;
            this.Properties = properties;
            this.Children = children;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public AggregateSpec Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Depth
        /// </summary>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public int? Depth { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<AggregationResponseNodeOfDictionaryOfStringToObject> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationResponseNodeOfDictionaryOfStringToObject {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return this.Equals(input as AggregationResponseNodeOfDictionaryOfStringToObject);
        }

        /// <summary>
        /// Returns true if AggregationResponseNodeOfDictionaryOfStringToObject instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationResponseNodeOfDictionaryOfStringToObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationResponseNodeOfDictionaryOfStringToObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                return hashCode;
            }
        }
    }

}
