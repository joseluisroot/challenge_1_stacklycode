using JobSearch.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobSearch.UI.Interfaces
{
    public interface IJobService
    {

        Task<IEnumerable<Job>> getAllJobs();
        Task<Job> getDetails(int id);

    }
}
