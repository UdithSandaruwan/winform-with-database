using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Final_Project
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void jMaterialTextbox1_Load(object sender, EventArgs e)
        {

        }

        private void txt_Id_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            {
                string a = "user", b = "user";
                if (txt_id.Text == a)
                {
                    if (txt_id.Text == b)
                    {
                        frm_Home form = new frm_Home();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The username or password you entered is wrong! Try again!");
                    }
                }

            }
        }
        
    }
}