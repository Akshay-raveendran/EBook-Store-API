﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }

    }
}