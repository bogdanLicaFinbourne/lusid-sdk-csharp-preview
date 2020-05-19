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
    /// QueryableEntitiesResponse
    /// </summary>
    [DataContract]
    public partial class QueryableEntitiesResponse :  IEquatable<QueryableEntitiesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryableEntitiesResponse" /> class.
        /// </summary>
        /// <param name="addressKeys">The set of addresses that can be accessed via (an aggregation) query..</param>
        /// <param name="descriptions">The descriptions for each address key to explain exactly what they are and mean..</param>
        /// <param name="definitions">The definitions of the the results returned for a given key with information on whether it is scaled with quantity of holdings and what type it is..</param>
        public QueryableEntitiesResponse(List<string> addressKeys = default(List<string>), List<string> descriptions = default(List<string>), List<AggregationResult> definitions = default(List<AggregationResult>))
        {
            this.AddressKeys = addressKeys;
            this.Descriptions = descriptions;
            this.Definitions = definitions;
        }
        
        /// <summary>
        /// The set of addresses that can be accessed via (an aggregation) query.
        /// </summary>
        /// <value>The set of addresses that can be accessed via (an aggregation) query.</value>
        [DataMember(Name="addressKeys", EmitDefaultValue=false)]
        public List<string> AddressKeys { get; set; }

        /// <summary>
        /// The descriptions for each address key to explain exactly what they are and mean.
        /// </summary>
        /// <value>The descriptions for each address key to explain exactly what they are and mean.</value>
        [DataMember(Name="descriptions", EmitDefaultValue=false)]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// The definitions of the the results returned for a given key with information on whether it is scaled with quantity of holdings and what type it is.
        /// </summary>
        /// <value>The definitions of the the results returned for a given key with information on whether it is scaled with quantity of holdings and what type it is.</value>
        [DataMember(Name="definitions", EmitDefaultValue=false)]
        public List<AggregationResult> Definitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryableEntitiesResponse {\n");
            sb.Append("  AddressKeys: ").Append(AddressKeys).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  Definitions: ").Append(Definitions).Append("\n");
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
            return this.Equals(input as QueryableEntitiesResponse);
        }

        /// <summary>
        /// Returns true if QueryableEntitiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryableEntitiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryableEntitiesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressKeys == input.AddressKeys ||
                    this.AddressKeys != null &&
                    input.AddressKeys != null &&
                    this.AddressKeys.SequenceEqual(input.AddressKeys)
                ) && 
                (
                    this.Descriptions == input.Descriptions ||
                    this.Descriptions != null &&
                    input.Descriptions != null &&
                    this.Descriptions.SequenceEqual(input.Descriptions)
                ) && 
                (
                    this.Definitions == input.Definitions ||
                    this.Definitions != null &&
                    input.Definitions != null &&
                    this.Definitions.SequenceEqual(input.Definitions)
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
                if (this.AddressKeys != null)
                    hashCode = hashCode * 59 + this.AddressKeys.GetHashCode();
                if (this.Descriptions != null)
                    hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                if (this.Definitions != null)
                    hashCode = hashCode * 59 + this.Definitions.GetHashCode();
                return hashCode;
            }
        }
    }

}
