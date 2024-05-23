using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a sublocation entity with essential details
    /// </summary>
    public class SubLocation
    {
        /// <summary>
        /// Required field TenantId of the SubLocation 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the SubLocation 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the SubLocation belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }

        /// <summary>
        /// Required field Code of the SubLocation 
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Required field Name of the SubLocation 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// RoomNumber of the SubLocation 
        /// </summary>
        public string? RoomNumber { get; set; }
        /// <summary>
        /// RoomTypeId of the SubLocation 
        /// </summary>
        public Guid? RoomTypeId { get; set; }
        /// <summary>
        /// Floor of the SubLocation 
        /// </summary>
        public string? Floor { get; set; }
        /// <summary>
        /// Ward of the SubLocation 
        /// </summary>
        public string? Ward { get; set; }
        /// <summary>
        /// CanBeBooked of the SubLocation 
        /// </summary>
        public bool? CanBeBooked { get; set; }
        /// <summary>
        /// CanHaveInventory of the SubLocation 
        /// </summary>
        public bool? CanHaveInventory { get; set; }
        /// <summary>
        /// Active of the SubLocation 
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// CreatedBy of the SubLocation 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the SubLocation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the SubLocation 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the SubLocation 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// OpeningBalanceDone of the SubLocation 
        /// </summary>
        public bool? OpeningBalanceDone { get; set; }
    }
}