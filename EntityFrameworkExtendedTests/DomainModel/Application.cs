namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.Applications")]
    public partial class Application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Application()
        {
            ApplicationAssesmentAnswers = new HashSet<ApplicationAssesmentAnswer>();
            ApplicationScreeningAnswers = new HashSet<ApplicationScreeningAnswer>();
        }

        public int Id { get; set; }

        public int RoundId { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        public int RoundStageId { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        public int SectorId { get; set; }

        public int DACCRSCode { get; set; }

        public bool RequiresNewProject { get; set; }

        public int? ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string Services { get; set; }

        public string OtherServices { get; set; }

        public int LeadIFIOrganizationId { get; set; }

        [StringLength(100)]
        public string CofinancierOrganizationIds { get; set; }

        public int? Amount { get; set; }

        [StringLength(50)]
        public string NewProjectCode { get; set; }

        [StringLength(50)]
        public string NewGrantCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedByUserId { get; set; }

        public int CreatedByOrganizationId { get; set; }

        public DateTime? LastUpdatedAt { get; set; }

        public int? DraftProjectId { get; set; }

        public int? DraftGrantId { get; set; }

        public virtual DACCRSCode DACCRSCode1 { get; set; }

        public virtual ProjectSector ProjectSector { get; set; }

        public virtual RoundStage RoundStage { get; set; }

        public virtual ApplicationAssesment ApplicationAssesment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationAssesmentAnswer> ApplicationAssesmentAnswers { get; set; }

        public virtual Grant Grant { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Organization Organization1 { get; set; }

        public virtual Project Project { get; set; }

        public virtual Project Project1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationScreeningAnswer> ApplicationScreeningAnswers { get; set; }

        public virtual ApplicationScreeningConclusion ApplicationScreeningConclusion { get; set; }

        public virtual ApplicationSubmission ApplicationSubmission { get; set; }
    }
}
