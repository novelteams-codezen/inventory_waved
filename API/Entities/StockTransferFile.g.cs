using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace inventory_waved.Entities
{
    /// <summary> 
    /// Represents a stocktransferfile entity with essential details
    /// </summary>
    public class StockTransferFile
    {
        /// <summary>
        /// Primary key for the StockTransferFile 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the StockTransferFile 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Foreign key referencing the StockTransfer to which the StockTransferFile belongs 
        /// </summary>
        [Required]
        public Guid StockTransferId { get; set; }

        /// <summary>
        /// Navigation property representing the associated StockTransfer
        /// </summary>
        [ForeignKey("StockTransferId")]
        public StockTransfer? StockTransferId_StockTransfer { get; set; }
        /// <summary>
        /// TransferNumber of the StockTransferFile 
        /// </summary>
        public string? TransferNumber { get; set; }
        /// <summary>
        /// Title of the StockTransferFile 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// FileName of the StockTransferFile 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileExtension of the StockTransferFile 
        /// </summary>
        public string? FileExtension { get; set; }
        /// <summary>
        /// MimeType of the StockTransferFile 
        /// </summary>
        public string? MimeType { get; set; }
        /// <summary>
        /// AzureFilePath of the StockTransferFile 
        /// </summary>
        public string? AzureFilePath { get; set; }

        /// <summary>
        /// Required field CreatedBy of the StockTransferFile 
        /// </summary>
        [Required]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the StockTransferFile 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Required field Print of the StockTransferFile 
        /// </summary>
        [Required]
        public bool Print { get; set; }
    }
}