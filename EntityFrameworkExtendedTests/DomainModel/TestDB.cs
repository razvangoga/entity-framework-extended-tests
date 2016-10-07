namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Diagnostics;

    public partial class TestDB : DbContext
    {
        public TestDB()
            : base("name=TestDB")
        {
#if DEBUG
            this.Database.Log = s => { Debug.WriteLine(s); };
#endif
        }

        public virtual DbSet<ContractAttachmentType> ContractAttachmentTypes { get; set; }
        public virtual DbSet<ContractRating> ContractRatings { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DACCRSCode> DACCRSCodes { get; set; }
        public virtual DbSet<GrantImplementationStatus> GrantImplementationStatuses { get; set; }
        public virtual DbSet<GrantStage> GrantStages { get; set; }
        public virtual DbSet<GrantType> GrantTypes { get; set; }
        public virtual DbSet<LoanProbabilitiesOfSigning> LoanProbabilitiesOfSignings { get; set; }
        public virtual DbSet<LoanStage> LoanStages { get; set; }
        public virtual DbSet<OrganizationType> OrganizationTypes { get; set; }
        public virtual DbSet<ProjectCostContributionType> ProjectCostContributionTypes { get; set; }
        public virtual DbSet<ProjectFinancingType> ProjectFinancingTypes { get; set; }
        public virtual DbSet<ProjectSector> ProjectSectors { get; set; }
        public virtual DbSet<ProjectStage> ProjectStages { get; set; }
        public virtual DbSet<RioMarker> RioMarkers { get; set; }
        public virtual DbSet<RoundStage> RoundStages { get; set; }
        public virtual DbSet<RoundType> RoundTypes { get; set; }
        public virtual DbSet<ScreeningConclusionResult> ScreeningConclusionResults { get; set; }
        public virtual DbSet<ApplicationAssesment> ApplicationAssesments { get; set; }
        public virtual DbSet<ApplicationAssesmentAnswer> ApplicationAssesmentAnswers { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationScreeningAnswer> ApplicationScreeningAnswers { get; set; }
        public virtual DbSet<ApplicationScreeningConclusion> ApplicationScreeningConclusions { get; set; }
        public virtual DbSet<ApplicationSubmission> ApplicationSubmissions { get; set; }
        public virtual DbSet<AssesmentQuestion> AssesmentQuestions { get; set; }
        public virtual DbSet<ContractAttachment> ContractAttachments { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<GrantAttachment> GrantAttachments { get; set; }
        public virtual DbSet<Grant> Grants { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<ProjectAttachment> ProjectAttachments { get; set; }
        public virtual DbSet<ProjectCost> ProjectCosts { get; set; }
        public virtual DbSet<ProjectFinance> ProjectFinances { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Round> Rounds { get; set; }
        public virtual DbSet<ScreeningQuestion> ScreeningQuestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractAttachmentType>()
                .HasMany(e => e.ContractAttachments)
                .WithRequired(e => e.ContractAttachmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContractRating>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.ContractRating)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Organizations)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DACCRSCode>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.DACCRSCode1)
                .HasForeignKey(e => e.DACCRSCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DACCRSCode>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.DACCRSCode1)
                .HasForeignKey(e => e.DACCRSCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GrantImplementationStatus>()
                .HasMany(e => e.Grants)
                .WithRequired(e => e.GrantImplementationStatus)
                .HasForeignKey(e => e.ImplementationStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GrantStage>()
                .HasMany(e => e.Grants)
                .WithRequired(e => e.GrantStage)
                .HasForeignKey(e => e.CurrentStageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoanProbabilitiesOfSigning>()
                .HasMany(e => e.ProjectFinances)
                .WithOptional(e => e.LoanProbabilitiesOfSigning)
                .HasForeignKey(e => e.ProbabilityOfSigningId);

            modelBuilder.Entity<OrganizationType>()
                .HasMany(e => e.Organizations)
                .WithRequired(e => e.OrganizationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectCostContributionType>()
                .HasMany(e => e.ProjectCosts)
                .WithRequired(e => e.ProjectCostContributionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectFinancingType>()
                .HasMany(e => e.ProjectFinances)
                .WithRequired(e => e.ProjectFinancingType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectSector>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.ProjectSector)
                .HasForeignKey(e => e.SectorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectSector>()
                .HasMany(e => e.Organizations)
                .WithOptional(e => e.ProjectSector)
                .HasForeignKey(e => e.ScreeningProjectSectorId);

            modelBuilder.Entity<ProjectSector>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.ProjectSector)
                .HasForeignKey(e => e.SectorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectStage>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.ProjectStage)
                .HasForeignKey(e => e.CurrentStageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RioMarker>()
                .HasMany(e => e.ApplicationAssesments)
                .WithRequired(e => e.RioMarker)
                .HasForeignKey(e => e.AdaptationGrantRioMarkerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RioMarker>()
                .HasMany(e => e.ApplicationAssesments1)
                .WithRequired(e => e.RioMarker1)
                .HasForeignKey(e => e.AdaptationProjectRioMarkerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RioMarker>()
                .HasMany(e => e.ApplicationAssesments2)
                .WithRequired(e => e.RioMarker2)
                .HasForeignKey(e => e.MitigationGrantRioMarkerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RioMarker>()
                .HasMany(e => e.ApplicationAssesments3)
                .WithRequired(e => e.RioMarker3)
                .HasForeignKey(e => e.MitigationProjectRioMarkerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoundStage>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.RoundStage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScreeningConclusionResult>()
                .HasMany(e => e.ApplicationScreeningConclusions)
                .WithRequired(e => e.ScreeningConclusionResult)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasOptional(e => e.ApplicationAssesment)
                .WithRequired(e => e.Application);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.ApplicationAssesmentAnswers)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.ApplicationScreeningAnswers)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasOptional(e => e.ApplicationScreeningConclusion)
                .WithRequired(e => e.Application);

            modelBuilder.Entity<Application>()
                .HasOptional(e => e.ApplicationSubmission)
                .WithRequired(e => e.Application);

            modelBuilder.Entity<AssesmentQuestion>()
                .HasMany(e => e.ApplicationAssesmentAnswers)
                .WithRequired(e => e.AssesmentQuestion)
                .HasForeignKey(e => e.QuestionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grant>()
                .HasMany(e => e.Applications)
                .WithOptional(e => e.Grant)
                .HasForeignKey(e => e.DraftGrantId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.Organization)
                .HasForeignKey(e => e.LeadIFIOrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Applications1)
                .WithRequired(e => e.Organization1)
                .HasForeignKey(e => e.CreatedByOrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ApplicationScreeningAnswers)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Organization)
                .HasForeignKey(e => e.ContractingAuthorityOrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Contracts1)
                .WithOptional(e => e.Organization1)
                .HasForeignKey(e => e.ContractorOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Grants)
                .WithRequired(e => e.Organization)
                .HasForeignKey(e => e.LeadIFIOrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ProjectFinances)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.FinancierOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.Organization)
                .HasForeignKey(e => e.MonitorIFIOrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Applications)
                .WithOptional(e => e.Project)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Applications1)
                .WithOptional(e => e.Project1)
                .HasForeignKey(e => e.DraftProjectId);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Projects1)
                .WithOptional(e => e.Project1)
                .HasForeignKey(e => e.ParentProjectId);

            modelBuilder.Entity<ScreeningQuestion>()
                .HasMany(e => e.ApplicationScreeningAnswers)
                .WithRequired(e => e.ScreeningQuestion)
                .HasForeignKey(e => e.QuestionId)
                .WillCascadeOnDelete(false);
        }
    }
}
