using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a organisationstockbalance entity with essential details
    /// </summary>
    public class OrganisationStockBalance
    {
        /// <summary>
        /// Primary key for the OrganisationStockBalance 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the OrganisationStockBalance 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the OrganisationStockBalance belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field Quantity of the OrganisationStockBalance 
        /// </summary>
        [Required]
        public int Quantity { get; set; }
        /// <summary>
        /// AgerageCost of the OrganisationStockBalance 
        /// </summary>
        public int? AgerageCost { get; set; }
    }
}