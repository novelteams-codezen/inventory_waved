using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a pricelistcomponent entity with essential details
    /// </summary>
    public class PriceListComponent
    {
        /// <summary>
        /// Required field TenantId of the PriceListComponent 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceListComponent 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the PriceList to which the PriceListComponent belongs 
        /// </summary>
        [Required]
        public Guid PriceListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceList
        /// </summary>
        [ForeignKey("PriceListId")]
        public PriceList? PriceListId_PriceList { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the PriceListComponent belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the Supplier to which the PriceListComponent belongs 
        /// </summary>
        public Guid? SupplierId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Supplier
        /// </summary>
        [ForeignKey("SupplierId")]
        public Supplier? SupplierId_Supplier { get; set; }
    }
}