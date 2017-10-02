using Microsoft.EntityFrameworkCore;
using WebServiceTest.Entities;

namespace WebServiceTest.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {
        }
    }
}
