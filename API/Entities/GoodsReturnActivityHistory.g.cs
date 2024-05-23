using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a goodsreturnactivityhistory entity with essential details
    /// </summary>
    public class GoodsReturnActivityHistory
    {
        /// <summary>
        /// Required field TenantId of the GoodsReturnActivityHistory 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReturnActivityHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the GoodsReturn to which the GoodsReturnActivityHistory belongs 
        /// </summary>
        [Required]
        public Guid GoodsReturnId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReturn
        /// </summary>
        [ForeignKey("GoodsReturnId")]
        public GoodsReturn? GoodsReturnId_GoodsReturn { get; set; }

        /// <summary>
        /// Required field Step of the GoodsReturnActivityHistory 
        /// </summary>
        [Required]
        public int Step { get; set; }

        /// <summary>
        /// Required field TransactionDate of the GoodsReturnActivityHistory 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Foreign key referencing the Transaction to which the GoodsReturnActivityHistory belongs 
        /// </summary>
        [Required]
        public Guid TransactionBy { get; set; }

        /// <summary>
        /// Navigation property representing the associated Transaction
        /// </summary>
        [ForeignKey("TransactionBy")]
        public Transaction? TransactionBy_Transaction { get; set; }

        /// <summary>
        /// Required field Active of the GoodsReturnActivityHistory 
        /// </summary>
        [Required]
        public bool Active { get; set; }
        /// <summary>
        /// ContinueWithoutAssign of the GoodsReturnActivityHistory 
        /// </summary>
        public bool? ContinueWithoutAssign { get; set; }
        /// <summary>
        /// AssignedUser of the GoodsReturnActivityHistory 
        /// </summary>
        public Guid? AssignedUser { get; set; }
    }
}