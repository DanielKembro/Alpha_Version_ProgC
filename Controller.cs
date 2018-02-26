using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pk_Uppgift 
{
    class Controller
    {
        



        public List<string> LoadInstitutionComboBox()
        {
            List<string> institutionnames = new List<String>();
            using (var unitOfWork = new UnitOfWork(new PkDbEntities()))
            {

                var institutions = unitOfWork.Institutions.GetAll();
                foreach (var i in institutions)
                {
                    institutionnames.Add(i.Name);
                }

            }

            return institutionnames;
        }

        public List<PersonInInstitutionView> GetPeople()
        {
            List<PersonInInstitutionView> people = new List<PersonInInstitutionView>();
            using (var unitofwork = new UnitOfWork(new PkDbEntities()))
            {

                people = unitofwork.PersonInInstitutionView.GetAll() as List<PersonInInstitutionView>;

            }

            return people;

        }

        /*  public List <string []> LoadPeople()
          {
              List<string[]> Itemrows = new List<string[]>();
              var peoplelist = GetPeople();
              foreach (var pview in peoplelist)
              {

                  var row = new string[] { pview.Name, pview.Work, pview.InstitutionName };


                  //denna metoden måste fylla listviewn med flera listview items, alt göra en lista av items, Hur fan då ???
              }
              return Itemrows;
          }
  */

        public List<String> LoadRoomComboBox(String selectedInstitution)
        {
            List<String> roomList = new List<String>();
            Institution institution = new Institution();
            using (var unitOfWork = new UnitOfWork(new PkDbEntities()))
            {
                List<Institution> listInstitution = unitOfWork.Institutions.GetAll() as List<Institution>;
                foreach (Institution forInstitution in listInstitution)
                {
                    if (forInstitution.Name == selectedInstitution)
                    {
                        institution = forInstitution;
                    }
                }

                var personList = unitOfWork.People.GetAll();

                List<Room> roomId = (unitOfWork.Rooms.GetAll()) as List<Room>;

                foreach (Room r in roomId)
                {
                    try
                    {
                        //(r.IId) == (inst.Id) ? ComboBoxRoom.Items.Add(r.Nr) : Console.WriteLine("Please choose a institution");
                        if (r.IId.Equals(institution.Id))
                        {
                            roomList.Add(r.Nr);

                        }
                    }
                    catch (Exception institutionError)
                    {
                        String msgBoxError = "Please choose an institution";
                        MessageBox.Show(msgBoxError);
                        break;
                    }


                    foreach (Person p in personList)
                    {
                        if (p.RoomId == r.Id)
                        {
                            roomList.Remove(r.Nr);
                        }
                    }
                }
            }
            return roomList;
        }

        public void AddPerson(Person p, string roomname, string selectedInstitution)
        {
            var room = new Room();
            var institution = new Institution();
            

            using (var unitOfWork = new UnitOfWork(new PkDbEntities()))
            {
                List<Room> listRoom = unitOfWork.Rooms.GetAll() as List<Room>;
                foreach (Room rooms in listRoom)

                    if (rooms.Nr == roomname)
                    {
                        room = rooms;
                        p.RoomId = room.Id;
                    }


                unitOfWork.People.Add(p);
                unitOfWork.Complete();

               var institutions = unitOfWork.Institutions.GetAll() as List<Institution>;
               var institutionId = FindInstitutionByName(selectedInstitution, institutions);

               
                int latestId = unitOfWork.Peps.GetMaxId();
                var tmppersonininst = new PersonInInst(); 

                tmppersonininst.PersonId = latestId;
                tmppersonininst.InstitutionId = institutionId;

                unitOfWork.PersonInInst.Add(tmppersonininst);
                unitOfWork.Complete();
                unitOfWork.Dispose();
                

            }

        }

        public int FindInstitutionByName(string selectedInstitution, List<Institution> institutionList)
        {
            Institution institution = new Institution();
            foreach (Institution tmpinstitution in institutionList)
            {
                if (tmpinstitution.Name == selectedInstitution)
                {
                    institution = tmpinstitution;
                }
            }
            return institution.Id;

        }

        public void RemovePerson(PersonInInstitutionView person)
        {
           
           
            using (var unitOfWork = new UnitOfWork(new PkDbEntities()))
            {
               var selectedPerson = unitOfWork.People.Get(person.PersonId);
               var institutionList = unitOfWork.Institutions.GetAll() as List<Institution>;
              var selectedPersonInInstitution = unitOfWork.PersonInInst.Get(person.PersonInInstitutionId);
                unitOfWork.PersonInInst.Remove(selectedPersonInInstitution);
                unitOfWork.People.Remove(selectedPerson);

                unitOfWork.Complete();
            }



        }
    }
}
