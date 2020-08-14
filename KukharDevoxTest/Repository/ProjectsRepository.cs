using KukharDevoxTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KukharDevoxTest.Repository
{
 public   interface ProjectsRepository
    {
        public IEnumerable<Projects> GetAllProjects();
        //public Project GetProjectById();
        public Projects GetProjectById(int id);

        //public Project DeleteProjectById();
        public void DeleteProjectById(int id);

        public void CreateNewProject(Projects projects);

        public void UpdateProject(Projects projects, int id);


        //PersonID Date
        //WeekNumber

    }
}
