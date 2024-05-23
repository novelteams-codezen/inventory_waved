using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a openingbalance entity with essential details
    /// </summary>
    public class OpeningBalance
    {
        /// <summary>
        /// Primary key for the OpeningBalance 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the OpeningBalance 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Foreign key referencing the Location to which the OpeningBalance belongs 
        /// </summary>
        [Required]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Required field OpeningBalanceStatus of the OpeningBalance 
        /// </summary>
        [Required]
        public int OpeningBalanceStatus { get; set; }

        /// <summary>
        /// Required field OpeningBalanceDate of the OpeningBalance 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OpeningBalanceDate { get; set; }

        /// <summary>
        /// Required field CreatedBy of the OpeningBalance 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the OpeningBalance 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the OpeningBalance 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the OpeningBalance 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the SubLocation to which the OpeningBalance belongs 
        /// </summary>
        public Guid? SubLocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated SubLocation
        /// </summary>
        [ForeignKey("SubLocationId")]
        public SubLocation? SubLocationId_SubLocation { get; set; }
    }
}