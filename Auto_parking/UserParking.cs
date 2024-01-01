using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Auto_parking
{
    public partial class UserParking : Form
    {
        static String connString = @"Data Source=DESKTOP-4JKQC8K;Initial Catalog=userparking;Integrated Security=True;";
        SqlConnection conn = new SqlConnection(connString);
        public UserParking()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserParking_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) 
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from userinfo", conn);
                
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvUserParking.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void capCameraBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (txtID.Equals(""))
            {
                MessageBox.Show("Not Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("insert into userinfo values (@id, @hoten, @bienso, @sdt, @tongtien, @idface)", conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@hoten", txtName.Text);
                cmd.Parameters.AddWithValue("@bienso", txtBien.Text);
                cmd.Parameters.AddWithValue("@sdt", txtNum.Text);
                cmd.Parameters.AddWithValue("@tongtien", txtTien.Text);
                cmd.Parameters.AddWithValue("@idface", txtFaceID.Text);

                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                UserParking_Load(sender, e);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUserParking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUserParking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvUserParking.CurrentRow.Index;
            txtID.Text = dgvUserParking.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvUserParking.Rows[i].Cells[1].Value.ToString();
            txtBien.Text = dgvUserParking.Rows[i].Cells[2].Value.ToString();
            txtNum.Text = dgvUserParking.Rows[i].Cells[3].Value.ToString();
            txtTien.Text = dgvUserParking.Rows[i].Cells[4].Value.ToString();
            txtFaceID.Text = dgvUserParking.Rows[i].Cells[5].Value.ToString();

        }

        private void DeleteTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtBien.Clear();
            txtNum.Clear();
            txtTien.Clear();
            txtFaceID.Clear();
            txtID.Focus();
        }
        private void UpdateBut_Click(object sender, EventArgs e)
        {
            if (txtID.Equals(""))
            {
                MessageBox.Show("Not Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("update userinfo set id = @id, hoten = @hoten, bienso = @bienso, sdt = @sdt, tongtien = @tongtien, idface = @idface where id = @id", conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@hoten", txtName.Text);
                cmd.Parameters.AddWithValue("@bienso", txtBien.Text);
                cmd.Parameters.AddWithValue("@sdt", txtNum.Text);
                cmd.Parameters.AddWithValue("@tongtien", txtTien.Text);
                cmd.Parameters.AddWithValue("@idface", txtFaceID.Text);

                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                UserParking_Load(sender, e);
                DeleteTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("delete from userinfo where id='" +txtID.Text+"'", conn);
                

                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                UserParking_Load(sender, e);
                DeleteTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncreBut_Click(object sender, EventArgs e)
        {
            if (txtID.Equals(""))
            {
                MessageBox.Show("Not Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                int tienThem = Int32.Parse(txtTienThem.Text);
                int tienGoc = Int32.Parse(txtTien.Text);
                int tienUpdate = tienThem + tienGoc;

                SqlCommand cmd = new SqlCommand("update userinfo set id = @id, hoten = @hoten, bienso = @bienso, sdt = @sdt, tongtien = @tongtien, idface = @idface where id = @id", conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@hoten", txtName.Text);
                cmd.Parameters.AddWithValue("@bienso", txtBien.Text);
                cmd.Parameters.AddWithValue("@sdt", txtNum.Text);
                cmd.Parameters.AddWithValue("@tongtien", tienUpdate.ToString());
                cmd.Parameters.AddWithValue("@idface", txtFaceID.Text);

                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                UserParking_Load(sender, e);
                DeleteTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
