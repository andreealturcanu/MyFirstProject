using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class ToDoItemModel
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
