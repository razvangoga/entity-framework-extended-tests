namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ProjectAttachments")]
    public partial class ProjectAttachment
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

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

        public virtual Project Project { get; set; }
    }
}
