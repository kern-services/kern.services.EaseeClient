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
    /// EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Schedule.WeeklyChargeScheduleResponseDTO")]
    public partial class EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO : IEquatable<EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="tags">tags.</param>
        /// <param name="days">days.</param>
        public EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO(bool isEnabled = default(bool), List<EaseeCoreEnumsChargeScheduleTag> tags = default(List<EaseeCoreEnumsChargeScheduleTag>), List<EaseeCoreDTOsScheduleWeeklyChargeScheduleDateDTO> days = default(List<EaseeCoreDTOsScheduleWeeklyChargeScheduleDateDTO>))
        {
            this.IsEnabled = isEnabled;
            this.Tags = tags;
            this.Days = days;
        }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<EaseeCoreEnumsChargeScheduleTag> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name = "days", EmitDefaultValue = true)]
        public List<EaseeCoreDTOsScheduleWeeklyChargeScheduleDateDTO> Days { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsScheduleWeeklyChargeScheduleResponseDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    input.Days != null &&
                    this.Days.SequenceEqual(input.Days)
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
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Days != null)
                {
                    hashCode = (hashCode * 59) + this.Days.GetHashCode();
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