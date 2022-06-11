﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;


namespace Infraestructure
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("MyContextDB") { }

        public DbSet<Student> Students { get; set; }
    }
}