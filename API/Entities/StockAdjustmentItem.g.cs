using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stockadjustmentitem entity with essential details
    /// </summary>
    public class StockAdjustmentItem
    {
        /// <summary>
        /// Required field TenantId of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockAdjustmentItem 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the StockAdjustment to which the StockAdjustmentItem belongs 
        /// </summary>
        [Required]
        public Guid StockAdjustmentId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockAdjustment
        /// </summary>
        [ForeignKey("StockAdjustmentId")]
        public StockAdjustment? StockAdjustmentId_StockAdjustment { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the StockAdjustmentItem belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductBatch to which the StockAdjustmentItem belongs 
        /// </summary>
        public Guid? ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }

        /// <summary>
        /// Required field AdjustedQuantity of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public int AdjustedQuantity { get; set; }

        /// <summary>
        /// Required field PackUnitPrice of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public int PackUnitPrice { get; set; }

        /// <summary>
        /// Required field CreatedBy of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the StockAdjustmentItem 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StockAdjustmentItem 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StockAdjustmentItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the StockAdjustmentItem belongs 
        /// </summary>
        public Guid? ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }

        /// <summary>
        /// Required field LineRejected of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public bool LineRejected { get; set; }
        /// <summary>
        /// Foreign key referencing the SubReason to which the StockAdjustmentItem belongs 
        /// </summary>
        public Guid? SubReasonId { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubReason
        /// </summary>
        [ForeignKey("SubReasonId")]
        public SubReason? SubReasonId_SubReason { get; set; }

        /// <summary>
        /// Required field LowestUnitQuantity of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public int LowestUnitQuantity { get; set; }
        /// <summary>
        /// RejectReason of the StockAdjustmentItem 
        /// </summary>
        public string? RejectReason { get; set; }

        /// <summary>
        /// Required field AdjustedAmount of the StockAdjustmentItem 
        /// </summary>
        [Required]
        public int AdjustedAmount { get; set; }
        /// <summary>
        /// NewQoh of the StockAdjustmentItem 
        /// </summary>
        public int? NewQoh { get; set; }
    }
}