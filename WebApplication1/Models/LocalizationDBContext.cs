// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class LocalizationDBContext : DbContext
    {
        public LocalizationDBContext(DbContextOptions options): base(options)
        {
                
        }
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<Resource> Resources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            
        }
    }
}
