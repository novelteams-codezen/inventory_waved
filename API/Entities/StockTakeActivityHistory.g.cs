using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktakeactivityhistory entity with essential details
    /// </summary>
    public class StockTakeActivityHistory
    {
        /// <summary>
        /// Primary key for the StockTakeActivityHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the StockTakeActivityHistory 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Foreign key referencing the StockTake to which the StockTakeActivityHistory belongs 
        /// </summary>
        [Required]
        public Guid StockTakeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockTake
        /// </summary>
        [ForeignKey("StockTakeId")]
        public StockTake? StockTakeId_StockTake { get; set; }

        /// <summary>
        /// Required field Step of the StockTakeActivityHistory 
        /// </summary>
        [Required]
        public int Step { get; set; }

        /// <summary>
        /// Required field TransactionDate of the StockTakeActivityHistory 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Required field Description of the StockTakeActivityHistory 
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Required field Active of the StockTakeActivityHistory 
        /// </summary>
        [Required]
        public bool Active { get; set; }
        /// <summary>
        /// Reason of the StockTakeActivityHistory 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the StockTakeActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
        /// <summary>
        /// AssignedUser of the StockTakeActivityHistory 
        /// </summary>
        public Guid? AssignedUser { get; set; }
    }
}