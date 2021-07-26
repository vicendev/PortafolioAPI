using MongoDB.Driver;
using Org.Sdt.Projects.ContextMongoDb;
using Org.Sdt.Projects.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Org.Sdt.Projects.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IProjectContext _projectContext;

        public ProjectRepository(IProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public async Task<IEnumerable<Project>> GetProjects()
        {
            return await _projectContext.Projects.Find(a => true).ToListAsync();
        }
    }
}
