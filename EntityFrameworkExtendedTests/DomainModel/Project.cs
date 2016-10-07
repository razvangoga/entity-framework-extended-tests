namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.Projects")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            Applications = new HashSet<Application>();
            Applications1 = new HashSet<Application>();
            ProjectAttachments = new HashSet<ProjectAttachment>();
            ProjectCosts = new HashSet<ProjectCost>();
            ProjectFinances = new HashSet<ProjectFinance>();
            Projects1 = new HashSet<Project>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        public int SectorId { get; set; }

        public int DACCRSCode { get; set; }

        public int MonitorIFIOrganizationId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpectedCompletionDate { get; set; }

        public int CurrentStageId { get; set; }

        public string ProgressRemarks { get; set; }

        public int? ParentProjectId { get; set; }

        public bool IsDraft { get; set; }

        public virtual DACCRSCode DACCRSCode1 { get; set; }

        public virtual ProjectSector ProjectSector { get; set; }

        public virtual ProjectStage ProjectStage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications1 { get; set; }

        public virtual Organization Organization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectAttachment> ProjectAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectCost> ProjectCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectFinance> ProjectFinances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects1 { get; set; }

        public virtual Project Project1 { get; set; }
    }
}
