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
    /// A request to create or update an Allocation.
    /// </summary>
    [DataContract]
    public partial class AllocationRequest :  IEquatable<AllocationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllocationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationRequest" /> class.
        /// </summary>
        /// <param name="properties">Client-defined properties associated with this allocation..</param>
        /// <param name="instrumentIdentifiers">The instrument allocated. (required).</param>
        /// <param name="quantity">The quantity of given instrument allocated. (required).</param>
        /// <param name="portfolioId">portfolioId (required).</param>
        /// <param name="allocatedOrderId">allocatedOrderId (required).</param>
        /// <param name="id">id (required).</param>
        public AllocationRequest(Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), int? quantity = default(int?), ResourceId portfolioId = default(ResourceId), ResourceId allocatedOrderId = default(ResourceId), ResourceId id = default(ResourceId))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new InvalidDataException("instrumentIdentifiers is a required property for AllocationRequest and cannot be null");
            }
            else
            {
                this.InstrumentIdentifiers = instrumentIdentifiers;
            }
            
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for AllocationRequest and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            
            // to ensure "portfolioId" is required (not null)
            if (portfolioId == null)
            {
                throw new InvalidDataException("portfolioId is a required property for AllocationRequest and cannot be null");
            }
            else
            {
                this.PortfolioId = portfolioId;
            }
            
            // to ensure "allocatedOrderId" is required (not null)
            if (allocatedOrderId == null)
            {
                throw new InvalidDataException("allocatedOrderId is a required property for AllocationRequest and cannot be null");
            }
            else
            {
                this.AllocatedOrderId = allocatedOrderId;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AllocationRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            this.Properties = properties;
        }
        
        /// <summary>
        /// Client-defined properties associated with this allocation.
        /// </summary>
        /// <value>Client-defined properties associated with this allocation.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The instrument allocated.
        /// </summary>
        /// <value>The instrument allocated.</value>
        [DataMember(Name="instrumentIdentifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The quantity of given instrument allocated.
        /// </summary>
        /// <value>The quantity of given instrument allocated.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name="portfolioId", EmitDefaultValue=false)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets AllocatedOrderId
        /// </summary>
        [DataMember(Name="allocatedOrderId", EmitDefaultValue=false)]
        public ResourceId AllocatedOrderId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllocationRequest {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  AllocatedOrderId: ").Append(AllocatedOrderId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as AllocationRequest);
        }

        /// <summary>
        /// Returns true if AllocationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AllocationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllocationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.AllocatedOrderId == input.AllocatedOrderId ||
                    (this.AllocatedOrderId != null &&
                    this.AllocatedOrderId.Equals(input.AllocatedOrderId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.PortfolioId != null)
                    hashCode = hashCode * 59 + this.PortfolioId.GetHashCode();
                if (this.AllocatedOrderId != null)
                    hashCode = hashCode * 59 + this.AllocatedOrderId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }

}
