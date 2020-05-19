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
    /// OrderBySpec
    /// </summary>
    [DataContract]
    public partial class OrderBySpec :  IEquatable<OrderBySpec>
    {
        /// <summary>
        /// Defines SortOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum
        {
            /// <summary>
            /// Enum Ascending for value: Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            Ascending = 1,

            /// <summary>
            /// Enum Descending for value: Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            Descending = 2

        }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBySpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderBySpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBySpec" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="sortOrder">sortOrder (required).</param>
        public OrderBySpec(string key = default(string), SortOrderEnum sortOrder = default(SortOrderEnum))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for OrderBySpec and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "sortOrder" is required (not null)
            if (sortOrder == null)
            {
                throw new InvalidDataException("sortOrder is a required property for OrderBySpec and cannot be null");
            }
            else
            {
                this.SortOrder = sortOrder;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderBySpec {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as OrderBySpec);
        }

        /// <summary>
        /// Returns true if OrderBySpec instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderBySpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderBySpec input)
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
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
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
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                return hashCode;
            }
        }
    }

}
