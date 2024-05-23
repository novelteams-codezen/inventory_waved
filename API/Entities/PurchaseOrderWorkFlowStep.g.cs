using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a purchaseorderworkflowstep entity with essential details
    /// </summary>
    public class PurchaseOrderWorkFlowStep
    {
        /// <summary>
        /// Required field TenantId of the PurchaseOrderWorkFlowStep 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the PurchaseOrderWorkFlowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field FromStep of the PurchaseOrderWorkFlowStep 
        /// </summary>
        [Required]
        public int FromStep { get; set; }

        /// <summary>
        /// Required field ToStep of the PurchaseOrderWorkFlowStep 
        /// </summary>
        [Required]
        public int ToStep { get; set; }
        /// <summary>
        /// ToStepText of the PurchaseOrderWorkFlowStep 
        /// </summary>
        public string? ToStepText { get; set; }

        /// <summary>
        /// Required field StepType of the PurchaseOrderWorkFlowStep 
        /// </summary>
        [Required]
        public int StepType { get; set; }

        /// <summary>
        /// Required field Sequence of the PurchaseOrderWorkFlowStep 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// ConfigureAssignment of the PurchaseOrderWorkFlowStep 
        /// </summary>
        public bool? ConfigureAssignment { get; set; }
    }
}