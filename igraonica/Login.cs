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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_passw.Text == "")
            {
                MessageBox.Show("Unesite sve podatke!");
                return;
            }
            else
            {

                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM Korisnik WHERE email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (string.Compare(tabela.Rows[0]["password"].ToString(), txt_passw.Text) == 0)
                        {
                            MessageBox.Show("Uspesna prijava!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];
                            Program.user_id = (int)tabela.Rows[0]["id"];
                            this.Hide();

                            if (Program.user_uloga == 1)
                            {
                                Admin frm_admin = new Admin();
                                frm_admin.Show();
                            }
                            else if (Program.user_uloga == 0)
                            {
                                Korisnik frm_korisnik = new Korisnik();
                                frm_korisnik.Show();
                            }
                            else
                            {
                                MessageBox.Show("Ovaj korisnik nema ulogu");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Los password!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nepostojeca email adresa!");
                    }

                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
