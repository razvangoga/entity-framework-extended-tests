namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.AssesmentQuestions")]
    public partial class AssesmentQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssesmentQuestion()
        {
            ApplicationAssesmentAnswers = new HashSet<ApplicationAssesmentAnswer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationAssesmentAnswer> ApplicationAssesmentAnswers { get; set; }
    }
}
