using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection comn = new SqlConnection("Data Source=LOQ-RV;Initial Catalog=materiCRUD;Integrated Security=True");

        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select noid,namadepan As namadepan,namabelakang As namabelakang,lain from materiCRUD", comn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNamaDepan.Text) || string.IsNullOrWhiteSpace(txtNamaBelakang.Text) || string.IsNullOrWhiteSpace(txtNilai.Text))
            {
                MessageBox.Show("Harap lengkapi semua kolom.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand cmd2 = new SqlCommand("INSERT INTO materiCRUD (noid, namadepan, namabelakang, lain) VALUES (@noid, @namadepan, @namabelakang, @lainnya)", comn);
            cmd2.Parameters.AddWithValue("@noid", txtID.Text);
            cmd2.Parameters.AddWithValue("@namadepan", txtNamaDepan.Text);
            cmd2.Parameters.AddWithValue("@namabelakang", txtNamaBelakang.Text);
            cmd2.Parameters.AddWithValue("@lainnya", txtNilai.Text);

            try
            {
                comn.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data sudah tertambah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bind_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                comn.Close();
            }

            /*SqlCommand cmd2 = new SqlCommand("Insert into materiCRUD(noid,namadepan,namabelakang,lain)Values(@noid,@namadepan,@namabelakang,@lainnya)", comn);
            cmd2.Parameters.AddWithValue("noid", txtID.Text);
            cmd2.Parameters.AddWithValue("namadepan", txtNamaDepan.Text);
            cmd2.Parameters.AddWithValue("namabelakang", txtNamaBelakang.Text);
            cmd2.Parameters.AddWithValue("lainnya", txtNilai.Text);
            comn.Open();
            cmd2.ExecuteNonQuery();
            comn.Close();
            bind_data();*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Tidak valid. Masukkan hanya angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Memproses karakter
            }
        }
    }
}
