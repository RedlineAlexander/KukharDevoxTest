using KukharDevoxTest.Data;
using KukharDevoxTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KukharDevoxTest.Repository
{
    public class SqlProjectsRepository
    {
        private KukharDevoxTestContext contexts { get; set; }

        public SqlProjectsRepository(KukharDevoxTestContext contexts)
        {
            this.contexts = contexts;
        }
        public void CreateNewProject(Projects projects)
        {
            contexts.Projects.Add(projects);
            contexts.SaveChanges();
            //  throw new NotImplementedException();
        }

        public void DeleteProjectById(int id)
        {
            var project = contexts.Projects.SingleOrDefault(project => project.ProjectsID == id);
            try
            {
                contexts.Projects.Remove(project);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException($"There is no project with ID = {id}");
            }
            finally
            {
                contexts.SaveChanges();
            }
            // throw new NotImplementedException();
        }

        public IEnumerable<Projects> GetAllProjects()
        {
            return contexts.Projects;
            //throw new NotImplementedException();
        }

        public Projects GetProjectById(int id)
        {
            return contexts.Projects.SingleOrDefault(project => project.ProjectsID == id);
            //   throw new NotImplementedException();
        }

        public void UpdateProject(Projects projects, int id)
        {


            var project = contexts.Projects.SingleOrDefault(projects => projects.ProjectsID == id);//prodectToUpdateValues
            if (projects == null)
            {
                return;
            }
            project.ProjectName = project.ProjectName;
            project.ProjectDateStart = project.ProjectDateStart;
            project.ProjectDateEnd = project.ProjectDateEnd;

            contexts.SaveChanges();

            //throw new NotImplementedException();
        }
    }
}
