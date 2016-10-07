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
            //porject #98 has 11 cost and 17 finance components
            int pid = 98;

            Console.WriteLine("Default way - with EF.Entity includes");
            using (TestDB ctx = new TestDB())
            {
                Project project = ctx.Projects
                    .Include(p=> p.Organization)

                    .Include(p => p.ProjectCosts)
                    .Include(p => p.ProjectCosts.Select( pc => pc.ProjectCostContributionType))
                    
                    .Include(p => p.ProjectFinances)
                    .Include(p => p.ProjectFinances.Select(pf => pf.ProjectFinancingType))
                    .Include(p => p.ProjectFinances.Select(pf => pf.Grant))
                    .Include(p => p.ProjectFinances.Select(pf => pf.Grant.Organization))
                    .Single(p => p.Id == pid);

                Console.WriteLine("Costs count = {0}", project.ProjectCosts.Count);
                Console.WriteLine("Finances count = {0}", project.ProjectFinances.Count);
            }


            Console.WriteLine("Done...");
            Console.ReadKey();
        }
    }
}
