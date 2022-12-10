using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frm_Add : Form
    {
        public frm_Add()
        {
            InitializeComponent();
        }

        private void txt_Id_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Home home = new frm_Home();
            home.Show();
            this.Hide();
        }

        private void btn_Okey_Click(object sender, EventArgs e)
        {
            Cls_connection.open_connection();
            MySqlCommand cmd = new MySqlCommand("insert into detail values(@id,@name,@birthday,@address,@gender)", Cls_connection.con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", txt_Id.Text);
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@birthday", txt_BirthDay.Text);
            cmd.Parameters.AddWithValue("@address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@gender", txt_Gender.Text);
            cmd.ExecuteNonQuery();
            Cls_connection.close_connection();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
