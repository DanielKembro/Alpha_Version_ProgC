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
    public partial class WebService : Form
    {
        string filename;
        string item;
        WFReader.Controller.Controller con = new WFReader.Controller.Controller();
        public WebService()
        {
            InitializeComponent();
            comboBoxEntities.Text = "--Choose Entity--";
            comboBoxEntities.Items.Add("Building");
            comboBoxEntities.Items.Add("Institution");
            comboBoxEntities.Items.Add("Room");
            comboBoxEntities.Items.Add("People");
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            txtBoxBrowseText.Clear();
            txtBoxFileContent.Clear();
            using(OpenFileDialog fd = new OpenFileDialog())
            {
                if(fd.ShowDialog() == DialogResult.OK)
                {
                    filename = fd.FileName;
                    txtBoxBrowseText.Text = filename;
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxFileContent.Text = con.Getfile(filename);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("File is not .text");
            }
        }

        private void comboBoxEntities_DropDownClosed(object sender, EventArgs e)
        {
            item = comboBoxEntities.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
      //     txtBoxEntityContent.AppendText( con.GetEntities(item) as List<T);
        }
    }
}
