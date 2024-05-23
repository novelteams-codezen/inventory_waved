using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productgeneric entity with essential details
    /// </summary>
    public class ProductGeneric
    {
        /// <summary>
        /// Primary key for the ProductGeneric 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the ProductGeneric 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field Name of the ProductGeneric 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the ProductGeneric belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field GenericId of the ProductGeneric 
        /// </summary>
        [Required]
        public Guid GenericId { get; set; }

        /// <summary>
        /// Foreign key referencing the UOM to which the ProductGeneric belongs 
        /// </summary>
        [Required]
        public Guid UOM { get; set; }

        /// <summary>
        /// Navigation property representing the associated UOM
        /// </summary>
        [ForeignKey("UOM")]
        public UOM? UOM_UOM { get; set; }

        /// <summary>
        /// Required field Strength of the ProductGeneric 
        /// </summary>
        [Required]
        public int Strength { get; set; }

        /// <summary>
        /// Required field CreatedBy of the ProductGeneric 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the ProductGeneric 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ProductGeneric 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ProductGeneric 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}