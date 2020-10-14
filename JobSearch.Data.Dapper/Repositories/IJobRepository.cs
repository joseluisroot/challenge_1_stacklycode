using JobSearch.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobSearch.Data.Dapper.Repositories
{
    public interface IJobRepository
    {

        Task<IEnumerable<Job>> getAllJob();
        Task<Job> getJob(int id);

    }
}
