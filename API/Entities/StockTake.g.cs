using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktake entity with essential details
    /// </summary>
    public class StockTake
    {
        /// <summary>
        /// Primary key for the StockTake 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the StockTake 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field Code of the StockTake 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field StockTakeType of the StockTake 
        /// </summary>
        [Required]
        public int StockTakeType { get; set; }
        /// <summary>
        /// ReferenceNo of the StockTake 
        /// </summary>
        public string? ReferenceNo { get; set; }
        /// <summary>
        /// AdjustmentQuantity of the StockTake 
        /// </summary>
        public int? AdjustmentQuantity { get; set; }
        /// <summary>
        /// AdjustmentAmount of the StockTake 
        /// </summary>
        public int? AdjustmentAmount { get; set; }

        /// <summary>
        /// Required field EstimatedTakeCount of the StockTake 
        /// </summary>
        [Required]
        public int EstimatedTakeCount { get; set; }

        /// <summary>
        /// Required field OngoingCount of the StockTake 
        /// </summary>
        [Required]
        public int OngoingCount { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the StockTake belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Required field CreatedBy of the StockTake 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the StockTake 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StockTake 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StockTake 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the SubLocation to which the StockTake belongs 
        /// </summary>
        public Guid? SubLocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubLocation
        /// </summary>
        [ForeignKey("SubLocationId")]
        public SubLocation? SubLocationId_SubLocation { get; set; }
    }
}