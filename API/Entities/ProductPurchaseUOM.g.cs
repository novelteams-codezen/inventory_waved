using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productpurchaseuom entity with essential details
    /// </summary>
    public class ProductPurchaseUOM
    {
        /// <summary>
        /// Required field TenantId of the ProductPurchaseUOM 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductPurchaseUOM 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the ProductPurchaseUOM belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Foreign key referencing the UOM to which the ProductPurchaseUOM belongs 
        /// </summary>
        [Required]
        public Guid ProductCustomUOMId { get; set; }

        /// <summary>
        /// Navigation property representing the associated UOM
        /// </summary>
        [ForeignKey("ProductCustomUOMId")]
        public UOM? ProductCustomUOMId_UOM { get; set; }

        /// <summary>
        /// Required field Count of the ProductPurchaseUOM 
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Foreign key referencing the UOM to which the ProductPurchaseUOM belongs 
        /// </summary>
        [Required]
        public Guid UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated UOM
        /// </summary>
        [ForeignKey("UomId")]
        public UOM? UomId_UOM { get; set; }
    }
}