using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.UI.Design.WebControls;
using GymManagement.DAO;
using Bunifu.UI.WinForms;
using System.IO;
using System.Globalization;
using System.Collections;
using Utilities.BunifuButton.Transitions;
using Bunifu.Framework.UI;

namespace GymManagement
{
    public partial class AddMember : Form
    {   private DTO.MemberDTO member= new DTO.MemberDTO(); //new object 
        private BUS.MemberCTL memberCTL = new BUS.MemberCTL(); //new BUS for member
        private string imgLoc;
        private int iLastRowID=0;

        public AddMember()
        {
            InitializeComponent();
      
        }
        private void IdforMember() 
        { 
            DataTable dtb=memberCTL.getMemberlist();
            DataGridView1.DataSource = dtb;
             if (DataGridView1.Rows.Count <=1)
                  iLastRowID = 0;
              else
              {
               
                DataGridViewRow lastRow = DataGridView1.Rows[DataGridView1.Rows.Count-2];
                string sub = lastRow.Cells[0].Value.ToString();
                string cut = sub.Substring(3);
                iLastRowID= Convert.ToInt16(cut);
              }    


         
           

        }
        private void LoadCoach()
        {
            DataTable dtb = memberCTL.getCoachlist();
            DataGridView DataGridView1 = new DataGridView();
            DataGridView1.DataSource = dtb;
            for (int i = 0; i < DataGridView1.RowCount; i++)
                Coachcb.Items.Add(DataGridView1.Rows[i].Cells[0].Value.ToString());

        }
        private void BlankComponent() {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();   //if textbox then clear,else call *func(control not textbox type)*
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
      
 /*       public AddMember(string lastrowID)
        {
            InitializeComponent();         
            Gendecb.SelectedIndex = 0;
            string sub = lastrowID.Substring(Math.Max(0, lastrowID.Length - 3)); //return 0 or (lastrowID.Length - 3) value 
            iLastRowID = Int32.Parse(sub);
        
        } */
        private Byte[] ImageToByteArray(string imgLocation)
        {
            Byte[] img = null;
            FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            return img;
        }
        private void populate()
        {
            DataTable dataTable = new DataTable();
            dataTable = memberCTL.getMemberlist();
            DataGridView1.DataSource = dataTable;
        }

        private DateTime CalculateExpirationDate()
        {   
           
            DateTime dt = DateTime.Now;
            switch (Membershipcb.Text)
            {
                case "Basic":
                    dt = dt.AddMonths(1);
                    break;
                case "Vip":
                    dt = dt.AddMonths(3);
                    break;
                case "Diamond":
                    dt = dt.AddMonths(6);
                    break;
                case "Supreme":
                    dt = dt.AddYears(1);
                    break;
            }
            member.ExpirationDate=dt.ToString("d/M/yyyy", CultureInfo.InvariantCulture);
            return dt;
        }
        private void GetMemberIn4mation()
        {
            member.Name = NameTb.Text;
            member.Gender = Gendecb.Text;
            member.Age = Convert.ToInt32(AgeTb.Text);
            member.Phone = PhoneTb.Text;
            member.MembershipType = Membershipcb.Text;
            member.Timing = Timingcb.Text;
            iLastRowID++;
            member.Id = "MEM"+ Convert.ToString(iLastRowID);
            if (MemberPicture.Image != null)
                member.Pic = ImageToByteArray(imgLoc);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" ||   Gendecb.Text == "" || imgLoc == null)
            {
                MessageBox.Show("Please fill all informations (include Avatar)!");
            }
            else
            {
                try
                {                
                    GetMemberIn4mation();
                    CalculateExpirationDate();
                    memberCTL.Member = member;
                    memberCTL.insert();
                    MessageBox.Show("Added Successfully!");
                    BlankComponent();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void PhoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void MemberPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Choose Avatar";
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName;
                    MemberPicture.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            BlankComponent();               
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            IdforMember();
            LoadCoach();
        }

        private void Membershipcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExpire.Text = CalculateExpirationDate().ToString("d/M/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
