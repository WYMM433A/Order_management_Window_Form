using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODM.BLL;
using ODM.DAL;

namespace ODM.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;  

      
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please fill the username and password", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var user = _userService.Login(tbName.Text, tbPassword.Text);  
                MessageBox.Show($"Welcome!{user.UserName}");
                var mainForm = new mForm(user);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
