namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ApplicationScreeningConclusions")]
    public partial class ApplicationScreeningConclusion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplicationId { get; set; }

        public string Conclusion { get; set; }

        public int ScreeningConclusionResultId { get; set; }

        public virtual ScreeningConclusionResult ScreeningConclusionResult { get; set; }

        public virtual Application Application { get; set; }
    }
}
