using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a subreason entity with essential details
    /// </summary>
    public class SubReason
    {
        /// <summary>
        /// Required field TenantId of the SubReason 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the SubReason 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field Name of the SubReason 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Required field CreatedBy of the SubReason 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the SubReason 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the SubReason 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the SubReason 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}