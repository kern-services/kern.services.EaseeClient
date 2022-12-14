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
    /// EaseeAccessControlDomainDTOSiteDTO
    /// </summary>
    [DataContract(Name = "Easee.AccessControl.Domain.DTO.SiteDTO")]
    public partial class EaseeAccessControlDomainDTOSiteDTO : IEquatable<EaseeAccessControlDomainDTOSiteDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LevelOfAccess
        /// </summary>
        [DataMember(Name = "levelOfAccess", EmitDefaultValue = false)]
        public EaseeCoreEnumsLevelOfAccess? LevelOfAccess { get; set; }

        /// <summary>
        /// Gets or Sets SiteType
        /// </summary>
        [DataMember(Name = "siteType", EmitDefaultValue = false)]
        public EaseeCoreConstantsSiteType? SiteType { get; set; }

        /// <summary>
        /// Gets or Sets UserRole
        /// </summary>
        [DataMember(Name = "userRole", EmitDefaultValue = false)]
        public EaseeCoreEnumsSiteUserRole? UserRole { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeAccessControlDomainDTOSiteDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="siteKey">siteKey.</param>
        /// <param name="name">name.</param>
        /// <param name="levelOfAccess">levelOfAccess.</param>
        /// <param name="address">address.</param>
        /// <param name="siteType">siteType.</param>
        /// <param name="ratedCurrent">ratedCurrent.</param>
        /// <param name="partnerId">partnerId.</param>
        /// <param name="circuits">circuits.</param>
        /// <param name="equalizers">equalizers.</param>
        /// <param name="userRole">userRole.</param>
        /// <param name="allowedSiteActions">allowedSiteActions.</param>
        public EaseeAccessControlDomainDTOSiteDTO(int id = default(int), string siteKey = default(string), string name = default(string), EaseeCoreEnumsLevelOfAccess? levelOfAccess = default(EaseeCoreEnumsLevelOfAccess?), EaseeAccessControlDomainDTOAddressDTO address = default(EaseeAccessControlDomainDTOAddressDTO), EaseeCoreConstantsSiteType? siteType = default(EaseeCoreConstantsSiteType?), double ratedCurrent = default(double), int? partnerId = default(int?), List<EaseeAccessControlDomainDTOCircuitDTO> circuits = default(List<EaseeAccessControlDomainDTOCircuitDTO>), List<EaseeCoreDTOsMyProductsEqualizerDTO> equalizers = default(List<EaseeCoreDTOsMyProductsEqualizerDTO>), EaseeCoreEnumsSiteUserRole? userRole = default(EaseeCoreEnumsSiteUserRole?), List<string> allowedSiteActions = default(List<string>))
        {
            this.Id = id;
            this.SiteKey = siteKey;
            this.Name = name;
            this.LevelOfAccess = levelOfAccess;
            this.Address = address;
            this.SiteType = siteType;
            this.RatedCurrent = ratedCurrent;
            this.PartnerId = partnerId;
            this.Circuits = circuits;
            this.Equalizers = equalizers;
            this.UserRole = userRole;
            this.AllowedSiteActions = allowedSiteActions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets SiteKey
        /// </summary>
        [DataMember(Name = "siteKey", EmitDefaultValue = true)]
        public string SiteKey { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public EaseeAccessControlDomainDTOAddressDTO Address { get; set; }

        /// <summary>
        /// Gets or Sets RatedCurrent
        /// </summary>
        [DataMember(Name = "ratedCurrent", EmitDefaultValue = false)]
        public double RatedCurrent { get; set; }

        /// <summary>
        /// Gets or Sets PartnerId
        /// </summary>
        [DataMember(Name = "partnerId", EmitDefaultValue = true)]
        public int? PartnerId { get; set; }

        /// <summary>
        /// Gets or Sets Circuits
        /// </summary>
        [DataMember(Name = "circuits", EmitDefaultValue = true)]
        public List<EaseeAccessControlDomainDTOCircuitDTO> Circuits { get; set; }

        /// <summary>
        /// Gets or Sets Equalizers
        /// </summary>
        [DataMember(Name = "equalizers", EmitDefaultValue = true)]
        public List<EaseeCoreDTOsMyProductsEqualizerDTO> Equalizers { get; set; }

        /// <summary>
        /// Gets or Sets AllowedSiteActions
        /// </summary>
        [DataMember(Name = "allowedSiteActions", EmitDefaultValue = true)]
        public List<string> AllowedSiteActions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeAccessControlDomainDTOSiteDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SiteKey: ").Append(SiteKey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LevelOfAccess: ").Append(LevelOfAccess).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  SiteType: ").Append(SiteType).Append("\n");
            sb.Append("  RatedCurrent: ").Append(RatedCurrent).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  Circuits: ").Append(Circuits).Append("\n");
            sb.Append("  Equalizers: ").Append(Equalizers).Append("\n");
            sb.Append("  UserRole: ").Append(UserRole).Append("\n");
            sb.Append("  AllowedSiteActions: ").Append(AllowedSiteActions).Append("\n");
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
            return this.Equals(input as EaseeAccessControlDomainDTOSiteDTO);
        }

        /// <summary>
        /// Returns true if EaseeAccessControlDomainDTOSiteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeAccessControlDomainDTOSiteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeAccessControlDomainDTOSiteDTO input)
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
                    this.SiteKey == input.SiteKey ||
                    (this.SiteKey != null &&
                    this.SiteKey.Equals(input.SiteKey))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LevelOfAccess == input.LevelOfAccess ||
                    this.LevelOfAccess.Equals(input.LevelOfAccess)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.SiteType == input.SiteType ||
                    this.SiteType.Equals(input.SiteType)
                ) && 
                (
                    this.RatedCurrent == input.RatedCurrent ||
                    this.RatedCurrent.Equals(input.RatedCurrent)
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.Circuits == input.Circuits ||
                    this.Circuits != null &&
                    input.Circuits != null &&
                    this.Circuits.SequenceEqual(input.Circuits)
                ) && 
                (
                    this.Equalizers == input.Equalizers ||
                    this.Equalizers != null &&
                    input.Equalizers != null &&
                    this.Equalizers.SequenceEqual(input.Equalizers)
                ) && 
                (
                    this.UserRole == input.UserRole ||
                    this.UserRole.Equals(input.UserRole)
                ) && 
                (
                    this.AllowedSiteActions == input.AllowedSiteActions ||
                    this.AllowedSiteActions != null &&
                    input.AllowedSiteActions != null &&
                    this.AllowedSiteActions.SequenceEqual(input.AllowedSiteActions)
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
                if (this.SiteKey != null)
                {
                    hashCode = (hashCode * 59) + this.SiteKey.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LevelOfAccess.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SiteType.GetHashCode();
                hashCode = (hashCode * 59) + this.RatedCurrent.GetHashCode();
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.Circuits != null)
                {
                    hashCode = (hashCode * 59) + this.Circuits.GetHashCode();
                }
                if (this.Equalizers != null)
                {
                    hashCode = (hashCode * 59) + this.Equalizers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserRole.GetHashCode();
                if (this.AllowedSiteActions != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedSiteActions.GetHashCode();
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
