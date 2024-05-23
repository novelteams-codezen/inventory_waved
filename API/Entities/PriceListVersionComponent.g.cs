using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a pricelistversioncomponent entity with essential details
    /// </summary>
    public class PriceListVersionComponent
    {
        /// <summary>
        /// Required field TenantId of the PriceListVersionComponent 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceListVersionComponent 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the PriceList to which the PriceListVersionComponent belongs 
        /// </summary>
        [Required]
        public Guid PriceListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceList
        /// </summary>
        [ForeignKey("PriceListId")]
        public PriceList? PriceListId_PriceList { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the PriceListVersionComponent belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the PriceListVersion to which the PriceListVersionComponent belongs 
        /// </summary>
        public Guid? PriceListVersionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceListVersion
        /// </summary>
        [ForeignKey("PriceListVersionId")]
        public PriceListVersion? PriceListVersionId_PriceListVersion { get; set; }
        /// <summary>
        /// Foreign key referencing the Supplier to which the PriceListVersionComponent belongs 
        /// </summary>
        public Guid? SupplierId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Supplier
        /// </summary>
        [ForeignKey("SupplierId")]
        public Supplier? SupplierId_Supplier { get; set; }
    }
}