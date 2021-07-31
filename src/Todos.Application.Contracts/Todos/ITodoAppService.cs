using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Todos.Application.Contracts.Todos
{
    public interface ITodoAppService :  IApplicationService
    {
        Task<TodoDto> CreateAsync(TodoDto todoDto);
        Task<bool> DeleteAsync(Guid id);
        Task<List<TodoDto>> GetListAsync();
        Task<TodoDto> UpdateAsync(TodoDto todoDto);
    }
}
