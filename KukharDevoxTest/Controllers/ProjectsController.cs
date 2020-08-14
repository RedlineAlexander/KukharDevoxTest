using KukharDevoxTest.Models;
using KukharDevoxTest.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KukharDevoxTest.Controllers
{
    public class ProjectsController : Controller
    {
        private ProjectsRepository repository { get; }
        public ProjectsController(ProjectsRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet("Projects")]
        public IEnumerable<Projects> GetProject([FromServices] ProjectsRepository repo)
        {
            return repo.GetAllProjects();
        }

        [HttpGet("Projects")]
        public void GetProjects(int id)
        {
            repository.GetProjectById(id);
        }

        [HttpPost("Projects")]
        public void CreateProject(Projects projects)
        {
            repository.CreateNewProject(projects);
        }


        [HttpDelete("Projects")]
        public void DeleteProjects(int id)
        {
            repository.DeleteProjectById(id);
        }

        [HttpPut("Projects")]
        public void UpdateProject(Projects projects, int id)
        {
            repository.UpdateProject(projects, id);
        }
    }
}
