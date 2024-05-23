using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktransferworkflowstep entity with essential details
    /// </summary>
    public class StockTransferWorkFlowStep
    {
        /// <summary>
        /// Required field TenantId of the StockTransferWorkFlowStep 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockTransferWorkFlowStep 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field FromStep of the StockTransferWorkFlowStep 
        /// </summary>
        [Required]
        public int FromStep { get; set; }

        /// <summary>
        /// Required field ToStep of the StockTransferWorkFlowStep 
        /// </summary>
        [Required]
        public int ToStep { get; set; }

        /// <summary>
        /// Required field ToStepText of the StockTransferWorkFlowStep 
        /// </summary>
        [Required]
        public string ToStepText { get; set; }

        /// <summary>
        /// Required field StepType of the StockTransferWorkFlowStep 
        /// </summary>
        [Required]
        public int StepType { get; set; }

        /// <summary>
        /// Required field Sequence of the StockTransferWorkFlowStep 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// ConfigureAssignment of the StockTransferWorkFlowStep 
        /// </summary>
        public bool? ConfigureAssignment { get; set; }
    }
}