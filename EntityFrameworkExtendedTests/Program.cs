using EntityFramework.Extensions;
using EntityFramework.Future;
using EntityFrameworkExtendedTests.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExtendedTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //project #98 has 11 cost and 17 finance components
            int pid = 98;

            Console.WriteLine("Default way - with EF.Entity includes");
            using (TestDB ctx = new TestDB())
            {
                Project project = ctx.Projects
                    .Include(p => p.Organization)

                    .Include(p => p.ProjectCosts)
                    .Include(p => p.ProjectCosts.Select(pc => pc.ProjectCostContributionType))

                    .Include(p => p.ProjectFinances)
                    .Include(p => p.ProjectFinances.Select(pf => pf.ProjectFinancingType))
                    .Include(p => p.ProjectFinances.Select(pf => pf.Grant))
                    .Include(p => p.ProjectFinances.Select(pf => pf.Grant.Organization))
                    .Single(p => p.Id == pid);

                Print(project);
            }

            Console.WriteLine("EFEx way");
            using (TestDB ctx = new TestDB())
            {
                //Lazy loading must be off to make sure EF does not trigger any other DB calls 
                ctx.Configuration.LazyLoadingEnabled = false;

                FutureQuery<ProjectCost> costs = ctx.ProjectCosts
                    .Include(pc => pc.ProjectCostContributionType)
                    .Where(pc => pc.ProjectId == pid)
                    .Future();

                FutureQuery<ProjectFinance> finances = ctx.ProjectFinances
                    .Include(pf => pf.ProjectFinancingType)
                    .Include(pf => pf.Grant)
                    .Include(pf => pf.Grant.Organization)
                    .Where(pf => pf.ProjectId == pid)
                    .Future();

                //!!! -> trigger query must also be a future type query otherwise the previous future queries are not executed
                Project project = ctx.Projects
                    .Include(p => p.Organization)
                    .Where(p => p.Id == pid)
                    .Future()
                    .Single();

                Print(project);
            }

            Console.WriteLine("Done...");
            Console.ReadKey();
        }

        private static void Print(Project project)
        {
            Console.WriteLine("Costs count = {0}", project.ProjectCosts.Count);
            Console.WriteLine("Costs Type count = {0}", project.ProjectCosts.Count(pc => pc.ProjectCostContributionType == null));
            Console.WriteLine("Finances count = {0}", project.ProjectFinances.Count);
            Console.WriteLine("Finances Type count = {0}", project.ProjectFinances.Count(pf => pf.ProjectFinancingType == null));
            Console.WriteLine("Grants count = {0}", project.ProjectFinances.Count(pf => pf.Grant != null));
        }
    }
}
