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
    /// EaseeCoreDTOsEqualizerChildDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Equalizer.ChildDTO")]
    public partial class EaseeCoreDTOsEqualizerChildDTO : IEquatable<EaseeCoreDTOsEqualizerChildDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsEqualizerChildDTO" /> class.
        /// </summary>
        /// <param name="scid">scid.</param>
        /// <param name="fuse">fuse.</param>
        /// <param name="cid">cid.</param>
        /// <param name="oflc">oflc.</param>
        public EaseeCoreDTOsEqualizerChildDTO(string scid = default(string), int fuse = default(int), int cid = default(int), int oflc = default(int))
        {
            this.Scid = scid;
            this.Fuse = fuse;
            this.Cid = cid;
            this.Oflc = oflc;
        }

        /// <summary>
        /// Gets or Sets Scid
        /// </summary>
        [DataMember(Name = "scid", EmitDefaultValue = true)]
        public string Scid { get; set; }

        /// <summary>
        /// Gets or Sets Fuse
        /// </summary>
        [DataMember(Name = "fuse", EmitDefaultValue = false)]
        public int Fuse { get; set; }

        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name = "cid", EmitDefaultValue = false)]
        public int Cid { get; set; }

        /// <summary>
        /// Gets or Sets Oflc
        /// </summary>
        [DataMember(Name = "oflc", EmitDefaultValue = false)]
        public int Oflc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsEqualizerChildDTO {\n");
            sb.Append("  Scid: ").Append(Scid).Append("\n");
            sb.Append("  Fuse: ").Append(Fuse).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Oflc: ").Append(Oflc).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsEqualizerChildDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsEqualizerChildDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsEqualizerChildDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsEqualizerChildDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scid == input.Scid ||
                    (this.Scid != null &&
                    this.Scid.Equals(input.Scid))
                ) && 
                (
                    this.Fuse == input.Fuse ||
                    this.Fuse.Equals(input.Fuse)
                ) && 
                (
                    this.Cid == input.Cid ||
                    this.Cid.Equals(input.Cid)
                ) && 
                (
                    this.Oflc == input.Oflc ||
                    this.Oflc.Equals(input.Oflc)
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
                if (this.Scid != null)
                {
                    hashCode = (hashCode * 59) + this.Scid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Fuse.GetHashCode();
                hashCode = (hashCode * 59) + this.Cid.GetHashCode();
                hashCode = (hashCode * 59) + this.Oflc.GetHashCode();
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