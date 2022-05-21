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
    public partial class Korisnik : Form
    {
        public DateTime datum;
        public Korisnik()
        {
            InitializeComponent();
        }

        private void Korisnik_Load(object sender, EventArgs e)
        {
            label1.Text = Program.user_ime + " " + Program.user_prezime;
            monthCalendar1.SelectionStart = Convert.ToDateTime("01/01/0001");
            IgraonicaPopulate();
        }

        private void IgraonicaPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Igraonica", veza);
            DataTable dt_igraonice = new DataTable();
            adapter.Fill(dt_igraonice);
            cmb_igraonice.DataSource = dt_igraonice;
            cmb_igraonice.ValueMember = "id";
            cmb_igraonice.DisplayMember = "adresa";
        }

        private void btn_zakazi_Click(object sender, EventArgs e)
        {
            if (cmb_igraonice.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite igraonicu");
            }
            else if (datum == Convert.ToDateTime("01/01/0001"))
            {
                MessageBox.Show("Izaberite datum");
            }
            else
            {
                SqlConnection veza = Konekcija.Connect();
                string naredba = "SELECT dbo.Proveri_Rezervacija(" + cmb_igraonice.SelectedValue + ", '" + datum.ToString("yyyy-MM-dd") + "')";
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                int status = (int)komanda.ExecuteScalar();
                veza.Close();

                //label1.Text = status.ToString();

                if (status == 1)
                {
                    MessageBox.Show("Termin je vec zauzet, promenite igraonicu ili datum");
                }
                else if (status == 0)
                {
                    naredba = "EXEC Dodaj_Rezervacija " + Program.user_id + ", " + cmb_igraonice.SelectedValue + ", 1, " + "'" + datum.ToString("yyyy-MM-dd") + "'" + ", 0";
                    komanda = new SqlCommand(naredba, veza);
                    //label1.Text = naredba.ToString();
                    try
                    {
                        veza.Open();
                        komanda.ExecuteNonQuery();
                        veza.Close();

                        MessageBox.Show("Uspesno ste poslali zahtev za rezervaciju");
                    }
                    catch (Exception greska)
                    {
                        Console.WriteLine(greska.Message);
                    }
                }
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            datum = Convert.ToDateTime(e.Start.ToShortDateString());
        }
    }
}
