using System;
using Volo.Abp.Domain.Entities;

namespace Todos.Domain.Todos
{
    public class Todo :  Entity<Guid>
    {
        public string Content { get; set; }
        public bool IsDone { get; set; }        
    }
}
