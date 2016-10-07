namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ApplicationSubmission")]
    public partial class ApplicationSubmission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplicationId { get; set; }

        public string BorrowerBeneficiaryies { get; set; }

        public string ProjectGrantDescription { get; set; }

        public string Outcome { get; set; }

        public string StrategicJustification { get; set; }

        public string AdditionalComments { get; set; }

        public string DescriptionOfTheGrantUse { get; set; }

        public string GrantRequestJustification { get; set; }

        public string ContributionToClimateChange { get; set; }

        public string MeetingRoundPriorities { get; set; }

        public string LeadIFIContacts { get; set; }

        public string CoFinancierContacts { get; set; }

        public bool EligibilityChecklist1 { get; set; }

        public bool EligibilityChecklist2 { get; set; }

        public bool EligibilityChecklist3 { get; set; }

        public bool EligibilityChecklist4 { get; set; }

        public bool EligibilityChecklist5 { get; set; }

        public bool EligibilityChecklist6 { get; set; }

        public bool EligibilityChecklist7 { get; set; }

        public bool EligibilityChecklist8 { get; set; }

        public bool EligibilityChecklist9 { get; set; }

        public bool EligibilityChecklist10 { get; set; }

        public bool EligibilityChecklist11 { get; set; }

        public bool EligibilityChecklist12 { get; set; }

        public virtual Application Application { get; set; }
    }
}
