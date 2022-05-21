using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace igraonica
{
    public partial class Admin : Form
    {
        public string datum;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            label1.Text = Program.user_ime + " " + Program.user_prezime;
            Rezervacije_Populate();
        }

        private void Rezervacije_Populate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Rezervacija.id, korisnik_id, Korisnik.ime + ' ' + Korisnik.prezime AS naziv, igraonica_id, Igraonica.adresa AS adresa, datum FROM Rezervacija JOIN Korisnik ON korisnik_id = Korisnik.id JOIN Igraonica ON igraonica_id = Igraonica.id WHERE odobrena = 0", Konekcija.Connect());
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.ClearSelection();
        }

        private void Animator_Populate()
        {
            SqlConnection veza = Konekcija.Connect();
            int dan = (int)(DateTime.ParseExact(datum, "yyyy-MM-dd", null).DayOfWeek);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Animator.id, ime + ' ' + prezime as naziv FROM Animator JOIN AnimatorRadniDan ON animator_id = Animator.id WHERE dan = " + dan, veza);
            DataTable dt_animator = new DataTable();
            adapter.Fill(dt_animator);
            cmb_animatori.DataSource = dt_animator;
            cmb_animatori.ValueMember = "id";
            cmb_animatori.DisplayMember = "naziv";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int red = int.Parse(dataGridView1.CurrentRow.Index.ToString());
            datum = (DateTime.Parse(dataGridView1.Rows[red].Cells[5].Value.ToString())).ToString("yyyy-MM-dd");
            //label1.Text = datum;
            Animator_Populate();
        }

        private void btn_potvrdi_Click(object sender, EventArgs e)
        {
            if (cmb_animatori.SelectedIndex < 0 || dataGridView1.CurrentRow.Index < 0 || dataGridView1.Rows.Count <= dataGridView1.CurrentRow.Index)
            {
                MessageBox.Show("Izaberite rezervaciju i animatora");
            }
            else
            {
                int red = int.Parse(dataGridView1.CurrentRow.Index.ToString());
                string id = dataGridView1.Rows[red].Cells[0].Value.ToString();
                string igraonica_id = dataGridView1.Rows[red].Cells[3].Value.ToString();
                datum = (DateTime.Parse(dataGridView1.Rows[red].Cells[5].Value.ToString())).ToString("yyyy-MM-dd");
                string animator_id = cmb_animatori.SelectedValue.ToString();

                SqlConnection veza = Konekcija.Connect();
                string naredba = "EXEC Odobri_Rezervacija " + id + ", " + animator_id;
                SqlCommand komanda = new SqlCommand(naredba, veza);

                veza.Open();
                komanda.ExecuteNonQuery();

                naredba = "DELETE FROM Rezervacija WHERE odobrena = 0 AND datum = '" + datum + "'" + " AND igraonica_id = " + igraonica_id;
                komanda = new SqlCommand(naredba, veza);
                komanda.ExecuteNonQuery();
                veza.Close();

                Rezervacije_Populate();
            }
        }
    }
}
