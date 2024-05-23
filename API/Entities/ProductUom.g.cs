using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productuom entity with essential details
    /// </summary>
    public class ProductUom
    {
        /// <summary>
        /// Required field TenantId of the ProductUom 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductUom 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the ProductUom belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Foreign key referencing the UOM to which the ProductUom belongs 
        /// </summary>
        [Required]
        public Guid UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated UOM
        /// </summary>
        [ForeignKey("UomId")]
        public UOM? UomId_UOM { get; set; }

        /// <summary>
        /// Required field ConversionQuantity of the ProductUom 
        /// </summary>
        [Required]
        public int ConversionQuantity { get; set; }

        /// <summary>
        /// Required field Purchase of the ProductUom 
        /// </summary>
        [Required]
        public bool Purchase { get; set; }

        /// <summary>
        /// Required field Selling of the ProductUom 
        /// </summary>
        [Required]
        public bool Selling { get; set; }

        /// <summary>
        /// Required field PurchaseDefault of the ProductUom 
        /// </summary>
        [Required]
        public bool PurchaseDefault { get; set; }

        /// <summary>
        /// Required field SellingDefault of the ProductUom 
        /// </summary>
        [Required]
        public bool SellingDefault { get; set; }

        /// <summary>
        /// Required field LowestUom of the ProductUom 
        /// </summary>
        [Required]
        public bool LowestUom { get; set; }
    }
}