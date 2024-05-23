using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a requisition entity with essential details
    /// </summary>
    public class Requisition
    {
        /// <summary>
        /// Required field TenantId of the Requisition 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the Requisition 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field RequisitionDate of the Requisition 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime RequisitionDate { get; set; }

        /// <summary>
        /// Required field Code of the Requisition 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the Requisition belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Required field RequestBy of the Requisition 
        /// </summary>
        [Required]
        public Guid RequestBy { get; set; }
        /// <summary>
        /// StatusReason of the Requisition 
        /// </summary>
        public string? StatusReason { get; set; }
        /// <summary>
        /// CreatedBy of the Requisition 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the Requisition 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Requisition 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Requisition 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}