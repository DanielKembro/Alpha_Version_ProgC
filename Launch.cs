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
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
        }

        private void btnPk_Click(object sender, EventArgs e)
        {
            FindPersonForm findPerson = new FindPersonForm();
            this.Hide();
            findPerson.Show();
        }

        private void btnWebSerivce_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            this.Hide();
            webService.Show();
        }
    }
}
