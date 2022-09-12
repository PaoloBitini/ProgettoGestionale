using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGestionale
{
    public partial class MainForm : Form
    {

        private enum Pagine{
            pagCli,
            pagForn,
            pagDdt,
            pagFat,
            pagMag,
            pagPag
        }

        private Pagine pagina;
        
        public MainForm()
        {
            InitializeComponent();

            // database connection
            connection = new System.Data.SqlClient.SqlConnection(connectionString);

            updateTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void paginaClienti_Click(object sender, EventArgs e)
        {
            nomePagina.Text = "Pagina Clienti";
            pagina = Pagine.pagCli;

            contenitoreBottoni.Controls.Clear();
            contenitoreBottoni.Controls.Add(nuovoCliente);
            contenitoreBottoni.Controls.Add(eliminaCliente);

            interrogazioniSelect(datiClienti);

        }

        private void paginaFornitori_Click(object sender, EventArgs e)
        {
            nomePagina.Text = "Pagina Fornitori";
            pagina = Pagine.pagForn;

            contenitoreBottoni.Controls.Clear();
            contenitoreBottoni.Controls.Add(nuovoFornitore);
            contenitoreBottoni.Controls.Add(eliminaFornitore);

            interrogazioniSelect(datiFornitori);
        }

        private void paginaDdt_Click(object sender, EventArgs e)
        {

            nomePagina.Text = "Pagina Documenti di trasporto";
            pagina = Pagine.pagDdt;

            contenitoreBottoni.Controls.Clear();
            contenitoreBottoni.Controls.Add(nuovoDdt);
            contenitoreBottoni.Controls.Add(eliminaDdt);

            interrogazioniSelect(datiDdt);
        }

        private void paginaFatture_Click(object sender, EventArgs e)
        {
            nomePagina.Text = "Pagina Fatture";
            pagina = Pagine.pagFat;

            contenitoreBottoni.Controls.Clear();
            contenitoreBottoni.Controls.Add(nuovaFattura);
            contenitoreBottoni.Controls.Add(eliminaFattura);

            interrogazioniSelect(datiFatture);
        }

        private void paginaMagazzino_Click(object sender, EventArgs e)
        {
            nomePagina.Text = "Pagina Magazzino";
            pagina = Pagine.pagMag;

            contenitoreBottoni.Controls.Clear();
            contenitoreBottoni.Controls.Add(nuovoProdotto);
            contenitoreBottoni.Controls.Add(eliminaProdotto);

            interrogazioniSelect(datiMagazzino);
        }

        private void paginaPagamenti_Click(object sender, EventArgs e)
        {
            nomePagina.Text = "Pagina Pagamenti";
            pagina = Pagine.pagPag;

            contenitoreBottoni.Controls.Clear();
            contenitoreBottoni.Controls.Add(nuovoPagamento);
            contenitoreBottoni.Controls.Add(eliminaPagamento);

            interrogazioniSelect(datiPagamenti);
        }

        private void eliminaCliente_Click(object sender, EventArgs e)
        {

        }

        private void nuovoCliente_Click(object sender, EventArgs e)
        {
            CreaClientiFornitoriForm creaClientiFornitoriform = new CreaClientiFornitoriForm(this, true);
            creaClientiFornitoriform.Show();
        }

        private void nuovoFornitore_Click(object sender, EventArgs e)
        {
            CreaClientiFornitoriForm creaClientiFornitoriform = new CreaClientiFornitoriForm(this, false);
            creaClientiFornitoriform.Show();
        }

        private void nuovoDdt_Click(object sender, EventArgs e)
        {
            CreaDdtFattureForm creaDdtFattureForm = new CreaDdtFattureForm(this, true);
            creaDdtFattureForm.Show();  
        }

        private void nuovaFattura_Click(object sender, EventArgs e)
        {
            CreaDdtFattureForm creaDdtFattureForm = new CreaDdtFattureForm(this, false);
            creaDdtFattureForm.Show();
        }

        public void updateTable()
        {
            switch (pagina)
            {
                case Pagine.pagCli:
                    interrogazioniSelect(datiClienti);
                    break;

                case Pagine.pagForn:
                    interrogazioniSelect(datiFornitori);
                    break;

                case Pagine.pagDdt:
                    interrogazioniSelect(datiDdt);
                    break;

                case Pagine.pagFat:
                    interrogazioniSelect(datiFatture);
                    break;

                case Pagine.pagMag:
                    interrogazioniSelect(datiMagazzino);
                    break;

                case Pagine.pagPag:
                    interrogazioniSelect(datiPagamenti);
                    break;
            }
        }
    }
}
