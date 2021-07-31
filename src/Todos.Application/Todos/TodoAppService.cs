using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Todos.Application.Contracts.Todos;
using Todos.Domain.Todos;
using Todos.Permissions;
// using Todos.Permissions;
using Volo.Abp.Domain.Repositories;

namespace Todos.Application.Todos
{


    public class TodoAppService : TodosAppService, ITodoAppService
    {
        private readonly IRepository<Todo, Guid> _todoRepository;

        public TodoAppService(IRepository<Todo, Guid> todoRepository)
        {
            _todoRepository = todoRepository;
        }


        [Authorize(TodosPermissions.Todos.Default)]

        public async Task<List<TodoDto>> GetListAsync()
        {


            var todos = await _todoRepository.GetListAsync();
            return ObjectMapper.Map<List<Todo>, List<TodoDto>>(todos);
        }


        // [Authorize(TodosPermissions.Todos.Create)]
        public async Task<TodoDto> CreateAsync(TodoDto todoDto)
        {
            var result = await AuthorizationService.AuthorizeAsync(TodosPermissions.Todos.Create);
            if (result.Succeeded)
            {
                var todo = ObjectMapper.Map<TodoDto, Todo>(todoDto);
                var createdTodo = await _todoRepository.InsertAsync(todo, autoSave: false);
                return ObjectMapper.Map<Todo, TodoDto>(createdTodo);
            }
            throw new UnauthorizedAccessException();
        }


        [Authorize(TodosPermissions.Todos.Update)]


        public async Task<TodoDto> UpdateAsync(TodoDto todoDto)
        {
            var todo = ObjectMapper.Map<TodoDto, Todo>(todoDto);
            var updateDto = await _todoRepository.UpdateAsync(todo, autoSave: false);
            return ObjectMapper.Map<Todo, TodoDto>(updateDto);
        }


        [Authorize(TodosPermissions.Todos.Delete)]
        public async Task<bool> DeleteAsync(Guid id)
        {
            var todo = await _todoRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (todo != null)
            {
                await _todoRepository.DeleteAsync(id, autoSave: false);
                return true;
            }
            return false;
        }



    }
}
