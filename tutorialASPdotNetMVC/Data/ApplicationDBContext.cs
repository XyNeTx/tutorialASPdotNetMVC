using Microsoft.EntityFrameworkCore;
using tutorialASPdotNetMVC.Models;

namespace tutorialASPdotNetMVC.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options){

        }
        public DbSet<Student> Students { get; set; }
    }
}
