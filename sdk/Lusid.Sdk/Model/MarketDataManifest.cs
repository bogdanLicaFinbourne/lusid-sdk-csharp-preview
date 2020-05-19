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
    /// MarketDataManifest
    /// </summary>
    [DataContract]
    public partial class MarketDataManifest :  IEquatable<MarketDataManifest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketDataManifest" /> class.
        /// </summary>
        /// <param name="quotes">quotes.</param>
        /// <param name="structuredMarketData">structuredMarketData.</param>
        public MarketDataManifest(Dictionary<string, ValueTupleOfMarketDataKeyRuleToQuote> quotes = default(Dictionary<string, ValueTupleOfMarketDataKeyRuleToQuote>), Dictionary<string, ValueTupleOfMarketDataKeyRuleToStructuredMarketData> structuredMarketData = default(Dictionary<string, ValueTupleOfMarketDataKeyRuleToStructuredMarketData>))
        {
            this.Quotes = quotes;
            this.StructuredMarketData = structuredMarketData;
        }
        
        /// <summary>
        /// Gets or Sets Quotes
        /// </summary>
        [DataMember(Name="quotes", EmitDefaultValue=false)]
        public Dictionary<string, ValueTupleOfMarketDataKeyRuleToQuote> Quotes { get; set; }

        /// <summary>
        /// Gets or Sets StructuredMarketData
        /// </summary>
        [DataMember(Name="structuredMarketData", EmitDefaultValue=false)]
        public Dictionary<string, ValueTupleOfMarketDataKeyRuleToStructuredMarketData> StructuredMarketData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketDataManifest {\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
            sb.Append("  StructuredMarketData: ").Append(StructuredMarketData).Append("\n");
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
            return this.Equals(input as MarketDataManifest);
        }

        /// <summary>
        /// Returns true if MarketDataManifest instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketDataManifest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketDataManifest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    input.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
                ) && 
                (
                    this.StructuredMarketData == input.StructuredMarketData ||
                    this.StructuredMarketData != null &&
                    input.StructuredMarketData != null &&
                    this.StructuredMarketData.SequenceEqual(input.StructuredMarketData)
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
                if (this.Quotes != null)
                    hashCode = hashCode * 59 + this.Quotes.GetHashCode();
                if (this.StructuredMarketData != null)
                    hashCode = hashCode * 59 + this.StructuredMarketData.GetHashCode();
                return hashCode;
            }
        }
    }

}
