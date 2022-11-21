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
    /// EaseeCoreDTOsSessionHourlySummaryDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Session.HourlySummaryDTO")]
    public partial class EaseeCoreDTOsSessionHourlySummaryDTO : IEquatable<EaseeCoreDTOsSessionHourlySummaryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsSessionHourlySummaryDTO" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="month">month.</param>
        /// <param name="totalEnergyUsage">totalEnergyUsage.</param>
        /// <param name="totalCost">totalCost.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="authTokensUsage">authTokensUsage.</param>
        /// <param name="dayOfMonth">dayOfMonth.</param>
        /// <param name="hourOfDay">hourOfDay.</param>
        public EaseeCoreDTOsSessionHourlySummaryDTO(int year = default(int), int month = default(int), double totalEnergyUsage = default(double), double totalCost = default(double), string currencyId = default(string), List<EaseeCoreDTOsSessionAuthorizationTokenEnergy> authTokensUsage = default(List<EaseeCoreDTOsSessionAuthorizationTokenEnergy>), int dayOfMonth = default(int), int hourOfDay = default(int))
        {
            this.Year = year;
            this.Month = month;
            this.TotalEnergyUsage = totalEnergyUsage;
            this.TotalCost = totalCost;
            this.CurrencyId = currencyId;
            this.AuthTokensUsage = authTokensUsage;
            this.DayOfMonth = dayOfMonth;
            this.HourOfDay = hourOfDay;
        }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets TotalEnergyUsage
        /// </summary>
        [DataMember(Name = "totalEnergyUsage", EmitDefaultValue = false)]
        public double TotalEnergyUsage { get; set; }

        /// <summary>
        /// Gets or Sets TotalCost
        /// </summary>
        [DataMember(Name = "totalCost", EmitDefaultValue = false)]
        public double TotalCost { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "currencyId", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets AuthTokensUsage
        /// </summary>
        [DataMember(Name = "authTokensUsage", EmitDefaultValue = true)]
        public List<EaseeCoreDTOsSessionAuthorizationTokenEnergy> AuthTokensUsage { get; set; }

        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        [DataMember(Name = "dayOfMonth", EmitDefaultValue = false)]
        public int DayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets HourOfDay
        /// </summary>
        [DataMember(Name = "hourOfDay", EmitDefaultValue = false)]
        public int HourOfDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsSessionHourlySummaryDTO {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  TotalEnergyUsage: ").Append(TotalEnergyUsage).Append("\n");
            sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  AuthTokensUsage: ").Append(AuthTokensUsage).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  HourOfDay: ").Append(HourOfDay).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsSessionHourlySummaryDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsSessionHourlySummaryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsSessionHourlySummaryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsSessionHourlySummaryDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) && 
                (
                    this.Month == input.Month ||
                    this.Month.Equals(input.Month)
                ) && 
                (
                    this.TotalEnergyUsage == input.TotalEnergyUsage ||
                    this.TotalEnergyUsage.Equals(input.TotalEnergyUsage)
                ) && 
                (
                    this.TotalCost == input.TotalCost ||
                    this.TotalCost.Equals(input.TotalCost)
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.AuthTokensUsage == input.AuthTokensUsage ||
                    this.AuthTokensUsage != null &&
                    input.AuthTokensUsage != null &&
                    this.AuthTokensUsage.SequenceEqual(input.AuthTokensUsage)
                ) && 
                (
                    this.DayOfMonth == input.DayOfMonth ||
                    this.DayOfMonth.Equals(input.DayOfMonth)
                ) && 
                (
                    this.HourOfDay == input.HourOfDay ||
                    this.HourOfDay.Equals(input.HourOfDay)
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
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
                hashCode = (hashCode * 59) + this.Month.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalEnergyUsage.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalCost.GetHashCode();
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.AuthTokensUsage != null)
                {
                    hashCode = (hashCode * 59) + this.AuthTokensUsage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DayOfMonth.GetHashCode();
                hashCode = (hashCode * 59) + this.HourOfDay.GetHashCode();
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
