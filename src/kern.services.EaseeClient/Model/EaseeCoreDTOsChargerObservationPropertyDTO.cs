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
    /// EaseeCoreDTOsChargerObservationPropertyDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Charger.ObservationPropertyDTO")]
    public partial class EaseeCoreDTOsChargerObservationPropertyDTO : IEquatable<EaseeCoreDTOsChargerObservationPropertyDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public MasterloopCoreTypesBaseDataType? DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsChargerObservationPropertyDTO" /> class.
        /// </summary>
        /// <param name="observationId">observationId.</param>
        /// <param name="name">name.</param>
        /// <param name="dataType">dataType.</param>
        public EaseeCoreDTOsChargerObservationPropertyDTO(int observationId = default(int), string name = default(string), MasterloopCoreTypesBaseDataType? dataType = default(MasterloopCoreTypesBaseDataType?))
        {
            this.ObservationId = observationId;
            this.Name = name;
            this.DataType = dataType;
        }

        /// <summary>
        /// Gets or Sets ObservationId
        /// </summary>
        [DataMember(Name = "observationId", EmitDefaultValue = false)]
        public int ObservationId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsChargerObservationPropertyDTO {\n");
            sb.Append("  ObservationId: ").Append(ObservationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsChargerObservationPropertyDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsChargerObservationPropertyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsChargerObservationPropertyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsChargerObservationPropertyDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObservationId == input.ObservationId ||
                    this.ObservationId.Equals(input.ObservationId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
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
                hashCode = (hashCode * 59) + this.ObservationId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DataType.GetHashCode();
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
