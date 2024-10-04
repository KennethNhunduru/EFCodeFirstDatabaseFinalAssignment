using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCodeFirstDatabaseFinalAssignment.Models;

namespace EFCodeFirstDatabaseFinalAssignment.Data
{
    public class EFCodeFirstDatabaseFinalAssignmentContext : DbContext
    {
        public EFCodeFirstDatabaseFinalAssignmentContext (DbContextOptions<EFCodeFirstDatabaseFinalAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<EFCodeFirstDatabaseFinalAssignment.Models.Student> Student { get; set; } = default!;
    }
}
