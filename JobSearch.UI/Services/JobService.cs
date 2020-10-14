using JobSearch.Data.Dapper.Repositories;
using JobSearch.Model;
using JobSearch.UI.Data;
using JobSearch.UI.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobSearch.UI.Services
{
    public class JobService : IJobService
    {
        private IJobRepository _jobRepository;
        private readonly SqlConfiguration _configuration;

        public JobService(SqlConfiguration sqlConfiguration)
        {
            _configuration = sqlConfiguration;
            _jobRepository = new JobRepository(sqlConfiguration._cnnString);
        }

        public Task<IEnumerable<Job>> getAllJobs()
        {
            return _jobRepository.getAllJob();
        }

        public Task<Job> getDetails(int id)
        {
            return _jobRepository.getJob(id);
        }
    }
}
