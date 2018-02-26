using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pk_Uppgift
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly PkDbEntities _context;

   

       
        public Repository<Person> People { get; private set; }

        public Repository<Building> Buildings { get; private set; }
        public Repository<PersonInInstitutionView> PersonInInstitutionView { get; private set; }
       
        public Repository<Room> Rooms { get; private set; }
        public Repository<Institution> Institutions { get; private set; }
        public PersonRepositorycs Peps { get; private set; }
        public Repository<PersonInInst> PersonInInst { get; private set; }
       

        public UnitOfWork(PkDbEntities context)
        {
            _context = context;
           
            People = new Repository<Person>(_context);
            PersonInInstitutionView = new Repository<PersonInInstitutionView>(_context);
            Buildings = new Repository<Building>(_context);
            PersonInInst = new Repository<PersonInInst>(_context);
           
            Rooms = new Repository<Room>(_context);
            Institutions = new Repository<Institution>(_context);
            Peps = new PersonRepositorycs(_context);
           

            //fixa peps så people hämtar från samma




        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
