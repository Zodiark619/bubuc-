using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<CompanyRepository>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void GetAllCompanies(bool trackChanges)
        {
            //return FindAll(trackChanges).OrderBy(c => c.Name).ToList();
            return;
        }
    }
}
