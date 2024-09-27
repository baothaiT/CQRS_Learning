using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IProjectRepository
    {
        Task<IEnumerable<ProjectEntity>> GetAllProjectAsync();
        Task<ProjectEntity> GetProjectByIdAsync(Guid id);
        Task AddProjectAsync(ProjectEntity project);
        Task UpdateProjectAsync(ProjectEntity project);
        Task DeleteProjectAsync(Guid id);
    }
}
