using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pk_Uppgift
{
    public partial class ShowPersonForm : Form
    {
        private PersonInInstitutionView p1;
        public ShowPersonForm() { }
        public ShowPersonForm(PersonInInstitutionView p)
        {
            p1 = p;
            InitializeComponent();
        }

        private void Load_ShowPerson(object sender, EventArgs e)
        {
            SetName.Text = p1.PersonName;
            SetMail.Text = p1.Mail;
            SetWork.Text = p1.Work;
            SetPhone.Text = p1.Telefon;
            SetInst.Text = p1.InstitutionName;
            SetBuilding.Text = p1.BuildingName;
            


        }
    }
}
