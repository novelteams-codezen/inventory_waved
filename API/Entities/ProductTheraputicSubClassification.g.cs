using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a producttheraputicsubclassification entity with essential details
    /// </summary>
    public class ProductTheraputicSubClassification
    {
        /// <summary>
        /// Required field TenantId of the ProductTheraputicSubClassification 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductTheraputicSubClassification 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the ProductTheraputicClassification to which the ProductTheraputicSubClassification belongs 
        /// </summary>
        [Required]
        public Guid ProductTheraputicClassificationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductTheraputicClassification
        /// </summary>
        [ForeignKey("ProductTheraputicClassificationId")]
        public ProductTheraputicClassification? ProductTheraputicClassificationId_ProductTheraputicClassification { get; set; }

        /// <summary>
        /// Required field DrugSystemOrganTypeId of the ProductTheraputicSubClassification 
        /// </summary>
        [Required]
        public string DrugSystemOrganTypeId { get; set; }

        /// <summary>
        /// Required field DrugSystemTherapeuticClassId of the ProductTheraputicSubClassification 
        /// </summary>
        [Required]
        public string DrugSystemTherapeuticClassId { get; set; }
    }
}