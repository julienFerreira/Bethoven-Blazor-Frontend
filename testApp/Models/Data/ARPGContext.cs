﻿using ARPG.Areas.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARPG.Models.Data
{
    public class ARPGContext : IdentityDbContext<User>
    {
        public ARPGContext(DbContextOptions<ARPGContext> options)
            : base(options)
        {
        }
        public DbSet<Action> Action { get; set; }
        public DbSet<Book> Book { get; set; }

    }
}