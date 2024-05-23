using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a pricelistversionitem entity with essential details
    /// </summary>
    public class PriceListVersionItem
    {
        /// <summary>
        /// Required field TenantId of the PriceListVersionItem 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceListVersionItem 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the PriceList to which the PriceListVersionItem belongs 
        /// </summary>
        [Required]
        public Guid PriceListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceList
        /// </summary>
        [ForeignKey("PriceListId")]
        public PriceList? PriceListId_PriceList { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the PriceListVersionItem belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }
        /// <summary>
        /// Price of the PriceListVersionItem 
        /// </summary>
        public int? Price { get; set; }
        /// <summary>
        /// MarkUpMarkDownValue of the PriceListVersionItem 
        /// </summary>
        public int? MarkUpMarkDownValue { get; set; }
        /// <summary>
        /// MarkUpMarkDownUnit of the PriceListVersionItem 
        /// </summary>
        public int? MarkUpMarkDownUnit { get; set; }
        /// <summary>
        /// Foreign key referencing the PriceListVersion to which the PriceListVersionItem belongs 
        /// </summary>
        public Guid? PriceListVersionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PriceListVersion
        /// </summary>
        [ForeignKey("PriceListVersionId")]
        public PriceListVersion? PriceListVersionId_PriceListVersion { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductUom to which the PriceListVersionItem belongs 
        /// </summary>
        public Guid? ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }
    }
}