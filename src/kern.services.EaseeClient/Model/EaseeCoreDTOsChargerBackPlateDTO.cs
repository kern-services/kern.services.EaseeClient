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
    /// EaseeCoreDTOsChargerBackPlateDTO
    /// </summary>
    [DataContract(Name = "Easee.Core.DTOs.Charger.BackPlateDTO")]
    public partial class EaseeCoreDTOsChargerBackPlateDTO : IEquatable<EaseeCoreDTOsChargerBackPlateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EaseeCoreDTOsChargerBackPlateDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="masterBackPlateId">masterBackPlateId.</param>
        /// <param name="name">name.</param>
        /// <param name="features">features.</param>
        public EaseeCoreDTOsChargerBackPlateDTO(string id = default(string), string masterBackPlateId = default(string), string name = default(string), List<EaseeCoreEnumsBackPlateFeature> features = default(List<EaseeCoreEnumsBackPlateFeature>))
        {
            this.Id = id;
            this.MasterBackPlateId = masterBackPlateId;
            this.Name = name;
            this.Features = features;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets MasterBackPlateId
        /// </summary>
        [DataMember(Name = "masterBackPlateId", EmitDefaultValue = true)]
        public string MasterBackPlateId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CircuitId
        /// </summary>
        [DataMember(Name = "circuitId", EmitDefaultValue = true)]
        public int? CircuitId { get; private set; }

        /// <summary>
        /// Returns false as CircuitId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCircuitId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = true)]
        public List<EaseeCoreEnumsBackPlateFeature> Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EaseeCoreDTOsChargerBackPlateDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MasterBackPlateId: ").Append(MasterBackPlateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CircuitId: ").Append(CircuitId).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(input as EaseeCoreDTOsChargerBackPlateDTO);
        }

        /// <summary>
        /// Returns true if EaseeCoreDTOsChargerBackPlateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EaseeCoreDTOsChargerBackPlateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EaseeCoreDTOsChargerBackPlateDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MasterBackPlateId == input.MasterBackPlateId ||
                    (this.MasterBackPlateId != null &&
                    this.MasterBackPlateId.Equals(input.MasterBackPlateId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CircuitId == input.CircuitId ||
                    (this.CircuitId != null &&
                    this.CircuitId.Equals(input.CircuitId))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.MasterBackPlateId != null)
                {
                    hashCode = (hashCode * 59) + this.MasterBackPlateId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CircuitId != null)
                {
                    hashCode = (hashCode * 59) + this.CircuitId.GetHashCode();
                }
                if (this.Features != null)
                {
                    hashCode = (hashCode * 59) + this.Features.GetHashCode();
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
