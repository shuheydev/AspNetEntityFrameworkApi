using AspNetEntityFrameworkApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetEntityFrameworkApi.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //Modelのプロパティに属性で指定する代わりに,
        //    //このようにFluent APIで指定することもできる.
        //    //多くの場合は属性で書けるが,Fluent APIじゃないとできないものもある
        //    modelBuilder.Entity<Book>()
        //        .Property(b => b.Title)
        //        .IsRequired();
        //}
    }
}
