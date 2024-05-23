using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a requisitionworkflowstep entity with essential details
    /// </summary>
    public class RequisitionWorkFlowStep
    {
        /// <summary>
        /// Required field TenantId of the RequisitionWorkFlowStep 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the RequisitionWorkFlowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field FromStep of the RequisitionWorkFlowStep 
        /// </summary>
        [Required]
        public int FromStep { get; set; }

        /// <summary>
        /// Required field ToStep of the RequisitionWorkFlowStep 
        /// </summary>
        [Required]
        public int ToStep { get; set; }

        /// <summary>
        /// Required field ToStepText of the RequisitionWorkFlowStep 
        /// </summary>
        [Required]
        public string ToStepText { get; set; }

        /// <summary>
        /// Required field StepType of the RequisitionWorkFlowStep 
        /// </summary>
        [Required]
        public int StepType { get; set; }

        /// <summary>
        /// Required field Sequence of the RequisitionWorkFlowStep 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// ConfigureAssignment of the RequisitionWorkFlowStep 
        /// </summary>
        public bool? ConfigureAssignment { get; set; }
    }
}