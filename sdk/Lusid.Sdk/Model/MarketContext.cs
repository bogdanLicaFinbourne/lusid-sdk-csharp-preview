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
    /// Market context node. This defines how LUSID processes parts of a request that require resolution of market data such as instrument prices or  Fx rates. It controls where the data is loaded from and which sources take precedence.
    /// </summary>
    [DataContract]
    public partial class MarketContext :  IEquatable<MarketContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketContext" /> class.
        /// </summary>
        /// <param name="marketRules">The set of rules that define how to resolve particular use cases. These can be relatively general or specific in nature.  Nominally any number are possible and will be processed in order where applicable. However, there is evidently a potential  for increased computational cost where many rules must be applied to resolve data. Ensuring that portfolios are structured in  such a way as to reduce the number of rules required is therefore sensible..</param>
        /// <param name="suppliers">suppliers.</param>
        /// <param name="options">options.</param>
        public MarketContext(List<MarketDataKeyRule> marketRules = default(List<MarketDataKeyRule>), MarketContextSuppliers suppliers = default(MarketContextSuppliers), MarketOptions options = default(MarketOptions))
        {
            this.MarketRules = marketRules;
            this.Suppliers = suppliers;
            this.Options = options;
        }
        
        /// <summary>
        /// The set of rules that define how to resolve particular use cases. These can be relatively general or specific in nature.  Nominally any number are possible and will be processed in order where applicable. However, there is evidently a potential  for increased computational cost where many rules must be applied to resolve data. Ensuring that portfolios are structured in  such a way as to reduce the number of rules required is therefore sensible.
        /// </summary>
        /// <value>The set of rules that define how to resolve particular use cases. These can be relatively general or specific in nature.  Nominally any number are possible and will be processed in order where applicable. However, there is evidently a potential  for increased computational cost where many rules must be applied to resolve data. Ensuring that portfolios are structured in  such a way as to reduce the number of rules required is therefore sensible.</value>
        [DataMember(Name="marketRules", EmitDefaultValue=false)]
        public List<MarketDataKeyRule> MarketRules { get; set; }

        /// <summary>
        /// Gets or Sets Suppliers
        /// </summary>
        [DataMember(Name="suppliers", EmitDefaultValue=false)]
        public MarketContextSuppliers Suppliers { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public MarketOptions Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketContext {\n");
            sb.Append("  MarketRules: ").Append(MarketRules).Append("\n");
            sb.Append("  Suppliers: ").Append(Suppliers).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as MarketContext);
        }

        /// <summary>
        /// Returns true if MarketContext instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MarketRules == input.MarketRules ||
                    this.MarketRules != null &&
                    input.MarketRules != null &&
                    this.MarketRules.SequenceEqual(input.MarketRules)
                ) && 
                (
                    this.Suppliers == input.Suppliers ||
                    (this.Suppliers != null &&
                    this.Suppliers.Equals(input.Suppliers))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.MarketRules != null)
                    hashCode = hashCode * 59 + this.MarketRules.GetHashCode();
                if (this.Suppliers != null)
                    hashCode = hashCode * 59 + this.Suppliers.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }

}
