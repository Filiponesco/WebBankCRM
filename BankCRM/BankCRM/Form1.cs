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
using System.Configuration;

namespace BankCRM
{
    public partial class Form1 : Form
    {
        const string server = "localhost";
        const string dataBase = "bankCRM";
        const string user = "root";
        const string password = "";
        SqlConnection con;
        DataClasses1DataContext dc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bankcrmDataSet.klienci' . Możesz go przenieść lub usunąć.
            this.klienciTableAdapter.Fill(this.bankcrmDataSet.klienci);
            con = new SqlConnection(BankCRM.Properties.Settings.Default.bankcrmConnectionString);
            dc = new DataClasses1DataContext(con);
            DataBind();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PokazKlienta(e);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            klienci newKlient = new klienci();
            newKlient.imie = txtBoxImie.Text;
            newKlient.nazwisko = txtBoxNazwisko.Text;
            newKlient.e_mail = txtBoxEmail.Text;
            newKlient.telefon = txtBoxTel.Text;
            newKlient.pesel = txtBoxPesel.Text;

            dc.klienci.InsertOnSubmit(newKlient);
            dc.SubmitChanges();

            DataBind();
        }
        private void DataBind()
        {
            var selectQuery =
                from a in dc.GetTable<klienci>()
                select a;
            dataGridView1.DataSource = selectQuery;
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[indexRow].Cells[0].Value);
            klienci delKlient = dc.klienci.FirstOrDefault(klient => klient.id_klienci.Equals(id));
            dc.klienci.DeleteOnSubmit(delKlient);
            dc.SubmitChanges();

            DataBind();
            Wyczysc();
        }

        private void btnWYczysc_Click(object sender, EventArgs e)
        {
            Wyczysc();
        }

        private void btnZaktualizuj_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[indexRow].Cells[0].Value);
            klienci updKlient = dc.klienci.FirstOrDefault(klient => klient.id_klienci.Equals(id));
            updKlient.imie = txtBoxImie.Text;
            updKlient.nazwisko = txtBoxNazwisko.Text;
            updKlient.e_mail = txtBoxEmail.Text;
            updKlient.telefon = txtBoxTel.Text;
            updKlient.pesel = txtBoxPesel.Text;
            dc.SubmitChanges();

            DataBind();
        }
        private void Wyczysc()
        {
            txtBoxId.Text = "";
            txtBoxImie.Text = "";
            txtBoxNazwisko.Text = "";
            txtBoxEmail.Text = "";
            txtBoxTel.Text = "";
            txtBoxPesel.Text = "";
        }
        private void PokazKlienta(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                txtBoxId.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txtBoxImie.Text = selectedRow.Cells[1].Value.ToString().Trim();
                txtBoxNazwisko.Text = selectedRow.Cells[2].Value.ToString().Trim();
                txtBoxEmail.Text = selectedRow.Cells[3].Value.ToString().Trim();
                txtBoxTel.Text = selectedRow.Cells[4].Value.ToString().Trim();
                txtBoxPesel.Text = selectedRow.Cells[5].Value.ToString().Trim();
            }
        }
    }
}
