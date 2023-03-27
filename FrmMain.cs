using Microsoft.Data.SqlClient;
using WFA230323.Properties;

namespace WFA230323
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += OnFrmMainLoad;
            msiVevok.Click += OnMsiVevokClick;
            msiKereso.Click += OnMsiKeresoClick;
        }

        private void OnMsiKeresoClick(object? sender, EventArgs e)
            => new FrmKereso().ShowDialog();

        private void OnMsiVevokClick(object? sender, EventArgs e)
            => new FrmVevok().ShowDialog();

        private void OnFrmMainLoad(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            var reader = new SqlCommand(
                cmdText: "SELECT ufoid, tipus.nev, alapar, serules, lopott " +
                "FROM ufo INNER JOIN tipus ON ufo.tipus = tipusid " +
                "ORDER BY ufoid;",
                connection: conn)
                .ExecuteReader();
            while (reader.Read())
            {
                int alapar = reader.GetInt32(2);
                int serules = reader.GetInt32(3);

                float ar = alapar - (serules * alapar / 100F);
                if (reader.GetBoolean(4)) ar *= .8F;

                string allapot = serules switch
                {
                    _ when serules <= 25 => "hibátlan",
                    _ when serules <= 50 => "újszerû",
                    _ when serules <= 66 => "megkímélt",
                    _ => "ufo donor"
                };

                dgvMain.Rows.Add(reader[1], $"{ar:0} CP", allapot);
            }
        }
    }
}