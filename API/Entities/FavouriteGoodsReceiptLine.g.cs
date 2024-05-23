using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a favouritegoodsreceiptline entity with essential details
    /// </summary>
    public class FavouriteGoodsReceiptLine
    {
        /// <summary>
        /// Primary key for the FavouriteGoodsReceiptLine 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the FavouriteGoodsReceiptLine 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the FavouriteGoodsReceiptLine belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// UserId of the FavouriteGoodsReceiptLine 
        /// </summary>
        public Guid? UserId { get; set; }
    }
}