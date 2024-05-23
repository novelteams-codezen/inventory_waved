using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a requisitionactivityhistory entity with essential details
    /// </summary>
    public class RequisitionActivityHistory
    {
        /// <summary>
        /// Required field TenantId of the RequisitionActivityHistory 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the RequisitionActivityHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Requisition to which the RequisitionActivityHistory belongs 
        /// </summary>
        [Required]
        public Guid RequisitionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Requisition
        /// </summary>
        [ForeignKey("RequisitionId")]
        public Requisition? RequisitionId_Requisition { get; set; }

        /// <summary>
        /// Required field FromStep of the RequisitionActivityHistory 
        /// </summary>
        [Required]
        public int FromStep { get; set; }

        /// <summary>
        /// Required field TransactionDate of the RequisitionActivityHistory 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }
        /// <summary>
        /// Description of the RequisitionActivityHistory 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Required field Active of the RequisitionActivityHistory 
        /// </summary>
        [Required]
        public bool Active { get; set; }
        /// <summary>
        /// Reson of the RequisitionActivityHistory 
        /// </summary>
        public string? Reson { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the RequisitionActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
        /// <summary>
        /// AssignedUser of the RequisitionActivityHistory 
        /// </summary>
        public Guid? AssignedUser { get; set; }
    }
}