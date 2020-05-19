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
    /// A list of transactions.
    /// </summary>
    [DataContract]
    public partial class Transaction :  IEquatable<Transaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Transaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="transactionId">The unique identifier for the transaction. (required).</param>
        /// <param name="type">The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint. (required).</param>
        /// <param name="instrumentIdentifiers">The set of instrument identifiers that can be used to resolve the transaction to a unique instrument..</param>
        /// <param name="instrumentUid">The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in. (required).</param>
        /// <param name="transactionDate">The date of the transaction. (required).</param>
        /// <param name="settlementDate">The settlement date of the transaction. (required).</param>
        /// <param name="units">The number of units transacted in the associated instrument. (required).</param>
        /// <param name="transactionPrice">transactionPrice.</param>
        /// <param name="totalConsideration">totalConsideration (required).</param>
        /// <param name="exchangeRate">The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate..</param>
        /// <param name="transactionCurrency">The transaction currency..</param>
        /// <param name="properties">Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain..</param>
        /// <param name="counterpartyId">The identifier for the counterparty of the transaction..</param>
        /// <param name="source">The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration..</param>
        public Transaction(string transactionId = default(string), string type = default(string), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string instrumentUid = default(string), DateTimeOffset? transactionDate = default(DateTimeOffset?), DateTimeOffset? settlementDate = default(DateTimeOffset?), decimal? units = default(decimal?), TransactionPrice transactionPrice = default(TransactionPrice), CurrencyAndAmount totalConsideration = default(CurrencyAndAmount), decimal? exchangeRate = default(decimal?), string transactionCurrency = default(string), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), string counterpartyId = default(string), string source = default(string))
        {
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new InvalidDataException("transactionId is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionId = transactionId;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Transaction and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "instrumentUid" is required (not null)
            if (instrumentUid == null)
            {
                throw new InvalidDataException("instrumentUid is a required property for Transaction and cannot be null");
            }
            else
            {
                this.InstrumentUid = instrumentUid;
            }
            
            // to ensure "transactionDate" is required (not null)
            if (transactionDate == null)
            {
                throw new InvalidDataException("transactionDate is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TransactionDate = transactionDate;
            }
            
            // to ensure "settlementDate" is required (not null)
            if (settlementDate == null)
            {
                throw new InvalidDataException("settlementDate is a required property for Transaction and cannot be null");
            }
            else
            {
                this.SettlementDate = settlementDate;
            }
            
            // to ensure "units" is required (not null)
            if (units == null)
            {
                throw new InvalidDataException("units is a required property for Transaction and cannot be null");
            }
            else
            {
                this.Units = units;
            }
            
            // to ensure "totalConsideration" is required (not null)
            if (totalConsideration == null)
            {
                throw new InvalidDataException("totalConsideration is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TotalConsideration = totalConsideration;
            }
            
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.TransactionPrice = transactionPrice;
            this.ExchangeRate = exchangeRate;
            this.TransactionCurrency = transactionCurrency;
            this.Properties = properties;
            this.CounterpartyId = counterpartyId;
            this.Source = source;
        }
        
        /// <summary>
        /// The unique identifier for the transaction.
        /// </summary>
        /// <value>The unique identifier for the transaction.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint.
        /// </summary>
        /// <value>The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The set of instrument identifiers that can be used to resolve the transaction to a unique instrument.
        /// </summary>
        /// <value>The set of instrument identifiers that can be used to resolve the transaction to a unique instrument.</value>
        [DataMember(Name="instrumentIdentifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in.
        /// </summary>
        /// <value>The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in.</value>
        [DataMember(Name="instrumentUid", EmitDefaultValue=false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The date of the transaction.
        /// </summary>
        /// <value>The date of the transaction.</value>
        [DataMember(Name="transactionDate", EmitDefaultValue=false)]
        public DateTimeOffset? TransactionDate { get; set; }

        /// <summary>
        /// The settlement date of the transaction.
        /// </summary>
        /// <value>The settlement date of the transaction.</value>
        [DataMember(Name="settlementDate", EmitDefaultValue=false)]
        public DateTimeOffset? SettlementDate { get; set; }

        /// <summary>
        /// The number of units transacted in the associated instrument.
        /// </summary>
        /// <value>The number of units transacted in the associated instrument.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public decimal? Units { get; set; }

        /// <summary>
        /// Gets or Sets TransactionPrice
        /// </summary>
        [DataMember(Name="transactionPrice", EmitDefaultValue=false)]
        public TransactionPrice TransactionPrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalConsideration
        /// </summary>
        [DataMember(Name="totalConsideration", EmitDefaultValue=false)]
        public CurrencyAndAmount TotalConsideration { get; set; }

        /// <summary>
        /// The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate.
        /// </summary>
        /// <value>The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate.</value>
        [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The transaction currency.
        /// </summary>
        /// <value>The transaction currency.</value>
        [DataMember(Name="transactionCurrency", EmitDefaultValue=false)]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The identifier for the counterparty of the transaction.
        /// </summary>
        /// <value>The identifier for the counterparty of the transaction.</value>
        [DataMember(Name="counterpartyId", EmitDefaultValue=false)]
        public string CounterpartyId { get; set; }

        /// <summary>
        /// The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.
        /// </summary>
        /// <value>The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  TransactionPrice: ").Append(TransactionPrice).Append("\n");
            sb.Append("  TotalConsideration: ").Append(TotalConsideration).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CounterpartyId: ").Append(CounterpartyId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.TransactionPrice == input.TransactionPrice ||
                    (this.TransactionPrice != null &&
                    this.TransactionPrice.Equals(input.TransactionPrice))
                ) && 
                (
                    this.TotalConsideration == input.TotalConsideration ||
                    (this.TotalConsideration != null &&
                    this.TotalConsideration.Equals(input.TotalConsideration))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.TransactionCurrency == input.TransactionCurrency ||
                    (this.TransactionCurrency != null &&
                    this.TransactionCurrency.Equals(input.TransactionCurrency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.CounterpartyId == input.CounterpartyId ||
                    (this.CounterpartyId != null &&
                    this.CounterpartyId.Equals(input.CounterpartyId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.SettlementDate != null)
                    hashCode = hashCode * 59 + this.SettlementDate.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.TransactionPrice != null)
                    hashCode = hashCode * 59 + this.TransactionPrice.GetHashCode();
                if (this.TotalConsideration != null)
                    hashCode = hashCode * 59 + this.TotalConsideration.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.TransactionCurrency != null)
                    hashCode = hashCode * 59 + this.TransactionCurrency.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.CounterpartyId != null)
                    hashCode = hashCode * 59 + this.CounterpartyId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }
    }

}
