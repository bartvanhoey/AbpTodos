using System;
using Volo.Abp.Application.Dtos;

namespace Todos.Application.Contracts.Todos
{
    public class TodoDto :  EntityDto<Guid>
    {
        public string Content { get; set; }
        public bool IsDone { get; set; }
    }
}
