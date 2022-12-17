using System.Data.Entity;
using DynamicPage.Models;

namespace DynamicPage.Context
{
    // افزودن جداول در دیتابیس
    public class ContextDynamicPage : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}