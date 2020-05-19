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
    /// A list of property definitions.
    /// </summary>
    [DataContract]
    public partial class PropertyDefinition :  IEquatable<PropertyDefinition>
    {
        /// <summary>
        /// The type of values that can be associated with this property. This is defined by the property&#39;s data type.
        /// </summary>
        /// <value>The type of values that can be associated with this property. This is defined by the property&#39;s data type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Enum String for value: String
            /// </summary>
            [EnumMember(Value = "String")]
            String = 1,

            /// <summary>
            /// Enum Int for value: Int
            /// </summary>
            [EnumMember(Value = "Int")]
            Int = 2,

            /// <summary>
            /// Enum Decimal for value: Decimal
            /// </summary>
            [EnumMember(Value = "Decimal")]
            Decimal = 3,

            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 4,

            /// <summary>
            /// Enum Boolean for value: Boolean
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean = 5,

            /// <summary>
            /// Enum Map for value: Map
            /// </summary>
            [EnumMember(Value = "Map")]
            Map = 6,

            /// <summary>
            /// Enum List for value: List
            /// </summary>
            [EnumMember(Value = "List")]
            List = 7,

            /// <summary>
            /// Enum PropertyArray for value: PropertyArray
            /// </summary>
            [EnumMember(Value = "PropertyArray")]
            PropertyArray = 8,

            /// <summary>
            /// Enum Percentage for value: Percentage
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage = 9,

            /// <summary>
            /// Enum BenchmarkType for value: BenchmarkType
            /// </summary>
            [EnumMember(Value = "BenchmarkType")]
            BenchmarkType = 10,

            /// <summary>
            /// Enum Code for value: Code
            /// </summary>
            [EnumMember(Value = "Code")]
            Code = 11,

            /// <summary>
            /// Enum Id for value: Id
            /// </summary>
            [EnumMember(Value = "Id")]
            Id = 12,

            /// <summary>
            /// Enum Uri for value: Uri
            /// </summary>
            [EnumMember(Value = "Uri")]
            Uri = 13,

            /// <summary>
            /// Enum ArrayOfIds for value: ArrayOfIds
            /// </summary>
            [EnumMember(Value = "ArrayOfIds")]
            ArrayOfIds = 14,

            /// <summary>
            /// Enum ArrayOfTransactionAliases for value: ArrayOfTransactionAliases
            /// </summary>
            [EnumMember(Value = "ArrayOfTransactionAliases")]
            ArrayOfTransactionAliases = 15,

            /// <summary>
            /// Enum ArrayofTransactionMovements for value: ArrayofTransactionMovements
            /// </summary>
            [EnumMember(Value = "ArrayofTransactionMovements")]
            ArrayofTransactionMovements = 16,

            /// <summary>
            /// Enum ArrayofUnits for value: ArrayofUnits
            /// </summary>
            [EnumMember(Value = "ArrayofUnits")]
            ArrayofUnits = 17,

            /// <summary>
            /// Enum StringArray for value: StringArray
            /// </summary>
            [EnumMember(Value = "StringArray")]
            StringArray = 18,

            /// <summary>
            /// Enum CurrencyAndAmount for value: CurrencyAndAmount
            /// </summary>
            [EnumMember(Value = "CurrencyAndAmount")]
            CurrencyAndAmount = 19,

            /// <summary>
            /// Enum TradePrice for value: TradePrice
            /// </summary>
            [EnumMember(Value = "TradePrice")]
            TradePrice = 20,

            /// <summary>
            /// Enum UnitCreation for value: UnitCreation
            /// </summary>
            [EnumMember(Value = "UnitCreation")]
            UnitCreation = 21,

            /// <summary>
            /// Enum Currency for value: Currency
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency = 22,

            /// <summary>
            /// Enum UserId for value: UserId
            /// </summary>
            [EnumMember(Value = "UserId")]
            UserId = 23,

            /// <summary>
            /// Enum MetricValue for value: MetricValue
            /// </summary>
            [EnumMember(Value = "MetricValue")]
            MetricValue = 24,

            /// <summary>
            /// Enum QuoteId for value: QuoteId
            /// </summary>
            [EnumMember(Value = "QuoteId")]
            QuoteId = 25,

            /// <summary>
            /// Enum QuoteSeriesId for value: QuoteSeriesId
            /// </summary>
            [EnumMember(Value = "QuoteSeriesId")]
            QuoteSeriesId = 26,

            /// <summary>
            /// Enum ResourceId for value: ResourceId
            /// </summary>
            [EnumMember(Value = "ResourceId")]
            ResourceId = 27,

            /// <summary>
            /// Enum ResultValue for value: ResultValue
            /// </summary>
            [EnumMember(Value = "ResultValue")]
            ResultValue = 28,

            /// <summary>
            /// Enum CutLocalTime for value: CutLocalTime
            /// </summary>
            [EnumMember(Value = "CutLocalTime")]
            CutLocalTime = 29,

            /// <summary>
            /// Enum DateOrCutLabel for value: DateOrCutLabel
            /// </summary>
            [EnumMember(Value = "DateOrCutLabel")]
            DateOrCutLabel = 30,

            /// <summary>
            /// Enum Transition for value: Transition
            /// </summary>
            [EnumMember(Value = "Transition")]
            Transition = 31,

            /// <summary>
            /// Enum StructuredData for value: StructuredData
            /// </summary>
            [EnumMember(Value = "StructuredData")]
            StructuredData = 32,

            /// <summary>
            /// Enum StructuredDataId for value: StructuredDataId
            /// </summary>
            [EnumMember(Value = "StructuredDataId")]
            StructuredDataId = 33,

            /// <summary>
            /// Enum ConfigurationRecipe for value: ConfigurationRecipe
            /// </summary>
            [EnumMember(Value = "ConfigurationRecipe")]
            ConfigurationRecipe = 34,

            /// <summary>
            /// Enum ConfigurationRecipeSnippet for value: ConfigurationRecipeSnippet
            /// </summary>
            [EnumMember(Value = "ConfigurationRecipeSnippet")]
            ConfigurationRecipeSnippet = 35,

            /// <summary>
            /// Enum StructuredResultDataId for value: StructuredResultDataId
            /// </summary>
            [EnumMember(Value = "StructuredResultDataId")]
            StructuredResultDataId = 36,

            /// <summary>
            /// Enum StructuredResultData for value: StructuredResultData
            /// </summary>
            [EnumMember(Value = "StructuredResultData")]
            StructuredResultData = 37,

            /// <summary>
            /// Enum DataMapping for value: DataMapping
            /// </summary>
            [EnumMember(Value = "DataMapping")]
            DataMapping = 38,

            /// <summary>
            /// Enum LusidInstrument for value: LusidInstrument
            /// </summary>
            [EnumMember(Value = "LusidInstrument")]
            LusidInstrument = 39,

            /// <summary>
            /// Enum WeightedInstrument for value: WeightedInstrument
            /// </summary>
            [EnumMember(Value = "WeightedInstrument")]
            WeightedInstrument = 40,

            /// <summary>
            /// Enum Tenor for value: Tenor
            /// </summary>
            [EnumMember(Value = "Tenor")]
            Tenor = 41,

            /// <summary>
            /// Enum CdsDetailSpecifications for value: CdsDetailSpecifications
            /// </summary>
            [EnumMember(Value = "CdsDetailSpecifications")]
            CdsDetailSpecifications = 42,

            /// <summary>
            /// Enum FlowConventions for value: FlowConventions
            /// </summary>
            [EnumMember(Value = "FlowConventions")]
            FlowConventions = 43,

            /// <summary>
            /// Enum OrderId for value: OrderId
            /// </summary>
            [EnumMember(Value = "OrderId")]
            OrderId = 44

        }

        /// <summary>
        /// The type of values that can be associated with this property. This is defined by the property&#39;s data type.
        /// </summary>
        /// <value>The type of values that can be associated with this property. This is defined by the property&#39;s data type.</value>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Describes how the property&#39;s values can change over time.
        /// </summary>
        /// <value>Describes how the property&#39;s values can change over time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LifeTimeEnum
        {
            /// <summary>
            /// Enum Perpetual for value: Perpetual
            /// </summary>
            [EnumMember(Value = "Perpetual")]
            Perpetual = 1,

            /// <summary>
            /// Enum TimeVariant for value: TimeVariant
            /// </summary>
            [EnumMember(Value = "TimeVariant")]
            TimeVariant = 2

        }

        /// <summary>
        /// Describes how the property&#39;s values can change over time.
        /// </summary>
        /// <value>Describes how the property&#39;s values can change over time.</value>
        [DataMember(Name="lifeTime", EmitDefaultValue=false)]
        public LifeTimeEnum? LifeTime { get; set; }
        /// <summary>
        /// The type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Label for value: Label
            /// </summary>
            [EnumMember(Value = "Label")]
            Label = 1,

            /// <summary>
            /// Enum Metric for value: Metric
            /// </summary>
            [EnumMember(Value = "Metric")]
            Metric = 2,

            /// <summary>
            /// Enum Information for value: Information
            /// </summary>
            [EnumMember(Value = "Information")]
            Information = 3

        }

        /// <summary>
        /// The type of the property.
        /// </summary>
        /// <value>The type of the property.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type.
        /// </summary>
        /// <value>The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitSchemaEnum
        {
            /// <summary>
            /// Enum NoUnits for value: NoUnits
            /// </summary>
            [EnumMember(Value = "NoUnits")]
            NoUnits = 1,

            /// <summary>
            /// Enum Basic for value: Basic
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic = 2,

            /// <summary>
            /// Enum Iso4217Currency for value: Iso4217Currency
            /// </summary>
            [EnumMember(Value = "Iso4217Currency")]
            Iso4217Currency = 3

        }

        /// <summary>
        /// The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type.
        /// </summary>
        /// <value>The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type.</value>
        [DataMember(Name="unitSchema", EmitDefaultValue=false)]
        public UnitSchemaEnum? UnitSchema { get; set; }
        /// <summary>
        /// The domain that the property exists in.
        /// </summary>
        /// <value>The domain that the property exists in.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DomainEnum
        {
            /// <summary>
            /// Enum NotDefined for value: NotDefined
            /// </summary>
            [EnumMember(Value = "NotDefined")]
            NotDefined = 1,

            /// <summary>
            /// Enum Transaction for value: Transaction
            /// </summary>
            [EnumMember(Value = "Transaction")]
            Transaction = 2,

            /// <summary>
            /// Enum Portfolio for value: Portfolio
            /// </summary>
            [EnumMember(Value = "Portfolio")]
            Portfolio = 3,

            /// <summary>
            /// Enum Holding for value: Holding
            /// </summary>
            [EnumMember(Value = "Holding")]
            Holding = 4,

            /// <summary>
            /// Enum ReferenceHolding for value: ReferenceHolding
            /// </summary>
            [EnumMember(Value = "ReferenceHolding")]
            ReferenceHolding = 5,

            /// <summary>
            /// Enum TransactionConfiguration for value: TransactionConfiguration
            /// </summary>
            [EnumMember(Value = "TransactionConfiguration")]
            TransactionConfiguration = 6,

            /// <summary>
            /// Enum Instrument for value: Instrument
            /// </summary>
            [EnumMember(Value = "Instrument")]
            Instrument = 7,

            /// <summary>
            /// Enum CutLabelDefinition for value: CutLabelDefinition
            /// </summary>
            [EnumMember(Value = "CutLabelDefinition")]
            CutLabelDefinition = 8,

            /// <summary>
            /// Enum Analytic for value: Analytic
            /// </summary>
            [EnumMember(Value = "Analytic")]
            Analytic = 9,

            /// <summary>
            /// Enum PortfolioGroup for value: PortfolioGroup
            /// </summary>
            [EnumMember(Value = "PortfolioGroup")]
            PortfolioGroup = 10,

            /// <summary>
            /// Enum Person for value: Person
            /// </summary>
            [EnumMember(Value = "Person")]
            Person = 11,

            /// <summary>
            /// Enum AccessMetadata for value: AccessMetadata
            /// </summary>
            [EnumMember(Value = "AccessMetadata")]
            AccessMetadata = 12,

            /// <summary>
            /// Enum Order for value: Order
            /// </summary>
            [EnumMember(Value = "Order")]
            Order = 13,

            /// <summary>
            /// Enum UnitResult for value: UnitResult
            /// </summary>
            [EnumMember(Value = "UnitResult")]
            UnitResult = 14,

            /// <summary>
            /// Enum MarketData for value: MarketData
            /// </summary>
            [EnumMember(Value = "MarketData")]
            MarketData = 15,

            /// <summary>
            /// Enum ConfigurationRecipe for value: ConfigurationRecipe
            /// </summary>
            [EnumMember(Value = "ConfigurationRecipe")]
            ConfigurationRecipe = 16,

            /// <summary>
            /// Enum Allocation for value: Allocation
            /// </summary>
            [EnumMember(Value = "Allocation")]
            Allocation = 17

        }

        /// <summary>
        /// The domain that the property exists in.
        /// </summary>
        /// <value>The domain that the property exists in.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public DomainEnum? Domain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDefinition" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="key">The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;..</param>
        /// <param name="valueType">The type of values that can be associated with this property. This is defined by the property&#39;s data type..</param>
        /// <param name="valueRequired">Whether or not a value is always required for this property..</param>
        /// <param name="displayName">The display name of the property..</param>
        /// <param name="dataTypeId">dataTypeId.</param>
        /// <param name="lifeTime">Describes how the property&#39;s values can change over time..</param>
        /// <param name="type">The type of the property..</param>
        /// <param name="unitSchema">The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type..</param>
        /// <param name="constraintStyle">Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key..</param>
        /// <param name="links">links.</param>
        public PropertyDefinition(string href = default(string), string key = default(string), ValueTypeEnum? valueType = default(ValueTypeEnum?), bool? valueRequired = default(bool?), string displayName = default(string), ResourceId dataTypeId = default(ResourceId), LifeTimeEnum? lifeTime = default(LifeTimeEnum?), TypeEnum? type = default(TypeEnum?), UnitSchemaEnum? unitSchema = default(UnitSchemaEnum?), string constraintStyle = default(string), List<Link> links = default(List<Link>))
        {
            this.Href = href;
            this.Key = key;
            this.ValueType = valueType;
            this.ValueRequired = valueRequired;
            this.DisplayName = displayName;
            this.DataTypeId = dataTypeId;
            this.LifeTime = lifeTime;
            this.Type = type;
            this.UnitSchema = unitSchema;
            this.ConstraintStyle = constraintStyle;
            this.Links = links;
        }
        
        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;.
        /// </summary>
        /// <value>The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }


        /// <summary>
        /// Whether or not a value is always required for this property.
        /// </summary>
        /// <value>Whether or not a value is always required for this property.</value>
        [DataMember(Name="valueRequired", EmitDefaultValue=false)]
        public bool? ValueRequired { get; set; }

        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DataTypeId
        /// </summary>
        [DataMember(Name="dataTypeId", EmitDefaultValue=false)]
        public ResourceId DataTypeId { get; set; }





        /// <summary>
        /// The scope that the property exists in.
        /// </summary>
        /// <value>The scope that the property exists in.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; private set; }

        /// <summary>
        /// The code of the property. Together with the domain and scope this uniquely identifies the property.
        /// </summary>
        /// <value>The code of the property. Together with the domain and scope this uniquely identifies the property.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; private set; }

        /// <summary>
        /// Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key.
        /// </summary>
        /// <value>Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key.</value>
        [DataMember(Name="constraintStyle", EmitDefaultValue=false)]
        public string ConstraintStyle { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyDefinition {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  ValueRequired: ").Append(ValueRequired).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DataTypeId: ").Append(DataTypeId).Append("\n");
            sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnitSchema: ").Append(UnitSchema).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ConstraintStyle: ").Append(ConstraintStyle).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as PropertyDefinition);
        }

        /// <summary>
        /// Returns true if PropertyDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.ValueRequired == input.ValueRequired ||
                    (this.ValueRequired != null &&
                    this.ValueRequired.Equals(input.ValueRequired))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DataTypeId == input.DataTypeId ||
                    (this.DataTypeId != null &&
                    this.DataTypeId.Equals(input.DataTypeId))
                ) && 
                (
                    this.LifeTime == input.LifeTime ||
                    (this.LifeTime != null &&
                    this.LifeTime.Equals(input.LifeTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UnitSchema == input.UnitSchema ||
                    (this.UnitSchema != null &&
                    this.UnitSchema.Equals(input.UnitSchema))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ConstraintStyle == input.ConstraintStyle ||
                    (this.ConstraintStyle != null &&
                    this.ConstraintStyle.Equals(input.ConstraintStyle))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.ValueRequired != null)
                    hashCode = hashCode * 59 + this.ValueRequired.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DataTypeId != null)
                    hashCode = hashCode * 59 + this.DataTypeId.GetHashCode();
                if (this.LifeTime != null)
                    hashCode = hashCode * 59 + this.LifeTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UnitSchema != null)
                    hashCode = hashCode * 59 + this.UnitSchema.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ConstraintStyle != null)
                    hashCode = hashCode * 59 + this.ConstraintStyle.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
