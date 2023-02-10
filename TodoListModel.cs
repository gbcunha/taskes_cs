using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TodoList.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
    }

    public class TodoListModel : PageModel
    {
        public List<Todo> Todos { get; set; }

        public void OnGet()
        {
            Todos = new List<Todo>
            {
                new Todo { Id = 1, Description = "Comprar leite", DueDate = DateTime.Now.AddDays(1), IsDone = false },
                new Todo { Id = 2, Description = "Enviar e-mail", DueDate = DateTime.Now.AddDays(2), IsDone = false },
                new Todo { Id = 3, Description = "Ler livro", DueDate = DateTime.Now.AddDays(3), IsDone = false },
            };
        }
    }
}
