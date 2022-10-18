using Guna.UI2.WinForms;
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
    public partial class Payment : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=ADMIN;" +
                "DataBase=Gymdatabase;;Integrated Security=true");
        public Payment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            mem.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameCb.Text = "";
            AmountTb.Text = "";
        }
        private void fillname()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Mname from tblMember",Con);
            SqlDataReader dr;  //dùng để lưu dữ liệu vào dr
            dr = cmd.ExecuteReader(); //lưu vào dr
            DataTable dtb = new DataTable(); //bảng lưu dữ liệu
            dtb.Columns.Add("Mname", typeof(string)); //thêm cột
            dtb.Load(dr); //thêm dữ liệu của Mname vào bảng
            NameCb.ValueMember = "Mname";
            NameCb.DataSource = dtb;
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "Select * from tblPayment";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (NameCb.Text == "" || AmountTb.Text == "")
                MessageBox.Show("Missing information!");
            else
            {
                string payperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from tblPayment where PMember='" + NameCb.Text + "'and PMonth='" + payperiode + "'",Con);
                DataTable dtb = new DataTable();  //tạo bảng lưu dữ liệu
                sda.Fill(dtb);   //điền vào bảng    
                if (dtb.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already paid for this month!");
                }
                else
                {
                    string query = "insert into tblPayment values('" + payperiode + "','" + NameCb.SelectedValue.ToString() + "','" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid successfully!");
                    Con.Close();
                }
                Con.Close();
                populate();
            }

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            fillname();
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "Select * from tblPayment where PMember='"+SearchName.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
