using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktakeitembatches entity with essential details
    /// </summary>
    public class StockTakeItemBatches
    {
        /// <summary>
        /// Required field TenantId of the StockTakeItemBatches 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockTakeItemBatches 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field StockTakeItemId of the StockTakeItemBatches 
        /// </summary>
        [Required]
        public Guid StockTakeItemId { get; set; }
        /// <summary>
        /// LowestUnitQuantity of the StockTakeItemBatches 
        /// </summary>
        public int? LowestUnitQuantity { get; set; }

        /// <summary>
        /// Foreign key referencing the ProductBatch to which the StockTakeItemBatches belongs 
        /// </summary>
        [Required]
        public Guid ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }
        /// <summary>
        /// Variance of the StockTakeItemBatches 
        /// </summary>
        public int? Variance { get; set; }
        /// <summary>
        /// AverageCost of the StockTakeItemBatches 
        /// </summary>
        public int? AverageCost { get; set; }
        /// <summary>
        /// VarianceValue of the StockTakeItemBatches 
        /// </summary>
        public int? VarianceValue { get; set; }
    }
}