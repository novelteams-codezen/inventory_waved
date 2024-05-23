using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptsummary entity with essential details
    /// </summary>
    public class GoodsReceiptSummary
    {
        /// <summary>
        /// Required field TenantId of the GoodsReceiptSummary 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReceiptSummary 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the GoodsReceiptSummary belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// ProductCode of the GoodsReceiptSummary 
        /// </summary>
        public string? ProductCode { get; set; }
        /// <summary>
        /// ProductName of the GoodsReceiptSummary 
        /// </summary>
        public string? ProductName { get; set; }

        /// <summary>
        /// Foreign key referencing the ProductBatch to which the GoodsReceiptSummary belongs 
        /// </summary>
        [Required]
        public Guid ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }

        /// <summary>
        /// Required field BatchNumber of the GoodsReceiptSummary 
        /// </summary>
        [Required]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Required field BatchQuantity of the GoodsReceiptSummary 
        /// </summary>
        [Required]
        public int BatchQuantity { get; set; }

        /// <summary>
        /// Required field CostPrice of the GoodsReceiptSummary 
        /// </summary>
        [Required]
        public int CostPrice { get; set; }

        /// <summary>
        /// Required field ReceiptDate of the GoodsReceiptSummary 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ReceiptDate { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the GoodsReceiptSummary belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
    }
}