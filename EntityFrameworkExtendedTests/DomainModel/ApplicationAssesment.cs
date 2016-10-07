namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ApplicationAssesment")]
    public partial class ApplicationAssesment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplicationId { get; set; }

        public int MitigationProjectRioMarkerId { get; set; }

        public int MitigationGrantRioMarkerId { get; set; }

        public int AdaptationProjectRioMarkerId { get; set; }

        public int AdaptationGrantRioMarkerId { get; set; }

        public virtual RioMarker RioMarker { get; set; }

        public virtual RioMarker RioMarker1 { get; set; }

        public virtual RioMarker RioMarker2 { get; set; }

        public virtual RioMarker RioMarker3 { get; set; }

        public virtual Application Application { get; set; }
    }
}
