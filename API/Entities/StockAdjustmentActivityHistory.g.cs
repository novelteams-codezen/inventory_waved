using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stockadjustmentactivityhistory entity with essential details
    /// </summary>
    public class StockAdjustmentActivityHistory
    {
        /// <summary>
        /// Required field TenantId of the StockAdjustmentActivityHistory 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockAdjustmentActivityHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the StockAdjustment to which the StockAdjustmentActivityHistory belongs 
        /// </summary>
        [Required]
        public Guid StockAdjustmentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockAdjustment
        /// </summary>
        [ForeignKey("StockAdjustmentId")]
        public StockAdjustment? StockAdjustmentId_StockAdjustment { get; set; }

        /// <summary>
        /// Required field FromStep of the StockAdjustmentActivityHistory 
        /// </summary>
        [Required]
        public int FromStep { get; set; }
        /// <summary>
        /// ToStep of the StockAdjustmentActivityHistory 
        /// </summary>
        public int? ToStep { get; set; }

        /// <summary>
        /// Required field TransactionDate of the StockAdjustmentActivityHistory 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Required field Description of the StockAdjustmentActivityHistory 
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Required field Active of the StockAdjustmentActivityHistory 
        /// </summary>
        [Required]
        public bool Active { get; set; }
        /// <summary>
        /// Reason of the StockAdjustmentActivityHistory 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the StockAdjustmentActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
        /// <summary>
        /// AssignedUser of the StockAdjustmentActivityHistory 
        /// </summary>
        public Guid? AssignedUser { get; set; }
    }
}