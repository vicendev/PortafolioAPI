using Org.Sdt.Projects.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Org.Sdt.Projects.Repository
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjects();

    }
}
