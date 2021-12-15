using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DuThaiSon855.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DuThaiSon855.Models.Company_DTS855> Company_DTS855 { get; set; }

        public DbSet<DuThaiSon855.Models.DTS0855> DTS0855 { get; set; }
    }
