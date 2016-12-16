/*
 * REST API Documentation for Schoolbus
 *
 * API Sample
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SchoolBusAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FavoriteContextType :  IEquatable<FavoriteContextType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteContextType" /> class.
        /// </summary>
        /// <param name="Id">Primary Key (required).</param>
        /// <param name="Name">Context Name.</param>
        public FavoriteContextType(int Id, string Name = null)
        {
            
            this.Id = Id;            
            this.Name = Name;
            
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        /// <value>Primary Key</value>
        [DataMember(Name="id")]
        [MetaDataExtension (Description = "Primary Key")]        
        public int Id { get; set; }

        /// <summary>
        /// Context Name
        /// </summary>
        /// <value>Context Name</value>
        [DataMember(Name="Name")]
        [MetaDataExtension (Description = "Context Name")]        
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavoriteContextType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != GetType()) { return false; }
            return Equals((FavoriteContextType)obj);
        }

        /// <summary>
        /// Returns true if FavoriteContextType instances are equal
        /// </summary>
        /// <param name="other">Instance of FavoriteContextType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FavoriteContextType other)
        {

            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks 
                    if (this.Id != null)
                    { 
                        hash = hash * 59 + this.Id.GetHashCode();
                    }
                    if (this.Name != null)
                    { 
                        hash = hash * 59 + this.Name.GetHashCode();
                    }
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(FavoriteContextType left, FavoriteContextType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FavoriteContextType left, FavoriteContextType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}