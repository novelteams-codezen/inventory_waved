using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stockadjustment entity with essential details
    /// </summary>
    public class StockAdjustment
    {
        /// <summary>
        /// Required field TenantId of the StockAdjustment 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockAdjustment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Code of the StockAdjustment 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// AdjustmentDate of the StockAdjustment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AdjustmentDate { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the StockAdjustment belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Required field CreatedBy of the StockAdjustment 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the StockAdjustment 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StockAdjustment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StockAdjustment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Required field Status of the StockAdjustment 
        /// </summary>
        [Required]
        public int Status { get; set; }
        /// <summary>
        /// ReferenceNo of the StockAdjustment 
        /// </summary>
        public string? ReferenceNo { get; set; }
        /// <summary>
        /// Foreign key referencing the SubLocation to which the StockAdjustment belongs 
        /// </summary>
        public Guid? SubLocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubLocation
        /// </summary>
        [ForeignKey("SubLocationId")]
        public SubLocation? SubLocationId_SubLocation { get; set; }
    }
}