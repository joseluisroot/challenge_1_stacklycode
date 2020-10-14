using Dapper;
using JobSearch.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace JobSearch.Data.Dapper.Repositories
{
    public class JobRepository : IJobRepository
    {

        private string _cnnString;

        public JobRepository(string cnnString)
        {
            _cnnString = cnnString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_cnnString);
        }

        public async Task<IEnumerable<Job>> getAllJob()
        {
            var db = dbConnection();

            var sql = @"SELECT idJob, nameJob, company, place, finalDate, type, description FROM Job ";

            return await db.QueryAsync<Job>(sql.ToString(), new { });
        }

        public async Task<Job> getJob(int id)
        {
            var db = dbConnection();

            var sql = @"SELECT idJob, nameJob, company, place, finalDate, type, description FROM Job WHERE idJob = @id";

            return await db.QueryFirstOrDefaultAsync<Job>(sql.ToString(), new { id = id });
        }
    }
}
