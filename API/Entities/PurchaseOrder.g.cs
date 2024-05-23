using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a purchaseorder entity with essential details
    /// </summary>
    public class PurchaseOrder
    {
        /// <summary>
        /// Required field TenantId of the PurchaseOrder 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PurchaseOrder 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Supplier to which the PurchaseOrder belongs 
        /// </summary>
        [Required]
        public Guid SupplierId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Supplier
        /// </summary>
        [ForeignKey("SupplierId")]
        public Supplier? SupplierId_Supplier { get; set; }
        /// <summary>
        /// Code of the PurchaseOrder 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Required field PurchaseOrderDate of the PurchaseOrder 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime PurchaseOrderDate { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the PurchaseOrder belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Required field OrderBy of the PurchaseOrder 
        /// </summary>
        [Required]
        public Guid OrderBy { get; set; }

        /// <summary>
        /// ExpectedDeliveryDate of the PurchaseOrder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// CompletedDate of the PurchaseOrder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDate { get; set; }
        /// <summary>
        /// CreatedBy of the PurchaseOrder 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the PurchaseOrder 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PurchaseOrder 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PurchaseOrder 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// InUsed of the PurchaseOrder 
        /// </summary>
        public bool? InUsed { get; set; }
        /// <summary>
        /// ReceivedStatus of the PurchaseOrder 
        /// </summary>
        public int? ReceivedStatus { get; set; }
        /// <summary>
        /// ReferenceNumber of the PurchaseOrder 
        /// </summary>
        public string? ReferenceNumber { get; set; }
    }
}