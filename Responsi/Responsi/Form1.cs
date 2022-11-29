using Npgsql;
using System.Data;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022; Username=postgres;Password=informatika;Database=departemen";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridView r;

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvKaryawan.DataSource = null;
                sql = "select * from dt_load()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvKaryawan.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}