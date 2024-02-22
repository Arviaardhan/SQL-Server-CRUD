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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtID.Text = selectedRow.Cells[0].Value.ToString();
            txtNamaDepan.Text = selectedRow.Cells[1].Value.ToString();
            txtNamaBelakang.Text = selectedRow.Cells[2].Value.ToString();
            txtNilai.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from materiCRUD where noid=@noid", comn);
            cmd4.Parameters.AddWithValue("noid", txtID.Text);
            comn.Open();
            cmd4.ExecuteNonQuery();
            comn.Close();
            bind_data();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update materiCRUD Set namadepan=@namadepan,namabelakang=@namabelakang,lain=@lainnya where noid=@noid", comn);

            cmd3.Parameters.AddWithValue("namadepan", txtNamaDepan.Text);
            cmd3.Parameters.AddWithValue("namabelakang", txtNamaBelakang.Text);
            cmd3.Parameters.AddWithValue("lainnya", txtNilai.Text);
            cmd3.Parameters.AddWithValue("noid", txtID.Text);
            comn.Open();
            cmd3.ExecuteNonQuery();
            comn.Close();
            bind_data();
        }

        private void btnPrintPDF_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select noid,namadepan As namadepan,namabelakang As namabelakang,lain from materiCRUD where namadepan Like @namadepan+'%'", comn);
            cmd1.Parameters.AddWithValue("namadepan", textBoxSearch.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11);
        }
    }
}
