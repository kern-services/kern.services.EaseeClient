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
    /// EaseeCoreDTOsPartnersPartnerDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Partners.PartnerDTO")]
    public partial class EaseeCoreDTOsPartnersPartnerDTO : IEquatable<EaseeCoreDTOsPartnersPartnerDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsPartnersPartnerDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="_short">_short.</param>
        /// <param name="_long">_long.</param>
        /// <param name="bigImage">bigImage.</param>
        /// <param name="smallImage">smallImage.</param>
        public EaseeCoreDTOsPartnersPartnerDTO(int id = default(int), string name = default(string), string _short = default(string), string _long = default(string), string bigImage = default(string), string smallImage = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Short = _short;
            this.Long = _long;
            this.BigImage = bigImage;
            this.SmallImage = smallImage;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Short
        /// </summary>
        [DataMember(Name = "short", EmitDefaultValue = true)]
        public string Short { get; set; }

        /// <summary>
        /// Gets or Sets Long
        /// </summary>
        [DataMember(Name = "long", EmitDefaultValue = true)]
        public string Long { get; set; }

        /// <summary>
        /// Gets or Sets BigImage
        /// </summary>
        [DataMember(Name = "bigImage", EmitDefaultValue = true)]
        public string BigImage { get; set; }

        /// <summary>
        /// Gets or Sets SmallImage
        /// </summary>
        [DataMember(Name = "smallImage", EmitDefaultValue = true)]
        public string SmallImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsPartnersPartnerDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Short: ").Append(Short).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
            sb.Append("  BigImage: ").Append(BigImage).Append("\n");
            sb.Append("  SmallImage: ").Append(SmallImage).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsPartnersPartnerDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsPartnersPartnerDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsPartnersPartnerDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsPartnersPartnerDTO input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Short == input.Short ||
                    (this.Short != null &&
                    this.Short.Equals(input.Short))
                ) && 
                (
                    this.Long == input.Long ||
                    (this.Long != null &&
                    this.Long.Equals(input.Long))
                ) && 
                (
                    this.BigImage == input.BigImage ||
                    (this.BigImage != null &&
                    this.BigImage.Equals(input.BigImage))
                ) && 
                (
                    this.SmallImage == input.SmallImage ||
                    (this.SmallImage != null &&
                    this.SmallImage.Equals(input.SmallImage))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Short != null)
                {
                    hashCode = (hashCode * 59) + this.Short.GetHashCode();
                }
                if (this.Long != null)
                {
                    hashCode = (hashCode * 59) + this.Long.GetHashCode();
                }
                if (this.BigImage != null)
                {
                    hashCode = (hashCode * 59) + this.BigImage.GetHashCode();
                }
                if (this.SmallImage != null)
                {
                    hashCode = (hashCode * 59) + this.SmallImage.GetHashCode();
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
