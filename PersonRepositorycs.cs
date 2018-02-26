using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pk_Uppgift
{
    class PersonRepositorycs : Repository<Person>
    {
        public PersonRepositorycs(DbContext context) : base(context)
        {
        }

        public int GetMaxId()
        {
            return Context.Set<Person>().Max(p => p.Id);
        }
    } //implement interface

}
