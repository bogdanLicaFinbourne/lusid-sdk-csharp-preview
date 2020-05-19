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
    /// The unique identifier of the quote.
    /// </summary>
    [DataContract]
    public partial class QuoteId :  IEquatable<QuoteId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteId" /> class.
        /// </summary>
        /// <param name="quoteSeriesId">quoteSeriesId (required).</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the quote is valid from. (required).</param>
        public QuoteId(QuoteSeriesId quoteSeriesId = default(QuoteSeriesId), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // to ensure "quoteSeriesId" is required (not null)
            if (quoteSeriesId == null)
            {
                throw new InvalidDataException("quoteSeriesId is a required property for QuoteId and cannot be null");
            }
            else
            {
                this.QuoteSeriesId = quoteSeriesId;
            }
            
            // to ensure "effectiveAt" is required (not null)
            if (effectiveAt == null)
            {
                throw new InvalidDataException("effectiveAt is a required property for QuoteId and cannot be null");
            }
            else
            {
                this.EffectiveAt = effectiveAt;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets QuoteSeriesId
        /// </summary>
        [DataMember(Name="quoteSeriesId", EmitDefaultValue=false)]
        public QuoteSeriesId QuoteSeriesId { get; set; }

        /// <summary>
        /// The effective datetime or cut label at which the quote is valid from.
        /// </summary>
        /// <value>The effective datetime or cut label at which the quote is valid from.</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=false)]
        public DateTimeOrCutLabel EffectiveAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteId {\n");
            sb.Append("  QuoteSeriesId: ").Append(QuoteSeriesId).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
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
            return this.Equals(input as QuoteId);
        }

        /// <summary>
        /// Returns true if QuoteId instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteSeriesId == input.QuoteSeriesId ||
                    (this.QuoteSeriesId != null &&
                    this.QuoteSeriesId.Equals(input.QuoteSeriesId))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
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
                if (this.QuoteSeriesId != null)
                    hashCode = hashCode * 59 + this.QuoteSeriesId.GetHashCode();
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
