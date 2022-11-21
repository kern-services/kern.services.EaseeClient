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
    /// EaseeCoreDTOsEqualizerChildReportDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Equalizer.ChildReportDTO")]
    public partial class EaseeCoreDTOsEqualizerChildReportDTO : IEquatable<EaseeCoreDTOsEqualizerChildReportDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsEqualizerChildReportDTO" /> class.
        /// </summary>
        /// <param name="modified">modified.</param>
        /// <param name="children">children.</param>
        public EaseeCoreDTOsEqualizerChildReportDTO(bool? modified = default(bool?), List<EaseeCoreDTOsEqualizerChildDTO> children = default(List<EaseeCoreDTOsEqualizerChildDTO>))
        {
            this.Modified = modified;
            this.Children = children;
        }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = true)]
        public bool? Modified { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = true)]
        public List<EaseeCoreDTOsEqualizerChildDTO> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsEqualizerChildReportDTO {\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsEqualizerChildReportDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsEqualizerChildReportDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsEqualizerChildReportDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsEqualizerChildReportDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
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
                if (this.Modified != null)
                {
                    hashCode = (hashCode * 59) + this.Modified.GetHashCode();
                }
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
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
