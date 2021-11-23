using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAUniMenes
{
    public partial class Unikornis : Form
    {
        public static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniMenes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Unikornis()
        {
            InitializeComponent();
        }

        private void Unikornis_Load(object sender, EventArgs e) => UpdateDGV();


        private void UpdateDGV()
        {
            mainDGV.Rows.Clear();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                var r = new SqlCommand(
                    "SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Varos, Suly, Nem " +
                    "FROM Fajta " +
                    "INNER JOIN Unikornis ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON Tenyeszto.Id = TulajdonosId;", conn)
                    .ExecuteReader();
                while (r.Read())
                {
                    mainDGV.Rows.Add(
                        r[0], r[1], r[2], r[3],
                        r[4] + " Kg",
                        r.GetBoolean(5) ? "csődör" : "kanca");
                }
            }
        }

        private void BejelentesTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmAdatlap(connString);
            frm.ShowDialog();
            UpdateDGV();
        }
        private void mainDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string f = mainDGV[1, e.RowIndex].Value + "";
            string v = mainDGV[3, e.RowIndex].Value + "";
            string s = mainDGV[4, e.RowIndex].Value + "";
            int n = mainDGV[5, e.RowIndex].Value + "" == "kanca" ? 0 : 1;

            new FrmParkereso(connString, v, f, s, n).ShowDialog();
        }
    }
}
