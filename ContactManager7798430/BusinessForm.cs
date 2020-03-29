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
            PersonalGrid.DataSource = dconn.GetAllPersonal();
        }

        private void BusinessForm_Load(object sender, EventArgs e)
        {
            PersonalGrid.DataSource = dconn.GetAllPersonal();
        }
    }
}
