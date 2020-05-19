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
    /// The time invariant unique identifier of the quote. Combined with the effective datetime of the quote this  uniquely identifies the quote. This can be thought of as a unique identifier for a time series of quotes.
    /// </summary>
    [DataContract]
    public partial class QuoteSeriesId :  IEquatable<QuoteSeriesId>
    {
        /// <summary>
        /// The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;.
        /// </summary>
        /// <value>The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentIdTypeEnum
        {
            /// <summary>
            /// Enum LusidInstrumentId for value: LusidInstrumentId
            /// </summary>
            [EnumMember(Value = "LusidInstrumentId")]
            LusidInstrumentId = 1,

            /// <summary>
            /// Enum Figi for value: Figi
            /// </summary>
            [EnumMember(Value = "Figi")]
            Figi = 2,

            /// <summary>
            /// Enum RIC for value: RIC
            /// </summary>
            [EnumMember(Value = "RIC")]
            RIC = 3,

            /// <summary>
            /// Enum QuotePermId for value: QuotePermId
            /// </summary>
            [EnumMember(Value = "QuotePermId")]
            QuotePermId = 4,

            /// <summary>
            /// Enum Isin for value: Isin
            /// </summary>
            [EnumMember(Value = "Isin")]
            Isin = 5,

            /// <summary>
            /// Enum CurrencyPair for value: CurrencyPair
            /// </summary>
            [EnumMember(Value = "CurrencyPair")]
            CurrencyPair = 6

        }

        /// <summary>
        /// The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;.
        /// </summary>
        /// <value>The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;.</value>
        [DataMember(Name="instrumentIdType", EmitDefaultValue=false)]
        public InstrumentIdTypeEnum InstrumentIdType { get; set; }
        /// <summary>
        /// The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used.
        /// </summary>
        /// <value>The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuoteTypeEnum
        {
            /// <summary>
            /// Enum Price for value: Price
            /// </summary>
            [EnumMember(Value = "Price")]
            Price = 1,

            /// <summary>
            /// Enum Spread for value: Spread
            /// </summary>
            [EnumMember(Value = "Spread")]
            Spread = 2,

            /// <summary>
            /// Enum Rate for value: Rate
            /// </summary>
            [EnumMember(Value = "Rate")]
            Rate = 3,

            /// <summary>
            /// Enum LogNormalVol for value: LogNormalVol
            /// </summary>
            [EnumMember(Value = "LogNormalVol")]
            LogNormalVol = 4,

            /// <summary>
            /// Enum NormalVol for value: NormalVol
            /// </summary>
            [EnumMember(Value = "NormalVol")]
            NormalVol = 5,

            /// <summary>
            /// Enum ParSpread for value: ParSpread
            /// </summary>
            [EnumMember(Value = "ParSpread")]
            ParSpread = 6,

            /// <summary>
            /// Enum IsdaSpread for value: IsdaSpread
            /// </summary>
            [EnumMember(Value = "IsdaSpread")]
            IsdaSpread = 7,

            /// <summary>
            /// Enum Upfront for value: Upfront
            /// </summary>
            [EnumMember(Value = "Upfront")]
            Upfront = 8

        }

        /// <summary>
        /// The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used.
        /// </summary>
        /// <value>The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used.</value>
        [DataMember(Name="quoteType", EmitDefaultValue=false)]
        public QuoteTypeEnum QuoteType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSeriesId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteSeriesId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSeriesId" /> class.
        /// </summary>
        /// <param name="provider">The platform or vendor that provided the quote, e.g. &#39;DataScope&#39;, &#39;LUSID&#39; etc. (required).</param>
        /// <param name="priceSource">The source or originator of the quote, e.g. a bank or financial institution..</param>
        /// <param name="instrumentId">The value of the instrument identifier that uniquely identifies the instrument that the quote is for, e.g. &#39;BBG00JX0P539&#39;. (required).</param>
        /// <param name="instrumentIdType">The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;. (required).</param>
        /// <param name="quoteType">The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used. (required).</param>
        /// <param name="field">The field of the quote e.g. bid, mid, ask etc. This should be consistent across a time series of quotes. The allowed values are dependant on the specified Provider. (required).</param>
        public QuoteSeriesId(string provider = default(string), string priceSource = default(string), string instrumentId = default(string), InstrumentIdTypeEnum instrumentIdType = default(InstrumentIdTypeEnum), QuoteTypeEnum quoteType = default(QuoteTypeEnum), string field = default(string))
        {
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new InvalidDataException("provider is a required property for QuoteSeriesId and cannot be null");
            }
            else
            {
                this.Provider = provider;
            }
            
            // to ensure "instrumentId" is required (not null)
            if (instrumentId == null)
            {
                throw new InvalidDataException("instrumentId is a required property for QuoteSeriesId and cannot be null");
            }
            else
            {
                this.InstrumentId = instrumentId;
            }
            
            // to ensure "instrumentIdType" is required (not null)
            if (instrumentIdType == null)
            {
                throw new InvalidDataException("instrumentIdType is a required property for QuoteSeriesId and cannot be null");
            }
            else
            {
                this.InstrumentIdType = instrumentIdType;
            }
            
            // to ensure "quoteType" is required (not null)
            if (quoteType == null)
            {
                throw new InvalidDataException("quoteType is a required property for QuoteSeriesId and cannot be null");
            }
            else
            {
                this.QuoteType = quoteType;
            }
            
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new InvalidDataException("field is a required property for QuoteSeriesId and cannot be null");
            }
            else
            {
                this.Field = field;
            }
            
            this.PriceSource = priceSource;
        }
        
        /// <summary>
        /// The platform or vendor that provided the quote, e.g. &#39;DataScope&#39;, &#39;LUSID&#39; etc.
        /// </summary>
        /// <value>The platform or vendor that provided the quote, e.g. &#39;DataScope&#39;, &#39;LUSID&#39; etc.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// The source or originator of the quote, e.g. a bank or financial institution.
        /// </summary>
        /// <value>The source or originator of the quote, e.g. a bank or financial institution.</value>
        [DataMember(Name="priceSource", EmitDefaultValue=false)]
        public string PriceSource { get; set; }

        /// <summary>
        /// The value of the instrument identifier that uniquely identifies the instrument that the quote is for, e.g. &#39;BBG00JX0P539&#39;.
        /// </summary>
        /// <value>The value of the instrument identifier that uniquely identifies the instrument that the quote is for, e.g. &#39;BBG00JX0P539&#39;.</value>
        [DataMember(Name="instrumentId", EmitDefaultValue=false)]
        public string InstrumentId { get; set; }



        /// <summary>
        /// The field of the quote e.g. bid, mid, ask etc. This should be consistent across a time series of quotes. The allowed values are dependant on the specified Provider.
        /// </summary>
        /// <value>The field of the quote e.g. bid, mid, ask etc. This should be consistent across a time series of quotes. The allowed values are dependant on the specified Provider.</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteSeriesId {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  PriceSource: ").Append(PriceSource).Append("\n");
            sb.Append("  InstrumentId: ").Append(InstrumentId).Append("\n");
            sb.Append("  InstrumentIdType: ").Append(InstrumentIdType).Append("\n");
            sb.Append("  QuoteType: ").Append(QuoteType).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(input as QuoteSeriesId);
        }

        /// <summary>
        /// Returns true if QuoteSeriesId instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteSeriesId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteSeriesId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.PriceSource == input.PriceSource ||
                    (this.PriceSource != null &&
                    this.PriceSource.Equals(input.PriceSource))
                ) && 
                (
                    this.InstrumentId == input.InstrumentId ||
                    (this.InstrumentId != null &&
                    this.InstrumentId.Equals(input.InstrumentId))
                ) && 
                (
                    this.InstrumentIdType == input.InstrumentIdType ||
                    (this.InstrumentIdType != null &&
                    this.InstrumentIdType.Equals(input.InstrumentIdType))
                ) && 
                (
                    this.QuoteType == input.QuoteType ||
                    (this.QuoteType != null &&
                    this.QuoteType.Equals(input.QuoteType))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
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
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.PriceSource != null)
                    hashCode = hashCode * 59 + this.PriceSource.GetHashCode();
                if (this.InstrumentId != null)
                    hashCode = hashCode * 59 + this.InstrumentId.GetHashCode();
                if (this.InstrumentIdType != null)
                    hashCode = hashCode * 59 + this.InstrumentIdType.GetHashCode();
                if (this.QuoteType != null)
                    hashCode = hashCode * 59 + this.QuoteType.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                return hashCode;
            }
        }
    }

}
