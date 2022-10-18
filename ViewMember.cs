using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    
    public partial class ViewMember : Form
    {
        private BUS.MemberCTL memberCTL = new BUS.MemberCTL();
        public ViewMember()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {   DataTable dataTable = new DataTable();
            dataTable = memberCTL.getMemberlist();
            MemberSDGV.DataSource = dataTable;
        }
        private void filterByName()
        {
            DataTable dataTable = new DataTable();
            dataTable=memberCTL.getMemberlist(SearchName.Text);
            MemberSDGV.DataSource = dataTable;
        }
        private void ViewMember_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            mem.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
