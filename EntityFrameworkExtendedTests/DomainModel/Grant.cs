namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.Grants")]
    public partial class Grant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grant()
        {
            Applications = new HashSet<Application>();
            Contracts = new HashSet<Contract>();
            GrantAttachments = new HashSet<GrantAttachment>();
            ProjectFinances = new HashSet<ProjectFinance>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        public string Description { get; set; }

        public int? GrantTypeId { get; set; }

        public int LeadIFIOrganizationId { get; set; }

        [StringLength(100)]
        public string CofinancierOrganizationIds { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfAward { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpectedCompletionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public int ApprovedAmmount { get; set; }

        public int? RevisedAmmount { get; set; }

        [StringLength(100)]
        public string ContractedServices { get; set; }

        public int CurrentStageId { get; set; }

        public int ImplementationStatusId { get; set; }

        public string ProgressRemarks { get; set; }

        [StringLength(100)]
        public string IFIReference { get; set; }

        public bool IsDraft { get; set; }

        public virtual GrantImplementationStatus GrantImplementationStatus { get; set; }

        public virtual GrantStage GrantStage { get; set; }

        public virtual GrantType GrantType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrantAttachment> GrantAttachments { get; set; }

        public virtual Organization Organization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectFinance> ProjectFinances { get; set; }
    }
}
