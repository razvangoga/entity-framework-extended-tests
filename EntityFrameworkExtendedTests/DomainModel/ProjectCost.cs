namespace EntityFrameworkExtendedTests.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operational.ProjectCosts")]
    public partial class ProjectCost
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int ProjectCostContributionTypeId { get; set; }

        public int Component { get; set; }

        public string Description { get; set; }

        public int EstimatedCost { get; set; }

        public virtual ProjectCostContributionType ProjectCostContributionType { get; set; }

        public virtual Project Project { get; set; }
    }
}
