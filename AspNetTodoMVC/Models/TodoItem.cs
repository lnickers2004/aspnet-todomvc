﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTodoMVC.Models
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}