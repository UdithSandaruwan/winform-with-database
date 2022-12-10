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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void txt_Exit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Add add = new frm_Add();
            add.ShowDialog();
            this.Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            frm_Delete delete = new frm_Delete(); 
            delete.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            Cls_connection.open_connection();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from detail", Cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "detail");
            datag1.DataSource = ds.Tables["detail"].DefaultView;
            Cls_connection.close_connection();
        }
    }
}
