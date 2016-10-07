namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.Organizations")]
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            Applications = new HashSet<Application>();
            Applications1 = new HashSet<Application>();
            ApplicationScreeningAnswers = new HashSet<ApplicationScreeningAnswer>();
            Contracts = new HashSet<Contract>();
            Contracts1 = new HashSet<Contract>();
            Grants = new HashSet<Grant>();
            ProjectFinances = new HashSet<ProjectFinance>();
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int OrganizationTypeId { get; set; }

        public int CountryId { get; set; }

        public bool HideInApplicationSubmission { get; set; }

        public bool HideInProjectFinanciers { get; set; }

        public bool IsAlsoScreener { get; set; }

        public int? ScreeningProjectSectorId { get; set; }

        [StringLength(1000)]
        public string ScreeningQuestions { get; set; }

        [StringLength(1000)]
        public string ScreeningApplications { get; set; }

        public bool DoesScreeningConclusions { get; set; }

        public virtual Country Country { get; set; }

        public virtual OrganizationType OrganizationType { get; set; }

        public virtual ProjectSector ProjectSector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationScreeningAnswer> ApplicationScreeningAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grant> Grants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectFinance> ProjectFinances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }
    }
}
