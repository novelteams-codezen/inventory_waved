using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktakefile entity with essential details
    /// </summary>
    public class StockTakeFile
    {
        /// <summary>
        /// Primary key for the StockTakeFile 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the StockTakeFile 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Foreign key referencing the StockTake to which the StockTakeFile belongs 
        /// </summary>
        [Required]
        public Guid StockTakeId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockTake
        /// </summary>
        [ForeignKey("StockTakeId")]
        public StockTake? StockTakeId_StockTake { get; set; }

        /// <summary>
        /// Required field StockTakeCode of the StockTakeFile 
        /// </summary>
        [Required]
        public string StockTakeCode { get; set; }
        /// <summary>
        /// Title of the StockTakeFile 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// FileName of the StockTakeFile 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileExtension of the StockTakeFile 
        /// </summary>
        public string? FileExtension { get; set; }
        /// <summary>
        /// MimeType of the StockTakeFile 
        /// </summary>
        public string? MimeType { get; set; }
        /// <summary>
        /// AzureFilePath of the StockTakeFile 
        /// </summary>
        public string? AzureFilePath { get; set; }

        /// <summary>
        /// Required field CreatedBy of the StockTakeFile 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the StockTakeFile 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Required field Print of the StockTakeFile 
        /// </summary>
        [Required]
        public bool Print { get; set; }
    }
}