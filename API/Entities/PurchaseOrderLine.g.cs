using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a purchaseorderline entity with essential details
    /// </summary>
    public class PurchaseOrderLine
    {
        /// <summary>
        /// Required field TenantId of the PurchaseOrderLine 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PurchaseOrderLine 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the PurchaseOrder to which the PurchaseOrderLine belongs 
        /// </summary>
        [Required]
        public Guid PurchaseOrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PurchaseOrder
        /// </summary>
        [ForeignKey("PurchaseOrderId")]
        public PurchaseOrder? PurchaseOrderId_PurchaseOrder { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the PurchaseOrderLine belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field OrderQuantity of the PurchaseOrderLine 
        /// </summary>
        [Required]
        public int OrderQuantity { get; set; }

        /// <summary>
        /// Foreign key referencing the ProductUom to which the PurchaseOrderLine belongs 
        /// </summary>
        [Required]
        public Guid ProductUomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductUom
        /// </summary>
        [ForeignKey("ProductUomId")]
        public ProductUom? ProductUomId_ProductUom { get; set; }

        /// <summary>
        /// Required field TotalQuantity of the PurchaseOrderLine 
        /// </summary>
        [Required]
        public int TotalQuantity { get; set; }
        /// <summary>
        /// PackUnitPrice of the PurchaseOrderLine 
        /// </summary>
        public int? PackUnitPrice { get; set; }
        /// <summary>
        /// TaxAmount of the PurchaseOrderLine 
        /// </summary>
        public int? TaxAmount { get; set; }
        /// <summary>
        /// TotalAmount of the PurchaseOrderLine 
        /// </summary>
        public int? TotalAmount { get; set; }

        /// <summary>
        /// Required field LineRejected of the PurchaseOrderLine 
        /// </summary>
        [Required]
        public bool LineRejected { get; set; }
        /// <summary>
        /// Reason of the PurchaseOrderLine 
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// Required field CreatedBy of the PurchaseOrderLine 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the PurchaseOrderLine 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PurchaseOrderLine 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PurchaseOrderLine 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the Requisition to which the PurchaseOrderLine belongs 
        /// </summary>
        public Guid? RequisitionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Requisition
        /// </summary>
        [ForeignKey("RequisitionId")]
        public Requisition? RequisitionId_Requisition { get; set; }
        /// <summary>
        /// RequisitionLineId of the PurchaseOrderLine 
        /// </summary>
        public Guid? RequisitionLineId { get; set; }
        /// <summary>
        /// RemainingQuantity of the PurchaseOrderLine 
        /// </summary>
        public int? RemainingQuantity { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceipt to which the PurchaseOrderLine belongs 
        /// </summary>
        public Guid? GoodsReceiptId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceipt
        /// </summary>
        [ForeignKey("GoodsReceiptId")]
        public GoodsReceipt? GoodsReceiptId_GoodsReceipt { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReceiptItem to which the PurchaseOrderLine belongs 
        /// </summary>
        public Guid? GoodsReceiptItemId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReceiptItem
        /// </summary>
        [ForeignKey("GoodsReceiptItemId")]
        public GoodsReceiptItem? GoodsReceiptItemId_GoodsReceiptItem { get; set; }
    }
}