using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class ProjectRepository : IRepository<ProjectEntity>
{
    private readonly AppDbContext _context;

    public ProjectRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ProjectEntity>> GetAllAsync()
    {
        return await _context.ProjectTable.ToListAsync();
    }

    public async Task<ProjectEntity> GetByIdAsync(Guid id)
    {
        return await _context.ProjectTable.FindAsync(id);
    }

    public async Task AddAsync(ProjectEntity project)
    {
        await _context.ProjectTable.AddAsync(project);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ProjectEntity project)
    {
        _context.ProjectTable.Update(project);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var project = await _context.ProjectTable.FindAsync(id);
        if (project != null)
        {
            _context.ProjectTable.Remove(project);
            await _context.SaveChangesAsync();
        }
    }
}
