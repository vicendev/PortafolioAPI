using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.Sdt.Architecture.Core.Repository;
using Org.Sdt.Projects.Entities;
using Org.Sdt.Projects.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Portafolio.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMongoRepository<ProjectEntity> _genericProjectRepository;

        public ProjectsController(
            IProjectRepository projectRepository,
            IMongoRepository<ProjectEntity> genericProjectRepository)
        {
            _projectRepository = projectRepository;
            _genericProjectRepository = genericProjectRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            var projects = await _genericProjectRepository.GetAll();

            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectEntity>> GetById(string id)
        {
            var project = await _genericProjectRepository.GetById(id);

            return Ok(project);
        }

        [HttpPost]
        public async Task Post(ProjectEntity project)
        {
            await _genericProjectRepository.InsertDocument(project);
        }

        [HttpPut]
        public async Task Update(ProjectEntity project)
        {
            await _genericProjectRepository.UpdateDocument(project);
        }
    }
}
