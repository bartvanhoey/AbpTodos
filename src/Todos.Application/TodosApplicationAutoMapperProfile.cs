﻿using AutoMapper;
using Todos.Application.Contracts.Todos;
using Todos.Domain.Todos;

namespace Todos
{
    public class TodosApplicationAutoMapperProfile : Profile
    {
        public TodosApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

             CreateMap<Todo,TodoDto>();
             CreateMap<TodoDto,Todo>();
        }
    }
}
