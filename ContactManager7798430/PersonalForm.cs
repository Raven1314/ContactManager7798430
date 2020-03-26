using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager7798430
{
    public partial class PersonalForm : Form
    {
        dbConn dconn = new dbConn();
        
        public PersonalForm()
        {
            InitializeComponent();
        }

        public void dataRefresh()//Refresh database can be called instead using same code
        {
            PersonalGrid.DataSource = dconn.GetAllPersonal();
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            dataRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataRefresh();
        }

       

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txbFname.Enabled = true;
            txbLname.Enabled = true;
            txbEmail.Enabled = true;
            txbPtel.Enabled = true;
            txbAddr1.Enabled = true;
            txbAddr2.Enabled = true;
            txbAddr3.Enabled = true;
            txbPostcode.Enabled = true;
            txbCity.Enabled = true;

            btnUpdateSelected.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveNew.Enabled = true;
            txbFname.Text = String.Empty;
            txbLname.Text = String.Empty;
            txbEmail.Text = String.Empty;
            txbPtel.Text = String.Empty;
            txbAddr1.Text = String.Empty;
            txbAddr2.Text = String.Empty;
            txbAddr3.Text = String.Empty;
            txbPostcode.Text = String.Empty;
            txbCity.Text = String.Empty;
        }

        private void PersonalGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Int32.Parse(PersonalGrid.SelectedCells[0].Value.ToString());
            txbFname.Text = PersonalGrid.SelectedCells[1].Value.ToString();
            txbLname.Text = PersonalGrid.SelectedCells[2].Value.ToString();
            txbEmail.Text = PersonalGrid.SelectedCells[3].Value.ToString();
            txbPtel.Text = PersonalGrid.SelectedCells[4].Value.ToString();
            txbAddr1.Text = PersonalGrid.SelectedCells[5].Value.ToString();
            txbAddr2.Text = PersonalGrid.SelectedCells[6].Value.ToString();
            txbAddr3.Text = PersonalGrid.SelectedCells[7].Value.ToString();
            txbPostcode.Text = PersonalGrid.SelectedCells[8].Value.ToString();
            txbCity.Text = PersonalGrid.SelectedCells[9].Value.ToString();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            PersonalContact personalContact = new PersonalContact();
            personalContact.contactFname = txbFname.Text;
            personalContact.ContactLname = txbLname.Text;
            personalContact.contactEmail = txbEmail.Text;
            personalContact.PersonalTel = txbPtel.Text;
            personalContact.contactAddr1 = txbAddr1.Text;
            personalContact.contactAddr2 = txbAddr2.Text;
            personalContact.contactAddr3 = txbAddr3.Text;
            personalContact.contactPostcode = txbPostcode.Text;
            personalContact.contactCity = txbCity.Text;
            dconn.InsertPersonal(personalContact);

            txbFname.Enabled = false;
            txbLname.Enabled = false;
            txbEmail.Enabled = false;
            txbPtel.Enabled = false;
            txbAddr1.Enabled = false;
            txbAddr2.Enabled = false;
            txbAddr3.Enabled = false;
            txbPostcode.Enabled = false;
            txbCity.Enabled = false;

            btnUpdateSelected.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveNew.Enabled = true;
            dataRefresh();
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            txbFname.Enabled = true;
            txbLname.Enabled = true;
            txbEmail.Enabled = true;
            txbPtel.Enabled = true;
            txbAddr1.Enabled = true;
            txbAddr2.Enabled = true;
            txbAddr3.Enabled = true;
            txbPostcode.Enabled = true;
            txbCity.Enabled = true;

            btnUpdateSelected.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveSelected.Enabled = true;
            btnAddNew.Enabled = false;
            txbFname.Text = String.Empty;
            txbLname.Text = String.Empty;
            txbEmail.Text = String.Empty;
            txbPtel.Text = String.Empty;
            txbAddr1.Text = String.Empty;
            txbAddr2.Text = String.Empty;
            txbAddr3.Text = String.Empty;
            txbPostcode.Text = String.Empty;
            txbCity.Text = String.Empty;
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(PersonalGrid.SelectedCells[0].Value.ToString());
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactID = index;
            personalContact.contactFname = txbFname.Text;
            personalContact.ContactLname = txbLname.Text;
            personalContact.contactEmail = txbEmail.Text;
            personalContact.PersonalTel = txbPtel.Text;
            personalContact.contactAddr1 = txbAddr1.Text;
            personalContact.contactAddr2 = txbAddr2.Text;
            personalContact.contactAddr3 = txbAddr3.Text;
            personalContact.contactPostcode = txbPostcode.Text;
            personalContact.contactCity = txbCity.Text;
            dconn.UpdatetPersonal(personalContact);
            dataRefresh();

            txbFname.Enabled = false;
            txbLname.Enabled = false;
            txbEmail.Enabled = false;
            txbPtel.Enabled = false;
            txbAddr1.Enabled = false;
            txbAddr2.Enabled = false;
            txbAddr3.Enabled = false;
            txbPostcode.Enabled = false;
            txbCity.Enabled = false;

            btnUpdateSelected.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveSelected.Enabled = false;
            btnAddNew.Enabled = true;

        }
    }
}
 