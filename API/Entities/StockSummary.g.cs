using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocksummary entity with essential details
    /// </summary>
    public class StockSummary
    {
        /// <summary>
        /// Required field TenantId of the StockSummary 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockSummary 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field StartDate of the StockSummary 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Required field EndDate of the StockSummary 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the StockSummary belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field ProductCode of the StockSummary 
        /// </summary>
        [Required]
        public string ProductCode { get; set; }

        /// <summary>
        /// Required field ProductName of the StockSummary 
        /// </summary>
        [Required]
        public string ProductName { get; set; }

        /// <summary>
        /// Required field UomId of the StockSummary 
        /// </summary>
        [Required]
        public Guid UomId { get; set; }

        /// <summary>
        /// Required field UomName of the StockSummary 
        /// </summary>
        [Required]
        public string UomName { get; set; }

        /// <summary>
        /// Foreign key referencing the ProductBatch to which the StockSummary belongs 
        /// </summary>
        [Required]
        public Guid ProductBatchId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductBatch
        /// </summary>
        [ForeignKey("ProductBatchId")]
        public ProductBatch? ProductBatchId_ProductBatch { get; set; }

        /// <summary>
        /// Required field BatchNumber of the StockSummary 
        /// </summary>
        [Required]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the StockSummary belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Required field OpeningQuantity of the StockSummary 
        /// </summary>
        [Required]
        public int OpeningQuantity { get; set; }

        /// <summary>
        /// Required field ClosingQuantity of the StockSummary 
        /// </summary>
        [Required]
        public int ClosingQuantity { get; set; }

        /// <summary>
        /// Required field OpeningCostPrice of the StockSummary 
        /// </summary>
        [Required]
        public int OpeningCostPrice { get; set; }

        /// <summary>
        /// Required field ClosingCostPrice of the StockSummary 
        /// </summary>
        [Required]
        public int ClosingCostPrice { get; set; }
    }
}