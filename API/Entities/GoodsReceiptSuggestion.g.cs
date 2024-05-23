using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptsuggestion entity with essential details
    /// </summary>
    public class GoodsReceiptSuggestion
    {
        /// <summary>
        /// Primary key for the GoodsReceiptSuggestion 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the GoodsReceiptSuggestion 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the GoodsReceiptSuggestion belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the GoodsReceiptSuggestion belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Count of the GoodsReceiptSuggestion 
        /// </summary>
        public int? Count { get; set; }
    }
}