using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktransfer entity with essential details
    /// </summary>
    public class StockTransfer
    {
        /// <summary>
        /// Required field TenantId of the StockTransfer 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockTransfer 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// TransferNumber of the StockTransfer 
        /// </summary>
        public string? TransferNumber { get; set; }

        /// <summary>
        /// Required field TransferDate of the StockTransfer 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransferDate { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the StockTransfer belongs 
        /// </summary>
        public Guid? LocationFromId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationFromId")]
        public Location? LocationFromId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the StockTransfer belongs 
        /// </summary>
        public Guid? LocationToId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationToId")]
        public Location? LocationToId_Location { get; set; }

        /// <summary>
        /// Required field CreatedBy of the StockTransfer 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the StockTransfer 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StockTransfer 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StockTransfer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// ReferenceNumber of the StockTransfer 
        /// </summary>
        public string? ReferenceNumber { get; set; }

        /// <summary>
        /// ExpectedDeliveryDate of the StockTransfer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpectedDeliveryDate { get; set; }
        /// <summary>
        /// Foreign key referencing the SubLocation to which the StockTransfer belongs 
        /// </summary>
        public Guid? SubLocationFromId { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubLocation
        /// </summary>
        [ForeignKey("SubLocationFromId")]
        public SubLocation? SubLocationFromId_SubLocation { get; set; }
        /// <summary>
        /// Foreign key referencing the SubLocation to which the StockTransfer belongs 
        /// </summary>
        public Guid? SubLocationToId { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubLocation
        /// </summary>
        [ForeignKey("SubLocationToId")]
        public SubLocation? SubLocationToId_SubLocation { get; set; }
    }
}