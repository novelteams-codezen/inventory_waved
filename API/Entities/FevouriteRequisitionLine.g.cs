using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a fevouriterequisitionline entity with essential details
    /// </summary>
    public class FevouriteRequisitionLine
    {
        /// <summary>
        /// Required field TenantId of the FevouriteRequisitionLine 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the FevouriteRequisitionLine 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the FevouriteRequisitionLine belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// UserId of the FevouriteRequisitionLine 
        /// </summary>
        public Guid? UserId { get; set; }
    }
}