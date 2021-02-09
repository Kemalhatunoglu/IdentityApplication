using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreIdentityApplication.Data
{
    // Identity işlemi yaparken kendi application dp context isminde hazır bir klass açar bu identity işlemlerinin Context klassıdır.
    // NoT: Bu context klassı IdentityDbContext den instance alır.

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
