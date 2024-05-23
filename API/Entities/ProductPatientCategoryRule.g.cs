using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productpatientcategoryrule entity with essential details
    /// </summary>
    public class ProductPatientCategoryRule
    {
        /// <summary>
        /// Required field TenantId of the ProductPatientCategoryRule 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductPatientCategoryRule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field ProductRuleId of the ProductPatientCategoryRule 
        /// </summary>
        [Required]
        public string ProductRuleId { get; set; }

        /// <summary>
        /// Required field PatientCategoryId of the ProductPatientCategoryRule 
        /// </summary>
        [Required]
        public string PatientCategoryId { get; set; }
    }
}