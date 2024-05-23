using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a producttheraputicclassification entity with essential details
    /// </summary>
    public class ProductTheraputicClassification
    {
        /// <summary>
        /// Required field TenantId of the ProductTheraputicClassification 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductTheraputicClassification 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the ProductTheraputicClassification belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field DrugSystemOrganTypeId of the ProductTheraputicClassification 
        /// </summary>
        [Required]
        public string DrugSystemOrganTypeId { get; set; }
    }
}