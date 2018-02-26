using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pk_Uppgift
{
    interface IUnitOfWork : IDisposable
    {
       
        Repository<Room> Rooms { get; }
        Repository<Person> People { get; }
        Repository<PersonInInstitutionView> PersonInInstitutionView { get; }
        Repository<PersonInInst> PersonInInst { get; }
        Repository<Institution> Institutions { get; }
        


        int Complete();
    }
}
