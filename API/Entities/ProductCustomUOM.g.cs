using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productcustomuom entity with essential details
    /// </summary>
    public class ProductCustomUOM
    {
        /// <summary>
        /// Primary key for the ProductCustomUOM 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the ProductCustomUOM 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field ProductUomType of the ProductCustomUOM 
        /// </summary>
        [Required]
        public int ProductUomType { get; set; }

        /// <summary>
        /// Required field Name of the ProductCustomUOM 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}