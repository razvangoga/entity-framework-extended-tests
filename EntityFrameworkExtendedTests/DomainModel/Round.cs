namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.Rounds")]
    public partial class Round
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PreSubmissionDeadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SubmissionDeadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndorsmentDeadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ScreeningDeadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ScreeningConclusionsDeadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AssesmentDeadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SteeringCommitteeDate { get; set; }

        public int? RoundStageId { get; set; }

        public int? RoundTypeId { get; set; }

        public bool AllowPreSubmissions { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? ClosedAt { get; set; }

        public virtual RoundStage RoundStage { get; set; }

        public virtual RoundType RoundType { get; set; }
    }
}
