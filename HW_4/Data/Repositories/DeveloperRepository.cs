using HW_4.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HW_4.Data.Repositories
{
    public class DeveloperRepository
    {
        private readonly AppDbContext appDbContext;

        public DeveloperRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<ASPDeveloper> Developers => appDbContext.Developer;

        public void AddDeveloper(ASPDeveloper developer)
        {
            appDbContext.Developer.Add(developer);
            appDbContext.SaveChanges();
        }

        public bool DeveloperExists(string emailToCheck)
        {
            return appDbContext.Developer.Any(d => d.email == emailToCheck);
        }
    }
}