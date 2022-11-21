/*
 * Easee Cloud API
 *
 * Find more information and documentation at <br/> <a href='https://developer.easee.cloud'>https://developer.easee.cloud</a>
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = kern.services.EaseeClient.Client.OpenAPIDateConverter;

namespace kern.services.EaseeClient.Model
{
    /// <summary>
    /// EaseeCoreDTOsChargerUsageStatisticsDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Charger.UsageStatisticsDTO")]
    public partial class EaseeCoreDTOsChargerUsageStatisticsDTO : IEquatable<EaseeCoreDTOsChargerUsageStatisticsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsChargerUsageStatisticsDTO" /> class.
        /// </summary>
        /// <param name="chargerId">chargerId.</param>
        /// <param name="sessionEnergy">sessionEnergy.</param>
        /// <param name="sessionStart">sessionStart.</param>
        /// <param name="sessionEnd">sessionEnd.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="chargeDurationInSeconds">chargeDurationInSeconds.</param>
        /// <param name="firstEnergyTransferPeriodStart">firstEnergyTransferPeriodStart.</param>
        /// <param name="lastEnergyTransferPeriodEnd">lastEnergyTransferPeriodEnd.</param>
        /// <param name="pricePrKwhIncludingVat">pricePrKwhIncludingVat.</param>
        /// <param name="pricePerKwhExcludingVat">pricePerKwhExcludingVat.</param>
        /// <param name="vatPercentage">vatPercentage.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="costIncludingVat">costIncludingVat.</param>
        /// <param name="costExcludingVat">costExcludingVat.</param>
        public EaseeCoreDTOsChargerUsageStatisticsDTO(string chargerId = default(string), double sessionEnergy = default(double), DateTime? sessionStart = default(DateTime?), DateTime? sessionEnd = default(DateTime?), int? sessionId = default(int?), int? chargeDurationInSeconds = default(int?), DateTime? firstEnergyTransferPeriodStart = default(DateTime?), DateTime? lastEnergyTransferPeriodEnd = default(DateTime?), double? pricePrKwhIncludingVat = default(double?), double? pricePerKwhExcludingVat = default(double?), double? vatPercentage = default(double?), string currencyId = default(string), double? costIncludingVat = default(double?), double? costExcludingVat = default(double?))
        {
            this.ChargerId = chargerId;
            this.SessionEnergy = sessionEnergy;
            this.SessionStart = sessionStart;
            this.SessionEnd = sessionEnd;
            this.SessionId = sessionId;
            this.ChargeDurationInSeconds = chargeDurationInSeconds;
            this.FirstEnergyTransferPeriodStart = firstEnergyTransferPeriodStart;
            this.LastEnergyTransferPeriodEnd = lastEnergyTransferPeriodEnd;
            this.PricePrKwhIncludingVat = pricePrKwhIncludingVat;
            this.PricePerKwhExcludingVat = pricePerKwhExcludingVat;
            this.VatPercentage = vatPercentage;
            this.CurrencyId = currencyId;
            this.CostIncludingVat = costIncludingVat;
            this.CostExcludingVat = costExcludingVat;
        }

        /// <summary>
        /// Gets or Sets ChargerId
        /// </summary>
        [DataMember(Name = "chargerId", EmitDefaultValue = true)]
        public string ChargerId { get; set; }

        /// <summary>
        /// Gets or Sets SessionEnergy
        /// </summary>
        [DataMember(Name = "sessionEnergy", EmitDefaultValue = false)]
        public double SessionEnergy { get; set; }

        /// <summary>
        /// Gets or Sets SessionStart
        /// </summary>
        [DataMember(Name = "sessionStart", EmitDefaultValue = true)]
        public DateTime? SessionStart { get; set; }

        /// <summary>
        /// Gets or Sets SessionEnd
        /// </summary>
        [DataMember(Name = "sessionEnd", EmitDefaultValue = true)]
        public DateTime? SessionEnd { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name = "sessionId", EmitDefaultValue = true)]
        public int? SessionId { get; set; }

        /// <summary>
        /// Gets or Sets ChargeDurationInSeconds
        /// </summary>
        [DataMember(Name = "chargeDurationInSeconds", EmitDefaultValue = true)]
        public int? ChargeDurationInSeconds { get; set; }

        /// <summary>
        /// Gets or Sets FirstEnergyTransferPeriodStart
        /// </summary>
        [DataMember(Name = "firstEnergyTransferPeriodStart", EmitDefaultValue = true)]
        public DateTime? FirstEnergyTransferPeriodStart { get; set; }

        /// <summary>
        /// Gets or Sets LastEnergyTransferPeriodEnd
        /// </summary>
        [DataMember(Name = "lastEnergyTransferPeriodEnd", EmitDefaultValue = true)]
        public DateTime? LastEnergyTransferPeriodEnd { get; set; }

        /// <summary>
        /// Gets or Sets PricePrKwhIncludingVat
        /// </summary>
        [DataMember(Name = "pricePrKwhIncludingVat", EmitDefaultValue = true)]
        public double? PricePrKwhIncludingVat { get; set; }

        /// <summary>
        /// Gets or Sets PricePerKwhExcludingVat
        /// </summary>
        [DataMember(Name = "pricePerKwhExcludingVat", EmitDefaultValue = true)]
        public double? PricePerKwhExcludingVat { get; set; }

        /// <summary>
        /// Gets or Sets VatPercentage
        /// </summary>
        [DataMember(Name = "vatPercentage", EmitDefaultValue = true)]
        public double? VatPercentage { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "currencyId", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets CostIncludingVat
        /// </summary>
        [DataMember(Name = "costIncludingVat", EmitDefaultValue = true)]
        public double? CostIncludingVat { get; set; }

        /// <summary>
        /// Gets or Sets CostExcludingVat
        /// </summary>
        [DataMember(Name = "costExcludingVat", EmitDefaultValue = true)]
        public double? CostExcludingVat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsChargerUsageStatisticsDTO {\n");
            sb.Append("  ChargerId: ").Append(ChargerId).Append("\n");
            sb.Append("  SessionEnergy: ").Append(SessionEnergy).Append("\n");
            sb.Append("  SessionStart: ").Append(SessionStart).Append("\n");
            sb.Append("  SessionEnd: ").Append(SessionEnd).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  ChargeDurationInSeconds: ").Append(ChargeDurationInSeconds).Append("\n");
            sb.Append("  FirstEnergyTransferPeriodStart: ").Append(FirstEnergyTransferPeriodStart).Append("\n");
            sb.Append("  LastEnergyTransferPeriodEnd: ").Append(LastEnergyTransferPeriodEnd).Append("\n");
            sb.Append("  PricePrKwhIncludingVat: ").Append(PricePrKwhIncludingVat).Append("\n");
            sb.Append("  PricePerKwhExcludingVat: ").Append(PricePerKwhExcludingVat).Append("\n");
            sb.Append("  VatPercentage: ").Append(VatPercentage).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CostIncludingVat: ").Append(CostIncludingVat).Append("\n");
            sb.Append("  CostExcludingVat: ").Append(CostExcludingVat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EaseeCoreDTOsChargerUsageStatisticsDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsChargerUsageStatisticsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsChargerUsageStatisticsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsChargerUsageStatisticsDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChargerId == input.ChargerId ||
                    (this.ChargerId != null &&
                    this.ChargerId.Equals(input.ChargerId))
                ) && 
                (
                    this.SessionEnergy == input.SessionEnergy ||
                    this.SessionEnergy.Equals(input.SessionEnergy)
                ) && 
                (
                    this.SessionStart == input.SessionStart ||
                    (this.SessionStart != null &&
                    this.SessionStart.Equals(input.SessionStart))
                ) && 
                (
                    this.SessionEnd == input.SessionEnd ||
                    (this.SessionEnd != null &&
                    this.SessionEnd.Equals(input.SessionEnd))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.ChargeDurationInSeconds == input.ChargeDurationInSeconds ||
                    (this.ChargeDurationInSeconds != null &&
                    this.ChargeDurationInSeconds.Equals(input.ChargeDurationInSeconds))
                ) && 
                (
                    this.FirstEnergyTransferPeriodStart == input.FirstEnergyTransferPeriodStart ||
                    (this.FirstEnergyTransferPeriodStart != null &&
                    this.FirstEnergyTransferPeriodStart.Equals(input.FirstEnergyTransferPeriodStart))
                ) && 
                (
                    this.LastEnergyTransferPeriodEnd == input.LastEnergyTransferPeriodEnd ||
                    (this.LastEnergyTransferPeriodEnd != null &&
                    this.LastEnergyTransferPeriodEnd.Equals(input.LastEnergyTransferPeriodEnd))
                ) && 
                (
                    this.PricePrKwhIncludingVat == input.PricePrKwhIncludingVat ||
                    (this.PricePrKwhIncludingVat != null &&
                    this.PricePrKwhIncludingVat.Equals(input.PricePrKwhIncludingVat))
                ) && 
                (
                    this.PricePerKwhExcludingVat == input.PricePerKwhExcludingVat ||
                    (this.PricePerKwhExcludingVat != null &&
                    this.PricePerKwhExcludingVat.Equals(input.PricePerKwhExcludingVat))
                ) && 
                (
                    this.VatPercentage == input.VatPercentage ||
                    (this.VatPercentage != null &&
                    this.VatPercentage.Equals(input.VatPercentage))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.CostIncludingVat == input.CostIncludingVat ||
                    (this.CostIncludingVat != null &&
                    this.CostIncludingVat.Equals(input.CostIncludingVat))
                ) && 
                (
                    this.CostExcludingVat == input.CostExcludingVat ||
                    (this.CostExcludingVat != null &&
                    this.CostExcludingVat.Equals(input.CostExcludingVat))
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
                if (this.ChargerId != null)
                {
                    hashCode = (hashCode * 59) + this.ChargerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SessionEnergy.GetHashCode();
                if (this.SessionStart != null)
                {
                    hashCode = (hashCode * 59) + this.SessionStart.GetHashCode();
                }
                if (this.SessionEnd != null)
                {
                    hashCode = (hashCode * 59) + this.SessionEnd.GetHashCode();
                }
                if (this.SessionId != null)
                {
                    hashCode = (hashCode * 59) + this.SessionId.GetHashCode();
                }
                if (this.ChargeDurationInSeconds != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeDurationInSeconds.GetHashCode();
                }
                if (this.FirstEnergyTransferPeriodStart != null)
                {
                    hashCode = (hashCode * 59) + this.FirstEnergyTransferPeriodStart.GetHashCode();
                }
                if (this.LastEnergyTransferPeriodEnd != null)
                {
                    hashCode = (hashCode * 59) + this.LastEnergyTransferPeriodEnd.GetHashCode();
                }
                if (this.PricePrKwhIncludingVat != null)
                {
                    hashCode = (hashCode * 59) + this.PricePrKwhIncludingVat.GetHashCode();
                }
                if (this.PricePerKwhExcludingVat != null)
                {
                    hashCode = (hashCode * 59) + this.PricePerKwhExcludingVat.GetHashCode();
                }
                if (this.VatPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.VatPercentage.GetHashCode();
                }
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.CostIncludingVat != null)
                {
                    hashCode = (hashCode * 59) + this.CostIncludingVat.GetHashCode();
                }
                if (this.CostExcludingVat != null)
                {
                    hashCode = (hashCode * 59) + this.CostExcludingVat.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}