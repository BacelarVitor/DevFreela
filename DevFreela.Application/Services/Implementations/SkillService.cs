using Dapper;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private const string DevFreelaCs = "DevFreelaCs";
        private readonly string _connectionString;
        public SkillService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString(DevFreelaCs);
        }
        public IList<SkillViewModel> GetAll()
        {
            using var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            var sql = @"SELECT Id, Description FROM Skills";

            return sqlConnection.Query<SkillViewModel>(sql).ToList();
        }
    }
}
