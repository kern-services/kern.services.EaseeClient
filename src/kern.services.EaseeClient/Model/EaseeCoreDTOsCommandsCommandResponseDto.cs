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
    /// EaseeCoreDTOsCommandsCommandResponseDto
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Commands.CommandResponseDto")]
    public partial class EaseeCoreDTOsCommandsCommandResponseDto : IEquatable<EaseeCoreDTOsCommandsCommandResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsCommandsCommandResponseDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="deliveredAt">deliveredAt.</param>
        /// <param name="wasAccepted">wasAccepted.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="comment">comment.</param>
        public EaseeCoreDTOsCommandsCommandResponseDto(int id = default(int), DateTime timestamp = default(DateTime), DateTime? deliveredAt = default(DateTime?), bool wasAccepted = default(bool), int? resultCode = default(int?), string comment = default(string))
        {
            this.Id = id;
            this.Timestamp = timestamp;
            this.DeliveredAt = deliveredAt;
            this.WasAccepted = wasAccepted;
            this.ResultCode = resultCode;
            this.Comment = comment;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets DeliveredAt
        /// </summary>
        [DataMember(Name = "deliveredAt", EmitDefaultValue = true)]
        public DateTime? DeliveredAt { get; set; }

        /// <summary>
        /// Gets or Sets WasAccepted
        /// </summary>
        [DataMember(Name = "wasAccepted", EmitDefaultValue = true)]
        public bool WasAccepted { get; set; }

        /// <summary>
        /// Gets or Sets ResultCode
        /// </summary>
        [DataMember(Name = "resultCode", EmitDefaultValue = true)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Ticks
        /// </summary>
        [DataMember(Name = "ticks", EmitDefaultValue = false)]
        public long Ticks { get; private set; }

        /// <summary>
        /// Returns false as Ticks should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTicks()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsCommandsCommandResponseDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  DeliveredAt: ").Append(DeliveredAt).Append("\n");
            sb.Append("  WasAccepted: ").Append(WasAccepted).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Ticks: ").Append(Ticks).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsCommandsCommandResponseDto);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsCommandsCommandResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsCommandsCommandResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsCommandsCommandResponseDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.DeliveredAt == input.DeliveredAt ||
                    (this.DeliveredAt != null &&
                    this.DeliveredAt.Equals(input.DeliveredAt))
                ) && 
                (
                    this.WasAccepted == input.WasAccepted ||
                    this.WasAccepted.Equals(input.WasAccepted)
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Ticks == input.Ticks ||
                    this.Ticks.Equals(input.Ticks)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.DeliveredAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveredAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WasAccepted.GetHashCode();
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ticks.GetHashCode();
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
