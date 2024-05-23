using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktransferactivityhistory entity with essential details
    /// </summary>
    public class StockTransferActivityHistory
    {
        /// <summary>
        /// Required field TenantId of the StockTransferActivityHistory 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockTransferActivityHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the StockTransfer to which the StockTransferActivityHistory belongs 
        /// </summary>
        [Required]
        public Guid StockTransferId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockTransfer
        /// </summary>
        [ForeignKey("StockTransferId")]
        public StockTransfer? StockTransferId_StockTransfer { get; set; }

        /// <summary>
        /// Required field Step of the StockTransferActivityHistory 
        /// </summary>
        [Required]
        public int Step { get; set; }

        /// <summary>
        /// Required field TransactionDate of the StockTransferActivityHistory 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Required field Active of the StockTransferActivityHistory 
        /// </summary>
        [Required]
        public bool Active { get; set; }
        /// <summary>
        /// Description of the StockTransferActivityHistory 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Reason of the StockTransferActivityHistory 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the StockTransferActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
        /// <summary>
        /// AssignedUser of the StockTransferActivityHistory 
        /// </summary>
        public Guid? AssignedUser { get; set; }
    }
}