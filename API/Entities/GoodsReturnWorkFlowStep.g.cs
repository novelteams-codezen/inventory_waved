using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a goodsreturnworkflowstep entity with essential details
    /// </summary>
    public class GoodsReturnWorkFlowStep
    {
        /// <summary>
        /// Required field TenantId of the GoodsReturnWorkFlowStep 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReturnWorkFlowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field FromStep of the GoodsReturnWorkFlowStep 
        /// </summary>
        [Required]
        public int FromStep { get; set; }

        /// <summary>
        /// Required field ToStep of the GoodsReturnWorkFlowStep 
        /// </summary>
        [Required]
        public int ToStep { get; set; }

        /// <summary>
        /// Required field ToStepText of the GoodsReturnWorkFlowStep 
        /// </summary>
        [Required]
        public string ToStepText { get; set; }

        /// <summary>
        /// Required field StepType of the GoodsReturnWorkFlowStep 
        /// </summary>
        [Required]
        public int StepType { get; set; }

        /// <summary>
        /// Required field Sequence of the GoodsReturnWorkFlowStep 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// ConfigureAssignment of the GoodsReturnWorkFlowStep 
        /// </summary>
        public bool? ConfigureAssignment { get; set; }
    }
}