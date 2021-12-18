using WhatToDo.Domain.Entities;

namespace WhatToDo.Domain.Repositories;

public interface ITodoRepository
{
    Task<IEnumerable<Todo>> GetAllToDo();
}