namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ApplicationScreeningAnswers")]
    public partial class ApplicationScreeningAnswer
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        public int OrganizationId { get; set; }

        public int UserId { get; set; }

        public int QuestionId { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public virtual Application Application { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual ScreeningQuestion ScreeningQuestion { get; set; }
    }
}
