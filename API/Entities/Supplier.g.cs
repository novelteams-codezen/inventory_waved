using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a supplier entity with essential details
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// TenantId of the Supplier 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Supplier 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Supplier 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Supplier 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// ContactName of the Supplier 
        /// </summary>
        public string? ContactName { get; set; }
        /// <summary>
        /// MobileNumber of the Supplier 
        /// </summary>
        public string? MobileNumber { get; set; }
        /// <summary>
        /// EmailAddress of the Supplier 
        /// </summary>
        public string? EmailAddress { get; set; }
        /// <summary>
        /// AddressLine1 of the Supplier 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Supplier 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// StateId of the Supplier 
        /// </summary>
        public string? StateId { get; set; }
        /// <summary>
        /// CityId of the Supplier 
        /// </summary>
        public string? CityId { get; set; }

        /// <summary>
        /// Required field CountryId of the Supplier 
        /// </summary>
        [Required]
        public string CountryId { get; set; }
        /// <summary>
        /// PostalCode of the Supplier 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// Description of the Supplier 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Supplier 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Supplier 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Supplier 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Supplier 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}