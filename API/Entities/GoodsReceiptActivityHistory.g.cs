using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptactivityhistory entity with essential details
    /// </summary>
    public class GoodsReceiptActivityHistory
    {
        /// <summary>
        /// Required field TenantId of the GoodsReceiptActivityHistory 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReceiptActivityHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceipt to which the GoodsReceiptActivityHistory belongs 
        /// </summary>
        public Guid? GoodsReceiptId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceipt
        /// </summary>
        [ForeignKey("GoodsReceiptId")]
        public GoodsReceipt? GoodsReceiptId_GoodsReceipt { get; set; }
        /// <summary>
        /// FromStep of the GoodsReceiptActivityHistory 
        /// </summary>
        public int? FromStep { get; set; }
        /// <summary>
        /// ToStep of the GoodsReceiptActivityHistory 
        /// </summary>
        public int? ToStep { get; set; }

        /// <summary>
        /// TransactionDate of the GoodsReceiptActivityHistory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Transaction to which the GoodsReceiptActivityHistory belongs 
        /// </summary>
        public Guid? TransactionBy { get; set; }

        /// <summary>
        /// Navigation property representing the associated Transaction
        /// </summary>
        [ForeignKey("TransactionBy")]
        public Transaction? TransactionBy_Transaction { get; set; }
        /// <summary>
        /// Description of the GoodsReceiptActivityHistory 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Active of the GoodsReceiptActivityHistory 
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// Reason of the GoodsReceiptActivityHistory 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the GoodsReceiptActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
        /// <summary>
        /// AssignedUser of the GoodsReceiptActivityHistory 
        /// </summary>
        public Guid? AssignedUser { get; set; }
    }
}