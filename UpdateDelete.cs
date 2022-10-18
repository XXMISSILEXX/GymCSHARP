using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class UpdateDelete : Form
    {
        BUS.MemberCTL memberCTL = new BUS.MemberCTL();
        int key = 0;
        public UpdateDelete()
        {
            InitializeComponent();
        }
        private void populate()
        {
            DataTable dataTable = new DataTable();
            dataTable = memberCTL.getMemberlist();
            MemberSDGV.DataSource = dataTable;
        }
 
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value);
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCB.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            Coachcb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text=PhoneTb.Text=GenderCB.Text=AgeTb.Text=Coachcb.Text=TimingCb.Text="";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            mem.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0)
                MessageBox.Show("Please select row to delete!");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete ?","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        /*Con.Open();
                        string query = "Delete from tblMember where Mid=" + key;
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!");
                        Con.Close();
                        populate();*/

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || GenderCB.Text == ""  || TimingCb.Text == "")
            {
                MessageBox.Show("Missing Information!");

            }
            else
            {
                try
                {   /*Con.Open();
                    string query = "Update tblMember set MName='" + NameTb.Text + "',MPhone='" + PhoneTb.Text + "',MGender='" + GenderCB.Text + "',MAge='" + AgeTb.Text + "',MAmount='" + AmountTb.Text + "',Mtiming='" + TimingCb.Text+"' where Mid='"+key+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully!");
              
                    Con.Close();
                    populate();*/

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
