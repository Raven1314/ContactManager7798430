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
    public partial class BusinessForm : Form
    {
        dbConn dconn = new dbConn();
        public BusinessForm()
        {
            InitializeComponent();

        }
        private void dataRefresh()//Refresh database can be called instead using same code
        {
            BusinessGrid.DataSource = dconn.GetAllbusiness();
        }

        private void BusinessForm_Load(object sender, EventArgs e)
        {
            dataRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataRefresh();
        }

        private void updata()
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txbFname.Enabled = true;
            txbLname.Enabled = true;
            txbEmail.Enabled = true;
            txbBtel.Enabled = true;
            txbAddr1.Enabled = true;
            txbAddr2.Enabled = true;
            txbAddr3.Enabled = true;
            txbPostcode.Enabled = true;
            txbCity.Enabled = true;

            btnUpdateSelected.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveNew.Enabled = true;
            btnAddNew.Enabled = false;
            txbFname.Text = String.Empty;
            txbLname.Text = String.Empty;
            txbEmail.Text = String.Empty;
            txbBtel.Text = String.Empty;
            txbAddr1.Text = String.Empty;
            txbAddr2.Text = String.Empty;
            txbAddr3.Text = String.Empty;
            txbPostcode.Text = String.Empty;
            txbCity.Text = String.Empty;
        }



        private void BusinessGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a cell is clicked it will put the cell information to textbox for update
            int index = Int32.Parse(BusinessGrid.SelectedCells[0].Value.ToString());
            txbFname.Text = BusinessGrid.SelectedCells[1].Value.ToString();
            txbLname.Text = BusinessGrid.SelectedCells[2].Value.ToString();
            txbEmail.Text = BusinessGrid.SelectedCells[3].Value.ToString();
            txbBtel.Text = BusinessGrid.SelectedCells[4].Value.ToString();
            txbAddr1.Text = BusinessGrid.SelectedCells[5].Value.ToString();
            txbAddr2.Text = BusinessGrid.SelectedCells[6].Value.ToString();
            txbAddr3.Text = BusinessGrid.SelectedCells[7].Value.ToString();
            txbPostcode.Text = BusinessGrid.SelectedCells[8].Value.ToString();
            txbCity.Text = BusinessGrid.SelectedCells[9].Value.ToString();
        }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            BusinessContact businessContact = new BusinessContact();
            businessContact.contactFname = txbFname.Text;
            businessContact.ContactLname = txbLname.Text;
            businessContact.contactEmail = txbEmail.Text;
            businessContact.BusinessTel = txbBtel.Text;
            businessContact.contactAddr1 = txbAddr1.Text;
            businessContact.contactAddr2 = txbAddr2.Text;
            businessContact.contactAddr3 = txbAddr3.Text;
            businessContact.contactPostcode = txbPostcode.Text;
            businessContact.contactCity = txbCity.Text;
            dconn.InsertBusiness(businessContact);
            dataRefresh();


            txbFname.Enabled = false;
            txbLname.Enabled = false;
            txbEmail.Enabled = false;
            txbBtel.Enabled = false;
            txbAddr1.Enabled = false;
            txbAddr2.Enabled = false;
            txbAddr3.Enabled = false;
            txbPostcode.Enabled = false;
            txbCity.Enabled = false;

            btnUpdateSelected.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveNew.Enabled = false;
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            txbFname.Enabled = true;
            txbLname.Enabled = true;
            txbEmail.Enabled = true;
            txbBtel.Enabled = true;
            txbAddr1.Enabled = true;
            txbAddr2.Enabled = true;
            txbAddr3.Enabled = true;
            txbPostcode.Enabled = true;
            txbCity.Enabled = true;

            btnUpdateSelected.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveSelected.Enabled = true;
            btnAddNew.Enabled = true;
            txbFname.Text = String.Empty;
            txbLname.Text = String.Empty;
            txbEmail.Text = String.Empty;
            txbBtel.Text = String.Empty;
            txbAddr1.Text = String.Empty;
            txbAddr2.Text = String.Empty;
            txbAddr3.Text = String.Empty;
            txbPostcode.Text = String.Empty;
            txbCity.Text = String.Empty;
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(BusinessGrid.SelectedCells[0].Value.ToString());
            BusinessContact businessContact = new BusinessContact();
            businessContact.ContactID = index;
            businessContact.contactFname = txbFname.Text;
            businessContact.ContactLname = txbLname.Text;
            businessContact.contactEmail = txbEmail.Text;
            businessContact.BusinessTel = txbBtel.Text;
            businessContact.contactAddr1 = txbAddr1.Text;
            businessContact.contactAddr2 = txbAddr2.Text;
            businessContact.contactAddr3 = txbAddr3.Text;
            businessContact.contactPostcode = txbPostcode.Text;
            businessContact.contactCity = txbCity.Text;
            dconn.UpdatetBusiness(businessContact);
            dataRefresh();

            txbFname.Enabled = false;
            txbLname.Enabled = false;
            txbEmail.Enabled = false;
            txbBtel.Enabled = false;
            txbAddr1.Enabled = false;
            txbAddr2.Enabled = false;
            txbAddr3.Enabled = false;
            txbPostcode.Enabled = false;
            txbCity.Enabled = false;

            btnUpdateSelected.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveSelected.Enabled = false;
            btnAddNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string caption = "Important";
            string message = "DELETE" + " " + BusinessGrid.SelectedCells[1].Value.ToString() + " " + BusinessGrid.SelectedCells[2].Value.ToString() + "?";


            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                dconn.DeletePersonal(Int32.Parse(BusinessGrid.SelectedCells[0].Value.ToString()));
                dataRefresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbFname.Enabled = false;
            txbLname.Enabled = false;
            txbEmail.Enabled = false;
            txbBtel.Enabled = false;
            txbAddr1.Enabled = false;
            txbAddr2.Enabled = false;
            txbAddr3.Enabled = false;
            txbPostcode.Enabled = false;
            txbCity.Enabled = false;

            btnUpdateSelected.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveNew.Enabled = false;
            btnSaveSelected.Enabled = false;
            btnAddNew.Enabled = true; ;
        }

        private void btnMBus_Click(object sender, EventArgs e)
        {
            string caption = "Important";
            string message = "Migrate" + " " + BusinessGrid.SelectedCells[1].Value.ToString() + " " + BusinessGrid.SelectedCells[2].Value.ToString() + "?";


            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                BusinessContact businessContact = new BusinessContact();
                businessContact.contactFname = txbFname.Text;
                businessContact.ContactLname = txbLname.Text;
                businessContact.contactEmail = txbEmail.Text;
                businessContact.BusinessTel = txbBtel.Text;
                businessContact.contactAddr1 = txbAddr1.Text;
                businessContact.contactAddr2 = txbAddr2.Text;
                businessContact.contactAddr3 = txbAddr3.Text;
                businessContact.contactPostcode = txbPostcode.Text;
                businessContact.contactCity = txbCity.Text;
                dconn.InsertBusiness(businessContact);

                dconn.DeleteBusiness(Int32.Parse(BusinessGrid.SelectedCells[0].Value.ToString()));

                dataRefresh();
            }
        }
    }
}
