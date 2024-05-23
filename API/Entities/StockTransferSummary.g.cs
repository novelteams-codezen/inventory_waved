using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktransfersummary entity with essential details
    /// </summary>
    public class StockTransferSummary
    {
        /// <summary>
        /// Required field TenantId of the StockTransferSummary 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockTransferSummary 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the StockTransferSummary belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field ProductCode of the StockTransferSummary 
        /// </summary>
        [Required]
        public string ProductCode { get; set; }

        /// <summary>
        /// Required field ProductName of the StockTransferSummary 
        /// </summary>
        [Required]
        public string ProductName { get; set; }

        /// <summary>
        /// Foreign key referencing the ProductBatch to which the StockTransferSummary belongs 
        /// </summary>
        [Required]
        public Guid ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }

        /// <summary>
        /// Required field BatchNumber of the StockTransferSummary 
        /// </summary>
        [Required]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Required field BatchQuantity of the StockTransferSummary 
        /// </summary>
        [Required]
        public int BatchQuantity { get; set; }

        /// <summary>
        /// Required field CostPrice of the StockTransferSummary 
        /// </summary>
        [Required]
        public int CostPrice { get; set; }

        /// <summary>
        /// Required field TransferDate of the StockTransferSummary 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransferDate { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the StockTransferSummary belongs 
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