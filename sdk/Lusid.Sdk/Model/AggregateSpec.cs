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
    /// AggregateSpec
    /// </summary>
    [DataContract]
    public partial class AggregateSpec :  IEquatable<AggregateSpec>
    {
        /// <summary>
        /// Defines Op
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpEnum
        {
            /// <summary>
            /// Enum Sum for value: Sum
            /// </summary>
            [EnumMember(Value = "Sum")]
            Sum = 1,

            /// <summary>
            /// Enum Proportion for value: Proportion
            /// </summary>
            [EnumMember(Value = "Proportion")]
            Proportion = 2,

            /// <summary>
            /// Enum Average for value: Average
            /// </summary>
            [EnumMember(Value = "Average")]
            Average = 3,

            /// <summary>
            /// Enum Count for value: Count
            /// </summary>
            [EnumMember(Value = "Count")]
            Count = 4,

            /// <summary>
            /// Enum Min for value: Min
            /// </summary>
            [EnumMember(Value = "Min")]
            Min = 5,

            /// <summary>
            /// Enum Max for value: Max
            /// </summary>
            [EnumMember(Value = "Max")]
            Max = 6,

            /// <summary>
            /// Enum Value for value: Value
            /// </summary>
            [EnumMember(Value = "Value")]
            Value = 7

        }

        /// <summary>
        /// Gets or Sets Op
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public OpEnum? Op { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateSpec" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="op">op.</param>
        public AggregateSpec(string key = default(string), OpEnum? op = default(OpEnum?))
        {
            this.Key = key;
            this.Op = op;
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
            sb.Append("class AggregateSpec {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
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
            return this.Equals(input as AggregateSpec);
        }

        /// <summary>
        /// Returns true if AggregateSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregateSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregateSpec input)
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
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
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
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                return hashCode;
            }
        }
    }

}
