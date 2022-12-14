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
    /// EaseeSiteStructureDomainPortsSiteCircuitDTO
    /// </summary>
    [DataContract(Name = "Easee.SiteStructure.Domain.Ports.SiteCircuitDTO")]
    public partial class EaseeSiteStructureDomainPortsSiteCircuitDTO : IEquatable<EaseeSiteStructureDomainPortsSiteCircuitDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeSiteStructureDomainPortsSiteCircuitDTO" /> class.
        /// </summary>
        /// <param name="circuitName">circuitName.</param>
        /// <param name="siteKey">siteKey.</param>
        public EaseeSiteStructureDomainPortsSiteCircuitDTO(string circuitName = default(string), string siteKey = default(string))
        {
            this.CircuitName = circuitName;
            this.SiteKey = siteKey;
        }

        /// <summary>
        /// Gets or Sets CircuitName
        /// </summary>
        [DataMember(Name = "circuitName", EmitDefaultValue = true)]
        public string CircuitName { get; set; }

        /// <summary>
        /// Gets or Sets SiteKey
        /// </summary>
        [DataMember(Name = "siteKey", EmitDefaultValue = true)]
        public string SiteKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeSiteStructureDomainPortsSiteCircuitDTO {\n");
            sb.Append("  CircuitName: ").Append(CircuitName).Append("\n");
            sb.Append("  SiteKey: ").Append(SiteKey).Append("\n");
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
            return this.Equals(input as EaseeSiteStructureDomainPortsSiteCircuitDTO);
        }

        /// <summary>
        /// Returns true if EaseeSiteStructureDomainPortsSiteCircuitDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeSiteStructureDomainPortsSiteCircuitDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeSiteStructureDomainPortsSiteCircuitDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CircuitName == input.CircuitName ||
                    (this.CircuitName != null &&
                    this.CircuitName.Equals(input.CircuitName))
                ) && 
                (
                    this.SiteKey == input.SiteKey ||
                    (this.SiteKey != null &&
                    this.SiteKey.Equals(input.SiteKey))
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
                if (this.CircuitName != null)
                {
                    hashCode = (hashCode * 59) + this.CircuitName.GetHashCode();
                }
                if (this.SiteKey != null)
                {
                    hashCode = (hashCode * 59) + this.SiteKey.GetHashCode();
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
