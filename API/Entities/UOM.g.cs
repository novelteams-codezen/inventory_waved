using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a uom entity with essential details
    /// </summary>
    public class UOM
    {
        /// <summary>
        /// TenantId of the UOM 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the UOM 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the UOM 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the UOM 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the UOM 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the UOM 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the UOM 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the UOM 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the UOM 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}