using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA230323.Properties;

namespace WFA230323
{
    public partial class FrmKereso : Form
    {
        public FrmKereso()
        {
            InitializeComponent();
            this.Load += OnKereses;
            txtJarmuTipus.TextChanged += OnKereses;
            txtVevoNev.TextChanged += OnKereses;
        }

        private void OnKereses(object? sender, EventArgs e)
        {
            dgvKereso.Rows.Clear();

            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT tipus.nev, vevo.nev " +
                "FROM tipus " +
                "INNER JOIN ufo ON tipusId = ufo.tipus " +
                "INNER JOIN vevo ON foglalo = vevoId " +
                $"WHERE tipus.nev LIKE '{txtJarmuTipus.Text}%' " +
                $"AND vevo.nev LIKE '{txtVevoNev.Text}%';",
                connection: conn)
                .ExecuteReader();

            while (reader.Read()) dgvKereso.Rows.Add(reader[0], reader[1]);
        }
    }
}
