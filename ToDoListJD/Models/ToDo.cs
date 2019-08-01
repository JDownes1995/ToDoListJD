using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListJD.Models
{
    public class ToDo
    {
        //Declare Items
        public int Id { get; set; }

        public string Description { get; set; }

        public bool isDone { get; set; }

        //public string DateModified { get; set; }

        //link items to user using asp.net identity system
        public virtual ApplicationUser User { get; set; }
    }
}