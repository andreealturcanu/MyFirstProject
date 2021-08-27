using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class ToDoItem
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
