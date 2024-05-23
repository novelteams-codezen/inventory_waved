using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a location entity with essential details
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Primary key for the Location 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the Location 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field Code of the Location 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the Location 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// CountryCode of the Location 
        /// </summary>
        public int? CountryCode { get; set; }
        /// <summary>
        /// MobileNumber of the Location 
        /// </summary>
        public string? MobileNumber { get; set; }
        /// <summary>
        /// EmailAddress of the Location 
        /// </summary>
        public string? EmailAddress { get; set; }
        /// <summary>
        /// AddressLine1 of the Location 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Location 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// StateId of the Location 
        /// </summary>
        public string? StateId { get; set; }
        /// <summary>
        /// CityId of the Location 
        /// </summary>
        public string? CityId { get; set; }
        /// <summary>
        /// CountryId of the Location 
        /// </summary>
        public string? CountryId { get; set; }
        /// <summary>
        /// PostalCode of the Location 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// Enable of the Location 
        /// </summary>
        public bool? Enable { get; set; }
        /// <summary>
        /// CreatedBy of the Location 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the Location 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Location 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Location 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// DrugLicence of the Location 
        /// </summary>
        public string? DrugLicence { get; set; }
        /// <summary>
        /// FssaiNumber of the Location 
        /// </summary>
        public string? FssaiNumber { get; set; }
        /// <summary>
        /// TaxEnable of the Location 
        /// </summary>
        public bool? TaxEnable { get; set; }
        /// <summary>
        /// GstinNumber of the Location 
        /// </summary>
        public string? GstinNumber { get; set; }
        /// <summary>
        /// LocationRole of the Location 
        /// </summary>
        public int? LocationRole { get; set; }
        /// <summary>
        /// ClinicTypeId of the Location 
        /// </summary>
        public string? ClinicTypeId { get; set; }
        /// <summary>
        /// OpeningBalanceDone of the Location 
        /// </summary>
        public bool? OpeningBalanceDone { get; set; }
    }
}