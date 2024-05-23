using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productmanufacture entity with essential details
    /// </summary>
    public class ProductManufacture
    {
        /// <summary>
        /// Required field TenantId of the ProductManufacture 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductManufacture 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ProductManufacture 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ProductManufacture 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Required field CreatedBy of the ProductManufacture 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the ProductManufacture 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ProductManufacture 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ProductManufacture 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}