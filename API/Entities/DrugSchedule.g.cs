using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a drugschedule entity with essential details
    /// </summary>
    public class DrugSchedule
    {
        /// <summary>
        /// Required field TenantId of the DrugSchedule 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the DrugSchedule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the DrugSchedule 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the DrugSchedule 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Description of the DrugSchedule 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Authorization of the DrugSchedule 
        /// </summary>
        public bool? Authorization { get; set; }
        /// <summary>
        /// CreatedBy of the DrugSchedule 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the DrugSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DrugSchedule 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DrugSchedule 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}