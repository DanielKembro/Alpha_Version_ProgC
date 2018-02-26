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
    public partial class FindPersonForm : Form
    {
        Controller controller = new Controller();
       
        private int sortcolum = -1;
        DataTable dt = new DataTable();
        
        public int Sortcolumn { get => sortcolum; set => sortcolum = value; }
       
      

        public FindPersonForm()
        {
            InitializeComponent();
           var institutionnames = controller.LoadInstitutionComboBox();
            ComboBoxInst.Text = "Choose an item";
            ComboBoxInst.DataSource = institutionnames;
            
        }

       

        public void Empty()
        {
            TxtBoxEmail.Clear();
            TxtBoxName.Clear();
            TxtBoxPhone.Clear();
            TxtBoxTask.Clear();
            ComboBoxRoom.DataSource = null;
            ComboBoxRoom.Text = String.Empty;
        }

        

        private void ShowPerson(object sender, EventArgs e)
        {
            var Selectedperson = listView1.SelectedItems[0].Tag as PersonInInstitutionView;


            if (Selectedperson != null)
            {
                ShowPersonForm form = new ShowPersonForm(Selectedperson);

                form.Show();
            }


        }

        private void FindPersonForm_Load(object sender, EventArgs e)
        {

            LoadPeople();
          
            


        }

        public void LoadPeople()
        {
            var peoplelist = controller.GetPeople();
            listView1.Items.Clear();
            foreach (var pview in peoplelist)
            {

                var row = new string[] { pview.PersonName, pview.Work, pview.InstitutionName };
                var lvi = new ListViewItem(row);
                lvi.Tag = pview;
                listView1.Items.Add(lvi);
            }
        }

        

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
            string Mail = TxtBoxEmail.Text.ToUpper();
            string Name = TxtBoxName.Text.ToUpper();
            string Telefon = TxtBoxPhone.Text.ToUpper();
            string Work = TxtBoxTask.Text.ToUpper();
            var person = new Person(Name, Mail, Telefon, Work);
            var roomname = ComboBoxRoom.SelectedItem as String;
            var selectedInstitution = ComboBoxInst.SelectedItem as String;
            controller.AddPerson(person, roomname, selectedInstitution );
            LoadPeople();
         







            ComboBoxInst.Text = "--Choose an institution--";
                MessageBox.Show("Added");
                
                Empty();

            
        }

        private void ComboBoxInst_DropdownClosed(object sender, EventArgs e)
        {

            ComboBoxRoom.DataSource = null;
            ComboBoxRoom.Enabled = true;
            ComboBoxRoom.Text = "--Select an item--";
            var selectedInstitution = ComboBoxInst.SelectedItem as String;
            var roomList = controller.LoadRoomComboBox(selectedInstitution);
            ComboBoxRoom.DataSource = roomList;

        }

        private void SortName(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != Sortcolumn)
            {
                Sortcolumn = e.Column;
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (listView1.Sorting == SortOrder.Ascending)
                    listView1.Sorting = SortOrder.Descending;
                else
                    listView1.Sorting = SortOrder.Ascending;

            }
            listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

            try
            {

                var selectedPerson = listView1.SelectedItems[0].Tag as PersonInInstitutionView;
                controller.RemovePerson(selectedPerson);
                MessageBox.Show(selectedPerson.PersonName + " Successfully REMOVED ", " Removed");
                LoadPeople();
            }

            catch(ArgumentOutOfRangeException argException)
            {
                           }
        
            


        }

        private void Search(object sender, EventArgs e)
        {
            if (searchTxtBox.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(searchTxtBox.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
                LoadPeople();
            
        }

    }
}


