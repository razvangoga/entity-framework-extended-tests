namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ContractAttachments")]
    public partial class ContractAttachment
    {
        public int Id { get; set; }

        public int ContractId { get; set; }

        public int ContractAttachmentTypeId { get; set; }

        [Required]
        [StringLength(200)]
        public string FileName { get; set; }

        [Required]
        [StringLength(100)]
        public string ContentType { get; set; }

        public int ContentLenght { get; set; }

        [Required]
        [StringLength(200)]
        public string BlobPath { get; set; }

        public int? UploadedByUserId { get; set; }

        public DateTime? UploadedAt { get; set; }

        public virtual ContractAttachmentType ContractAttachmentType { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
