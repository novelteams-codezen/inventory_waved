using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a pricelistversion entity with essential details
    /// </summary>
    public class PriceListVersion
    {
        /// <summary>
        /// Required field TenantId of the PriceListVersion 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceListVersion 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field PriceListBaseType of the PriceListVersion 
        /// </summary>
        [Required]
        public int PriceListBaseType { get; set; }
        /// <summary>
        /// PricelistType of the PriceListVersion 
        /// </summary>
        public int? PricelistType { get; set; }
        /// <summary>
        /// Name of the PriceListVersion 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Notes of the PriceListVersion 
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// StartDate of the PriceListVersion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the PriceListVersion 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Foreign key referencing the PriceList to which the PriceListVersion belongs 
        /// </summary>
        [Required]
        public Guid PriceListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceList
        /// </summary>
        [ForeignKey("PriceListId")]
        public PriceList? PriceListId_PriceList { get; set; }

        /// <summary>
        /// Required field Version of the PriceListVersion 
        /// </summary>
        [Required]
        public int Version { get; set; }
        /// <summary>
        /// PreviousVersionId of the PriceListVersion 
        /// </summary>
        public Guid? PreviousVersionId { get; set; }

        /// <summary>
        /// Required field CreatedBy of the PriceListVersion 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the PriceListVersion 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
    }
}