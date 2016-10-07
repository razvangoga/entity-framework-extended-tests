namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.Contracts")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            ContractAttachments = new HashSet<ContractAttachment>();
        }

        public int Id { get; set; }

        public int GrantId { get; set; }

        public int ContractingAuthorityOrganizationId { get; set; }

        public int? ContractorOrganizationId { get; set; }

        public int ContractValue { get; set; }

        public int? ActualExpenditure { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpectedCompletion { get; set; }

        [StringLength(100)]
        public string ContractedServices { get; set; }

        public int ContractRatingId { get; set; }

        public string Description { get; set; }

        public virtual ContractRating ContractRating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractAttachment> ContractAttachments { get; set; }

        public virtual Grant Grant { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Organization Organization1 { get; set; }
    }
}
