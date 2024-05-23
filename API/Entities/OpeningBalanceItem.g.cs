using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a openingbalanceitem entity with essential details
    /// </summary>
    public class OpeningBalanceItem
    {
        /// <summary>
        /// Primary key for the OpeningBalanceItem 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the OpeningBalanceItem 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field OpeningBalanceId of the OpeningBalanceItem 
        /// </summary>
        [Required]
        public Guid OpeningBalanceId { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the OpeningBalanceItem belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// BatchNumber of the OpeningBalanceItem 
        /// </summary>
        public string? BatchNumber { get; set; }
        /// <summary>
        /// OpeningQuantity of the OpeningBalanceItem 
        /// </summary>
        public int? OpeningQuantity { get; set; }
        /// <summary>
        /// AverageCost of the OpeningBalanceItem 
        /// </summary>
        public int? AverageCost { get; set; }

        /// <summary>
        /// Required field CreatedBy of the OpeningBalanceItem 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the OpeningBalanceItem 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the OpeningBalanceItem 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the OpeningBalanceItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// ExpiryDate of the OpeningBalanceItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// ManufactureDate of the OpeningBalanceItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
    }
}