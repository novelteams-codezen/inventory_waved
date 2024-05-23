using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a transaction entity with essential details
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// TenantId of the Transaction 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Transaction 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Order to which the Transaction belongs 
        /// </summary>
        public Guid? OrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Order
        /// </summary>
        [ForeignKey("OrderId")]
        public Order? OrderId_Order { get; set; }

        /// <summary>
        /// Required field Date of the Transaction 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Amount of the Transaction 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Description of the Transaction 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Transaction 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Transaction 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Transaction 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Transaction 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}