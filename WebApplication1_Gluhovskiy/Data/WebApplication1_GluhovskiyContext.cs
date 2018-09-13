using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1_Gluhovskiy.Models
{
    public class WebApplication1_GluhovskiyContext : DbContext
    {
        public WebApplication1_GluhovskiyContext (DbContextOptions<WebApplication1_GluhovskiyContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1_Gluhovskiy.Models.Work> Work { get; set; }
        public DbSet<WebApplication1_Gluhovskiy.Models.Genre> Genres { get; set; }
        public DbSet<WebApplication1_Gluhovskiy.Models.Series> Series { get; set; }

        public DbQuery<FullWorkData> FullWorkDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Query<FullWorkData>().ToView("View_FullWorkData");
        }
    }
}
