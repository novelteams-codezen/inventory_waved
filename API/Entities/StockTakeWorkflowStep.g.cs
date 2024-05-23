using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktakeworkflowstep entity with essential details
    /// </summary>
    public class StockTakeWorkflowStep
    {
        /// <summary>
        /// Required field TenantId of the StockTakeWorkflowStep 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockTakeWorkflowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// FromStep of the StockTakeWorkflowStep 
        /// </summary>
        public int? FromStep { get; set; }
        /// <summary>
        /// ToStep of the StockTakeWorkflowStep 
        /// </summary>
        public int? ToStep { get; set; }
        /// <summary>
        /// ToStepText of the StockTakeWorkflowStep 
        /// </summary>
        public string? ToStepText { get; set; }
        /// <summary>
        /// StepType of the StockTakeWorkflowStep 
        /// </summary>
        public int? StepType { get; set; }
        /// <summary>
        /// Sequence of the StockTakeWorkflowStep 
        /// </summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// ConfigureAssignment of the StockTakeWorkflowStep 
        /// </summary>
        public bool? ConfigureAssignment { get; set; }
    }
}