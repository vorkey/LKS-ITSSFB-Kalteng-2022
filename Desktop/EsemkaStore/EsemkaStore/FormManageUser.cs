using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaStore
{
    public partial class FormManageUser : Form
    {
        readonly Functions fn = new Functions();

        public FormManageUser()
        {
            InitializeComponent();
        }

        private void FormManageUser_Load(object sender, EventArgs e)
        {
            DataSet ds = fn.GetData("SELECT Email, Name, Dob AS Birthday, Gender, Address, Role FROM Users");
            dataGridView1.DataSource = ds;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormMenuUtama f = new FormMenuUtama();
            f.Show();
            this.Close();
        }

        private void Clear()
        {
            TxtAddress.Text = "";
            TxtEmail.Text = "";
            TxtName.Text = "";
            TxtPassword.Text = "";
            TxtSearch.Text = "";
            RbtnFemale.Checked = false;
            RbtnMale.Checked = false;
        }

        string Gender;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(ValidationAdd())
            {
                fn.InsertData($"INSERT INTO Users (Email, Name, DoB, Gender, Address, Password, Role) VALUES ( {TxtEmail.Text}, {TxtName.Text}, {DateBirthday.Text}, {Gender}, {TxtAddress.Text}, {TxtPassword.Text}, {CmbRole.Text} )");
                this.FormManageUser_Load(sender, e);
            }
        }

        private void RbtnMale_Click(object sender, EventArgs e)
        {
            if(RbtnMale.Checked)
            {
                Gender = "M";
                RbtnFemale.Checked = false;
            }
        }

        private bool ValidationAdd()
        {
            if(DateBirthday.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Please check your birthday date");
                return false;
            }

            if(TxtEmail.Text.Trim() == "" || TxtAddress.Text.Trim() == "" || TxtName.Text.Trim() == "" || TxtPassword.Text.Trim() == "" || Gender.Trim() == "" || CmbRole.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all field");
                return false;
            } 
            else
            {
                return true;
            }
        }

        private void RbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnFemale.Checked)
            {
                Gender = "M";
                RbtnMale.Checked = false;
            }
        }
    }
}
