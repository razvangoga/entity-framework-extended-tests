namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ScreeningQuestions")]
    public partial class ScreeningQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScreeningQuestion()
        {
            ApplicationScreeningAnswers = new HashSet<ApplicationScreeningAnswer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationScreeningAnswer> ApplicationScreeningAnswers { get; set; }
    }
}
