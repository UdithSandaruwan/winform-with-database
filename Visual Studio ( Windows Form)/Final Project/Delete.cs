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
    public partial class frm_Delete : Form
    {
        public frm_Delete()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Home home = new frm_Home();
            home.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Okey_Click(object sender, EventArgs e)
        {
            Cls_connection.open_connection();
            MySqlCommand cmd = new MySqlCommand("delete from detail where id=@id", Cls_connection.con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", txt_Id.Text);
            cmd.ExecuteNonQuery();
            Cls_connection.close_connection();
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
