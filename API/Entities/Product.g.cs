using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a product entity with essential details
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Primary key for the Product 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the Product 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }
        /// <summary>
        /// Name of the Product 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Price of the Product 
        /// </summary>
        public int? Price { get; set; }
        /// <summary>
        /// Default of the Product 
        /// </summary>
        public bool? Default { get; set; }
        /// <summary>
        /// IsStandard of the Product 
        /// </summary>
        public bool? IsStandard { get; set; }
        /// <summary>
        /// Code of the Product 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// EntityCode of the Product 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the Product 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }
        /// <summary>
        /// CreatedBy of the Product 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Product 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductManufacture to which the Product belongs 
        /// </summary>
        public Guid? ProductManufactureId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductManufacture
        /// </summary>
        [ForeignKey("ProductManufactureId")]
        public ProductManufacture? ProductManufactureId_ProductManufacture { get; set; }
        /// <summary>
        /// IsOnline of the Product 
        /// </summary>
        public bool? IsOnline { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductCategory to which the Product belongs 
        /// </summary>
        public Guid? ProductCategoryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductCategory
        /// </summary>
        [ForeignKey("ProductCategoryId")]
        public ProductCategory? ProductCategoryId_ProductCategory { get; set; }
        /// <summary>
        /// ProductType of the Product 
        /// </summary>
        public string? ProductType { get; set; }
        /// <summary>
        /// Inventoried of the Product 
        /// </summary>
        public bool? Inventoried { get; set; }
        /// <summary>
        /// HSNCode of the Product 
        /// </summary>
        public string? HSNCode { get; set; }
        /// <summary>
        /// Description of the Product 
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductFormulation to which the Product belongs 
        /// </summary>
        public Guid? ProductFormulationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductFormulation
        /// </summary>
        [ForeignKey("ProductFormulationId")]
        public ProductFormulation? ProductFormulationId_ProductFormulation { get; set; }
        /// <summary>
        /// ScheduleDrug of the Product 
        /// </summary>
        public int? ScheduleDrug { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductClassification to which the Product belongs 
        /// </summary>
        public Guid? ProductClassificationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductClassification
        /// </summary>
        [ForeignKey("ProductClassificationId")]
        public ProductClassification? ProductClassificationId_ProductClassification { get; set; }
        /// <summary>
        /// Foreign key referencing the UOM to which the Product belongs 
        /// </summary>
        public Guid? LowestUOM { get; set; }

        /// <summary>
        /// Navigation property representing the associated UOM
        /// </summary>
        [ForeignKey("LowestUOM")]
        public UOM? LowestUOM_UOM { get; set; }
        /// <summary>
        /// BaseType of the Product 
        /// </summary>
        public int? BaseType { get; set; }
        /// <summary>
        /// Status of the Product 
        /// </summary>
        public bool? Status { get; set; }
        /// <summary>
        /// ReOrderLevel of the Product 
        /// </summary>
        public int? ReOrderLevel { get; set; }
        /// <summary>
        /// ReOrderQuantity of the Product 
        /// </summary>
        public int? ReOrderQuantity { get; set; }
        /// <summary>
        /// GstCategory of the Product 
        /// </summary>
        public Guid? GstCategory { get; set; }
        /// <summary>
        /// GSTPercentage of the Product 
        /// </summary>
        public int? GSTPercentage { get; set; }
        /// <summary>
        /// Foreign key referencing the UOM to which the Product belongs 
        /// </summary>
        public Guid? ReOrderQuantityUom { get; set; }

        /// <summary>
        /// Navigation property representing the associated UOM
        /// </summary>
        [ForeignKey("ReOrderQuantityUom")]
        public UOM? ReOrderQuantityUom_UOM { get; set; }
        /// <summary>
        /// Foreign key referencing the DrugSchedule to which the Product belongs 
        /// </summary>
        public Guid? DrugScheduleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DrugSchedule
        /// </summary>
        [ForeignKey("DrugScheduleId")]
        public DrugSchedule? DrugScheduleId_DrugSchedule { get; set; }
        /// <summary>
        /// FormulationId of the Product 
        /// </summary>
        public Guid? FormulationId { get; set; }
        /// <summary>
        /// ComponentType of the Product 
        /// </summary>
        public int? ComponentType { get; set; }
        /// <summary>
        /// Import of the Product 
        /// </summary>
        public bool? Import { get; set; }

        /// <summary>
        /// SellingStartDate of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? SellingStartDate { get; set; }

        /// <summary>
        /// SellingEndDate of the Product 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? SellingEndDate { get; set; }
    }
}