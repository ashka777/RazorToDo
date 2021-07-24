using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RazorToDo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        private TodosModel todo = new TodosModel();
        public List<TodosModel> todos = new List<TodosModel>();


        //public IActionResult OnGet()
        //{
        //    TodosModel tod = todo.GetTodos().Where(w => w.NumberId == 1).FirstOrDefault();
        //    return Page();
        //    //return null;
        //}

        public void OnPost(List<TodosModel> todo, string str = "Пусто")
        {
            todo.Add(new TodosModel { NumberId = todo.Count + 1, Name = str, DateTimeTodo = DateTime.Now, IsComplited = false });

            //return null;
        }
    }
}
