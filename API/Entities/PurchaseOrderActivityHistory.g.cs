using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a purchaseorderactivityhistory entity with essential details
    /// </summary>
    public class PurchaseOrderActivityHistory
    {
        /// <summary>
        /// Required field TenantId of the PurchaseOrderActivityHistory 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PurchaseOrderActivityHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the PurchaseOrder to which the PurchaseOrderActivityHistory belongs 
        /// </summary>
        [Required]
        public Guid PurchaseOrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PurchaseOrder
        /// </summary>
        [ForeignKey("PurchaseOrderId")]
        public PurchaseOrder? PurchaseOrderId_PurchaseOrder { get; set; }

        /// <summary>
        /// Required field FromStep of the PurchaseOrderActivityHistory 
        /// </summary>
        [Required]
        public int FromStep { get; set; }
        /// <summary>
        /// ToStep of the PurchaseOrderActivityHistory 
        /// </summary>
        public int? ToStep { get; set; }

        /// <summary>
        /// Required field TransactionDate of the PurchaseOrderActivityHistory 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }
        /// <summary>
        /// Description of the PurchaseOrderActivityHistory 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Required field Active of the PurchaseOrderActivityHistory 
        /// </summary>
        [Required]
        public bool Active { get; set; }
        /// <summary>
        /// Reason of the PurchaseOrderActivityHistory 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the PurchaseOrderActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
        /// <summary>
        /// AssignedUser of the PurchaseOrderActivityHistory 
        /// </summary>
        public Guid? AssignedUser { get; set; }
    }
}