using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFReader.Model;

namespace WFReader.Controller
{
    class Controller
    {
         FileReaderModel fr = new FileReaderModel();

          public string Getfile(string filename)
          {
              return fr.Getfile(filename);

          }
        /* 
         public Building[] GetBuildings(string item)
          {
              return 
          }

          public Institution[] GetInstitution(string item)
          {

          }

          public Room[] GetRoom(string item)
          {

          }

          public Person[] GetPeople(string item)
          {

          }
      }*/

    }
}
