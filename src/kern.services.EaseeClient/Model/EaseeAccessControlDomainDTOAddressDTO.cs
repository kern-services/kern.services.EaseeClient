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
    /// EaseeAccessControlDomainDTOAddressDTO
    /// </summary>
    [DataContract(Name = "Easee.AccessControl.Domain.DTO.AddressDTO")]
    public partial class EaseeAccessControlDomainDTOAddressDTO : IEquatable<EaseeAccessControlDomainDTOAddressDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeAccessControlDomainDTOAddressDTO" /> class.
        /// </summary>
        /// <param name="street">street.</param>
        /// <param name="buildingNumber">buildingNumber.</param>
        /// <param name="zip">zip.</param>
        /// <param name="area">area.</param>
        /// <param name="country">country.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="altitude">altitude.</param>
        public EaseeAccessControlDomainDTOAddressDTO(string street = default(string), string buildingNumber = default(string), string zip = default(string), string area = default(string), EaseeAccessControlDomainEntitiesCountryDTO country = default(EaseeAccessControlDomainEntitiesCountryDTO), double? latitude = default(double?), double? longitude = default(double?), double? altitude = default(double?))
        {
            this.Street = street;
            this.BuildingNumber = buildingNumber;
            this.Zip = zip;
            this.Area = area;
            this.Country = country;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Altitude = altitude;
        }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name = "street", EmitDefaultValue = true)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets BuildingNumber
        /// </summary>
        [DataMember(Name = "buildingNumber", EmitDefaultValue = true)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name = "area", EmitDefaultValue = true)]
        public string Area { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public EaseeAccessControlDomainEntitiesCountryDTO Country { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Altitude
        /// </summary>
        [DataMember(Name = "altitude", EmitDefaultValue = true)]
        public double? Altitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeAccessControlDomainDTOAddressDTO {\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Altitude: ").Append(Altitude).Append("\n");
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
            return this.Equals(input as EaseeAccessControlDomainDTOAddressDTO);
        }

        /// <summary>
        /// Returns true if EaseeAccessControlDomainDTOAddressDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeAccessControlDomainDTOAddressDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeAccessControlDomainDTOAddressDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.BuildingNumber == input.BuildingNumber ||
                    (this.BuildingNumber != null &&
                    this.BuildingNumber.Equals(input.BuildingNumber))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Altitude == input.Altitude ||
                    (this.Altitude != null &&
                    this.Altitude.Equals(input.Altitude))
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
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.BuildingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingNumber.GetHashCode();
                }
                if (this.Zip != null)
                {
                    hashCode = (hashCode * 59) + this.Zip.GetHashCode();
                }
                if (this.Area != null)
                {
                    hashCode = (hashCode * 59) + this.Area.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.Altitude != null)
                {
                    hashCode = (hashCode * 59) + this.Altitude.GetHashCode();
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