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
    /// EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Site.DynamicCircuitCurrentTtlDto")]
    public partial class EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto : IEquatable<EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto" /> class.
        /// </summary>
        /// <param name="phase1">phase1.</param>
        /// <param name="phase2">phase2.</param>
        /// <param name="phase3">phase3.</param>
        /// <param name="timeToLive">timeToLive.</param>
        public EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto(double? phase1 = default(double?), double? phase2 = default(double?), double? phase3 = default(double?), int? timeToLive = default(int?))
        {
            this.Phase1 = phase1;
            this.Phase2 = phase2;
            this.Phase3 = phase3;
            this.TimeToLive = timeToLive;
        }

        /// <summary>
        /// Gets or Sets Phase1
        /// </summary>
        [DataMember(Name = "phase1", EmitDefaultValue = true)]
        public double? Phase1 { get; set; }

        /// <summary>
        /// Gets or Sets Phase2
        /// </summary>
        [DataMember(Name = "phase2", EmitDefaultValue = true)]
        public double? Phase2 { get; set; }

        /// <summary>
        /// Gets or Sets Phase3
        /// </summary>
        [DataMember(Name = "phase3", EmitDefaultValue = true)]
        public double? Phase3 { get; set; }

        /// <summary>
        /// Gets or Sets TimeToLive
        /// </summary>
        [DataMember(Name = "timeToLive", EmitDefaultValue = true)]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto {\n");
            sb.Append("  Phase1: ").Append(Phase1).Append("\n");
            sb.Append("  Phase2: ").Append(Phase2).Append("\n");
            sb.Append("  Phase3: ").Append(Phase3).Append("\n");
            sb.Append("  TimeToLive: ").Append(TimeToLive).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsSiteDynamicCircuitCurrentTtlDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Phase1 == input.Phase1 ||
                    (this.Phase1 != null &&
                    this.Phase1.Equals(input.Phase1))
                ) && 
                (
                    this.Phase2 == input.Phase2 ||
                    (this.Phase2 != null &&
                    this.Phase2.Equals(input.Phase2))
                ) && 
                (
                    this.Phase3 == input.Phase3 ||
                    (this.Phase3 != null &&
                    this.Phase3.Equals(input.Phase3))
                ) && 
                (
                    this.TimeToLive == input.TimeToLive ||
                    (this.TimeToLive != null &&
                    this.TimeToLive.Equals(input.TimeToLive))
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
                if (this.Phase1 != null)
                {
                    hashCode = (hashCode * 59) + this.Phase1.GetHashCode();
                }
                if (this.Phase2 != null)
                {
                    hashCode = (hashCode * 59) + this.Phase2.GetHashCode();
                }
                if (this.Phase3 != null)
                {
                    hashCode = (hashCode * 59) + this.Phase3.GetHashCode();
                }
                if (this.TimeToLive != null)
                {
                    hashCode = (hashCode * 59) + this.TimeToLive.GetHashCode();
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
