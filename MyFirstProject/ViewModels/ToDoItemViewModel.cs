using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.ViewModels
{
    public class ToDoItemViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
