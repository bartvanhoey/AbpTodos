using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Todos.Application.Contracts.Todos;

namespace Todos.Blazor.Pages
{
    public partial class Todos
    {
        [Inject] private ITodoAppService TodoAppService { get; set; }

        private List<TodoDto> TodoItems { get; set; } = new();
        private string NewTodoText { get; set; }

        protected async override Task OnInitializedAsync()
        {
            TodoItems =  await TodoAppService.GetListAsync();
        }

        public async Task CreateAsync()
        {

            var todoDto = new TodoDto {Content = NewTodoText, Id = Guid.NewGuid()};
            var x = await TodoAppService.CreateAsync(todoDto);
            TodoItems.Add(x);
            NewTodoText = null;
        }
        private async Task DeleteAsync(TodoDto todoDto)
        {
            await TodoAppService.DeleteAsync(todoDto.Id);
            await Notify.Info("Deleted the todo item!");
            TodoItems.Remove(todoDto);
        }
        
        


  

    }
}
