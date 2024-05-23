using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productbatch entity with essential details
    /// </summary>
    public class ProductBatch
    {
        /// <summary>
        /// Required field TenantId of the ProductBatch 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductBatch 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the ProductBatch belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the ProductBatch belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field PurchaseValue of the ProductBatch 
        /// </summary>
        [Required]
        public int PurchaseValue { get; set; }

        /// <summary>
        /// Foreign key referencing the ProductUom to which the ProductBatch belongs 
        /// </summary>
        [Required]
        public Guid ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }
        /// <summary>
        /// BatchNumber of the ProductBatch 
        /// </summary>
        public string? BatchNumber { get; set; }

        /// <summary>
        /// Required field BatchQuantity of the ProductBatch 
        /// </summary>
        [Required]
        public int BatchQuantity { get; set; }

        /// <summary>
        /// Required field PackReceiptQuantity of the ProductBatch 
        /// </summary>
        [Required]
        public int PackReceiptQuantity { get; set; }

        /// <summary>
        /// Required field PackUnitPrice of the ProductBatch 
        /// </summary>
        [Required]
        public int PackUnitPrice { get; set; }

        /// <summary>
        /// Required field UnitPrice of the ProductBatch 
        /// </summary>
        [Required]
        public int UnitPrice { get; set; }

        /// <summary>
        /// Required field ExpiryDate of the ProductBatch 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Required field ManufactureDate of the ProductBatch 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ManufactureDate { get; set; }

        /// <summary>
        /// Required field CreatedOn of the ProductBatch 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ProductBatch 
        /// </summary>
        public Guid? CreatedBy { get; set; }
        /// <summary>
        /// UpdatedBy of the ProductBatch 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ProductBatch 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}