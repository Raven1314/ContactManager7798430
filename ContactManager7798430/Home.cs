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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnOpenBusinessContact_Click(object sender, EventArgs e)
        {
            BusinessForm bf = new BusinessForm();
            bf.Show();
        }

        private void btnOpenPersonal_Click(object sender, EventArgs e)
        {
            PersonalForm pf = new PersonalForm();
            pf.Show();
            
        }
    }
}
