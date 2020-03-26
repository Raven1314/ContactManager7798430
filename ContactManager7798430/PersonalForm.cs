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

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            PersonalGrid.DataSource = dconn.GetAllPersonal();
        }
    }
}
