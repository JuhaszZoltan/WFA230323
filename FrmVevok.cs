using Microsoft.Data.SqlClient;
using WFA230323.Properties;

namespace WFA230323
{
    public partial class FrmVevok : Form
    {
        public FrmVevok()
        {
            InitializeComponent();
            this.Load += OnFrmVevokLoad;
            cboxNevek.SelectedIndexChanged += OnCboxNevekSelectedIndexChanged;
        }

        private void OnCboxNevekSelectedIndexChanged(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();

            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT * FROM vevo " +
                $"WHERE nev = '{cboxNevek.Text}';",
                connection: conn)
                .ExecuteReader();
            reader.Read();
            txtCim.Text = $"{reader[2]}";
            if (reader.GetBoolean(3))
                rbMegbizhatoIgen.Checked = true;
            else rbMegbizhatoNem.Checked = true;
            reader.Close();

            rtbFoglalozott.Clear();
            reader = new SqlCommand(
                cmdText: "SELECT tipus.nev, serules " +
                "FROM tipus " +
                "INNER JOIN ufo ON tipusid = ufo.tipus " +
                "INNER JOIN vevo ON ufo.foglalo = vevoid " +
                $"WHERE vevo.nev = '{cboxNevek.Text}';",
                connection: conn)
                .ExecuteReader();
            while (reader.Read())
            {
                rtbFoglalozott.Text += $"{reader[0]}: {reader[1]}%\n";
            }
        }

        private void OnFrmVevokLoad(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            
            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT nev FROM vevo ORDER BY nev;",
                connection: conn)
                .ExecuteReader();
            while (reader.Read()) cboxNevek.Items.Add(reader[0]);
            cboxNevek.SelectedIndex = 0;
        }
    }
}
