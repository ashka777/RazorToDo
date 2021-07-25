using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToDo
{
    public class TodosModel : PageModel
    {
        public int NumberId { get; set; }

        public string Name { get; set; }

        public DateTime DateTimeTodo { get; set; }

        public bool IsComplited { get; set; }

        public List<TodosModel> todos = new List<TodosModel>();

        public List<TodosModel> GetTodos() =>
           todos = new List<TodosModel>()
            {
            new TodosModel{ NumberId = 1, Name="Почитать инфо", DateTimeTodo=DateTime.Now.AddDays(-2), IsComplited=true },
            new TodosModel{ NumberId = 2, Name="Создать проект", DateTimeTodo=DateTime.Now.AddDays(-2), IsComplited=true },
            new TodosModel{ NumberId = 3, Name="Ознакомиться с Git", DateTimeTodo=DateTime.Now.AddDays(-1), IsComplited=true },
            new TodosModel{ NumberId = 4, Name="Выгрузить в Git", DateTimeTodo=DateTime.Now, IsComplited=true },
            new TodosModel{ NumberId = 5, Name="Показать проект", DateTimeTodo=DateTime.Now, IsComplited=false }
            };

        public void OnGet()
        {
            todos = GetTodos();
        }
    }
}
