using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.SystemData;
using KutuphaneSistemi.SystemData.Member;

namespace KutuphaneSistemi.Database.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Rezervation> Rezervation { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<PersonelMember> Personel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
