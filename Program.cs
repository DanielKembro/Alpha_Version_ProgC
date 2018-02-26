using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pk_Uppgift
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            /*  using (var unitOfWork = new UnitOfWork(new PkDbEntities()))
              {
                 Person p = unitOfWork.People.Get(3);
                  unitOfWork.People.Remove(p);
                  unitOfWork.Complete();
              }*/
            // Starts the application.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                  Application.Run(new Launch());
            }
    }
}
