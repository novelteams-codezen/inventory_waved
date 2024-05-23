using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a order entity with essential details
    /// </summary>
    public class Order
    {
        /// <summary>
        /// TenantId of the Order 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Order 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Order 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Foreign key referencing the Supplier to which the Order belongs 
        /// </summary>
        public Guid? SupplierId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Supplier
        /// </summary>
        [ForeignKey("SupplierId")]
        public Supplier? SupplierId_Supplier { get; set; }

        /// <summary>
        /// Required field Date of the Order 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        /// <summary>
        /// TotalAmount of the Order 
        /// </summary>
        public int? TotalAmount { get; set; }
        /// <summary>
        /// IsPaid of the Order 
        /// </summary>
        public bool? IsPaid { get; set; }

        /// <summary>
        /// CreatedOn of the Order 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Order 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Order 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Order 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}