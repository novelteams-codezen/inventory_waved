using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stockadjustmentworkflowstep entity with essential details
    /// </summary>
    public class StockAdjustmentWorkFlowStep
    {
        /// <summary>
        /// Primary key for the StockAdjustmentWorkFlowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the StockAdjustmentWorkFlowStep 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field FromStep of the StockAdjustmentWorkFlowStep 
        /// </summary>
        [Required]
        public int FromStep { get; set; }

        /// <summary>
        /// Required field ToStep of the StockAdjustmentWorkFlowStep 
        /// </summary>
        [Required]
        public int ToStep { get; set; }

        /// <summary>
        /// Required field ToStepText of the StockAdjustmentWorkFlowStep 
        /// </summary>
        [Required]
        public string ToStepText { get; set; }

        /// <summary>
        /// Required field StepType of the StockAdjustmentWorkFlowStep 
        /// </summary>
        [Required]
        public int StepType { get; set; }
        /// <summary>
        /// Sequence of the StockAdjustmentWorkFlowStep 
        /// </summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// ConfigureAssignment of the StockAdjustmentWorkFlowStep 
        /// </summary>
        public bool? ConfigureAssignment { get; set; }
    }
}