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
    /// EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy
    /// </summary>
    [DataContract(Name = "Easee.Services.LifetimeEnergyReporting.AggregatedLifetimeEnergy")]
    public partial class EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy : IEquatable<EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="month">month.</param>
        /// <param name="day">day.</param>
        /// <param name="hour">hour.</param>
        /// <param name="consumption">consumption.</param>
        /// <param name="date">date.</param>
        public EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy(int year = default(int), int? month = default(int?), int? day = default(int?), int? hour = default(int?), double consumption = default(double), DateTime date = default(DateTime))
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Hour = hour;
            this.Consumption = consumption;
            this.Date = date;
        }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = true)]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = true)]
        public int? Day { get; set; }

        /// <summary>
        /// Gets or Sets Hour
        /// </summary>
        [DataMember(Name = "hour", EmitDefaultValue = true)]
        public int? Hour { get; set; }

        /// <summary>
        /// Gets or Sets Consumption
        /// </summary>
        [DataMember(Name = "consumption", EmitDefaultValue = false)]
        public double Consumption { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Consumption: ").Append(Consumption).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy);
        }

        /// <summary>
        /// Returns true if EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeServicesLifetimeEnergyReportingAggregatedLifetimeEnergy input)
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
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.Hour == input.Hour ||
                    (this.Hour != null &&
                    this.Hour.Equals(input.Hour))
                ) && 
                (
                    this.Consumption == input.Consumption ||
                    this.Consumption.Equals(input.Consumption)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Month != null)
                {
                    hashCode = (hashCode * 59) + this.Month.GetHashCode();
                }
                if (this.Day != null)
                {
                    hashCode = (hashCode * 59) + this.Day.GetHashCode();
                }
                if (this.Hour != null)
                {
                    hashCode = (hashCode * 59) + this.Hour.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Consumption.GetHashCode();
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
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
