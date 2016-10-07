namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ProjectFinances")]
    public partial class ProjectFinance
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int ProjectFinancingTypeId { get; set; }

        public int? FinancierOrganizationId { get; set; }

        [StringLength(200)]
        public string ExternalFinacierName { get; set; }

        public string Remarks { get; set; }

        public int Ammount { get; set; }

        public int? GrantId { get; set; }

        public bool IsExternalFinance { get; set; }

        public string ExternalGrant { get; set; }

        public int? LoanStageId { get; set; }

        public string LoanIFIReference { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LoanSignatureDate { get; set; }

        public int? ProbabilityOfSigningId { get; set; }

        [StringLength(50)]
        public string Components { get; set; }

        public virtual LoanProbabilitiesOfSigning LoanProbabilitiesOfSigning { get; set; }

        public virtual LoanStage LoanStage { get; set; }

        public virtual ProjectFinancingType ProjectFinancingType { get; set; }

        public virtual Grant Grant { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Project Project { get; set; }
    }
}
