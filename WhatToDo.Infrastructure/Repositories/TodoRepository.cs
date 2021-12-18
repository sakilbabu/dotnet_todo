using WhatToDo.Domain.Entities;
using WhatToDo.Domain.Repositories;

namespace WhatToDo.Infrastructure.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly IEnumerable<Todo> _todos = new[]
    {
        new Todo{ Id = Guid.NewGuid(),IsCompleted = false,Title = "Super",},
        new Todo{ Id = Guid.NewGuid(),IsCompleted = true,Title = "Todoes",},
    };
    public async Task<IEnumerable<Todo>> GetAllToDo()
    {
        return _todos;
    }
}