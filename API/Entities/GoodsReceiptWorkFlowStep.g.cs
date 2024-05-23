using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a goodsreceiptworkflowstep entity with essential details
    /// </summary>
    public class GoodsReceiptWorkFlowStep
    {
        /// <summary>
        /// Primary key for the GoodsReceiptWorkFlowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the GoodsReceiptWorkFlowStep 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field FromStep of the GoodsReceiptWorkFlowStep 
        /// </summary>
        [Required]
        public int FromStep { get; set; }

        /// <summary>
        /// Required field ToStep of the GoodsReceiptWorkFlowStep 
        /// </summary>
        [Required]
        public int ToStep { get; set; }

        /// <summary>
        /// Required field ToStepText of the GoodsReceiptWorkFlowStep 
        /// </summary>
        [Required]
        public string ToStepText { get; set; }

        /// <summary>
        /// Required field StepType of the GoodsReceiptWorkFlowStep 
        /// </summary>
        [Required]
        public int StepType { get; set; }

        /// <summary>
        /// Required field Sequence of the GoodsReceiptWorkFlowStep 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// ConfigureAssignment of the GoodsReceiptWorkFlowStep 
        /// </summary>
        public bool? ConfigureAssignment { get; set; }
    }
}