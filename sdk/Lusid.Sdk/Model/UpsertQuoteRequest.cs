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
    /// The details of the quote including its unique identifier, value and lineage.
    /// </summary>
    [DataContract]
    public partial class UpsertQuoteRequest :  IEquatable<UpsertQuoteRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertQuoteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertQuoteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertQuoteRequest" /> class.
        /// </summary>
        /// <param name="quoteId">quoteId (required).</param>
        /// <param name="metricValue">metricValue.</param>
        /// <param name="lineage">Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;..</param>
        public UpsertQuoteRequest(QuoteId quoteId = default(QuoteId), MetricValue metricValue = default(MetricValue), string lineage = default(string))
        {
            // to ensure "quoteId" is required (not null)
            if (quoteId == null)
            {
                throw new InvalidDataException("quoteId is a required property for UpsertQuoteRequest and cannot be null");
            }
            else
            {
                this.QuoteId = quoteId;
            }
            
            this.MetricValue = metricValue;
            this.Lineage = lineage;
        }
        
        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name="quoteId", EmitDefaultValue=false)]
        public QuoteId QuoteId { get; set; }

        /// <summary>
        /// Gets or Sets MetricValue
        /// </summary>
        [DataMember(Name="metricValue", EmitDefaultValue=false)]
        public MetricValue MetricValue { get; set; }

        /// <summary>
        /// Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.
        /// </summary>
        /// <value>Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.</value>
        [DataMember(Name="lineage", EmitDefaultValue=false)]
        public string Lineage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertQuoteRequest {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  MetricValue: ").Append(MetricValue).Append("\n");
            sb.Append("  Lineage: ").Append(Lineage).Append("\n");
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
            return this.Equals(input as UpsertQuoteRequest);
        }

        /// <summary>
        /// Returns true if UpsertQuoteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertQuoteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertQuoteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteId == input.QuoteId ||
                    (this.QuoteId != null &&
                    this.QuoteId.Equals(input.QuoteId))
                ) && 
                (
                    this.MetricValue == input.MetricValue ||
                    (this.MetricValue != null &&
                    this.MetricValue.Equals(input.MetricValue))
                ) && 
                (
                    this.Lineage == input.Lineage ||
                    (this.Lineage != null &&
                    this.Lineage.Equals(input.Lineage))
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
                if (this.QuoteId != null)
                    hashCode = hashCode * 59 + this.QuoteId.GetHashCode();
                if (this.MetricValue != null)
                    hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                if (this.Lineage != null)
                    hashCode = hashCode * 59 + this.Lineage.GetHashCode();
                return hashCode;
            }
        }
    }

}
