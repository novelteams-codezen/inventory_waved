using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a productgenderrule entity with essential details
    /// </summary>
    public class ProductGenderRule
    {
        /// <summary>
        /// Primary key for the ProductGenderRule 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the ProductGenderRule 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Required field AgeFrom of the ProductGenderRule 
        /// </summary>
        [Required]
        public int AgeFrom { get; set; }

        /// <summary>
        /// Required field AgeTo of the ProductGenderRule 
        /// </summary>
        [Required]
        public int AgeTo { get; set; }
    }
}