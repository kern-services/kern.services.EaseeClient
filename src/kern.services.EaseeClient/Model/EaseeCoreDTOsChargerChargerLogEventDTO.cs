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
    /// EaseeCoreDTOsChargerChargerLogEventDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Charger.ChargerLogEventDTO")]
    public partial class EaseeCoreDTOsChargerChargerLogEventDTO : IEquatable<EaseeCoreDTOsChargerChargerLogEventDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LogTypeId
        /// </summary>
        [DataMember(Name = "logTypeId", EmitDefaultValue = false)]
        public EaseeCoreEnumsLogType? LogTypeId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsChargerChargerLogEventDTO" /> class.
        /// </summary>
        /// <param name="logTypeId">logTypeId.</param>
        /// <param name="logType">logType.</param>
        /// <param name="logValue">logValue.</param>
        /// <param name="timestamp">timestamp.</param>
        public EaseeCoreDTOsChargerChargerLogEventDTO(EaseeCoreEnumsLogType? logTypeId = default(EaseeCoreEnumsLogType?), string logType = default(string), string logValue = default(string), DateTime timestamp = default(DateTime))
        {
            this.LogTypeId = logTypeId;
            this.LogType = logType;
            this.LogValue = logValue;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Gets or Sets LogType
        /// </summary>
        [DataMember(Name = "logType", EmitDefaultValue = true)]
        public string LogType { get; set; }

        /// <summary>
        /// Gets or Sets LogValue
        /// </summary>
        [DataMember(Name = "logValue", EmitDefaultValue = true)]
        public string LogValue { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsChargerChargerLogEventDTO {\n");
            sb.Append("  LogTypeId: ").Append(LogTypeId).Append("\n");
            sb.Append("  LogType: ").Append(LogType).Append("\n");
            sb.Append("  LogValue: ").Append(LogValue).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsChargerChargerLogEventDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsChargerChargerLogEventDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsChargerChargerLogEventDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsChargerChargerLogEventDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogTypeId == input.LogTypeId ||
                    this.LogTypeId.Equals(input.LogTypeId)
                ) && 
                (
                    this.LogType == input.LogType ||
                    (this.LogType != null &&
                    this.LogType.Equals(input.LogType))
                ) && 
                (
                    this.LogValue == input.LogValue ||
                    (this.LogValue != null &&
                    this.LogValue.Equals(input.LogValue))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                hashCode = (hashCode * 59) + this.LogTypeId.GetHashCode();
                if (this.LogType != null)
                {
                    hashCode = (hashCode * 59) + this.LogType.GetHashCode();
                }
                if (this.LogValue != null)
                {
                    hashCode = (hashCode * 59) + this.LogValue.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
