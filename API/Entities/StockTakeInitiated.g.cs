using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktakeinitiated entity with essential details
    /// </summary>
    public class StockTakeInitiated
    {
        /// <summary>
        /// Primary key for the StockTakeInitiated 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the StockTakeInitiated 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Foreign key referencing the StockTake to which the StockTakeInitiated belongs 
        /// </summary>
        [Required]
        public Guid StockTakeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockTake
        /// </summary>
        [ForeignKey("StockTakeId")]
        public StockTake? StockTakeId_StockTake { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the StockTakeInitiated belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
    }
}